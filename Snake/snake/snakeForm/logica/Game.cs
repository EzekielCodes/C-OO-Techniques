using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace snakeForm.logica
{
    public class Game : IGame
    {
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _speed;
        public int Speed
        {
            get => _speed;
            set
            {
                if (value >= 0) throw new ArgumentException("Speed lager dan 0");
                _speed = value;
            }

        }
        private int _score;
        public int Score
        {
            get => _score;
            set
            {
                if (value < 0) throw new ArgumentException("Score lager dan 0");
                _score = value;
            }
        }
        private bool _gameStatus;
        public bool GameStatus
        {
            get { return _gameStatus; }
            set { _gameStatus = value; }
        }
        private Directions _direction;
        public Directions Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        //public List<(int x, int y)> Snake { get; set; } = new List<(int x, int y)>();
        public List<Cirkel> Snake = new List<Cirkel>();
        public Cirkel food = new Cirkel();
        public Cirkel bodypart = new Cirkel();




        public Game()
        {
            _width = 16;
            _height = 16;
            _speed = 15;
            _score = 0;
            _direction = Directions.Left;

            InitiazeSnake();



        }

        private void InitiazeSnake()
        {

            timer.Interval = 100;
            Start();
        }

        public void Start()
        {
            Snake.Clear();
            Cirkel head = new Cirkel { X = 17, Y = 17 };
            Snake.Add(head);
            timer.Start();
            GenerateFood();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void GenerateFood()
        {
            Random random = new Random();
            food = new Cirkel { X = random.Next(0, 33), Y = random.Next(0, 33) };
        }

        public void Dood()
        {
            if (Snake[0].X > 33 || Snake[0].Y > 33 || Snake[0].X < 0 || Snake[0].Y < 0)
            {
                GameStatus = true;
                timer.Stop();
                MessageBox.Show($"Thanks for playing. You had a score of: {Score}");
             
            }
        }

        public void Eat()
        {
            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
            {
                Score += 1;
                bodypart = new Cirkel { X = Snake[Snake.Count - 1].X + 1, Y = Snake[Snake.Count - 1].Y + 1 };
                Snake.Add(bodypart);
                GenerateFood();

            }
        }

        public void SnakeMovement()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Direction)

                    {
                        case Directions.Left:
                            Snake[0].X--;

                            break;
                        case Directions.Right:
                            Snake[0].X++;
                            break;
                        case Directions.Down:
                            Snake[0].Y++;
                            break;
                        case Directions.Up:
                            Snake[0].Y--;
                            break;
                    }

                    Dood();

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

    }
}
