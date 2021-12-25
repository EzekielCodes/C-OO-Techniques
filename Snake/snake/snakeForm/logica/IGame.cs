namespace snakeForm.logica
{
    public interface IGame
    {
        bool Conitnue { get; set; }
        Directions Direction { get; set; }
        bool Exit { get; set; }
        bool GameStatus { get; set; }
        int Height { get; set; }
        int Score { get; set; }
        int Speed { get; set; }
        int Width { get; set; }
        public List<Cirkel> Snake { get; set; }
        public List<String> ScoreList { get; set; }
        public Cirkel Food { get; set; }

        void Dood();
        void Eat();
        Cirkel GenerateFood();
        Task ReadFile();
        void SnakeMovement();
        Task Start();
        void Stop();
        void WriteFile();
        //static Task<Game> Create();
    }
}