namespace VSMaker.Data
{
    public class BallSeal
    {
        public ushort BallSealId { get; set; }
        public string Name { get; set; }
    }
  
    public static class BallSeals
    {
        private static List<BallSeal> seals;
        public static List<BallSeal> Seals
        {
            get => seals ?? new List<BallSeal>
            {
                CreateBallSeal(0, "-----"),
                CreateBallSeal(1, "Red Petals"),
                CreateBallSeal(2, "Music Notes"),
                CreateBallSeal(3, "Confetti"),
                CreateBallSeal(4, "Lightning Bolts"),
                CreateBallSeal(5, "Black Smoke Clouds"),
                CreateBallSeal(6, "Hearts & Stars"),
                CreateBallSeal(7, "Red Hearts"),
                CreateBallSeal(8, "Blue Bubbles"),
                CreateBallSeal(9, "Pink Bubbles"),
                CreateBallSeal(10, "Yellow Stars"),
                CreateBallSeal(11, "Cyan & Yellow Stars"),
                CreateBallSeal(12, "Black & White Smoke"),
                CreateBallSeal(13, "Orange Flame Clouds"),
                CreateBallSeal(14, "Blue Flame Clouds"),
                CreateBallSeal(15, "Pink & Blue Bubbles"),
                CreateBallSeal(16, "Black & White Smoke, Bubbles, Flame & Confetti"),
                CreateBallSeal(17, "Orange & Blue Flames, Blue & Yellow Stars"),
                CreateBallSeal(18, "Music Notes & Lightning"),
                CreateBallSeal(19, "Lots of Red Petals"),
                CreateBallSeal(20, "Small Red Pettles & Confetti"),
                CreateBallSeal(21, "Red Petal Spiral"),
                CreateBallSeal(22, "3 Confetti Pieces"),
                CreateBallSeal(23, "Blue Stars"),
                CreateBallSeal(24, "Blue & Yellow Stars"),
                CreateBallSeal(25, "Black Smoke From Ground"),
                CreateBallSeal(26, "Dark Purple Petal Spirals"),
                CreateBallSeal(27, "Lots of Red Petals 2"),
            };
            set => seals = value;
        }

        private static BallSeal CreateBallSeal(ushort ballSealId, string name)
        {
           return new BallSeal { BallSealId = ballSealId, Name = name };
        }
    }
}