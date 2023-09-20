using VSMaker;
using VSMaker.ROMFiles;
using System.Text;
using static VSMaker.RomInfo;

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

    public static void UpdateCurrentTrainerClassName(string newName, int index)
    {
        TextArchive trainerClassNames = new(trainerClassMessageNumber);
        trainerClassNames.Messages[index] = newName;
        trainerClassNames.SaveToFileDefaultDir(trainerClassMessageNumber, showSuccessMessage: false);
    }
}