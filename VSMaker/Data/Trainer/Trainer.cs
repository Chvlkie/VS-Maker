namespace VSMaker.Data
{
    public class Trainer
    {
        #region TrainerInfo

        public string TrainerName { get; set; }
        public int TrainerId { get; set; }
        public int TrainerClassId { get; set; }
        public string DisplayTrainerId => TrainerId.ToString("D3");
        public bool IsPlayerTrainer => TrainerId == 0;
        public int TrainerSpriteFrames { get; set; }

        #endregion TrainerInfo

        #region TrainerProperties

        public bool IsDouble;
        public bool TrainerFlag1 { get; set; }
        public bool TrainerFlag2 { get; set; }
        public bool TrainerFlag3 { get; set; }
        public bool TrainerFlag4 { get; set; }
        public bool TrainerFlag5 { get; set; }
        public bool TrainerFlag6 { get; set; }

        #endregion TrainerProperties

        #region Pokemon

        public List<Pokemon> Pokemon { get; set; }
        public int TeamSize { get; set; }

        #endregion Pokemon

        #region Messages

        public List<TrainerMessage> TrainerMessages { get; set; }

        #endregion Messages
    }
}