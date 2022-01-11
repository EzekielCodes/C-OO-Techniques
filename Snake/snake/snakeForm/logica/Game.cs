using System;
using System.Threading;
using System.Threading.Tasks;
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

        public Dictionary<Enum, Action> DictMovement = new Dictionary<Enum, Action>();
        public String SourceFile = SnakeForm.Properties.Resources.SourceFile;
        private String _eventResult;
        public String EventResult
        {
            get { return _eventResult; }
            set { _eventResult = value; }
        }
       // EventSubscriber _event = new EventSubscriber();
        public event EventHandler OnDeadMessage;



        private Game()
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
            Food = new Cirkel(0,0);
            Bodypart = new Cirkel();
            
            DictMovement.Add(Directions.Left, Snake.SnakeLeft);
            DictMovement.Add(Directions.Right, Snake.SnakeRight);
            DictMovement.Add(Directions.Up, Snake.SnakeUp);
            DictMovement.Add(Directions.Down, Snake.SnakeDown);

        }
        public static async Task<Game> Create()
        {
            var myClass = new Game();
            await myClass.InitiazeSnake();
            return myClass;
        }

        private async Task InitiazeSnake()
        {
            
            timer.Interval = 100;
            _exit = false;
            _continue = false;
            Console.WriteLine("wait start");
            await Start();
            Console.WriteLine("stop start");

        }

        public async Task Start()
        {
            OnDeadMessage += Message_OnDeadMessage;
            await ReadFile();
            Snake.Clear();
            Cirkel head = new Cirkel(17,17,16,16);
            Snake.Add(head);
            timer.Start();
            GenerateFood();
        }

        public void  PrintEvent()
        {
            Console.WriteLine("done");
        }


        public Cirkel GenerateFood()
        {
            Random random = new Random();
            int randX = random.Next(0, 33);
            int randY = random.Next(0, 33);

            if ((randX == 0) && (randY == 0))
                return new Cirkel { X = 1, Y = 1 };

            for (int i = 0; i < Snake.Count; i++)
            {
                if ((Snake[i].X == randX) && (Snake[i].Y == randY))
                {
                    return GenerateFood();
                }
            }
            //_eventResult = _event.Test_OnMessage("start GenerateFood");
            Console.WriteLine(_eventResult);
            return Food = new Cirkel { X = randX, Y = randY };
        }

        public void Dood()
        {
            if (Snake[0].X > 33 || Snake[0].Y > 33 || Snake[0].X < 0 || Snake[0].Y < 0)
            {
                GameStatus = true;
                WriteFile();            
                OnDeadMessage?.Invoke(this,EventArgs.Empty);
                _continue = true;
                PrintMenu();
                string input;
                input = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(input[0]);
                GetuserChoice(input[0])();


            }
        }
        private void Message_OnDeadMessage(Object sender, EventArgs e)
        {
           Console.WriteLine($"Thanks for playing. You had a score of: {Score}");
            //MessageBox.Show($"Thanks for playing. You had a score of: {Score}");
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
                    if (DictMovement.ContainsKey(Direction)) DictMovement[Direction]();

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
                '1' =>Task.Run(() => new Game().Further()).Wait,
                '2' => () => Console.WriteLine(""),
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
        private async Task Further()
        {

            Console.WriteLine("starten");
            await new Game().InitiazeSnake();

        }

        public async Task ReadFile()
        {
            StreamReader sr = new StreamReader(SourceFile);
            try
            {
                if (File.Exists(SourceFile))
                {
                    try
                    {
                        String line;
                        while (!sr.EndOfStream)
                        {
                            line = await sr.ReadLineAsync();
                            ScoreList.Add(line);
                        }
                    }
                    catch (IOException e)
                    {
                        throw new IOException($"The file could not be read { e.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Fout { ex.Message}");
                    }
                    finally
                    {
                        if (sr != null) sr.Dispose();
                    }
                }
            }
            catch (FileNotFoundException filenotfound)
            {
                throw new FileNotFoundException($"FIle not found{ filenotfound.Message}");
            }
        }

        public void WriteFile()
        {
            String scoreConvert = Convert.ToString(Score);
            if (!ScoreList.Contains(scoreConvert))
            {
                ScoreList.Add(scoreConvert);
            }
            StreamWriter sw = new StreamWriter(SourceFile);
            try
            {
                if (File.Exists(SourceFile))
                {
                    try
                    {
                        foreach (String line in ScoreList)
                        {
                            sw.WriteLine(line);
                        }
                    }
                    catch (IOException e)
                    {
                        throw new IOException($"The file couldn't be written { e.Message}");
                    }
                    catch (Exception ex)
                    {
                       throw new Exception($"Fout { ex.Message}");
                    }
                    finally
                    {
                        if (sw != null) sw.Dispose();
                    }
                }
            }

            catch (FileNotFoundException filenotfound)
            {
                throw new FileNotFoundException($"FIle not found{ filenotfound.Message}");
            }

        }

         
    }
}
