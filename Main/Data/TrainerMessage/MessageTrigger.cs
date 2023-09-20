namespace Main.Data
{
    public partial class MessageTrigger
    {
        public int MessageTriggerId { get; set; }
        public string MessageTriggerName { get; set; }
    }

    public enum MessageTriggerEnum
    {
        preBattleOw = 0,
        playerWins = 1,
        postBattleOw = 2,
        playerLost = 20,
        trainerLastPoke = 15,
        trainerLastPokeCritical = 16,

        doublePreBattleOwTrainer1 = 3,
        doublePlayerWinTrainer1 = 4,
        doublePostBattleOwTrainer1 = 5,
        doubleOnlyOnePokeTrainer1 = 6,

        doublePreBattleOwTrainer2 = 7,
        doublePlayerWinTrainer2 = 8,
        doublePostBattleOwTrainer2 = 9,
        doubleOnlyOnePokeTrainer2 = 10,

        notUsed0B = 11,
        notUsed0C = 12,
        notUsed0D = 13,
        notUsed0E = 14,
        rematch = 17,
        doubleRematchTrainer1 = 18,
        doubleRematchTrainer2 = 19,
    }

    public static class MessageTriggers
    {
        public static class Descriptions
        {
            public const string PreBattleOw = "Pre-Battle OW";
            public const string PlayerWins = "Player Wins";
            public const string PostBattleOw = "Post-Battle OW";
            public const string PlayerLost = "Player Lost";
            public const string TrainerLastPoke = "Opponent Last Pokemon";
            public const string TrainerLastPokeCritical = "Opponent Last Pokemon Crit. HP";

            public const string DoublePreBattleOwTrainer1 = "DOUBLE Pre-Battle OW; Trainer 1";
            public const string DoublePlayerWinTrainer1 = "DOUBLE Player Wins; Trainer 1";
            public const string DoublePostBattleOwTrainer1 = "DOUBLE Post-Battle OW; Trainer 1";
            public const string DoubleOnlyOnePokeTrainer1 = "DOUBLE Only One Poke; Trainer 1";

            public const string DoublePreBattleOwTrainer2 = "DOUBLE Pre-Battle OW; Trainer 2";
            public const string DoublePlayerWinTrainer2 = "DOUBLE Player Wins; Trainer 2";
            public const string DoublePostBattleOwTrainer2 = "DOUBLE Post-Battle OW; Trainer 2";
            public const string DoubleOnlyOnePokeTrainer2 = "DOUBLE Only One Poke; Trainer 2";
        }

        public static string GetDescriptionFromEnum(MessageTriggerEnum messageTrigger) => messageTrigger switch
        {
            MessageTriggerEnum.preBattleOw => Descriptions.PreBattleOw,
            MessageTriggerEnum.playerWins => Descriptions.PlayerWins,
            MessageTriggerEnum.postBattleOw => Descriptions.PostBattleOw,
            MessageTriggerEnum.playerLost => Descriptions.PlayerLost,
            MessageTriggerEnum.trainerLastPoke => Descriptions.TrainerLastPoke,
            MessageTriggerEnum.trainerLastPokeCritical => Descriptions.TrainerLastPokeCritical,
            MessageTriggerEnum.doublePreBattleOwTrainer1 => Descriptions.DoublePreBattleOwTrainer1,
            MessageTriggerEnum.doublePlayerWinTrainer1 => Descriptions.DoublePlayerWinTrainer1,
            MessageTriggerEnum.doublePostBattleOwTrainer1 => Descriptions.DoublePostBattleOwTrainer1,
            MessageTriggerEnum.doubleOnlyOnePokeTrainer1 => Descriptions.DoubleOnlyOnePokeTrainer1,
            MessageTriggerEnum.doublePreBattleOwTrainer2 => Descriptions.DoublePreBattleOwTrainer2,
            MessageTriggerEnum.doublePlayerWinTrainer2 => Descriptions.DoublePlayerWinTrainer2,
            MessageTriggerEnum.doublePostBattleOwTrainer2 => Descriptions.DoublePostBattleOwTrainer2,
            MessageTriggerEnum.doubleOnlyOnePokeTrainer2 => Descriptions.DoubleOnlyOnePokeTrainer2,
            _ => "Not in use.",
        };

        public static int GetIdFromDescription(string description)
        {
            switch (description)
            {
                case
                default:
                    break;
            }
        }
    }
}