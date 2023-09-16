using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Data
{
    public class TrainerClass
    {
        public int TrainerClassId { get; set; }
        public string DisplayTrainerClassId => TrainerClassId.ToString("D3");
        public string? TrainerClassName { get; set; }
        public bool IsPlayerClass => TrainerClassId == 1 || TrainerClassId == 2;
        public List<Trainer> UsedByTrainers { get; set; }
        public bool InUse => UsedByTrainers.Count > 0;
        public int TrainerSpriteFrames { get; set; }
    }
}
