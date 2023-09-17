using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Data
{
    public class TrainerClass
    {
        #region TrainerClassInfo
        public int TrainerClassId { get; set; }
        public string DisplayTrainerClassId => TrainerClassId.ToString("D3");
        public string TrainerClassName { get; set; }
        public int TrainerSpriteFrames { get; set; }
        public bool IsPlayerClass => TrainerClassId == 0 || TrainerClassId == 1;

        #endregion TrainerClassInfo

        #region TrainerClassMusic
        public int EyeContactMusic { get; set; }
        public int EyeContactAltMusic { get; set; }
        public int TrainerClassThemeId { get; set; }
        public int VsIntroId { get; set; }
        public int BattleMusic { get; set; }
        public string DisplayBattleMusic => BattleMusic.ToString("D4");
        #endregion TrainerClassMusic

        #region TrainerClassPrizeMoney
        public int PrizeMoney { get; set; }
        #endregion TrainerClassPrizeMoney

        #region TrainerClassUsedBy
        public List<Trainer> UsedByTrainers { get; set; }
        public bool InUse => UsedByTrainers.Count > 0;
        #endregion TrainerClassUsedBy
    }
}
