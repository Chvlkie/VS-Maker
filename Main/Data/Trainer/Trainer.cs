using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Data
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public int TrainerClassId { get; set; }
        public string DisplayTrainerId => TrainerId.ToString("D3");
        public string DisplayTrainerClassId => TrainerClassId.ToString("D3");
        public string? TrainerName { get; set; }
        public string? TrainerClassName { get; set; }
        public bool IsDouble;
        public bool IsPlayerTrainer => TrainerId == 1;
        public int TrainerSpriteFrames { get; set; }
    }
}
