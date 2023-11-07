namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 25;
            Height = 25;
            Speed = 5;
            Score = 0;
            Points = 50;
            GameOver = false;
            direction = Direction.Down;
        }
    }


}
