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

        public AI AI = new();

        public int TrainerItem1Id { get; set; }
        public int TrainerItem2Id { get; set; }
        public int TrainerItem3Id { get; set; }
        public int TrainerItem4Id { get; set; }

        public bool HeldItems { get; set; }
        public bool ChooseMoves { get; set; }
        #endregion TrainerProperties

        #region Pokemon

        public List<Pokemon> Pokemon { get; set; }
        public int TeamSize { get; set; }

        #endregion Pokemon

        #region Messages

        public List<TrainerMessage> TrainerMessages { get; set; }

        #endregion Messages
    }

    public class AI
    {
        public bool Basic { get; set; }
        public bool BatonPass { get; set; }
        public bool CheckHp { get; set; }
        public bool DamagePriority { get; set; }
        public bool EvaluateAttack { get; set; }
        public bool Expert { get; set; }
        public bool Unknown { get; set; }
        public bool Risky { get; set; }
        public bool Status { get; set; }
        public bool TagTeam { get; set; }
        public bool WeatherEffect { get; set; }
    };
}