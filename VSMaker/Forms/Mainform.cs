using ClosedXML.Excel;
using Ekona.Images;
using Images;
using Microsoft.WindowsAPICodePack.Dialogs;
using NarcAPI;
using OpenTK.Graphics.OpenGL;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using VSMaker.CommonFunctions;
using VSMaker.Data;
using VSMaker.Fonts;
using VSMaker.Forms;
using VSMaker.ROMFiles;
using static VSMaker.CommonFunctions.RomInfo;
using Application = System.Windows.Forms.Application;
using Font = System.Drawing.Font;

namespace VSMaker
{
    public partial class Mainform : Form
    {
        private readonly VsMakerFont vsMakerFont;

        #region ROM Info

        public Dictionary<ushort, ushort> eventToHeader = new();
        private RomInfo romInfo;

        #endregion ROM Info

        #region Editor Data

        private string[] abilityNames = Array.Empty<string>();
        private int currentTrainerMessageIndex;
        private List<string> displayTrainerMessage = new();
        private List<string> itemNames = new();
        private List<MessageTrigger> messageTriggers = new();
        private string[] moveNames = Array.Empty<string>();
        private List<Pokemon> pokemons = new();
        private SpeciesFile[] pokemonSpecies;
        private (int abi1, int abi2)[] pokemonSpeciesAbilities;
        private List<string> pokeNames = new();
        private Trainer selectedTrainer;
        private TrainerClass selectedTrainerClass;
        private int selectedTrainerClassIndex = -1;
        private int selectedTrainerIndex = -1;
        private List<TrainerClass> trainerClasses = new();
        private TrainerFile trainerFile;
        private List<TrainerMessage> trainerMessages = new();
        private PaletteBase trainerPal;
        private List<Trainer> trainers = new();
        private SpriteBase trainerSprite;
        private bool trainerSpriteMessage;
        private ImageBase trainerTile;
        private List<ComboBox> pokeComboBoxes;
        private List<ComboBox> pokeItemComboBoxes;
        private List<ComboBox> trainerItemComboBoxes;
        private List<NumericUpDown> pokeLevels;
        private bool unsavedChanges;
        private List<EyeContactMusic> eyeContactMusics = new();
        private Dictionary<byte, (uint entryOffset, ushort musicD, ushort? musicN)> trainerClassEncounterMusicDict;
        #endregion Editor Data

        #region Forms

        private PokemonEditor pokemonEditor;
        private TextEditor textEditor;
        private ChooseMoves moveEditor;

        #endregion Forms

        public Mainform(VsMakerFont vsMakerFont)
        {
            this.vsMakerFont = vsMakerFont;
            InitializeComponent();
            vsMakerFont.InitializePokemonDsFont();
            trainer_Message.Text = string.Empty;
            //trainerTextTable_help_label.Text = "";

            pokeComboBoxes = new List<ComboBox>
            {
                trainer_Poke1_comboBox,
                trainer_Poke2_comboBox,
                trainer_Poke3_comboBox,
                trainer_Poke4_comboBox,
                trainer_Poke5_comboBox,
                trainer_Poke6_comboBox
            };

            pokeLevels = new List<NumericUpDown>
            {
                trainer_Poke1_Level,
                trainer_Poke2_Level,
                trainer_Poke3_Level,
                trainer_Poke4_Level,
                trainer_Poke5_Level,
                trainer_Poke6_Level,
            };

            pokeItemComboBoxes = new List<ComboBox>
            {
                trainer_Poke1_Item,
                trainer_Poke2_Item,
                trainer_Poke3_Item,
                trainer_Poke4_Item,
                trainer_Poke5_Item,
                trainer_Poke6_Item,
            };

            trainerItemComboBoxes = new List<ComboBox>
            {
                trainer_Item1_comboBox,
                trainer_Item2_comboBox,
                trainer_Item3_comboBox,
                trainer_Item4_comboBox,
            };
        }

        #region ROM

        private void CheckROMLanguage()
        {
            versionLabel.Visible = true;
            languageLabel.Visible = true;

            versionLabel.Text = $"{gameVersion} [{romID}]";
            languageLabel.Text = $"Lang: {gameLanguage}";

            if (gameLanguage == gLangEnum.English)
            {
                if (RomFileSystem.europeByte == 0x0A)
                {
                    languageLabel.Text += " [Europe]";
                }
                else
                {
                    languageLabel.Text += " [America]";
                }
            }
        }

        private void OpenRom()
        {
            OpenFileDialog openRom = new()
            {
                Filter = DSUtils.NDSRomFilter
            };
            if (openRom.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            RomFileSystem.SetupROMLanguage(openRom.FileName);
            /* Set ROM gameVersion and language */
            romInfo = new RomInfo(RomFileSystem.gameCode, openRom.FileName, useSuffix: true);

            if (string.IsNullOrWhiteSpace(romID) || string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }

            CheckROMLanguage();

            int userchoice = UnpackRomCheckUserChoice();
            switch (userchoice)
            {
                case -1:
                    statusLabelMessage("Loading aborted");
                    Update();
                    return;

                case 0:
                    break;

                case 1:
                case 2:
                    Application.DoEvents();
                    if (userchoice == 1)
                    {
                        statusLabelMessage("Deleting old data...");
                        try
                        {
                            Directory.Delete(workDir, true);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Concurrent access detected: \n" + workDir +
                                "\nMake sure no other process is using the extracted ROM folder while VS-Maker is running.", "Concurrent Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Update();
                    }

                    try
                    {
                        if (!UnpackRom(openRom.FileName))
                        {
                            statusLabelError("ERROR");
                            languageLabel.Text = "";
                            versionLabel.Text = "Error";
                            return;
                        }
                        DSUtils.ARM9.EditSize(-12);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Can't access temp directory: \n" + workDir + "\nThis might be a temporary issue.\nMake sure no other process is using it and try again.", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        statusLabelError("ERROR: Concurrent access to " + workDir);
                        Update();
                        return;
                    }
                    break;
            }
            statusLabelMessage("Attempting to unpack NARCs from folder...");
            Update();
            ReadROMInitData();

            // Unpack Narcs
            UnpackEssentialNarcs();
            GetData();

            // Setup data for initial trainer class tab.
            SetupTrainerClassEditor();
        }

        private void OpenRomFolder()
        {
            CommonOpenFileDialog romFolder = new()
            {
                IsFolderPicker = true,
                Multiselect = false
            };

            if (romFolder.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            try
            {
                RomFileSystem.SetupROMLanguage(Directory.GetFiles(romFolder.FileName).First(x => x.Contains("header.bin")));
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("This folder does not seem to contain any data from a NDS Pokémon ROM.", "No ROM Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /* Set ROM gameVersion and language */
            romInfo = new RomInfo(RomFileSystem.gameCode, romFolder.FileName, useSuffix: false);

            if (string.IsNullOrWhiteSpace(romID) || string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }

            CheckROMLanguage();
            ReadROMInitData();
            // Unpack Narcs
            UnpackEssentialNarcs();
            GetData();

            // Setup data for initial trainer class tab.
            SetupTrainerClassEditor();
        }

        private void ReadROMInitData()
        {
            if (DSUtils.ARM9.CheckCompressionMark())
            {
                if (!gameFamily.Equals(gFamEnum.HGSS))
                {
                    MessageBox.Show("Unexpected compressed ARM9. It is advised that you double check the ARM9.");
                }
                if (!DSUtils.ARM9.Decompress(arm9Path))
                {
                    MessageBox.Show("ARM9 decompression failed. The program can't proceed.\nAborting.",
                                "Error with ARM9 decompression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //mainTabControl.Show();
            openRom_toolstrip.Enabled = false;
            openFolder_toolstrip.Enabled = false;
            openRom_btn.Enabled = false;
            openFolder_btn.Enabled = false;
            save_toolstrip.Enabled = true;
            save_btn.Enabled = true;
            mainContent.Enabled = true;
            mainContent.Visible = true;

            statusLabelMessage();
            Text += $"  -  {fileName}";
        }

        private bool UnpackRom(string ndsFileName)
        {
            statusLabelMessage($"Unpacking ROM contents to {workDir} ...");
            Update();

            Directory.CreateDirectory(workDir);
            Process unpack = new();
            unpack.StartInfo.FileName = @"Tools\ndstool.exe";
            unpack.StartInfo.Arguments = "-x " + '"' + ndsFileName + '"'
                + " -9 " + '"' + arm9Path + '"'
                + " -7 " + '"' + workDir + "arm7.bin" + '"'
                + " -y9 " + '"' + workDir + "y9.bin" + '"'
                + " -y7 " + '"' + workDir + "y7.bin" + '"'
                + " -d " + '"' + workDir + "data" + '"'
                + " -y " + '"' + workDir + "overlay" + '"'
                + " -t " + '"' + workDir + "banner.bin" + '"'
                + " -h " + '"' + workDir + "header.bin" + '"';
            Application.DoEvents();
            unpack.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            unpack.StartInfo.CreateNoWindow = true;
            try
            {
                unpack.Start();
                unpack.WaitForExit();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show($"Failed to call ndstool.exe{Environment.NewLine}Make sure VS-Maker's Tools folder is intact.",
                    "Couldn't unpack ROM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private static int UnpackRomCheckUserChoice()
        {
            // Check if extracted data for the ROM exists, and ask user if they want to load it.
            // Returns true if user aborted the process
            if (Directory.Exists(workDir))
            {
                DialogResult d = MessageBox.Show("Extracted data of this ROM has been found.\n" +
                    "Do you want to load it and unpack it?", "Data detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (d == DialogResult.Cancel)
                {
                    return -1; //user wants to abort loading
                }
                else if (d == DialogResult.Yes)
                {
                    return 0; //user wants to load data
                }
                else
                {
                    DialogResult nd = MessageBox.Show("All data of this ROM will be re-extracted. Proceed?\n",
                        "Existing data will be deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (nd == DialogResult.No)
                    {
                        return -1; //user wants to abort loading
                    }
                    else
                    {
                        return 1; //user wants to re-extract data
                    }
                }
            }
            else
            {
                return 2; //No data found
            }
        }

        private void GetTrainerClassEncounterMusic()
        {
            RomInfo.SetEncounterMusicTableOffsetToRAMAddress();
            trainerClassEncounterMusicDict = new Dictionary<byte, (uint entryOffset, ushort musicD, ushort? musicN)>();

            uint encounterMusicTableTableStartAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(RomInfo.encounterMusicTableOffsetToRAMAddress, 4), 0) - DSUtils.ARM9.address;

            uint entrySize = 4;
            uint tableSizeOffset = 10;
            if (gameFamily == gFamEnum.HGSS)
            {
                entrySize += 2;
                tableSizeOffset += 2;
            }

            byte tableEntriesCount = DSUtils.ARM9.ReadByte(RomInfo.encounterMusicTableOffsetToRAMAddress - tableSizeOffset);
            using (DSUtils.ARM9.Reader ar = new DSUtils.ARM9.Reader(encounterMusicTableTableStartAddress))
            {
                for (int i = 0; i < tableEntriesCount; i++)
                {
                    uint entryOffset = (uint)ar.BaseStream.Position;
                    byte tclass = (byte)ar.ReadUInt16();
                    ushort musicD = ar.ReadUInt16();
                    ushort? musicN = gameFamily == gFamEnum.HGSS ? ar.ReadUInt16() : (ushort?)null;
                    trainerClassEncounterMusicDict[tclass] = (entryOffset, musicD, musicN);
                }
            }
        }

        #endregion ROM

        #region Main Editor

        private void mainContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainContent.SelectedTab == mainContent_trainerClass)
            {
                SetupTrainerClassEditor();
            }
            else if (mainContent.SelectedTab == mainContent_trainer)
            {
                SetupTrainerEditor();
            }
            else if (mainContent.SelectedTab == mainContent_trainerText)
            {
                SetupTrainerTextTab();
            }
        }

        private void openFolder_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenRomFolder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The extracted folder is not setup correctly.\nEssential files are missing.\n\n{ex.Message}", "Error Opening Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void openFolder_toolstrip_Click(object sender, EventArgs e)
        {
            try
            {
                OpenRomFolder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The extracted folder is not setup correctly.\nEssential files are missing.\n\n{ex.Message}", "Error Opening Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void openRom_btn_Click(object sender, EventArgs e)
        {
            OpenRom();
        }

        private void openRom_toolstrip_Click(object sender, EventArgs e)
        {
            OpenRom();
        }

        private static void SafeWriteLabel(ToolStripStatusLabel label, string text, Font font, Color color)
        {
            if (label.GetCurrentParent().InvokeRequired)
            {
                label.GetCurrentParent().Invoke((MethodInvoker)delegate
                {
                    label.Text = text;
                    label.Font = font;
                    label.ForeColor = color;
                    label.Invalidate();
                });
            }
            else
            {
                label.Text = text;
                label.Font = font;
                label.ForeColor = color;
                label.Invalidate();
            }
        }

        private void statusLabelError(string errorMsg, bool severe = true)
        {
            SafeWriteLabel(statusLabel, errorMsg, new Font(statusLabel.Font, FontStyle.Bold), severe ? Color.Red : Color.DarkOrange);

            statusLabel.Text = errorMsg;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
            statusLabel.ForeColor = severe ? Color.Red : Color.DarkOrange;
            statusLabel.Invalidate();
        }

        private void statusLabelMessage(string msg = "Ready")
        {
            SafeWriteLabel(statusLabel, msg, new Font(statusLabel.Font, FontStyle.Regular), Color.Black);
        }

        #endregion Main Editor

        #region Trainer Class Editor

        private void ClearTrainerClassLists()
        {
            // Clear Lists
            trainerClassListBox.Items.Clear();
            trainerClass_Uses_list.Items.Clear();
        }

        private void DisableTrainerClassEditorInputs()
        {
            //Disable Buttons
            saveTrainerClassAll_btn.Enabled = false;
            undoTrainerClass_btn.Enabled = false;
            trainerClass_GoToTrainer_btn.Enabled = false;

            //Disable Fields
            trainerClassName.Enabled = false;
            trainerClass_PrizeMoney_num.Enabled = false;
            trainerClass_Gender_comboBox.Enabled = false;
            trainerClass_frames_num.Enabled = false;
            trainerClass_Uses_list.Enabled = false;
        }

        private void DisableTrainerEditorInputs()
        {
            //Disable Buttons
            saveTrainerAll_btn.Enabled = false;
            undoTrainer_btn.Enabled = false;
            trainer_GoToClass_btn.Enabled = false;
            trainer_EditMessage_btn.Enabled = false;

            //Disable Fields
            trainer_Name.Enabled = false;
            trainer_Class_comboBox.Enabled = false;
            trainer_MessageTrigger_list.Enabled = false;
        }

        private void GoToTrainer()
        {
            int index = trainerClass_Uses_list.SelectedIndex;
            var text = trainerClass_Uses_list.Items[index].ToString();
            int id = int.Parse(text.Remove(0, 1).Remove(3));
            selectedTrainer = trainers.SingleOrDefault(x => x.TrainerId == id);
            mainContent.SelectedTab = mainContent_trainer;
        }

        private void playerClass_help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These Trainer Classes are \"Player Classes\".\n\nChanging these can cause errors.", "Player Classes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateTrainerClassName()
        {
            if (trainerClassName.Text.Length > TrainerFile.maxClassNameLen)
            {
                MessageBox.Show($"Trainer Class name cannot exceed {TrainerFile.maxClassNameLen} characters.", "Trainer Class Name Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SaveTrainerClassName()
        {
            RomFileSystem.UpdateCurrentTrainerClassName(trainerClassName.Text, selectedTrainerClass.TrainerClassId);
        }

        private void SaveTrainerName()
        {
            RomFileSystem.UpdateCurrentTrainerName(trainer_Name.Text, selectedTrainer.TrainerClassId);
        }

        private bool ValidateTrainerName()
        {
            if (trainer_Name.Text.Length > TrainerFile.maxNameLen)
            {
                MessageBox.Show($"Trainer name cannot exceed {TrainerFile.maxNameLen} characters.", "Trainer Name Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SetupTrainerClassEditor()
        {
            selectedTrainerClassIndex = -1;
            ClearTrainerClassLists();
            DisableTrainerClassEditorInputs();
            statusLabelMessage("Setting up Trainer Class Editor...");
            Update();

            //Setup Trainer Class List

            foreach (var item in trainerClasses)
            {
                trainerClassListBox.Items.Add($"[{item.DisplayTrainerClassId}] - {item.TrainerClassName}");
            }
            if (trainerClassListBox.Items.Count > 0)
            {
                trainerClassListBox.Enabled = true;
            }

            statusLabelMessage();
            Update();

            if (selectedTrainerClass != default)
            {
                trainerClassListBox.SelectedIndex = selectedTrainerClass.TrainerClassId;
            }
        }

        private void SetupTrainerClassEditorInputs(TrainerClass trainerClass)
        {
            trainerClassName.Enabled = !string.IsNullOrEmpty(trainerClass.TrainerClassName);
            trainerClass_Uses_list.Enabled = trainerClass.InUse;
            trainerClass_frames_num.Enabled = trainerClass.TrainerSpriteFrames > 0;
            trainerClass_frames_num.Maximum = trainerClass.TrainerSpriteFrames;

            if (trainerClassEncounterMusicDict.TryGetValue((byte)trainerClass.TrainerClassId, out (uint entryOffset, ushort musicD, ushort? musicN) output))
            {
                trainerClass_EyeContact_Day_comboBox.Enabled = true;
                trainerClass_EyeContact_Day_comboBox.SelectedIndex = eyeContactMusics.FindIndex(x => x.MusicId == output.musicD);
            }
            else
            {
                trainerClass_EyeContact_Day_comboBox.Enabled = false;
                trainerClass_EyeContact_Day_comboBox.SelectedIndex = 0;
            }
            trainerClass_EyeContact_Night_comboBox.Enabled = trainerClass_EyeContact_Day_comboBox.Enabled && gameFamily == gFamEnum.HGSS;
            trainerClass_EyeContact_Night_comboBox.Visible = gameFamily == gFamEnum.HGSS;
            trainerClass_eyecontact_alt_label.Visible = gameFamily == gFamEnum.HGSS;
            trainerClass_EyeContact_Night_comboBox.SelectedIndex = output.musicN != null ? eyeContactMusics.FindIndex(x => x.MusicId == (ushort)output.musicN) : 0;
            eyeContact_help_btn.Visible = !trainerClass_EyeContact_Night_comboBox.Enabled;
        }

        private void SetupTrainerEditorInputs(Trainer trainer)
        {
            trainer_Name.Enabled = !string.IsNullOrEmpty(trainer.TrainerName);
            trainer_Class_comboBox.Enabled = trainer.TrainerClassId >= 0;
            trainer_frames_num.Enabled = trainer.TrainerSpriteFrames > 0;
            trainer_frames_num.Maximum = trainer.TrainerSpriteFrames;
            trainer_ai_Basic_checkbox.Enabled = true;
            trainer_ai_baton_checkBox.Enabled = true;
            trainer_ai_checkHp_checkBox.Enabled = true;
            trainer_ai_dmg_checkBox.Enabled = true;
            trainer_ai_evaluate_checkBox.Enabled = true;
            trainer_ai_expert_checkBox.Enabled = true;
            trainer_ai_misc_checkBox.Enabled = true;
            trainer_ai_risk_checkBox.Enabled = true;
            trainer_ai_status_checkBox.Enabled = true;
            trainer_ai_tag_checkBox.Enabled = true;
            trainer_ai_weather_checkBox.Enabled = true;
            trainerItemComboBoxes.ForEach(x => x.Enabled = true);
            trainer_Item1_comboBox.SelectedIndex = trainer.TrainerItem1Id;
            trainer_Item2_comboBox.SelectedIndex = trainer.TrainerItem2Id;
            trainer_Item3_comboBox.SelectedIndex = trainer.TrainerItem3Id;
            trainer_Item4_comboBox.SelectedIndex = trainer.TrainerItem4Id;

            trainer_ai_Basic_checkbox.Checked = trainer.AI.Basic;
            trainer_ai_baton_checkBox.Checked = trainer.AI.BatonPass;
            trainer_ai_checkHp_checkBox.Checked = trainer.AI.CheckHp;
            trainer_ai_dmg_checkBox.Checked = trainer.AI.DamagePriority;
            trainer_ai_evaluate_checkBox.Checked = trainer.AI.EvaluateAttack;
            trainer_ai_expert_checkBox.Checked = trainer.AI.Expert;
            trainer_ai_misc_checkBox.Checked = trainer.AI.Unknown;
            trainer_ai_risk_checkBox.Checked = trainer.AI.Risky;
            trainer_ai_status_checkBox.Checked = trainer.AI.Status;
            trainer_ai_tag_checkBox.Checked = trainer.AI.TagTeam;
            trainer_ai_weather_checkBox.Checked = trainer.AI.WeatherEffect;
        }

        private void trainerClass_GoToTrainer_btn_Click(object sender, EventArgs e)
        {
            GoToTrainer();
        }

        private void trainerClass_PrizeMoney_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Base Rate Multiplier for calculating Prize Money.\nIt is multiplied by the level of a Trainer's last Pokémon.", "About Prize Money", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainerClass_Uses_list_DoubleClick(object sender, EventArgs e)
        {
            GoToTrainer();
        }

        private void trainerClass_Uses_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainerClass_GoToTrainer_btn.Enabled = true;
        }

        private void trainerClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trainerClassListBox.SelectedIndex;

            if (selectedTrainerClassIndex == -1)
            {
                ChangeTrainerClass();
            }

            if (selectedTrainerClassIndex > -1 && selectedTrainerClassIndex != index)
            {
                if (unsavedChanges)
                {
                    var choice = MessageBox.Show("You have unsaved changes.\nDo you wish to discard these changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        ChangeTrainerClass();
                    }
                    else
                    {
                        trainerClassListBox.SelectedIndexChanged -= trainerClassListBox_SelectedIndexChanged;
                        trainerClassListBox.SelectedIndex = selectedTrainerClassIndex;
                        trainerClassListBox.SelectedIndexChanged += trainerClassListBox_SelectedIndexChanged;
                    }
                }
                else
                {
                    ChangeTrainerClass();
                }
            }

            void ChangeTrainerClass()
            {
                selectedTrainerClassIndex = index;
                SetUnsavedChanges(false);
                var text = trainerClassListBox.Items[index].ToString();
                int trainerClassId = int.Parse(text.Remove(0, 1).Remove(3));
                GetTrainerClassInfo(trainerClassId);
            }
        }

        #endregion Trainer Class Editor

        #region Trainer Editor

        private void SetupTrainerEditor()
        {
            selectedTrainerIndex = -1;
            DisableTrainerEditorInputs();
            trainers_Player_list.Items.Clear();
            trainers_list.Items.Clear();
            statusLabelMessage("Setting up Trainer Editor...");
            Update();

            foreach (var item in trainers)
            {
                if (item.IsPlayerTrainer)
                {
                    trainers_Player_list.Items.Add($"[{item.DisplayTrainerId}] - {item.TrainerName}");
                }
                else
                {
                    trainers_list.Items.Add($"[{item.DisplayTrainerId}] - {item.TrainerName}");
                }
            }
            statusLabelMessage();
            Update();
            if (selectedTrainer != default)
            {
                trainers_list.SelectedIndex = selectedTrainer.TrainerId - 1;
            }
        }

        private void trainer_Class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trainerId = trainer_Class_comboBox.SelectedIndex;
            selectedTrainer.TrainerSpriteFrames = LoadTrainerClassPic(trainerId);
            UpdateTrainerClassPic(trainerPicBox);
            trainer_frames_num.Maximum = selectedTrainer.TrainerSpriteFrames;
            trainer_frames_num.Enabled = selectedTrainer.TrainerSpriteFrames > 0;
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        #endregion Trainer Editor

        #region Unpack NARCs

        private void UnpackEssentialNarcs()
        {
            /* Extract essential NARCs sub-archives*/
            statusLabelMessage("Unpacking essential NARCs...");
            Update();
            DSUtils.TryUnpackNarcs(new List<DirNames> {
                DirNames.trainerProperties,
                DirNames.trainerParty,
                DirNames.trainerGraphics,
                DirNames.textArchives,
                DirNames.monIcons,
                DirNames.personalPokeData,
                DirNames.trainerTextTable,
                DirNames.trainerTextOffset,
            });
            GetTrainerClassEncounterMusic();

            SetTrainerTable();
            try
            {
                ReadTrainerTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Unpack NARCs

        #region Get

        private void GetAbilities()
        {
            statusLabelMessage("Getting Pokemon Abilities...");
            Update(); abilityNames = GetAbilityNames();
        }

        private void GetData()
        {
            if (eyeContactMusics.Count == 0)
            {
                GetEyeContactMusicLists();
            }
            if (trainers.Count == 0)
            {
                GetTrainers();
            }
            if (trainerClasses.Count == 0)
            {
                GetTrainerClasses();
            }
            if (messageTriggers.Count == 0)
            {
                GetMessageTriggers();
            }
            if (trainerMessages.Count == 0)
            {
                GetTrainerMessages();
            }
            if (itemNames.Count == 0)
            {
                GetItems();
            }
            if (moveNames.Length == 0)
            {
                GetMoves();
            }
            if (abilityNames.Length == 0)
            {
                GetAbilities();
            }
            if (pokemons.Count == 0)
            {
                GetPokemon();
            }
        }

        private void GetItems()
        {
            statusLabelMessage("Getting Item Names...");
            Update(); itemNames = GetItemNames().ToList();
        }

        private static MessageTrigger GetMessageTriggerDetails(MessageTriggerEnum messageTrigger)
        {
            return new MessageTrigger
            {
                MessageTriggerId = (int)messageTrigger,
                MessageTriggerName = messageTrigger.GetEnumDescription(),
            };
        }

        private void GetMessageTriggers()
        {
            statusLabelMessage("Getting Messages Triggers...");
            Update();

            messageTriggers = new List<MessageTrigger>{
                GetMessageTriggerDetails(MessageTriggerEnum.preBattleOw),
                GetMessageTriggerDetails(MessageTriggerEnum.playerWins),
                GetMessageTriggerDetails(MessageTriggerEnum.postBattleOw),
                GetMessageTriggerDetails(MessageTriggerEnum.playerLost),
                GetMessageTriggerDetails(MessageTriggerEnum.trainerLastPoke),
                GetMessageTriggerDetails(MessageTriggerEnum.trainerLastPokeCritical),

                GetMessageTriggerDetails(MessageTriggerEnum.doublePreBattleOwTrainer1),
                GetMessageTriggerDetails(MessageTriggerEnum.doublePlayerWinTrainer1),
                GetMessageTriggerDetails(MessageTriggerEnum.doublePostBattleOwTrainer1),
                GetMessageTriggerDetails(MessageTriggerEnum.doubleOnlyOnePokeTrainer1),

                GetMessageTriggerDetails(MessageTriggerEnum.doublePreBattleOwTrainer2),
                GetMessageTriggerDetails(MessageTriggerEnum.doublePlayerWinTrainer2),
                GetMessageTriggerDetails(MessageTriggerEnum.doublePostBattleOwTrainer2),
                GetMessageTriggerDetails(MessageTriggerEnum.doubleOnlyOnePokeTrainer2),
                GetMessageTriggerDetails(MessageTriggerEnum.rematch),
                GetMessageTriggerDetails(MessageTriggerEnum.doubleRematchTrainer1),
                GetMessageTriggerDetails(MessageTriggerEnum.doubleRematchTrainer2),
                GetMessageTriggerDetails(MessageTriggerEnum.notUsed0B),
                GetMessageTriggerDetails(MessageTriggerEnum.notUsed0C),
                GetMessageTriggerDetails(MessageTriggerEnum.notUsed0D),
                GetMessageTriggerDetails(MessageTriggerEnum.notUsed0E),
            };
        }

        private void GetMoves()
        {
            statusLabelMessage("Getting Moves...");
            Update();
            moveNames = GetAttackNames();
        }

        private void GetPokemon()
        {
            statusLabelMessage("Getting Pokemon...");
            Update();
            pokemons = new List<Pokemon>();

            int numberOfPokemon = Directory.GetFiles(gameDirs[DirNames.personalPokeData].unpackedDir, "*").Length;
            pokemonSpecies = new SpeciesFile[numberOfPokemon];

            for (int i = 0; i < numberOfPokemon; i++)
            {
                pokemonSpecies[i] = new SpeciesFile(new FileStream($"{gameDirs[DirNames.personalPokeData].unpackedDir}\\{i:D4}", FileMode.Open));
            }
            pokeNames = GetPokemonNames(2).ToList();
            pokemonSpeciesAbilities = GetPokemonAbilities(numberOfPokemon);

            for (int i = 0; i < pokeNames.Count; i++)
            {
                var pokemon = new Pokemon
                {
                    PokemonId = i,
                    PokemonName = pokeNames[i],
                };
                pokemons.Add(pokemon);
            }
        }

        private (int abi1, int abi2)[] GetPokemonAbilities(int numberOfPokemon)
        {
            statusLabelMessage("Getting Trainer's Pokemon Abilities...");
            Update();
            var pokemonSpeciesAbilities = new (int abi1, int abi2)[numberOfPokemon];

            for (int i = 0; i < numberOfPokemon; i++)
            {
                pokemonSpeciesAbilities[i] = (pokemonSpecies[i].Ability1, pokemonSpecies[i].Ability2);
            }

            return pokemonSpeciesAbilities;
        }

        /// <summary>
        /// Get a list of TrainerClasses
        /// </summary>
        private void GetTrainerClasses()
        {
            // Clear list data
            trainerClasses = new List<TrainerClass>();

            statusLabelMessage("Getting Trainer Classes...");
            Update();
            string[] classNames = GetTrainerClassNames();

            if (classNames.Length > byte.MaxValue + 1)
            {
                MessageBox.Show($"There can't be more than 256 trainer classes! [Found {classNames.Length}].\nAborting.",
                    "Too many trainer classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < classNames.Length; i++)
            {
                string suffix = "\\" + i.ToString("D4");
                var classProperties = new TrainerProperties((ushort)i, new FileStream($"{gameDirs[DirNames.trainerProperties].unpackedDir}{suffix}", FileMode.Open));

                var item = new TrainerClass
                {
                    TrainerClassId = i,
                    TrainerClassName = classNames[i],
                    UsedByTrainers = new List<Trainer>(),
                    TrainerSpriteFrames = 0,
                };
                item.UsedByTrainers.AddRange(trainers.Where(x => x.TrainerClassId == item.TrainerClassId && !x.IsPlayerTrainer));
                trainerClasses.Add(item);
            }
        }

        /// <summary>
        /// Get Trainer Class Info for given trainerClassId.
        /// </summary>
        /// <param name="trainerClassId"></param>
        private void GetTrainerClassInfo(int trainerClassId)
        {
            SetUnsavedChanges(false);
            undoTrainerClass_btn.Enabled = false;
            selectedTrainerClass = trainerClasses.Single(x => x.TrainerClassId == trainerClassId);

            trainerClassName.Text = selectedTrainerClass.TrainerClassName;
            trainerClass_Uses_list.Items.Clear();

            if (selectedTrainerClass.InUse)
            {
                foreach (var item in selectedTrainerClass.UsedByTrainers)
                {
                    trainerClass_Uses_list.Items.Add($"[{item.DisplayTrainerId}] - {item.TrainerName}");
                }
            }
            selectedTrainerClass.TrainerSpriteFrames = LoadTrainerClassPic(trainerClassId);
            UpdateTrainerClassPic(trainerClassPicBox);

            SetupTrainerClassEditorInputs(selectedTrainerClass);
            saveTrainerClassAll_btn.Enabled = true;
        }

        /// <summary>
        /// Get Trainer Info for given trainerId.
        /// </summary>
        /// <param name="trainerId"></param>
        private void GetTrainerInfo(int trainerId)
        {
            trainer_Message.Text = string.Empty;
            trainer_Class_comboBox.Items.Clear();
            trainer_MessageTrigger_list.Items.Clear();

            selectedTrainer = trainers.Single(x => x.TrainerId == trainerId);
            //Setup Trainer Class Pic
            selectedTrainer.TrainerSpriteFrames = LoadTrainerClassPic(selectedTrainer.TrainerClassId);
            UpdateTrainerClassPic(trainerPicBox);
            trainer_frames_num.Maximum = selectedTrainer.TrainerSpriteFrames;
            trainer_frames_num.Enabled = selectedTrainer.TrainerSpriteFrames > 0; selectedTrainer.TrainerMessages = trainerMessages.Where(x => x.TrainerId == selectedTrainer.TrainerId).OrderBy(x => x.MessageTriggerId).ToList();
            selectedTrainer.Pokemon = new List<Pokemon>();

            int currentIndex = trainerId;
            string suffix = $"\\{currentIndex:D4}";

            trainerFile = new TrainerFile(
                new TrainerProperties(
                    (ushort)currentIndex,
                    new FileStream(gameDirs[DirNames.trainerProperties].unpackedDir + suffix, FileMode.Open)
                ),
                new FileStream(gameDirs[DirNames.trainerParty].unpackedDir + suffix, FileMode.Open),
                selectedTrainer.TrainerName
            );
            //Setup Trainer Name
            trainer_Name.Text = selectedTrainer.TrainerName;

            //Setup Trainer Class

            foreach (var item in trainerClasses)
            {
                trainer_Class_comboBox.Items.Add($"[{item.DisplayTrainerClassId}] - {item.TrainerClassName}");
            }

            if (trainer_Class_comboBox.Items.Count > 0)
            {
                int index = selectedTrainer.TrainerClassId;
                trainer_Class_comboBox.Enabled = true;
                trainer_GoToClass_btn.Enabled = true;
                trainer_Class_comboBox.SelectedIndex = index > -1 ? index : 0;
            }

            //Setup Trainer Messages
            displayTrainerMessage = new List<string>();

            foreach (var item in selectedTrainer.TrainerMessages)
            {
                trainer_MessageTrigger_list.Items.Add(item.MessageTriggerText);
            }

            if (trainer_MessageTrigger_list.Items.Count > 0)
            {
                trainer_MessageTrigger_list.Enabled = true;
                trainer_MessageTrigger_list.SelectedIndex = 0;
            }
            else
            {
                trainer_MessageTrigger_list.Enabled = false;
            }
            currentTrainerMessageIndex = 0;
            trainer_Message_Next_btn.Enabled = displayTrainerMessage.Count > 1;

            // Setup Trainer Pokemon
            foreach (var item in pokeComboBoxes)
            {
                item.Items.Clear();
                pokemons.ForEach(x => item.Items.Add(x.PokemonName));
            }

            foreach (var item in pokeItemComboBoxes)
            {
                item.Items.Clear();
                itemNames.ForEach(x => item.Items.Add(x));
            }
            trainer_Double_checkBox.Enabled = true;
            trainer_NumPoke_num.Enabled = true;
            trainer_Poke_HeldItem_checkBox.Enabled = true;
            trainer_Poke_Moves_checkBox.Enabled = true;
            trainer_NumPoke_num.Enabled = true;
            trainer_Double_checkBox.Checked = selectedTrainer.IsDouble;
            trainer_Poke_HeldItem_checkBox.Checked = selectedTrainer.HeldItems;
            trainer_Poke_Moves_checkBox.Checked = selectedTrainer.ChooseMoves;

            for (int i = 0; i < 6; i++)
            {
                var partyPokemon = trainerFile.party[i];
                int heldItemId = partyPokemon.heldItem.HasValue ? (int)partyPokemon.heldItem.Value : 0;
                pokeComboBoxes[i].SelectedIndex = partyPokemon.pokeID ?? 0;
                pokeItemComboBoxes[i].SelectedIndex = heldItemId;
                pokeLevels[i].Value = (int?)partyPokemon.level ?? 0;
                if (partyPokemon?.pokeID.HasValue == true)
                {
                    var pokemon = new Pokemon
                    {
                        PokemonId = partyPokemon.pokeID.Value,
                        FormId = partyPokemon.formID,
                        PokemonName = pokeNames[partyPokemon.pokeID.Value],
                        DV = partyPokemon.difficulty,
                        Level = (short)partyPokemon.level,
                        HeldItemId = heldItemId
                    };
                    selectedTrainer.Pokemon.Add(pokemon);
                    pokeLevels[i].Value = partyPokemon.level;
                }
            }

            if (selectedTrainer.Pokemon.Count > 0)
            {
                trainer_NumPoke_num.Minimum = 1;
            }
            else
            {
                trainer_NumPoke_num.Minimum = 0;
                MessageBox.Show("Trainer has no Pokemon set.\nYou must select at least one.", "No Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trainerEditor_tab.SelectedTab = trainerEditor_Pokemon;
                SetUnsavedChanges(true);
                undoTrainer_btn.Enabled = true;
            }

            trainer_NumPoke_num.Value = selectedTrainer.Pokemon.Count;

            foreach (var item in trainerItemComboBoxes)
            {
                item.Items.Clear();
                itemNames.ForEach(x => item.Items.Add(x));
            }
            EnablePokemon();
            SetupTrainerEditorInputs(selectedTrainer);
            EnableTrainerButtons();
            SetUnsavedChanges(false);
            undoTrainer_btn.Enabled = false;
        }

        private void EnableTrainerButtons()
        {
            saveTrainerAll_btn.Enabled = true;
        }

        private void GetTrainerMessages()
        {
            trainerMessages = new List<TrainerMessage>();
            statusLabelMessage("Getting Trainer's Messages...");
            Update();
            var allTrainerMessages = RomInfo.GetTrainerMessages();
            for (uint i = 0; i < allTrainerMessages.Length; i++)
            {
                var item = new TrainerMessage
                {
                    MessageId = (int)i,
                    MessageTriggerId = (int)TrainerTable[i].messageTriggerId,
                    MessageText = allTrainerMessages[i],
                    TrainerId = (int)TrainerTable[i].trainerId
                };
                item.TrainerName = trainers[item.TrainerId].TrainerName;
                item.MessageTriggerText = messageTriggers.Find(x => x.MessageTriggerId == item.MessageTriggerId).MessageTriggerName;

                trainerMessages.Add(item);
            }
        }

        /// <summary>
        /// Get a list of Trainers.
        /// </summary>
        private void GetTrainers()
        {
            // Clear list data
            trainers = new List<Trainer>();

            statusLabelMessage("Getting Trainers...");
            Update();
            string[] trainerNames = GetSimpleTrainerNames();

            for (int i = 0; i < trainerNames.Length; i++)
            {
                string suffix = "\\" + i.ToString("D4");
                var trainerProperties = new TrainerProperties((ushort)i, new FileStream($"{gameDirs[DirNames.trainerProperties].unpackedDir}{suffix}", FileMode.Open));
                var item = new Trainer
                {
                    TrainerId = i,
                    TrainerName = trainerNames[i],
                    TrainerClassId = trainerProperties.trainerClass,
                    Pokemon = new List<Pokemon>(),
                    IsDouble = trainerProperties.doubleBattle,
                    TrainerItem1Id = (int)trainerProperties.trainerItems[0],
                    TrainerItem2Id = (int)trainerProperties.trainerItems[1],
                    TrainerItem3Id = (int)trainerProperties.trainerItems[2],
                    TrainerItem4Id = (int)trainerProperties.trainerItems[3],
                    HeldItems = trainerProperties.chooseItems,
                    ChooseMoves = trainerProperties.chooseMoves,
                };
                item.AI.Basic = trainerProperties.AI[0];
                item.AI.EvaluateAttack = trainerProperties.AI[1];
                item.AI.Expert = trainerProperties.AI[2];
                item.AI.Status = trainerProperties.AI[3];
                item.AI.Risky = trainerProperties.AI[4];
                item.AI.DamagePriority = trainerProperties.AI[5];
                item.AI.BatonPass = trainerProperties.AI[6];
                item.AI.TagTeam = trainerProperties.AI[7];
                item.AI.CheckHp = trainerProperties.AI[8];
                item.AI.WeatherEffect = trainerProperties.AI[9];
                item.AI.Unknown = trainerProperties.AI[10];

                trainers.Add(item);
            }
        }

        #endregion Get

        #region TrainerSprite

        private int LoadTrainerClassPic(int trainerClassId)
        {
            if (gameFamily == gFamEnum.DP)
            {
                if (!trainerSpriteMessage)
                {
                    MessageBox.Show("Diamond and Pearl trainer sprites are compressed.\nAt the moment they cannot be viewed.", "Unable To View Trainer Sprite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trainerSpriteMessage = true;
                }
                return 0;
            }
            int tilesFileId = trainerClassId * 5;
            int paletteFileID = (tilesFileId + 1);
            string paletteFilename = paletteFileID.ToString("D4");
            trainerPal = new NCLR(gameDirs[DirNames.trainerGraphics].unpackedDir + "\\" + paletteFilename, paletteFileID, paletteFilename);

            string tilesFilename = tilesFileId.ToString("D4");
            trainerTile = new NCGR(gameDirs[DirNames.trainerGraphics].unpackedDir + "\\" + tilesFilename, tilesFileId, tilesFilename);

            int spriteFileID = (tilesFileId + 2);
            string spriteFilename = spriteFileID.ToString("D4");
            trainerSprite = new NCER(gameDirs[DirNames.trainerGraphics].unpackedDir + "\\" + spriteFilename, spriteFileID, spriteFilename);

            return trainerSprite.Banks.Length - 1;
        }

        private void UpdateTrainerClassPic(PictureBox pb, int frameNumber = 0)
        {
            if (trainerSprite == null)
            {
                Console.WriteLine("Sprite is null!");
                return;
            }

            int bank0OAMcount = trainerSprite.Banks[0].oams.Length;
            int[] OAMenabled = new int[bank0OAMcount];
            for (int i = 0; i < OAMenabled.Length; i++)
            {
                OAMenabled[i] = i;
            }

            frameNumber = Math.Min(trainerSprite.Banks.Length, frameNumber);
            pb.Image = trainerSprite.Get_Image(trainerTile, trainerPal, frameNumber, trainerClassPicBox.Width, trainerClassPicBox.Height, false, false, false, true, true, -1, OAMenabled);
            pb.Update();
        }

        #endregion TrainerSprite

        private static string ReadLine(string text, int lineNumber)
        {
            var reader = new StringReader(text);

            string line;
            int currentLineNumber = 0;

            do
            {
                currentLineNumber += 1;
                line = reader.ReadLine();
            }
            while (line != null && currentLineNumber < lineNumber);

            return (currentLineNumber == lineNumber) ? line :
                                                       string.Empty;
        }

        private void EnablePokemon()
        {
            switch (trainer_NumPoke_num.Value)
            {
                case 1:
                    EnableButtons(true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs1;
                    break;

                case 2:
                    EnableButtons(true, true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs2;
                    break;

                case 3:
                    EnableButtons(true, true, true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs3;
                    break;

                case 4:
                    EnableButtons(true, true, true, true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs4;
                    break;

                case 5:
                    EnableButtons(true, true, true, true, true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs5;
                    break;

                case 6:
                    EnableButtons(true, true, true, true, true, true);
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs6;
                    break;

                default:
                    EnableButtons();
                    trainer_Poke_Num_pic.Image = Properties.Resources.pokeballs0;
                    break;
            }

            void EnableButtons(bool poke1 = false, bool poke2 = false, bool poke3 = false, bool poke4 = false, bool poke5 = false, bool poke6 = false)
            {
                bool itemEnabled = trainer_Poke_HeldItem_checkBox.Checked;
                bool movesEnabled = trainer_Poke_Moves_checkBox.Checked;
                trainer_Poke1_comboBox.Enabled = poke1;
                trainer_Poke2_comboBox.Enabled = poke2;
                trainer_Poke3_comboBox.Enabled = poke3;
                trainer_Poke4_comboBox.Enabled = poke4;
                trainer_Poke5_comboBox.Enabled = poke5;
                trainer_Poke6_comboBox.Enabled = poke6;

                trainer_Poke1_Level.Enabled = poke1;
                trainer_Poke2_Level.Enabled = poke2;
                trainer_Poke3_Level.Enabled = poke3;
                trainer_Poke4_Level.Enabled = poke4;
                trainer_Poke5_Level.Enabled = poke5;
                trainer_Poke6_Level.Enabled = poke6;

                trainer_Poke1_Item.Enabled = poke1 && itemEnabled;
                trainer_Poke2_Item.Enabled = poke2 && itemEnabled;
                trainer_Poke3_Item.Enabled = poke3 && itemEnabled;
                trainer_Poke4_Item.Enabled = poke4 && itemEnabled;
                trainer_Poke5_Item.Enabled = poke5 && itemEnabled;
                trainer_Poke6_Item.Enabled = poke6 && itemEnabled;

                trainer_Poke1_Moves_btn.Enabled = poke1 && movesEnabled;
                trainer_Poke2_Moves_btn.Enabled = poke2 && movesEnabled;
                trainer_Poke3_Moves_btn.Enabled = poke3 && movesEnabled;
                trainer_Poke4_Moves_btn.Enabled = poke4 && movesEnabled;
                trainer_Poke5_Moves_btn.Enabled = poke5 && movesEnabled;
                trainer_Poke6_Moves_btn.Enabled = poke6 && movesEnabled;

                trainer_Poke1_Stats_btn.Enabled = poke1;
                trainer_Poke2_Stats_btn.Enabled = poke2;
                trainer_Poke3_Stats_btn.Enabled = poke3;
                trainer_Poke4_Stats_btn.Enabled = poke4;
                trainer_Poke5_Stats_btn.Enabled = poke5;
                trainer_Poke6_Stats_btn.Enabled = poke6;
            }
        }

        private Task GetTrainerTextTableData()
        {
            if (trainerTextTable_dataGrid.RowCount <= 1)
            {
                statusLabelMessage("Reading Trainer Text Table");
                string[] currentTrainers = new string[trainers.Count];
                string[] currentMessageTriggers = new string[messageTriggers.Count];

                for (int i = 0; i < trainers.Count; i++)
                {
                    currentTrainers[i] = $"[{trainers[i].DisplayTrainerId}] - {trainers[i].TrainerName}";
                }

                for (int i = 0; i < messageTriggers.Count; i++)
                {
                    currentMessageTriggers[i] = $"{messageTriggers[i].MessageTriggerName}";
                }

                for (int i = 0; i < trainerMessages.Count; i++)
                {
                    int trainerIndex = trainerMessages[i].TrainerId;
                    int messageTriggerIndex = messageTriggers.FindIndex(x => x.MessageTriggerId == trainerMessages[i].MessageTriggerId);

                    DataGridViewRow row = (DataGridViewRow)trainerTextTable_dataGrid.Rows[0].Clone();
                    row.Cells[0].Value = i;
                    row.Cells[1] = new DataGridViewComboBoxCell { DataSource = currentTrainers, Value = currentTrainers[trainerIndex] };
                    row.Cells[2] = new DataGridViewComboBoxCell { DataSource = currentMessageTriggers, Value = currentMessageTriggers[messageTriggerIndex] }; ;
                    row.Cells[3].Value = trainerMessages[i].MessageText;
                    ThreadSafeDataTable(row);
                }
            }
            statusLabelMessage();
            return Task.CompletedTask;
        }

        private void mainContent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (unsavedChanges)
            {
                var choice = MessageBox.Show("You have unsaved changes.\nDo you wish to discard these changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    SetUnsavedChanges(false);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void OpenPokemonEditor(int partyIndex)
        {
            pokemonEditor = new PokemonEditor(this, partyIndex, trainerFile);
            pokemonEditor.ShowDialog();
        }

        private void OpenTextEditor(int trainerMessageId, string messageText)
        {
            textEditor = new TextEditor(this, trainerMessageId, messageText, vsMakerFont);
            textEditor.ShowDialog();
        }

        private void OpenMoveEditor(int partyIndex)
        {
            moveEditor = new ChooseMoves(this, partyIndex, trainerFile);
            moveEditor.ShowDialog();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveRomChanges();
        }

        private void save_toolstrip_Click(object sender, EventArgs e)
        {
            SaveRomChanges();
        }

        private void SaveRomChanges()
        {
            SaveFileDialog saveRom = new()
            {
                Filter = DSUtils.NDSRomFilter
            };
            if (saveRom.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            statusLabelMessage("Repacking NARCS...");
            Update();

            // Repack NARCs
            foreach (KeyValuePair<DirNames, (string packedDir, string unpackedDir)> kvp in gameDirs)
            {
                DirectoryInfo di = new(kvp.Value.unpackedDir);
                if (di.Exists)
                {
                    Narc.FromFolder(kvp.Value.unpackedDir).Save(kvp.Value.packedDir); // Make new NARC from folder
                }
            }

            if (DSUtils.ARM9.CheckCompressionMark())
            {
                statusLabelMessage("Awaiting user response...");
                DialogResult d = MessageBox.Show("The ARM9 file of this ROM is currently uncompressed, but marked as compressed.\n" +
                    "This will prevent your ROM from working on native hardware.\n\n" +
                "Do you want to mark the ARM9 as uncompressed?", "ARM9 compression mismatch detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    DSUtils.ARM9.WriteBytes(new byte[4] { 0, 0, 0, 0 }, (uint)(gameFamily == gFamEnum.DP ? 0xB7C : 0xBB4));
                }
            }

            statusLabelMessage("Repacking ROM...");

            if (DSUtils.CheckOverlayHasCompressionFlag(1))
            {
                if (ROMToolboxDialog.overlay1MustBeRestoredFromBackup)
                {
                    DSUtils.RestoreOverlayFromCompressedBackup(1, false);
                }
                else
                {
                    if (!DSUtils.OverlayIsCompressed(1))
                    {
                        DSUtils.CompressOverlay(1);
                    }
                }
            }

            if (DSUtils.CheckOverlayHasCompressionFlag(RomInfo.initialMoneyOverlayNumber) && !DSUtils.OverlayIsCompressed(RomInfo.initialMoneyOverlayNumber))
            {
                DSUtils.CompressOverlay(RomInfo.initialMoneyOverlayNumber);
            }

            Update();

            DSUtils.RepackROM(saveRom.FileName);

            if (RomInfo.gameFamily != gFamEnum.DP && RomInfo.gameFamily != gFamEnum.Plat)
            {
                if (DSUtils.OverlayIsCompressed(1))
                {
                    DSUtils.DecompressOverlay(1);
                }
            }

            // Properties.Settings.Default.Save();
            statusLabelMessage();
        }

        private void SetUnsavedChanges(bool unsaved)
        {
            unsavedChanges = unsaved;
        }

        private void SetupPokemonTab()
        {
            EnablePokemon();
        }

        private void SetupTrainerTextTab(bool repoint = false)
        {
            statusLabelMessage("Setting up Trainer Text Table Editor...");
            Update();
            trainerTextTable_dataGrid.SuspendLayout();
            StartGetTrainerTextData(repoint);
            trainerTextTable_dataGrid.ResumeLayout();
            SetUnsavedChanges(false);
        }

        private async void StartGetTrainerTextData(bool repoint = false)
        {
            trainerText_toolstrip.Enabled = false;
            trainerTextTable_dataGrid.AllowUserToAddRows = true;
            await Task.Run(() => GetTrainerTextTableData().Wait());
            trainerText_toolstrip.Enabled = true;
            trainerTextTable_dataGrid.AllowUserToAddRows = false;
            if (repoint)
            {
                RepointTrainerOffsetTable(trainerTextTable_dataGrid);
                statusLabelMessage();
                Update();
            }
        }

        private void ThreadSafeDataTable(DataGridViewRow row)
        {
            if (trainerTextTable_dataGrid.InvokeRequired)
            {
                trainerTextTable_dataGrid.Invoke((MethodInvoker)delegate
                {
                    trainerTextTable_dataGrid.Rows.Add(row);
                });
            }
            else
            {
                trainerTextTable_dataGrid.Rows.Add(row);
            }
        }

        private void ThreadSafeDataTable(DataGridViewRow row, int index)
        {
            if (trainerTextTable_dataGrid.InvokeRequired)
            {
                trainerTextTable_dataGrid.Invoke((MethodInvoker)delegate
                {
                    trainerTextTable_dataGrid.Rows.Insert(index, row);
                });
            }
            else
            {
                trainerTextTable_dataGrid.Rows.Insert(index, row);
            }
        }

        private void trainer_Double_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trainer_Double_checkBox.Checked)
            {
                trainer_NumPoke_num.Minimum = 2;
                if (trainer_NumPoke_num.Value < 2)
                {
                    trainer_NumPoke_num.Value = 2;
                }
            }
            else
            {
                trainer_NumPoke_num.Minimum = 1;
            }
            if (!unsavedChanges)
            {
                undoTrainer_btn.Enabled = selectedTrainer.IsDouble != trainer_Double_checkBox.Checked;
            }
            SetUnsavedChanges(undoTrainer_btn.Enabled);
            EnablePokemon();
        }

        private void trainer_EditMessage_btn_Click(object sender, EventArgs e)
        {
            string selectedMessageTriggerName = trainer_MessageTrigger_list.SelectedItem.ToString();
            int messageTriggerId = messageTriggers.Find(x => x.MessageTriggerName == selectedMessageTriggerName).MessageTriggerId;
            var trainerMessage = selectedTrainer.TrainerMessages.Single(x => x.MessageTriggerId == messageTriggerId);
            OpenTextEditor(trainerMessage.MessageId, trainerMessage.MessageText);
        }

        private void trainer_frames_num_ValueChanged(object sender, EventArgs e)
        {
            UpdateTrainerClassPic(trainerPicBox, (int)((NumericUpDown)sender).Value);
        }

        private void trainer_GoToClass_btn_Click(object sender, EventArgs e)
        {
            int index = trainer_Class_comboBox.SelectedIndex;
            var text = trainer_Class_comboBox.Items[index].ToString();
            int id = int.Parse(text.Remove(0, 1).Remove(3));
            selectedTrainerClass = trainerClasses.SingleOrDefault(x => x.TrainerClassId == id);
            mainContent.SelectedTab = mainContent_trainerClass;
        }

        private void trainer_Message_Back_btn_Click(object sender, EventArgs e)
        {
            currentTrainerMessageIndex--;
            trainer_Message_Back_btn.Enabled = currentTrainerMessageIndex > 0;
            trainer_Message_Next_btn.Enabled = currentTrainerMessageIndex >= 0;

            if (currentTrainerMessageIndex >= 0)
            {
                trainer_Message.Text = displayTrainerMessage[currentTrainerMessageIndex];
            }
            else
            {
                currentTrainerMessageIndex++;
            }
        }

        private void trainer_Message_Next_btn_Click(object sender, EventArgs e)
        {
            currentTrainerMessageIndex++;
            trainer_Message_Back_btn.Enabled = currentTrainerMessageIndex > 0;
            trainer_Message_Next_btn.Enabled = currentTrainerMessageIndex < displayTrainerMessage.Count() - 1;

            if (currentTrainerMessageIndex < displayTrainerMessage.Count())
            {
                trainer_Message.Text = displayTrainerMessage[currentTrainerMessageIndex];
            }
            else
            {
                currentTrainerMessageIndex--;
            }
        }

        private void trainer_MessageTrigger_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTrainerMessageIndex = 0;
            displayTrainerMessage = new List<string>();
            if (trainer_MessageTrigger_list.SelectedIndex > -1)
            {
                trainer_EditMessage_btn.Enabled = true;
                const string seperator1 = @"\r";
                string selectedMessageTriggerName = trainer_MessageTrigger_list.SelectedItem.ToString();
                int messageTriggerId = messageTriggers.Find(x => x.MessageTriggerName == selectedMessageTriggerName).MessageTriggerId;
                string trainerText = selectedTrainer.TrainerMessages.Single(x => x.MessageTriggerId == messageTriggerId).MessageText;

                trainerText = trainerText.Replace("\\n", Environment.NewLine);
                trainerText = trainerText.Replace("\\f", Environment.NewLine);
                var messageArray = trainerText.Split(new string[] { seperator1 }, StringSplitOptions.None);
                foreach (var item in messageArray)
                {
                    int numLines = item.Split('\n').Length;
                    if (numLines >= 3 && !string.IsNullOrEmpty(ReadLine(item, 3)))
                    {
                        string text1 = ReadLine(item, 1) + Environment.NewLine + ReadLine(item, 2);
                        string text2 = ReadLine(item, 2) + Environment.NewLine + ReadLine(item, 3);

                        displayTrainerMessage.Add(text1);
                        displayTrainerMessage.Add(text2);
                    }
                    else
                    {
                        displayTrainerMessage.Add(item);
                    }
                }
                // Remove last item if blank line - is the case as trainer text formatted as ending with \n.
                if (string.IsNullOrEmpty(displayTrainerMessage.Last()))
                {
                    displayTrainerMessage.Remove(displayTrainerMessage.Last());
                }
                trainer_Message.Font = new Font(vsMakerFont.VsMakerFontCollection.Families[0], trainer_Message.Font.Size);
                trainer_Message.Text = displayTrainerMessage[0];
                trainer_Message_Next_btn.Enabled = displayTrainerMessage.Count() > 1;
                trainer_Message_Back_btn.Enabled = false;
            }
            else
            {
                trainer_EditMessage_btn.Enabled = false;
                trainer_MessageTrigger_list.Enabled = false;
            }
        }

        private void trainer_NumPoke_num_ValueChanged(object sender, EventArgs e)
        {
            if (!unsavedChanges)
            {
                undoTrainer_btn.Enabled = selectedTrainer.Pokemon.Count != trainer_NumPoke_num.Value;
            }
            SetUnsavedChanges(undoTrainer_btn.Enabled);
            EnablePokemon();
        }

        private void trainer_Player_help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the \"Player\" trainer file.\n\nChanging this can cause errors.", "Player File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainer_Poke1_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(0);
        }

        private void trainer_Poke2_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(1);
        }

        private void trainer_Poke3_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(2);
        }

        private void trainer_Poke4_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(3);
        }

        private void trainer_Poke5_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(4);
        }

        private void trainer_Poke6_btn_Click(object sender, EventArgs e)
        {
            OpenPokemonEditor(5);
        }

        private void trainerClass_frames_num_ValueChanged(object sender, EventArgs e)
        {
            UpdateTrainerClassPic(trainerClassPicBox, (int)((NumericUpDown)sender).Value);
        }

        private void trainerClassName_TextChanged(object sender, EventArgs e)
        {
            if (!unsavedChanges)
            {
                undoTrainerClass_btn.Enabled = selectedTrainerClass.TrainerClassName != trainerClassName.Text;
            }
            SetUnsavedChanges(undoTrainerClass_btn.Enabled);
        }

        private void trainerEditor_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainerEditor_tab.SelectedTab == trainerEditor_Pokemon)
            {
                SetupPokemonTab();
            }
        }

        private void trainers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trainers_list.SelectedIndex;

            if (selectedTrainerIndex == -1)
            {
                ChangeTrainer();
            }

            if (selectedTrainerIndex > -1 && selectedTrainerIndex != index)
            {
                if (unsavedChanges)
                {
                    var choice = MessageBox.Show("You have unsaved changes.\nDo you wish to discard these changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        ChangeTrainer();
                    }
                    else
                    {
                        trainers_list.SelectedIndexChanged -= trainers_list_SelectedIndexChanged;
                        trainers_list.SelectedIndex = selectedTrainerIndex;
                        trainers_list.SelectedIndexChanged += trainers_list_SelectedIndexChanged;
                    }
                }
                else
                {
                    ChangeTrainer();
                }
            }

            void ChangeTrainer()
            {
                selectedTrainerIndex = index;
                SetUnsavedChanges(false);
                var text = trainers_list.Items[index].ToString();
                int trainerId = int.Parse(text.Remove(0, 1).Remove(3));
                trainer_MessageTrigger_list.SelectedIndex = -1;
                GetTrainerInfo(trainerId);
            }
        }

        private void trainerTextTable_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //trainerTextTable_help_label.Text = "Double click to open text editor.";
            }
            else
            {
                //trainerTextTable_help_label.Text = "";
            }
        }

        private void trainerTextTable_dataGrid_TextDblClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int trainerMessageId = e.RowIndex;
                var trainerMessage = trainerMessages.Find(x => x.MessageId == trainerMessageId);
                OpenTextEditor(trainerMessage.MessageId, trainerMessage.MessageText);
            }
        }

        private void undoTrainerClass_btn_Click(object sender, EventArgs e)
        {
            SetUnsavedChanges(false);
            GetTrainerClassInfo(selectedTrainerClass.TrainerClassId);
        }

        public void RefreshTrainerMessages(bool repoint = false)
        {
            trainerTextTable_dataGrid.Rows.Clear();
            trainerMessages = new List<TrainerMessage>();
            GetData();
            SetupTrainerTextTab(repoint);
            if (selectedTrainer != default)
            {
                GetTrainerInfo(selectedTrainer.TrainerId);
            }
        }

        private void saveTrainerAll_btn_Click(object sender, EventArgs e)
        {
            bool valid = ValidateTrainerName() && ValidateTrainerPokemon();
            if (valid)
            {
                SaveTrainerName();
                SaveTrainerPokemon();
                SaveTrainerProperties();
                SaveTrainerClass();
                TrainerChangesCommit();
                GetTrainers();
                SetupTrainerEditor();
            }
        }

        private void TrainerChangesCommit()
        {
            /*Write to File*/
            string indexStr = $"\\{selectedTrainer.TrainerId:D4}";
            File.WriteAllBytes(gameDirs[DirNames.trainerProperties].unpackedDir + indexStr, trainerFile.trp.ToByteArray());
            File.WriteAllBytes(gameDirs[DirNames.trainerParty].unpackedDir + indexStr, trainerFile.party.ToByteArray());
        }

        private void SaveTrainerClass()
        {
            trainerFile.trp.trainerClass = (byte)trainer_Class_comboBox.SelectedIndex;
        }

        private void SaveTrainerProperties()
        {
            // Set Trainer AI Flags
            trainerFile.trp.AI[0] = trainer_ai_Basic_checkbox.Checked;
            trainerFile.trp.AI[1] = trainer_ai_evaluate_checkBox.Checked;
            trainerFile.trp.AI[2] = trainer_ai_expert_checkBox.Checked;
            trainerFile.trp.AI[3] = trainer_ai_status_checkBox.Checked;
            trainerFile.trp.AI[4] = trainer_ai_risk_checkBox.Checked;
            trainerFile.trp.AI[5] = trainer_ai_dmg_checkBox.Checked;
            trainerFile.trp.AI[6] = trainer_ai_baton_checkBox.Checked;
            trainerFile.trp.AI[7] = trainer_ai_tag_checkBox.Checked;
            trainerFile.trp.AI[8] = trainer_ai_checkHp_checkBox.Checked;
            trainerFile.trp.AI[9] = trainer_ai_weather_checkBox.Checked;
            trainerFile.trp.AI[10] = trainer_ai_misc_checkBox.Checked;

            // Set Trainer Items
            for (int i = 0; i < trainerItemComboBoxes.Count; i++)
            {
                trainerFile.trp.trainerItems[i] = (ushort)trainerItemComboBoxes[i].SelectedIndex;
            }
        }

        private void saveTrainerClassAll_btn_Click(object sender, EventArgs e)
        {
            bool valid = ValidateTrainerClassName();
            if (valid)
            {
                SaveTrainerClassEyeContact();
                SaveTrainerClassName();
                GetTrainerClassEncounterMusic();
                GetTrainerClasses();
                SetupTrainerClassEditor();
            }
        }

        private void SaveTrainerClassEyeContact()
        {
            byte trainerClassId = (byte)trainerClassListBox.SelectedIndex;

            ushort musicDay = EyeMusicIdNames.GetIdFromName(trainerClass_EyeContact_Day_comboBox.SelectedItem.ToString());
            ushort musicNight = EyeMusicIdNames.GetIdFromName(trainerClass_EyeContact_Night_comboBox.SelectedItem.ToString());

            if (trainerClassEncounterMusicDict.TryGetValue(trainerClassId, out var dictEntry))
            {
                if (gameFamily == gFamEnum.HGSS)
                {
                    trainerClassEncounterMusicDict[trainerClassId] = (dictEntry.entryOffset, musicDay, musicNight);
                    DSUtils.ARM9.WriteBytes(BitConverter.GetBytes(musicDay), dictEntry.entryOffset + 2);
                    DSUtils.ARM9.WriteBytes(BitConverter.GetBytes(musicNight), dictEntry.entryOffset + 4);
                }
                else
                {
                    trainerClassEncounterMusicDict[trainerClassId] = (dictEntry.entryOffset, musicDay, dictEntry.musicN);
                    DSUtils.ARM9.WriteBytes(BitConverter.GetBytes(musicDay), dictEntry.entryOffset + 2);
                }
            }
        }

        private void GetEyeContactMusicLists()
        {
            eyeContactMusics = new List<EyeContactMusic>
            {
                new EyeContactMusic { MusicId = (ushort)1107 },
                new EyeContactMusic { MusicId = (ushort)1108 },
                new EyeContactMusic { MusicId = (ushort)1109 },
                new EyeContactMusic { MusicId = (ushort)1110 },
                new EyeContactMusic { MusicId = (ushort)1111 },
                new EyeContactMusic { MusicId = (ushort)1112 },
                new EyeContactMusic { MusicId = (ushort)1113 },
                new EyeContactMusic { MusicId = (ushort)1114 },
                new EyeContactMusic { MusicId = (ushort)1115 },
            };

            foreach (var item in eyeContactMusics)
            {
                trainerClass_EyeContact_Day_comboBox.Items.Add(item.Name);
                trainerClass_EyeContact_Night_comboBox.Items.Add(item.Name);
            }
        }

        private void undoTrainer_btn_Click(object sender, EventArgs e)
        {
            SetUnsavedChanges(false);
            GetTrainerInfo(selectedTrainer.TrainerId);
        }

        private void trainer_Name_TextChanged(object sender, EventArgs e)
        {
            if (!unsavedChanges)
            {
                undoTrainer_btn.Enabled = selectedTrainer.TrainerName != trainer_Name.Text;
            }
            SetUnsavedChanges(undoTrainer_btn.Enabled);
        }

        private void trainerTextTable_SaveChanges_btn(object sender, EventArgs e)
        {
            trainerTextTable_dataGrid.EndEdit();
            var verify = VerifyTrainerTextTable();
            if (!verify.Valid)
            {
                MessageBox.Show("You must only use each Message Trigger once per Trainer.\n\nPlease review entry " + verify.Row, "Unable to Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trainerTextTable_dataGrid.FirstDisplayedScrollingRowIndex = verify.Row;
                trainerTextTable_dataGrid.ClearSelection();
                trainerTextTable_dataGrid.Rows[verify.Row].Selected = true;
                return;
            }

            var dialogResult = MessageBox.Show("Save all changes to Trainer Text Table?\nThis might take some time...", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                statusLabelMessage("Saving changes...");
                Update();
                string filePath = $"{gameDirs[DirNames.trainerTextTable].unpackedDir}\\{0.ToString("D4")}";
                var trainerTextArchive = new TextArchive(trainerTextMessageNumber);
                trainerTextArchive.Messages.Clear();
                for (int i = 0; i < trainerTextTable_dataGrid.Rows.Count; i++)
                {
                    string messageText = trainerTextTable_dataGrid.Rows[i].Cells[3].Value.ToString();
                    trainerTextArchive.Messages.Add(messageText);
                    var selectedMessageTrigger = trainerTextTable_dataGrid.Rows[i].Cells[2].Value.ToString();
                    var selectedTrainer = trainerTextTable_dataGrid.Rows[i].Cells[1].Value.ToString();
                    int trainerId = int.Parse(selectedTrainer.Remove(0, 1).Remove(3));
                    int messageTriggerId = messageTriggers.Find(x => x.MessageTriggerName == selectedMessageTrigger).MessageTriggerId;
                    using (DSUtils.EasyWriter wr = new DSUtils.EasyWriter(filePath, 4 * i))
                    {
                        wr.Write((ushort)trainerId);
                        wr.Write((ushort)messageTriggerId);
                    };
                }
                trainerTextArchive.SaveToFileDefaultDir(trainerTextMessageNumber);
                statusLabelMessage("Trainer Texts saved successfully");
                Update();
                SetUnsavedChanges(false);
                RomInfo.ReadTrainerTable();
                RefreshTrainerMessages();
            }
        }

        private void trainerTextTable_addRow_btn_Click(object sender, EventArgs e)
        {
            int index = trainerTextTable_dataGrid.Rows.Count - 1;

            // Get current selected row index - Can't multi-select
            if (trainerTextTable_dataGrid.SelectedRows.Count > 0)
            {
                index = trainerTextTable_dataGrid.SelectedRows[0].Index;
            }
            else if (trainerTextTable_dataGrid.SelectedCells.Count > 0)
            {
                index = trainerTextTable_dataGrid.SelectedCells[0].RowIndex;
            }
            string[] currentTrainers = new string[trainers.Count];
            string[] currentMessageTriggers = new string[messageTriggers.Count];

            for (int i = 0; i < trainers.Count; i++)
            {
                currentTrainers[i] = $"[{trainers[i].DisplayTrainerId}] - {trainers[i].TrainerName}";
            }

            for (int i = 0; i < messageTriggers.Count; i++)
            {
                currentMessageTriggers[i] = $"{messageTriggers[i].MessageTriggerName}";
            }

            DataGridViewRow row = (DataGridViewRow)trainerTextTable_dataGrid.Rows[0].Clone();
            row.Cells[0].Value = trainerTextTable_dataGrid.Rows.Count;
            row.Cells[1] = new DataGridViewComboBoxCell { DataSource = currentTrainers, Value = currentTrainers[0] };
            row.Cells[2] = new DataGridViewComboBoxCell { DataSource = currentMessageTriggers, Value = currentMessageTriggers[0] };
            row.Cells[3].Value = "";
            ThreadSafeDataTable(row, index + 1);
            trainerTextTable_dataGrid.FirstDisplayedScrollingRowIndex = index > 0 ? index - 1 : index;
            trainerTextTable_dataGrid.ClearSelection();
            trainerTextTable_dataGrid.Rows[index + 1].Selected = true;
            SetUnsavedChanges(true);
        }

        private void trainerTextTable_delRow_btn_Click(object sender, EventArgs e)
        {
            int index = trainerTextTable_dataGrid.Rows.Count - 1;

            // Get current selected row index - Can't multi-select
            if (trainerTextTable_dataGrid.SelectedRows.Count > 0)
            {
                index = trainerTextTable_dataGrid.SelectedRows[0].Index;
            }
            else if (trainerTextTable_dataGrid.SelectedCells.Count > 0)
            {
                index = trainerTextTable_dataGrid.SelectedCells[0].RowIndex;
            }

            trainerTextTable_dataGrid.Rows.RemoveAt(index);
            trainerTextTable_dataGrid.FirstDisplayedScrollingRowIndex = index > 0 ? index - 1 : index;
            trainerTextTable_dataGrid.ClearSelection();
            trainerTextTable_dataGrid.Rows[index].Selected = true;
            SetUnsavedChanges(true);
        }

        private (bool Valid, int Row) VerifyTrainerTextTable()
        {
            foreach (var trainer in trainers)
            {
                var checkMessages = new List<string>();
                for (int i = 0; i < trainerTextTable_dataGrid.Rows.Count; i++)
                {
                    var selectedMessageTrigger = trainerTextTable_dataGrid.Rows[i].Cells[2].Value.ToString();
                    var selectedTrainer = trainerTextTable_dataGrid.Rows[i].Cells[1].Value.ToString();
                    int trainerId = int.Parse(selectedTrainer.Remove(0, 1).Remove(3));
                    if (trainerId == trainer.TrainerId)
                    {
                        if (checkMessages.Contains(selectedMessageTrigger))
                        {
                            return (false, i);
                        }
                        else
                        {
                            checkMessages.Add(selectedMessageTrigger);
                        }
                    }
                }
            }

            return (true, -1);
        }

        private void trainerText_sort_Click(object sender, EventArgs e)
        {
            trainerTextTable_dataGrid.EndEdit();
            var verify = VerifyTrainerTextTable();
            if (!verify.Valid)
            {
                MessageBox.Show("You can only use each Message Trigger once per Trainer.\n\nPlease review entry " + verify.Row, "Unable to Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trainerTextTable_dataGrid.FirstDisplayedScrollingRowIndex = verify.Row;
                trainerTextTable_dataGrid.ClearSelection();
                trainerTextTable_dataGrid.Rows[verify.Row].Selected = true;
                return;
            }

            var dialogResult = MessageBox.Show("This will sort the Trainer Text table to group Trainers.\n\nThe Trainer Text lookup table will also be sorted.\nThis allows for more efficient loading in-game.\n\nAll changes will be saved.", "Sort and Repoint", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                var trainerTexts = new List<TrainerMessage>();

                // Sort Trainer Text Table by Trainer.
                foreach (var trainer in trainers)
                {
                    var thisTrainerText = new List<TrainerMessage>();
                    for (int i = 0; i < trainerTextTable_dataGrid.Rows.Count; i++)
                    {
                        var selectedMessageTrigger = trainerTextTable_dataGrid.Rows[i].Cells[2].Value.ToString();
                        var selectedTrainer = trainerTextTable_dataGrid.Rows[i].Cells[1].Value.ToString();
                        int trainerId = int.Parse(selectedTrainer.Remove(0, 1).Remove(3));

                        if (trainerId == trainer.TrainerId)
                        {
                            var trainerMessage = new TrainerMessage
                            {
                                TrainerId = trainerId,
                                MessageTriggerId = messageTriggers.Single(x => x.MessageTriggerName == selectedMessageTrigger).MessageTriggerId,
                                MessageText = trainerTextTable_dataGrid.Rows[i].Cells[3].Value.ToString()
                            };

                            thisTrainerText.Add(trainerMessage);
                        }
                    }
                    thisTrainerText = thisTrainerText.OrderBy(x => x.MessageTriggerId).ToList();
                    trainerTexts.AddRange(thisTrainerText);
                }
                var trainerTextArchive = new TextArchive(trainerTextMessageNumber);
                trainerTextArchive.Messages.Clear();
                string filePath = $"{gameDirs[DirNames.trainerTextTable].unpackedDir}\\{0.ToString("D4")}";

                for (int i = 0; i < trainerTexts.Count; i++)
                {
                    trainerTextArchive.Messages.Add(trainerTexts[i].MessageText);
                    using (DSUtils.EasyWriter wr = new(filePath, 4 * i))
                    {
                        wr.Write((ushort)trainerTexts[i].TrainerId);
                        wr.Write((ushort)trainerTexts[i].MessageTriggerId);
                    };
                }
                trainerTextArchive.SaveToFileDefaultDir(trainerTextMessageNumber);
                ReadTrainerTable();
                RefreshTrainerMessages(true);
            }
        }

        /// <summary>
        /// Repoint Trainer Text Offset table.
        /// </summary>
        /// <param name="dataGrid"></param>
        private void RepointTrainerOffsetTable(DataGridView dataGrid)
        {
            List<uint> offset = new List<uint>();
            statusLabelMessage("Getting Trainer Text offsets.");
            Update();
            foreach (var trainer in trainers)
            {
                string trainerListItem = $"[{trainer.DisplayTrainerId}] - {trainer.TrainerName}";
                int index = -1;
                bool search = true;
                while (search)
                {
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (dataGrid.Rows[i].Cells[1].Value.ToString() == trainerListItem)
                        {
                            index = i - 1;
                            search = false;
                            break;
                        }
                    }
                    break;
                }
                index++;
                index *= 4;
                offset.Add((uint)index);
            }
            string filePath = $"{gameDirs[DirNames.trainerTextOffset].unpackedDir}\\{0.ToString("D4")}";

            for (int i = 0; i < offset.Count; i++)
            {
                using (DSUtils.EasyWriter wr = new(filePath, 2 * i))
                {
                    wr.Write(offset[i]);
                };
            }
            statusLabelMessage("Trainer Text offsets generated successfully...");
            Update();
            MessageBox.Show("Trainer Text offsets repointed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainerText_Export_btn_Click(object sender, EventArgs e)
        {
            var (success, filePath) = ExportToExcel(trainerTextTable_dataGrid);
            if (success)
            {
                MessageBox.Show("Speadsheet exported to\n\n" + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Export given DataGridView to an Excel file.
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns>Success/Failure bool and File Path</returns>
        private (bool Success, string FilePath) ExportToExcel(DataGridView dataGrid)
        {
            // Do nothing if no data.
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new()
                {
                    Filter = "Excel (.xlsx)|  *.xlsx",
                    FileName = "Trainer Text Table.xlsx"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    // Setup DataTable for Export
                    var dataTable = new DataTable();
                    foreach (DataGridViewColumn col in dataGrid.Columns)
                    {
                        dataTable.Columns.Add(col.HeaderText);
                    }
                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        dataTable.Rows.Add(row);
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string value = cell.Value.ToString();
                            if (cell.ColumnIndex == 1)
                            {
                                value = value.Remove(0, 1).Remove(3);
                            }
                            else if (cell.ColumnIndex == 2)
                            {
                                value = (messageTriggers.Find(x => x.MessageTriggerName == value).MessageTriggerId + 1).ToString();
                            }
                            dataTable.Rows[row.Index][cell.ColumnIndex] = value;
                        }
                    }

                    // Setup Spreadsheet.
                    using XLWorkbook workbook = new();
                    var trainerText = workbook.Worksheets.Add(dataTable, "Trainer Text");
                    // Add Message Trigger List to new Sheet
                    var messageTriggerTypes = workbook.Worksheets.Add("Message Triggers");
                    messageTriggerTypes.Cell("A1").Value = "Message Trigger ID";
                    messageTriggerTypes.Cell("B1").Value = "Message Trigger Name";
                    for (int i = 0; i < messageTriggers.Count; i++)
                    {
                        string cellNumber = (i + 2).ToString();
                        messageTriggerTypes.Cell("A" + cellNumber).Value = (messageTriggers[i].MessageTriggerId + 1).ToString("D2");
                        messageTriggerTypes.Cell("B" + cellNumber).Value = messageTriggers[i].MessageTriggerName;
                    }
                    trainerText.Columns().AdjustToContents();
                    messageTriggerTypes.Columns().AdjustToContents();

                    // Try save Spreadsheet
                    try
                    {
                        workbook.SaveAs(filePath);
                        return (true, filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Speadsheet not exported.\n\n" + ex.Message, "Unable to Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (false, filePath);
                    }
                }
            }
            return (false, string.Empty);
        }

        private void SaveTrainerPokemon()
        {
            trainerFile.trp.doubleBattle = trainer_Double_checkBox.Checked;
            trainerFile.trp.chooseItems = trainer_Poke_HeldItem_checkBox.Checked;
            trainerFile.trp.chooseMoves = trainer_Poke_Moves_checkBox.Checked;
            trainerFile.trp.partyCount = (byte)trainer_NumPoke_num.Value;
            for (int i = 0; i < trainer_NumPoke_num.Value; i++)
            {
                trainerFile.party[i].pokeID = (ushort)pokeComboBoxes[i].SelectedIndex;
                trainerFile.party[i].level = (ushort)pokeLevels[i].Value;
                trainerFile.party[i].heldItem = trainer_Poke_HeldItem_checkBox.Checked ? (ushort)pokeItemComboBoxes[i].SelectedIndex : null;
            }
        }

        private bool ValidateTrainerPokemon()
        {
            for (int i = 0; i < trainer_NumPoke_num.Value; i++)
            {
                if (pokeComboBoxes[i].SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a Pokemon!", "Unable to Save Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            SetUnsavedChanges(false);
            return true;
        }

        private void trainer_Poke1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke3_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke4_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke5_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke6_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke1_Level_ValueChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke_HeldItem_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            EnablePokemon();
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Poke_Moves_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            EnablePokemon();
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Item4_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_Basic_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_expert_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_dmg_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_evaluate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_status_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_weather_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_risk_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_checkHp_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_baton_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_ai_tag_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Item1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Item2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainer_Item3_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUnsavedChanges(true);
            undoTrainer_btn.Enabled = unsavedChanges;
        }

        private void trainreText_Import_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Importing from a spreadsheet will clear the current table\n" +
                "and you will lose any unsaved changes.\n\nDo you wish to continue?", "Import Spreadsheet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ImportSpreadsheet();
            }
        }

        public XLWorkbook OpenSpreadsheet()
        {
            OpenFileDialog file = new();
            file.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (file.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Unable to open file.");
                return null;
            }
            else
            {
                string fileName = file.FileName;
                return new XLWorkbook(fileName);
            }
        }

        private void ImportSpreadsheet()
        {
            var workbook = OpenSpreadsheet();
            if (workbook != null)
            {
                bool firstRow = false; ;
                var worksheet = workbook.Worksheet(1);
                try
                {
                    statusLabelMessage("Importing data from spreadhsheet");
                    Update();
                    trainerMessages = new();

                    foreach (var row in worksheet.Rows())
                    {
                        if (!firstRow)
                        {
                            firstRow = true;
                        }
                        else
                        {
                            int messageId = int.Parse(row.Cell(1).Value.ToString());
                            int trainerId = int.Parse(row.Cell(2).Value.ToString());
                            int messageTriggerId = int.Parse(row.Cell(3).Value.ToString());
                            string text = row.Cell(4).Value.ToString();
                            TrainerMessage item = new TrainerMessage
                            {
                                MessageId = messageId,
                                TrainerId = trainerId,
                                MessageTriggerId = messageTriggerId - 1,
                                MessageText = text
                            };
                            item.TrainerName = trainers[item.TrainerId].TrainerName;
                            item.MessageTriggerText = messageTriggers.Find(x => x.MessageTriggerId == item.MessageTriggerId).MessageTriggerName;
                            trainerMessages.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open spreadsheet.\n\n" + ex.Message, "Unable to Open Spreadsheet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                statusLabelMessage("Reloading Trainer Text data.");
                Update();
                trainerTextTable_dataGrid.Rows.Clear();
                trainerText_toolstrip.Enabled = false;
                StartGetTrainerTextData(false);
            }
        }

        private void eyeContact_help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting eye-contact music for this Trainer Class is disabled.\n\nThis is because it does not originally have an entry\nin the Eye-Contact Music Table located in ARM9.\nThe table needs to be expanded first, but this feature is not yet implemented.", "Eye-Contact Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainer_Poke1_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(0);
        }

        private void trainer_Poke2_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(1);
        }

        private void trainer_Poke3_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(2);
        }

        private void trainer_Poke4_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(3);
        }

        private void trainer_Poke5_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(4);
        }

        private void trainer_Poke6_Moves_btn_Click(object sender, EventArgs e)
        {
            OpenMoveEditor(5);
        }
    }
}