﻿

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
        public Cirkel Bodypart { get; set; }

        private bool _exit;
        public bool Exit
        {
            get { return _exit; }
            set { _exit = value; }
        }

        private bool _continue;
        public bool Conitnue
        {
            get { return _continue; }
            set { _continue = value; }
        }

        public List<Cirkel> Snake { get; set; }
        public List<string> ScoreList { get; set; }
        public Cirkel Food { get; set; }

        public Dictionary<Enum, Action> dictMovement = new Dictionary<Enum, Action>();
        public String sourceFile = Properties.Resources.SourceFile;


        public Game()
        {
            _width = 16;
            _height = 16;
            _speed = 15;
            _score = 0;
            _direction = Directions.Left;
            _exit = false;
            _continue = false;
            ScoreList = new List<String>();
            Snake = new List<Cirkel>();
            Food = new Cirkel();
            Bodypart = new Cirkel();
            ReadFile();
            
            InitiazeSnake();
            
            dictMovement.Add(Directions.Left, Snake.SnakeLeft);
            dictMovement.Add(Directions.Right, Snake.SnakeRight);
            dictMovement.Add(Directions.Up, Snake.SnakeUp);
            dictMovement.Add(Directions.Down, Snake.SnakeDown);

        }

        private void InitiazeSnake()
        {

            timer.Interval = 100;
            _exit = false;
            _continue = false;
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

       

        public Cirkel GenerateFood()
        {
            Random random = new Random();
            int randX = random.Next(0, 33);
            int randY = random.Next(0, 33);

            for (int i = 0; i < Snake.Count; i++)
            {
                if((Snake[i].X == randX) && (Snake[i].Y == randY))
                {
                    return GenerateFood();
                }
            }
            
           return Food = new Cirkel { X = randX, Y = randY };
        }

        public void Dood()
        {
            if (Snake[0].X > 33 || Snake[0].Y > 33 || Snake[0].X < 0 || Snake[0].Y < 0)
            {
                GameStatus = true;
                WriteFile();
                Console.WriteLine($"Thanks for playing. You had a score of: {Score}");
                _continue = true;
                PrintMenu();
                string input = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(input[0]);
                GetuserChoice(input[0])();

            }
        }

        public void Eat()
        {
            if (Snake[0].X == Food.X && Snake[0].Y == Food.Y)
            {
                Score += 1;
                Bodypart = new Cirkel { X = Snake[Snake.Count - 1].X + 1, Y = Snake[Snake.Count - 1].Y + 1 };
                Snake.Add(Bodypart);
                GenerateFood();

            }
        }

        public void SnakeMovement()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (dictMovement.ContainsKey(Direction)) dictMovement[Direction]();

                    Dood();
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private Action GetuserChoice(char input)
        {

            return input switch
            {
                '0' => () => Stop(),
                '1' => new Game().Further,
                _ => () => Console.WriteLine("Invalid input")
            };
        }
        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("0.  Stop met spelen");
            Console.WriteLine("1.  Opnieuw)");
            Console.WriteLine();
            Console.Write("Geef je keuze in: ");
        }
        public void Stop()

        {
            _exit = true;
            timer.Stop();
            GameStatus = true;

        }
        private void Further()
        {

            Console.WriteLine("starten");
            new Game().InitiazeSnake();

        }

        public void ReadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                {
                    String line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        ScoreList.Add(line);
                    }

                }
                Console.WriteLine(String.Join(" \n", ScoreList));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The file couldn't be read { ex.Message}");
            }

        }

        public void WriteFile()
        {
            String scoreConvert = Convert.ToString(Score);
            if (!ScoreList.Contains(scoreConvert))
            {
                ScoreList.Add(scoreConvert);
            }
            try
            {

                using (StreamWriter sw = new StreamWriter(sourceFile))
                {

                    foreach (String line in ScoreList)
                    {
                        sw.WriteLine(line);
                    }
                    Console.WriteLine(String.Join(" \n", ScoreList));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Couldn't write file { ex.Message}");
            }

        }

    }
}
