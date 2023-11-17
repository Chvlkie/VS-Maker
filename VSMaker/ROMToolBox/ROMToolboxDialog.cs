using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Resources;
using VSMaker.CommonFunctions;
using VSMaker.Resources;
using VSMaker.Resources.ROMToolboxDB;
using VSMaker.ROMFiles;
using static VSMaker.CommonFunctions.RomInfo;
using static VSMaker.Resources.ROMToolboxDB.ToolboxDB;

namespace VSMaker
{
    public partial class ROMToolboxDialog : Form
    {
        public static uint expandedARMfileID = ToolboxDB.syntheticOverlayFileNumbersDB[RomInfo.gameFamily];
        public static bool flag_arm9Expanded { get; private set; } = false;
        public static bool flag_MainComboTableRepointed { get; set; } = false;
        public static bool flag_TrainerClassBattleTableRepointed { get; set; } = false;
        public static bool flag_PokemonBattleTableRepointed { get; set; } = false;
        public static bool flag_TrainerNamesExpanded { get; set; } = false;
        public static bool overlay1MustBeRestoredFromBackup { get; private set; } = true;
        public static int expandedTrainerNameLength = 12;

        #region Constructor
        public ROMToolboxDialog()
        {
            InitializeComponent();

            if (RomInfo.gameLanguage == gLangEnum.English || RomInfo.gameLanguage == gLangEnum.Spanish)
            {
                CheckARM9ExpansionApplied();
                CheckExpandedTrainerNamespatchApplied();
            }
        }

        #endregion

        #region Patch 
        private static bool CheckFilesArm9ExpansionApplied()
        {
            ARM9PatchData data = new ARM9PatchData();

            byte[] branchCode = DSUtils.HexStringToByteArray(data.branchString);
            byte[] branchCodeRead = DSUtils.ARM9.ReadBytes(data.branchOffset, data.branchString.Length / 3 + 1); //Read branchCode
            if (branchCodeRead.Length != branchCode.Length || !branchCodeRead.SequenceEqual(branchCode))
                return false;

            byte[] initCode = DSUtils.HexStringToByteArray(data.initString);
            byte[] initCodeRead = DSUtils.ARM9.ReadBytes(data.initOffset, data.initString.Length / 3 + 1); //Read initCode
            if (initCodeRead.Length != initCode.Length || !initCodeRead.SequenceEqual(initCode))
                return false;

            return true;
        }
        public string backupSuffix = ".backup";
        private bool CheckARM9ExpansionApplied()
        {
            if (!ROMToolboxDialog.flag_arm9Expanded)
            {
                if (!ROMToolboxDialog.CheckFilesArm9ExpansionApplied())
                {
                    return false;
                }
            }

            ROMToolboxDialog.flag_arm9Expanded = true;

            return true;
        }

        public void CheckExpandedTrainerNamespatchApplied()
        {
            if (!flag_TrainerNamesExpanded)
            {
                uint position = 0x6AC32;
                switch (RomInfo.gameFamily)
                {
                    case gFamEnum.DP:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English)) position = 0x6AC32;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x6AC8E;
                        break;
                    case gFamEnum.Plat:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English)) position = 0x791DE;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x7927E;
                        break;
                    case gFamEnum.HGSS:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English) || RomInfo.gameVersion.Equals(gVerEnum.SoulSilver)) position = 0x7342E;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x73426;
                        break;
                }
                byte initValue = DSUtils.ARM9.ReadByte(position);
                if (initValue > (byte)TrainerFile.maxNameLen + 1)
                {
                    ROMToolboxDialog.flag_TrainerNamesExpanded = true;
                    ROMToolboxDialog.expandedTrainerNameLength = initValue -1;
                }
            }
        }
        #endregion

        #region Button Actions

        private void ApplyARM9ExpansionButton_Click(object sender, EventArgs e)
        {
            ARM9PatchData data = new ARM9PatchData();

            DialogResult d = MessageBox.Show("Confirming this process will apply the following changes:\n\n" +
                "- Backup ARM9 file (arm9.bin" + backupSuffix + " will be created)." + "\n\n" +
                "- Replace " + (data.branchString.Length / 3 + 1) + " bytes of data at arm9 offset 0x" + data.branchOffset.ToString("X") + " with " + '\n' + data.branchString + "\n\n" +
                "- Replace " + (data.initString.Length / 3 + 1) + " bytes of data at arm9 offset 0x" + data.initOffset.ToString("X") + " with " + '\n' + data.initString + "\n\n" +
                "- Modify file #" + expandedARMfileID + " inside " + '\n' + RomInfo.gameDirs[DirNames.synthOverlay].unpackedDir + '\n' + " to accommodate for 88KB of data (no backup)." + "\n\n" +
                "Do you wish to continue?",
                "Confirm to proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                File.Copy(RomInfo.arm9Path, RomInfo.arm9Path + backupSuffix, overwrite: true);

                try
                {
                    DSUtils.ARM9.WriteBytes(DSUtils.HexStringToByteArray(data.branchString), data.branchOffset); //Write new branchOffset
                    DSUtils.ARM9.WriteBytes(DSUtils.HexStringToByteArray(data.initString), data.initOffset); //Write new initOffset

                    string fullFilePath = RomInfo.gameDirs[DirNames.synthOverlay].unpackedDir + '\\' + expandedARMfileID.ToString("D4");
                    File.Delete(fullFilePath);
                    using (BinaryWriter f = new BinaryWriter(File.Create(fullFilePath)))
                    {
                        for (int i = 0; i < 0x16000; i++)
                            f.Write((byte)0x00); // Write Expanded ARM9 File 
                    }

                    ROMToolboxDialog.flag_arm9Expanded = true;

                    MessageBox.Show("The ARM9's usable memory has been expanded.", "Operation successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Operation failed. It is strongly advised that you restore the arm9 backup (arm9.bin" + backupSuffix + ").", "Something went wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes have been made.", "Operation canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExpandTrainerNames()
        {
            // Pearl        USA     ARM9 at 0x6AC32     // TODO: Verify
            // Pearl        Spain   ARM9 at 0x6AC8E     // TODO: Verify
            // Diamond      USA     ARM9 at 0x6AC32
            // Diamond      Spain   ARM9 at 0x6AC8E
            // Platinum     USA     ARM9 at 0x791DE
            // Platinum     Spain   ARM9 at 0x7927E
            // HeartGold    USA     ARM9 at 0x7342E
            // HeartGold    Spain   ARM9 at 0x73426
            // SoulSilver   USA     ARM9 at 0x7342E
            // SoulSilver   Spain   ARM9 at 0x7342E     // TODO: Verify
            DialogResult d;
            int position = 0x7342E;
            bool gameFamGood = true;
            d = MessageBox.Show($"Applying this patch will set the Trainer Name max length to {ROMToolboxDialog.expandedTrainerNameLength}.\n" +
                "Please note that if you have modified the ARM9 these offsets may be wrong.\n" +
                "If you have done so we encourage you to seek in your ARM9 for where to make the modification as your offset might change.\n\n" +
                "Are you sure you want to proceed?",
                "Confirm to proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                switch (RomInfo.gameFamily)
                {
                    case gFamEnum.DP:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English)) position = 0x6AC32;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x6AC8E;
                        else gameFamGood = false;
                        break;
                    case gFamEnum.Plat:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English)) position = 0x791DE;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x7927E;
                        else gameFamGood = false;
                        break;
                    case gFamEnum.HGSS:
                        if (RomInfo.gameLanguage.Equals(gLangEnum.English) || RomInfo.gameVersion.Equals(gVerEnum.SoulSilver)) position = 0x7342E;
                        else if (RomInfo.gameLanguage.Equals(gLangEnum.Spanish)) position = 0x73426;
                        else gameFamGood = false;
                        break;
                }
                if (gameFamGood)
                {
                    using (DSUtils.ARM9.Writer wr = new DSUtils.ARM9.Writer())
                    {
                        wr.BaseStream.Position = position;
                        wr.Write((byte)(expandedTrainerNameLength+1));
                    }
                    ROMToolboxDialog.flag_TrainerNamesExpanded = true;
                    MessageBox.Show("Trainer Names have been expanded.", "Operation successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry this game language does not have a recorded offset for this patch.\n\n" +
                        "Reach out in our discord if you want to help researching it!",
                        "Operation canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No changes have been made.", "Operation canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}