using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public class EyeContactMusic
    {
        public uint MusicId { get; set; }
        public string DisplayMusicId => MusicId.ToString();

        public string Name => EyeMusicIdNames.GetNameFromId(MusicId);
    }

    public static class EyeMusicIdNames
    {
        public const string Id_1100 = "1100";
        public const string Id_1101 = "1101";
        public const string Id_1102 = "1102";
        public const string Id_1103 = "1103";
        public const string Id_1104 = "1104";
        public const string Id_1105 = "1105";
        public const string Id_1106 = "1106";
        public const string Id_1107 = "1107";
        public const string Id_1108 = "1108";
        public const string Id_1109 = "1109";
        public const string Id_1110 = "1110";
        public const string Id_1111 = "1111";
        public const string Id_1112 = "1112";
        public const string Id_1113 = "1113";
        public const string Id_1114 = "1114";
        public const string Id_1115 = "1115";
        public const string NoEntry = "-----";

        public static string GetNameFromId(uint musicId)
        {
            return musicId switch
            {
                1100 => Id_1100,
                1101 => Id_1101,
                1102 => Id_1102,
                1103 => Id_1103,
                1104 => Id_1104,
                1105 => Id_1105,
                1106 => Id_1106,
                1107 => Id_1107,
                1108 => Id_1108,
                1109 => Id_1109,
                1110 => Id_1110,
                1111 => Id_1111,
                1112 => Id_1112,
                1113 => Id_1113,
                1114 => Id_1114,
                1115 => Id_1115,
                _ => NoEntry,
            };
        }

        public static ushort GetIdFromName(string name)
        {
            return name switch
            {
                Id_1100 => 1100,
                Id_1101 => 1101,
                Id_1102 => 1102,
                Id_1103 => 1103,
                Id_1104 => 1104,
                Id_1105 => 1105,
                Id_1106 => 1106,
                Id_1107 => 1107,
                Id_1108 => 1108,
                Id_1109 => 1109,
                Id_1110 => 1110,
                Id_1111 => 1111,
                Id_1112 => 1112,
                Id_1113 => 1113,
                Id_1114 => 1114,
                Id_1115 => 1115,
                _ => 0,
            };
        }
    }
}
