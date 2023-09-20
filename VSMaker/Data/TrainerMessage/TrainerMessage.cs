namespace VSMaker.Data
{
    public class TrainerMessage
    {
        public int MessageId { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int MessageTriggerId { get; set; }
        public string MessageTriggerText { get; set; }
        public string MessageText { get; set; }

        public string DisplayTrainerName => $"[{TrainerId:D3}] - {TrainerName}";
    }
}