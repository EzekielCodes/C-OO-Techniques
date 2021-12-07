namespace snakeForm.logica
{
    public interface IGame
    {
        Directions Direction { get; set; }
        bool GameStatus { get; set; }
        int Height { get; set; }
        int Score { get; set; }
        int Speed { get; set; }
        int Width { get; set; }

        void Dood();
        void Eat();
        void GenerateFood();
        void SnakeMovement();
        void Start();
        void Stop();
    }
}