using Main.Data.TrainerClass;
using Main.ROMFiles;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Text;
using static Main.RomInfo;

namespace Main
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        /* ROM Information */
        public static string gameCode;
        public static byte europeByte;
        private RomInfo romInfo;
        public Dictionary<ushort, ushort> eventToHeader = new Dictionary<ushort, ushort>();

        private bool disableHandlers = false;
        private void openRom_toolstrip_Click(object sender, EventArgs e)
        {
            OpenRom();
        }

        private void openRom_btn_Click(object sender, EventArgs e)
        {
            OpenRom();
        }

        private static void SetupROMLanguage(string headerPath)
        {
            using DSUtils.EasyReader br = new(headerPath, 0xC);
            gameCode = Encoding.UTF8.GetString(br.ReadBytes(4));
            br.BaseStream.Position = 0x1E;
            europeByte = br.ReadByte();
        }

        private void CheckROMLanguage()
        {
            versionLabel.Visible = true;
            languageLabel.Visible = true;

            versionLabel.Text = gameVersion.ToString() + " " + "[" + romID + "]";
            languageLabel.Text = "Lang: " + RomInfo.gameLanguage;

            if (gameLanguage == gLangEnum.English)
            {
                if (europeByte == 0x0A)
                {
                    languageLabel.Text += " [Europe]";
                }
                else
                {
                    languageLabel.Text += " [America]";
                }
            }
        }

        private int UnpackRomCheckUserChoice()
        {
            // Check if extracted data for the ROM exists, and ask user if they want to load it.
            // Returns true if user aborted the process
            if (Directory.Exists(RomInfo.workDir))
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

        private bool UnpackRom(string ndsFileName)
        {
            statusLabelMessage("Unpacking ROM contents to " + RomInfo.workDir + " ...");
            Update();

            Directory.CreateDirectory(RomInfo.workDir);
            Process unpack = new Process();
            unpack.StartInfo.FileName = @"Tools\ndstool.exe";
            unpack.StartInfo.Arguments = "-x " + '"' + ndsFileName + '"'
                + " -9 " + '"' + RomInfo.arm9Path + '"'
                + " -7 " + '"' + RomInfo.workDir + "arm7.bin" + '"'
                + " -y9 " + '"' + RomInfo.workDir + "y9.bin" + '"'
                + " -y7 " + '"' + RomInfo.workDir + "y7.bin" + '"'
                + " -d " + '"' + RomInfo.workDir + "data" + '"'
                + " -y " + '"' + RomInfo.workDir + "overlay" + '"'
                + " -t " + '"' + RomInfo.workDir + "banner.bin" + '"'
                + " -h " + '"' + RomInfo.workDir + "header.bin" + '"';
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

        private void ReadROMInitData()
        {
            if (DSUtils.ARM9.CheckCompressionMark())
            {
                if (!RomInfo.gameFamily.Equals(gFamEnum.HGSS))
                {
                    MessageBox.Show("Unexpected compressed ARM9. It is advised that you double check the ARM9.");
                }
                if (!DSUtils.ARM9.Decompress(RomInfo.arm9Path))
                {
                    MessageBox.Show("ARM9 decompression failed. The program can't proceed.\nAborting.",
                                "Error with ARM9 decompression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            /* Setup essential editors */
            SetupHeaderEditor();

            //mainTabControl.Show();
            openRom_toolstrip.Enabled = false;
            openFolder_toolstrip.Enabled = false;
            openRom_btn.Enabled = false;
            openFolder_btn.Enabled = false;
            save_toolstrip.Enabled = true;
            export_toolstrip.Enabled = true;
            save_btn.Enabled = true;
            exportNarc_btn.Enabled = true;
            mainContent.Enabled = true;
            mainContent.Visible = true;

            statusLabelMessage();
            this.Text += "  -  " + RomInfo.fileName;
        }

        private void SetupHeaderEditor()
        {
            /* Extract essential NARCs sub-archives*/

            statusLabelMessage("Attempting to unpack Header Editor NARCs... Please wait.");
            Update();

            DSUtils.TryUnpackNarcs(new List<DirNames> { DirNames.synthOverlay, DirNames.textArchives, DirNames.dynamicHeaders });

            statusLabelMessage("Reading internal names... Please wait.");
            Update();
        }

        private void OpenRom()
        {
            OpenFileDialog openRom = new OpenFileDialog
            {
                Filter = DSUtils.NDSRomFilter
            }; // Select ROM
            if (openRom.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            SetupROMLanguage(openRom.FileName);
            /* Set ROM gameVersion and language */
            romInfo = new RomInfo(gameCode, openRom.FileName, useSuffix: true);

            if (string.IsNullOrWhiteSpace(RomInfo.romID) || string.IsNullOrWhiteSpace(RomInfo.fileName))
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
                            Directory.Delete(RomInfo.workDir, true);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Concurrent access detected: \n" + RomInfo.workDir +
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
                        MessageBox.Show("Can't access temp directory: \n" + RomInfo.workDir + "\nThis might be a temporary issue.\nMake sure no other process is using it and try again.", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        statusLabelError("ERROR: Concurrent access to " + RomInfo.workDir);
                        Update();
                        return;
                    }
                    break;
            }
            statusLabelMessage("Attempting to unpack NARCs from folder...");
            Update();
            ReadROMInitData();
            // Setup data for initial trainer class tab.
            SetupTrainerClass();
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
                SetupROMLanguage(Directory.GetFiles(romFolder.FileName).First(x => x.Contains("header.bin")));
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("This folder does not seem to contain any data from a NDS Pokémon ROM.", "No ROM Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /* Set ROM gameVersion and language */
            romInfo = new RomInfo(gameCode, romFolder.FileName, useSuffix: false);

            if (string.IsNullOrWhiteSpace(RomInfo.romID) || string.IsNullOrWhiteSpace(RomInfo.fileName))
            {
                return;
            }

            CheckROMLanguage();
            ReadROMInitData();
            // Setup data for initial trainer class tab.
            SetupTrainerClass();
        }

        private void statusLabelMessage(string msg = "Ready")
        {
            statusLabel.Text = msg;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Regular);
            statusLabel.ForeColor = Color.Black;
            statusLabel.Invalidate();
        }

        private void statusLabelError(string errorMsg, bool severe = true)
        {
            statusLabel.Text = errorMsg;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
            statusLabel.ForeColor = severe ? Color.Red : Color.DarkOrange;
            statusLabel.Invalidate();
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
            }
        }

        private void mainContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainContent.SelectedTab == mainContent_trainerClass)
            {
                SetupTrainerClass();
            }
        }

        private void SetupTrainerClass()
        {
            disableHandlers = true;
            trainerClassName.Text = string.Empty;
            trainerClassIdDisplay.Text = string.Empty;
            trainerClassName.ReadOnly = true;
            saveClassName_btn.Enabled = false;
            /* Extract essential NARCs sub-archives*/
            statusLabelMessage("Setting up Trainer Editor...");
            Update();

            DSUtils.TryUnpackNarcs(new List<DirNames> {
                DirNames.trainerProperties,
                DirNames.trainerParty,
                DirNames.trainerGraphics,
                DirNames.textArchives,
                DirNames.monIcons,
                DirNames.speciesData
            });

            string[] classNames = RomInfo.GetTrainerClassNames();
            player_trainer_class.Items.Clear();
            trainerClassListBox.Items.Clear();
            if (classNames.Length > byte.MaxValue + 1)
            {
                MessageBox.Show("There can't be more than 256 trainer classes! [Found " + classNames.Length + "].\nAborting.",
                    "Too many trainer classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < classNames.Length; i++)
            {
                string id = string.Format("[{0}]", (i + 1).ToString("D3"));
                if (i < 2)
                {
                    player_trainer_class.Items.Add($"{id} {classNames[i]}");
                }
                else
                {
                    trainerClassListBox.Items.Add($"{id} {classNames[i]}");
                }
            }
            disableHandlers = false;
            statusLabelMessage();
        }

        private void playerClass_help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These Trainer Classes are \"Player Classes\".\n\nChanging these can cause errors.", "Player Classes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainerClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trainerClassListBox.SelectedIndex + 2;
            GetTrainerClassInfo(index);
        }

        private void saveClassName_btn_Click(object sender, EventArgs e)
        {
            int index = trainerClassListBox.SelectedIndex + 2;
            int id = index + 1;
            if (trainerClassName.Text.Length > TrainerFile.maxClassNameLen)
            {
                MessageBox.Show($"Trainer Class name cannot exceed {TrainerFile.maxClassNameLen} characters.", "Trainer Class Name Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GetSingleTrainerClassName(index) != trainerClassName.Text)
            {
                string newName = trainerClassName.Text;
                UpdateCurrentTrainerClassName(newName, index);
                MessageBox.Show("Trainer Class name updated!", "Success!");
                SetupTrainerClass();
                trainerClassListBox.SelectedIndex = index - 2;
                GetTrainerClassInfo(index);
            }
        }

        private static void UpdateCurrentTrainerClassName(string newName, int index)
        {
            TextArchive trainerClassNames = new(trainerClassMessageNumber);
            trainerClassNames.messages[index] = newName;
            trainerClassNames.SaveToFileDefaultDir(trainerClassMessageNumber, showSuccessMessage: false);
        }

        private void GetTrainerClassInfo(int index)
        {
            var trainerClass = new TrainerClass
            {
                TrainerClassId = index + 1,
                TrainerClassName = GetSingleTrainerClassName(index)
            };

            trainerClassName.Text = trainerClass.TrainerClassName;
            trainerClassIdDisplay.Text = trainerClass.TrainerClassId.ToString("D3");
            trainerClassName.ReadOnly = false;
            saveClassName_btn.Enabled = true;


        }

        private void GetTrainersUsingClass(int  index)
        {

        }
    }
}