﻿using System.ComponentModel;

namespace VSMaker.Data
{
    public partial class MessageTrigger
    {
        public int MessageTriggerId { get; set; }
        public string MessageTriggerName { get; set; }
    }

    public enum MessageTriggerEnum
    {
        [Description(MessageTriggers.Descriptions.PreBattleOw)]
        preBattleOw = 0,

        [Description(MessageTriggers.Descriptions.PlayerWins)]
        playerWins = 1,

        [Description(MessageTriggers.Descriptions.PostBattleOw)]
        postBattleOw = 2,

        [Description(MessageTriggers.Descriptions.DoublePreBattleOwTrainer1)]
        doublePreBattleOwTrainer1 = 3,

        [Description(MessageTriggers.Descriptions.DoublePlayerWinTrainer1)]
        doublePlayerWinTrainer1 = 4,

        [Description(MessageTriggers.Descriptions.DoublePostBattleOwTrainer1)]
        doublePostBattleOwTrainer1 = 5,

        [Description(MessageTriggers.Descriptions.DoubleOnlyOnePokeTrainer1)]
        doubleOnlyOnePokeTrainer1 = 6,

        [Description(MessageTriggers.Descriptions.DoublePreBattleOwTrainer2)]
        doublePreBattleOwTrainer2 = 7,

        [Description(MessageTriggers.Descriptions.DoublePlayerWinTrainer2)]
        doublePlayerWinTrainer2 = 8,

        [Description(MessageTriggers.Descriptions.DoublePostBattleOwTrainer2)]
        doublePostBattleOwTrainer2 = 9,

        [Description(MessageTriggers.Descriptions.DoubleOnlyOnePokeTrainer2)]
        doubleOnlyOnePokeTrainer2 = 10,

        [Description("notUsed0B")]
        notUsed0B = 11,

        [Description("notUsed0C")]
        notUsed0C = 12,

        [Description("notUsed0D")]
        notUsed0D = 13,

        [Description("notUsed0E")]
        notUsed0E = 14,

        [Description(MessageTriggers.Descriptions.TrainerLastPoke)]
        trainerLastPoke = 15,

        [Description(MessageTriggers.Descriptions.TrainerLastPokeCritical)]
        trainerLastPokeCritical = 16,

        [Description(MessageTriggers.Descriptions.Rematch)]
        rematch = 17,

        [Description(MessageTriggers.Descriptions.DoubleRematchTrainer1)]
        doubleRematchTrainer1 = 18,

        [Description(MessageTriggers.Descriptions.DoubleRematchTrainer2)]
        doubleRematchTrainer2 = 19,

        [Description(MessageTriggers.Descriptions.PlayerLost)]
        playerLost = 20,
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
            public const string Rematch = "Rematch";
            public const string DoubleRematchTrainer1 = "Double Rematch Trainer 1";
            public const string DoubleRematchTrainer2 = "Double Rematch Trainer 2";
        }
    }
}