using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMaker.CommonFunctions;

namespace VSMaker.Data
{
    public class Move
    {
        public int MoveId { get; set; }
        public string MoveInfo { get; set; }
        public string DisplayMoveInfo => MoveInfo.Replace("\\n", " ");
        public string MoveName { get; set; }

        public ushort PP { get; set; }
        public ushort Power { get; set; }
        public ushort Accuracy { get; set; }
        public ushort Category { get; set; }
        public string DisplayCategory => MoveCategory.GetDescriptionById(Category);
        public ushort Type { get; set; }
        public string DisplayType => RomInfo.GetTypeNames()[Type];
    }
}
