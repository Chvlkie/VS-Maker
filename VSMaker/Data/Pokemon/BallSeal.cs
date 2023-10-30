namespace VSMaker.Data
{
    public class BallSeal
    {
        public int BallSealTypeId { get; set; }
        public string Name { get; set; }
    }

    public class BallSealType
    {
        public int BallSealTypeId { get; set; }
        public string Description { get; set; }
    }

    public static class BallSealTypes
    {
        private static List<BallSealType> types;

        public static List<BallSealType> Types
        {
            get => types ?? new List<BallSealType>
            {
                new BallSealType{BallSealTypeId = 0, Description = "-----"},
                new BallSealType{BallSealTypeId = 1, Description = "Heart Seal"},
                new BallSealType{BallSealTypeId = 2, Description = "Star Seal"},
                new BallSealType{BallSealTypeId = 3, Description = "Line Seal"},
                new BallSealType{BallSealTypeId = 4, Description = "Smoke Seal"},
                new BallSealType{BallSealTypeId = 5, Description = "Ele-Seal"},
                new BallSealType{BallSealTypeId = 6, Description = "Foamy Seal"},
                new BallSealType{BallSealTypeId = 7, Description = "Fire Seal"},
                new BallSealType{BallSealTypeId = 8, Description = "Party Seal"},
                new BallSealType{BallSealTypeId = 9, Description = "Flora Seal"},
                new BallSealType{BallSealTypeId = 10, Description = "Song Seal"},
                new BallSealType{BallSealTypeId = 11, Description = "Alphabet Seal"},
                new BallSealType{BallSealTypeId = 12, Description = "Shock Seal"},
                new BallSealType{BallSealTypeId = 13, Description = "Mystery Seal"},
                new BallSealType{BallSealTypeId = 14, Description = "Liquid Seal"},
                new BallSealType{BallSealTypeId = 15, Description = "Burst Seal"},
                new BallSealType{BallSealTypeId = 16, Description = "Twinkle Seal"},
            };
            set => types = value;
        }
    }

    public static class BallSeals
    {
        private static List<BallSeal> seals;
        public static List<BallSeal> Seals
        {
            get
            {
                if (seals == default)
                {
                    List<BallSeal> ballSeals = new()
                    {
                        new BallSeal { BallSealTypeId = 0, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 0).Description }
                    };
                    ballSeals.AddRange(BallSealRange(1));
                    ballSeals.AddRange(BallSealRange(2));
                    ballSeals.AddRange(BallSealRange(3, 'D'));
                    ballSeals.AddRange(BallSealRange(4, 'D'));
                    ballSeals.AddRange(BallSealRange(5, 'D'));
                    ballSeals.AddRange(BallSealRange(6, 'D'));
                    ballSeals.AddRange(BallSealRange(7, 'D'));
                    ballSeals.AddRange(BallSealRange(8, 'D'));
                    ballSeals.AddRange(BallSealRange(9, 'F'));
                    ballSeals.AddRange(BallSealRange(10, 'G'));
                    ballSeals.AddRange(BallSealRange(11, 'Z', true));
                    ballSeals.Add(new BallSeal { BallSealTypeId = 12, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 12).Description });
                    ballSeals.Add(new BallSeal { BallSealTypeId = 13, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 13).Description });
                    ballSeals.Add(new BallSeal { BallSealTypeId = 14, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 14).Description });
                    ballSeals.Add(new BallSeal { BallSealTypeId = 15, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 15).Description });
                    ballSeals.Add(new BallSeal { BallSealTypeId = 16, Name = BallSealTypes.Types.Find(x => x.BallSealTypeId == 16).Description });

                    return ballSeals;
                }
                else
                {
                    return seals;
                }

            }

            set => seals = value;
        }

        private static List<BallSeal> BallSealRange(int ballSealTypeId, char maxChar = 'F', bool isAlphabetSeal = false)
        {
            var returnList = new List<BallSeal>();
            for (char c = 'A'; c <= maxChar; c++)
            {
                string name = !isAlphabetSeal ? $"{BallSealTypes.Types.Find(x => x.BallSealTypeId == ballSealTypeId).Description} {c}"
                    : $"{c} Seal";

                var item = new BallSeal { BallSealTypeId = ballSealTypeId, Name = name };
                returnList.Add(item);
            }
            return returnList;

        }
    }
}