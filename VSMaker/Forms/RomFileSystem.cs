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

    public static void UpdateCurrentTrainerClassName(string newName, int trainerClassId)
    {
        TextArchive trainerClassNames = new TextArchive(RomInfo.trainerClassMessageNumber);
        trainerClassNames.Messages[trainerClassId] = newName;
        trainerClassNames.SaveToFileDefaultDir(RomInfo.trainerClassMessageNumber, showSuccessMessage: false);
    }
    public static void UpdateCurrentTrainerName(string newName, int trainerId)
    {
        TextArchive trainerNames = new TextArchive(RomInfo.trainerNamesMessageNumber);
        trainerNames.Messages[trainerId] = newName;
        trainerNames.SaveToFileDefaultDir(RomInfo.trainerNamesMessageNumber, showSuccessMessage: false);
    }
    public static void UpdateTrainerTextMessages(string newMessage, int messageId)
    {
        TextArchive trainerMessages = new TextArchive(RomInfo.trainerTextMessageNumber);
        trainerMessages.Messages[messageId] = newMessage;
        trainerMessages.SaveToFileDefaultDir(RomInfo.trainerTextMessageNumber, showSuccessMessage: false);
    }

}