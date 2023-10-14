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
        public const string Id_1107 = "1107";
        public const string Id_1108 = "1108";
        public const string Id_1109 = "1109";
        public const string Id_1110 = "1110";
        public const string Id_1111 = "1111";
        public const string Id_1112 = "1112";
        public const string Id_1113 = "1113";
        public const string Id_1114 = "1114";
        public const string Id_1115 = "1115";

        public static string GetNameFromId(uint musicId)
        {
            switch (musicId)
            {
                case 1107:
                    return Id_1107;
                case 1108:
                    return Id_1108;
                case 1109:
                    return Id_1109;
                case 1110:
                    return Id_1110;
                case 1111:
                    return Id_1111;
                case 1112:
                    return Id_1112;
                case 1113:
                    return Id_1113;
                case 1114:
                    return Id_1114;
                case 1115:
                    return Id_1115;
                default:
                    return musicId.ToString();
            }
        }

        public static ushort GetIdFromName(string name)
        {
            switch (name)
            {
                case Id_1107:
                    return 1107;
                case Id_1108:
                    return 1108;
                case Id_1109:
                    return 1109;
                case Id_1110:
                    return 1110;
                case Id_1111:
                    return 1111;
                case Id_1112:
                    return 1112;
                case Id_1113:
                    return 1113;
                case Id_1114:
                    return 1114;
                case Id_1115:
                    return 1115;
                default:
                    return 0;
            }
        }
    }
}
