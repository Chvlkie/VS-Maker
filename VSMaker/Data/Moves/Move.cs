using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public class Move
    {
        public int MoveId { get; set; }
        public string MoveInfo { get; set; }
        public string DisplayMoveInfo => MoveInfo.Replace("\\n", " ");
        public string MoveName { get; set; }
    }
}
