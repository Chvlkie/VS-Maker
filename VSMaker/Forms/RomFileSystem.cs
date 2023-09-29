using VSMaker.ROMFiles;
using System.Text;
using static VSMaker.CommonFunctions.RomInfo;
using VSMaker.CommonFunctions;

internal static class RomFileSystem
{
    public static byte europeByte;
    public static string gameCode;

    public static void SetupROMLanguage(string headerPath)
    {
        using DSUtils.EasyReader br = new(headerPath, 0xC);
        gameCode = Encoding.UTF8.GetString(br.ReadBytes(4));
        br.BaseStream.Position = 0x1E;
        europeByte = br.ReadByte();
    }

    public static void UpdateCurrentTrainerClassName(string newName, int trainerId)
    {
        TextArchive trainerClassNames = new TextArchive(RomInfo.trainerClassMessageNumber);
        trainerClassNames.Messages[trainerId] = newName;
        trainerClassNames.SaveToFileDefaultDir(RomInfo.trainerClassMessageNumber, showSuccessMessage: false);
    }
}