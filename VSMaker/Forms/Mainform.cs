using Ekona.Images;
using Images;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using VSMaker.Data;
using VSMaker.Forms;
using VSMaker.ROMFiles;
using static VSMaker.RomInfo;
using Image = System.Drawing.Image;

namespace VSMaker
{
    public partial class Mainform : Form
    {
        public PrivateFontCollection Fonts;
        #region ROM Info

        public Dictionary<ushort, ushort> eventToHeader = new();
        private RomInfo romInfo;

        #endregion ROM Info

        #region Editor Data

        private List<MessageTrigger> messageTriggers = new();
        private List<Move> moves = new();
        private List<Pokemon> pokemons = new();
        private Trainer selectedTrainer;
        private TrainerClass selectedTrainerClass;

        private List<TrainerClass> trainerClasses = new();
        private List<TrainerMessage> trainerMessages = new();
        private PaletteBase trainerPal;
        private List<Trainer> trainers = new();
        private SpriteBase trainerSprite;
        private ImageBase trainerTile;

        private bool unsavedChanges = false;

        private string[] displayTrainerMessage = new string[0];

        #endregion Editor Data

        #region Forms

        private PokemonEditor pokemonEditor;
        private TextEditor textEditor;

        #endregion Forms

        public Mainform()
        {
            InitializeComponent();
            InitializePokemonDsFont();
            trainer_Message.Text = string.Empty;
        }

        #region ROM

        private void CheckROMLanguage()
        {
            versionLabel.Visible = true;
            languageLabel.Visible = true;

            versionLabel.Text = gameVersion.ToString() + " " + "[" + romID + "]";
            languageLabel.Text = "Lang: " + gameLanguage;

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
            // Setup data for initial trainer class tab.
            SetupTrainerClassEditor();
        }

        private void OpenRomFolder()
        {
            CommonOpenFileDialog romFolder = new CommonOpenFileDialog
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
            this.Text += "  -  " + fileName;
        }

        private bool UnpackRom(string ndsFileName)
        {
            statusLabelMessage("Unpacking ROM contents to " + workDir + " ...");
            Update();

            Directory.CreateDirectory(workDir);
            Process unpack = new Process();
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
                MessageBox.Show("Failed to call ndstool.exe" + Environment.NewLine + "Make sure VS-Maker's Tools folder is intact.",
                    "Couldn't unpack ROM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private int UnpackRomCheckUserChoice()
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

        #endregion ROM

        #region Fonts
        private void InitializePokemonDsFont()
        {
            //Create your private font collection object.
            Fonts = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.pokemon_ds_font.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.pokemon_ds_font;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            Fonts.AddMemoryFont(data, fontLength);
        }
        #endregion Fonts

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
                MessageBox.Show("The extracted folder is not setup correctly.\nEssential files are missing.\n\n" + ex.Message, "Error Opening Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("The extracted folder is not setup correctly.\nEssential files are missing.\n\n" + ex.Message, "Error Opening Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void statusLabelError(string errorMsg, bool severe = true)
        {
            statusLabel.Text = errorMsg;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
            statusLabel.ForeColor = severe ? Color.Red : Color.DarkOrange;
            statusLabel.Invalidate();
        }

        private void statusLabelMessage(string msg = "Ready")
        {
            statusLabel.Text = msg;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Regular);
            statusLabel.ForeColor = Color.Black;
            statusLabel.Invalidate();
        }

        #endregion Main Editor

        #region Trainer Class Editor

        private void ClearTrainerClassLists()
        {
            // Clear Lists
            trainerClassListBox.Items.Clear();
            player_trainer_class.Items.Clear();
            trainerClass_Uses_list.Items.Clear();
        }

        private void playerClass_help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These Trainer Classes are \"Player Classes\".\n\nChanging these can cause errors.", "Player Classes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveClassName_btn_Click(object sender, EventArgs e)
        {
            if (trainerClassName.Text.Length > TrainerFile.maxClassNameLen)
            {
                MessageBox.Show($"Trainer Class name cannot exceed {TrainerFile.maxClassNameLen} characters.", "Trainer Class Name Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GetSingleTrainerClassName(selectedTrainerClass.TrainerClassId) != trainerClassName.Text)
            {
                RomFileSystem.UpdateCurrentTrainerClassName(trainerClassName.Text, selectedTrainerClass.TrainerClassId);
                MessageBox.Show("Trainer Class name updated!", "Success!");
                ClearTrainerClassLists();
                SetupTrainerClassEditor();
                SetSelectedTrainerClass(selectedTrainerClass);
                GetTrainerClassInfo(selectedTrainerClass.TrainerClassId);
            }
        }

        private void SetSelectedTrainerClass(TrainerClass trainerClass)
        {
            if (trainerClass.IsPlayerClass)
            {
                player_trainer_class.SelectedIndex = trainerClass.TrainerClassId;
            }
            else
            {
                trainerClassListBox.SelectedIndex = trainerClass.TrainerClassId - 2;
            }
        }
        private void DisableTrainerClassEditorInputs()
        {
            //Disable Buttons
            saveClassName_btn.Enabled = false;
            saveClassTheme_btn.Enabled = false;
            saveClassProperties_btn.Enabled = false;
            saveTrainerClassAll_btn.Enabled = false;
            undoTrainerClass_btn.Enabled = false;
            trainerClass_GoToTrainer_btn.Enabled = false;

            //Disable Fields
            trainerClassName.Enabled = false;
            trainerClass_EyeContactMain_comboBox.Enabled = false;
            trainerClass_EyeContactAlt_comboBox.Enabled = false;
            trainerClass_PrizeMoney_num.Enabled = false;
            trainerClass_Gender_comboBox.Enabled = false;
            trainerClass_frames_num.Enabled = false;
            trainerClass_Uses_list.Enabled = false;
        }

        private void SetupTrainerClassEditor()
        {
            ClearTrainerClassLists();
            DisableTrainerClassEditorInputs();
            GetData();
            statusLabelMessage("Setting up Trainer Class Editor...");
            Update();

            //Setup Trainer Class List

            foreach (var item in trainerClasses)
            {
                if (item.IsPlayerClass)
                {
                    player_trainer_class.Items.Add($"[{item.DisplayTrainerClassId}] - {item.TrainerClassName}");
                }
                else
                {
                    trainerClassListBox.Items.Add($"[{item.DisplayTrainerClassId}] - {item.TrainerClassName}");
                }
            }
            if (trainerClassListBox.Items.Count > 0)
            {
                trainerClassListBox.Enabled = true;
            }

            statusLabelMessage();
            Update();

            if (selectedTrainerClass != default)
            {
                trainerClassListBox.SelectedIndex = selectedTrainerClass.TrainerClassId - 2;
            }
        }

        private void SetupTrainerClassEditorInputs(TrainerClass trainerClass)
        {
            trainerClassName.Enabled = !string.IsNullOrEmpty(trainerClass.TrainerClassName);
            trainerClass_Uses_list.Enabled = trainerClass.InUse;
            trainerClass_frames_num.Enabled = trainerClass.TrainerSpriteFrames > 0;
        }

        private void TrainerClass_CheckSaveAllButton(bool enableSave, bool enableUndo)
        {
            saveTrainerClassAll_btn.Enabled = enableSave;
            undoTrainerClass_btn.Enabled = enableUndo;
            unsavedChanges = enableUndo;
        }

        private void trainerClass_GoToTrainer_btn_Click(object sender, EventArgs e)
        {
            int index = trainerClass_Uses_list.SelectedIndex;
            var text = trainerClass_Uses_list.Items[index].ToString();
            int id = int.Parse(text.Remove(0, 1).Remove(3));
            mainContent.SelectedTab = mainContent_trainer;
            SetupTrainerEditor();
            trainers_list.SelectedIndex = id - 1;
            GetTrainerInfo(id);
        }

        private void trainerClass_PrizeMoney_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Base Rate Multiplier for calculating Prize Money.\nIt is multiplied by the level of a Trainer's last Pokémon.", "About Prize Money", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainerClass_Uses_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainerClass_GoToTrainer_btn.Enabled = true;
        }

        private void trainerClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trainerClassListBox.SelectedIndex;
            if (index > -1)
            {
                player_trainer_class.SelectedIndex = -1;
                var text = trainerClassListBox.Items[index].ToString();
                int trainerClassId = int.Parse(text.Remove(0, 1).Remove(3));
                GetTrainerClassInfo(trainerClassId);
            }
        }

        #endregion Trainer Class Editor

        #region Trainer Editor

        private void SetupTrainerEditor()
        {
            trainers_Player_list.Items.Clear();
            trainers_list.Items.Clear();
            GetData();
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
            if (selectedTrainer != default)
            {
                trainers_list.SelectedIndex = selectedTrainer.TrainerId - 1;
            }
        }

        private void trainer_Class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTrainer.TrainerClassId = trainer_Class_comboBox.SelectedIndex + 2;
            selectedTrainer.TrainerSpriteFrames = LoadTrainerClassPic(selectedTrainer.TrainerClassId);
            UpdateTrainerClassPic(trainerPicBox);
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
                DirNames.speciesData,
                DirNames.trainerTable
            });

            SetTrainerTable();
            try
            {
                ReadTrainerTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion Unpack NARCs

        #region Get

        private void GetData()
        {
            GetTrainers();
            GetTrainerClasses();
            GetMessageTriggers();
            GetTrainerMessages();
        }

        private MessageTrigger GetMessageTriggerDetails(MessageTriggerEnum messageTrigger)
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
                MessageBox.Show("There can't be more than 256 trainer classes! [Found " + classNames.Length + "].\nAborting.",
                    "Too many trainer classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < classNames.Length; i++)
            {
                var item = new TrainerClass
                {
                    TrainerClassId = i,
                    TrainerClassName = classNames[i],
                    UsedByTrainers = new List<Trainer>(),
                    TrainerSpriteFrames = 0
                };
                item.UsedByTrainers.AddRange(trainers.Where(x => x.TrainerClassId == item.TrainerClassId));
                trainerClasses.Add(item);
            }
        }

        /// <summary>
        /// Get Trainer Class Info for given trainerClassId.
        /// </summary>
        /// <param name="trainerClassId"></param>
        private void GetTrainerClassInfo(int trainerClassId)
        {
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
            TrainerClass_CheckSaveAllButton(false, false);
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
            selectedTrainer.TrainerMessages = trainerMessages.Where(x => x.TrainerId == selectedTrainer.TrainerId).OrderBy(x => x.MessageTriggerId).ToList();
            selectedTrainer.TrainerSpriteFrames = LoadTrainerClassPic(selectedTrainer.TrainerClassId);

            //Setup Trainer Name
            trainer_Name.Text = selectedTrainer.TrainerName;

            //Setup Trainer Class

            foreach (var item in trainerClasses.Where(x => !x.IsPlayerClass))
            {
                trainer_Class_comboBox.Items.Add($"[{item.DisplayTrainerClassId}] - {item.TrainerClassName}");
            }

            if (trainer_Class_comboBox.Items.Count > 0)
            {
                trainer_Class_comboBox.Enabled = true;
                trainer_Class_comboBox.SelectedIndex = selectedTrainer.TrainerClassId - 2;
            }

            //Setup Trainer Class Pic
            UpdateTrainerClassPic(trainerPicBox);

            //Setup Trainer Messages
            displayTrainerMessage = Array.Empty<string>();

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
        }

        private void GetTrainerMessages()
        {
            trainerMessages = new List<TrainerMessage>();
            statusLabelMessage("Getting Trainers Messages...");
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

            //if (classNames.Length > byte.MaxValue + 1)
            //{
            //    MessageBox.Show("There can't be more than 256 trainer classes! [Found " + classNames.Length + "].\nAborting.",
            //        "Too many trainer classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            for (int i = 0; i < trainerNames.Length; i++)
            {
                string suffix = "\\" + i.ToString("D4");
                var trainerProperties = new TrainerProperties((ushort)i, new FileStream(gameDirs[DirNames.trainerProperties].unpackedDir + suffix, FileMode.Open));
                var item = new Trainer
                {
                    TrainerId = i,
                    TrainerName = trainerNames[i],
                    TrainerClassId = trainerProperties.trainerClass
                };

                trainers.Add(item);
            }
        }

        #endregion Get

        #region TrainerSprite

        private int LoadTrainerClassPic(int trainerClassId)
        {
            int paletteFileID = (trainerClassId * 5 + 1);
            string paletteFilename = paletteFileID.ToString("D4");
            trainerPal = new NCLR(gameDirs[DirNames.trainerGraphics].unpackedDir + "\\" + paletteFilename, paletteFileID, paletteFilename);

            int tilesFileID = trainerClassId * 5;
            string tilesFilename = tilesFileID.ToString("D4");
            trainerTile = new NCGR(gameDirs[DirNames.trainerGraphics].unpackedDir + "\\" + tilesFilename, tilesFileID, tilesFilename);

            if (gameFamily == gFamEnum.DP)
            {
                return 0;
            }

            int spriteFileID = (trainerClassId * 5 + 2);
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
            Image trSprite = trainerSprite.Get_Image(trainerTile, trainerPal, frameNumber, trainerClassPicBox.Width, trainerClassPicBox.Height, false, false, false, true, true, -1, OAMenabled);
            pb.Image = trSprite;
            pb.Update();
        }

        #endregion TrainerSprite

        private void EnablePokemon()
        {
            //switch (trainer_NumPoke_num.Value)
            //{
            //    case 1:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = false;
            //        trainer_Pokemon3_panel.Enabled = false;
            //        trainer_Pokemon4_panel.Enabled = false;
            //        trainer_Pokemon5_panel.Enabled = false;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;

            //    case 2:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = true;
            //        trainer_Pokemon3_panel.Enabled = false;
            //        trainer_Pokemon4_panel.Enabled = false;
            //        trainer_Pokemon5_panel.Enabled = false;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;

            //    case 3:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = true;
            //        trainer_Pokemon3_panel.Enabled = true;
            //        trainer_Pokemon4_panel.Enabled = false;
            //        trainer_Pokemon5_panel.Enabled = false;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;

            //    case 4:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = true;
            //        trainer_Pokemon3_panel.Enabled = true;
            //        trainer_Pokemon4_panel.Enabled = true;
            //        trainer_Pokemon5_panel.Enabled = false;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;

            //    case 5:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = true;
            //        trainer_Pokemon3_panel.Enabled = true;
            //        trainer_Pokemon4_panel.Enabled = true;
            //        trainer_Pokemon5_panel.Enabled = true;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;

            //    case 6:
            //        trainer_Pokemon1_panel.Enabled = true;
            //        trainer_Pokemon2_panel.Enabled = true;
            //        trainer_Pokemon3_panel.Enabled = true;
            //        trainer_Pokemon4_panel.Enabled = true;
            //        trainer_Pokemon5_panel.Enabled = true;
            //        trainer_Pokemon6_panel.Enabled = true;
            //        break;

            //    default:
            //        trainer_Pokemon1_panel.Enabled = false;
            //        trainer_Pokemon2_panel.Enabled = false;
            //        trainer_Pokemon3_panel.Enabled = false;
            //        trainer_Pokemon4_panel.Enabled = false;
            //        trainer_Pokemon5_panel.Enabled = false;
            //        trainer_Pokemon6_panel.Enabled = false;
            //        break;
            //}
        }

        private void OpenPokemonEditor(int pokemonId)
        {
            pokemonEditor = new PokemonEditor();
            pokemonEditor.Show();
        }

        private void OpenTextEditor(int trainerMessageId, string messageText)
        {
            textEditor = new TextEditor(trainerMessageId, messageText);
            textEditor.Show();
        }

        private void SetupPokemonTab()
        {
            EnablePokemon();
        }

        private void SetupTrainerTextTab()
        {
            if (trainerTextTable_dataGrid.RowCount == 0)
            {
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
                    trainerTextTable_dataGrid.Rows.Add(i, null, null, trainerMessages[i].MessageText);

                    DataGridViewComboBoxCell trainerCell =
    (DataGridViewComboBoxCell)(trainerTextTable_dataGrid.Rows[i].Cells[1]);
                    trainerCell.DataSource = currentTrainers;
                    trainerCell.Value = trainerCell.Items[trainerIndex];

                    DataGridViewComboBoxCell triggerCell =
   (DataGridViewComboBoxCell)(trainerTextTable_dataGrid.Rows[i].Cells[2]);
                    triggerCell.DataSource = currentMessageTriggers;
                    triggerCell.Value = triggerCell.Items[messageTriggerIndex];
                }
            }
        }

        private void trainer_Double_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trainer_Double_checkBox.Checked)
            {
                trainer_NumPoke_num.Maximum = 3;
                if (trainer_NumPoke_num.Value > 3)
                {
                    trainer_NumPoke_num.Value = 3;
                }
            }
            else
            {
                trainer_NumPoke_num.Maximum = 6;
            }
            EnablePokemon();
        }

        private void trainer_GoToClass_btn_Click(object sender, EventArgs e)
        {
            int index = trainer_Class_comboBox.SelectedIndex;
            var text = trainer_Class_comboBox.Items[index].ToString();
            int id = int.Parse(text.Remove(0, 1).Remove(3));
            mainContent.SelectedTab = mainContent_trainerClass;
            SetupTrainerClassEditor();
            if (id > 1)
            {
                trainerClassListBox.SelectedIndex = id - 2;
            }
            GetTrainerClassInfo(id);
        }

        private void trainer_Message_TextChanged(object sender, EventArgs e)
        {
        }

        private void trainer_MessageTrigger_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainer_MessageTrigger_list.SelectedIndex > -1)
            {
                trainer_EditMessage_btn.Enabled = true;
                const string seperator1 = @"\r";
                const string seperator2 = @"\f";
                string selectedMessageTriggerName = trainer_MessageTrigger_list.SelectedItem.ToString();
                int messageTriggerId = messageTriggers.Find(x => x.MessageTriggerName == selectedMessageTriggerName).MessageTriggerId;
                string trainerText = selectedTrainer.TrainerMessages.Single(x => x.MessageTriggerId == messageTriggerId).MessageText;

                trainerText = trainerText.Replace("\\n", Environment.NewLine);
                displayTrainerMessage = trainerText.Split(new string[] { seperator1, seperator2 }, StringSplitOptions.None);
                trainer_Message.Font = new Font(Fonts.Families[0], trainer_Message.Font.Size);
                trainer_Message.Text = displayTrainerMessage[0];
            }
            else
            {
                trainer_EditMessage_btn.Enabled = false;
                trainer_MessageTrigger_list.Enabled = false;
            }
        }

        private void trainer_NumPoke_num_ValueChanged(object sender, EventArgs e)
        {
            EnablePokemon();
        }

        private void trainerClassName_TextChanged(object sender, EventArgs e)
        {
            bool enableSave = selectedTrainerClass.TrainerClassName != trainerClassName.Text && !string.IsNullOrEmpty(trainerClassName.Text);
            saveClassName_btn.Enabled = enableSave;
            TrainerClass_CheckSaveAllButton(enableSave, true);
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
            var text = trainers_list.Items[index].ToString();
            int trainerId = int.Parse(text.Remove(0, 1).Remove(3));
            trainer_MessageTrigger_list.SelectedIndex = -1;
            GetTrainerInfo(trainerId);
        }

        private void trainerTextTable_dataGrid_TextDblClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int trainerMessageId = e.RowIndex;
                string messageText = trainerMessages.Find(x => x.MessageId == trainerMessageId).MessageText;
                OpenTextEditor(trainerMessageId, messageText);
            }
        }

        private void mainContent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (unsavedChanges)
            {
                var choice = MessageBox.Show("You have unsaved changes.\nDo you wish to discard these changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    unsavedChanges = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}