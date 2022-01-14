using SnakeForm.Data;
namespace snakeForm.logica
{
    public class Game : IGame

    {
        public System.Windows.Forms.Timer timer = new();

        public int Width { get; set; }

        public int Height { get; set; }
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

        public bool GameStatus { get; set; }

        public Directions Direction { get; set; }
        public Cirkel Bodypart { get; set; }
        public bool Exit { get; set; }
        public bool Conitnue { get; set; }

        public List<Cirkel> Snake { get; set; }
        public List<string> ScoreList { get; set; }
        public List<string> ScoreLi = new List<string>();
        public Cirkel Food { get; set; }

        public Dictionary<Enum, Action> DictMovement = new();
        public String SourceFile = SnakeForm.Properties.Resources.SourceFile;

        public String EventResult { get; set; }

        public event EventHandler OnDeadMessage;

        private readonly Random _random = new ();
        private int _randX;
        private int _randY;
        public Score _myscore = new();
        private Game()
        {
            Width = 16;
            Height = 16;
            _speed = 15;
            _score = 0;
            Direction = Directions.Left;
            Exit = false;
            Conitnue = false;
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
            Exit = false;
            Conitnue = false;
            Console.WriteLine("wait start");
            await Start();
            Console.WriteLine("stop start");

        }

        public async Task Start()
        {
            
            OnDeadMessage += Message_OnDeadMessage;
            await _myscore.ReadFile();
            ScoreList.AddRange(_myscore.ScoreList);
            //await ReadFile();
            Snake.Clear();
            var head = new Cirkel(17,17,16,16);
            Snake.Add(head);
            timer.Start();
            GenerateFood();
        }

     

        public Cirkel GenerateFood()
        {          
            _randX = _random.Next(0, 33);
            _randY = _random.Next(0, 33);

            if ((_randX == 0) && (_randY == 0))
                return new Cirkel { X = 1, Y = 1 };

            for (int i = 0; i < Snake.Count; i++)
            {
                if ((Snake[i].X == _randX) && (Snake[i].Y == _randY))
                {
                    return GenerateFood();
                }
            }
            //_eventResult = _event.Test_OnMessage("start GenerateFood");
            Console.WriteLine(EventResult);
            return Food = new Cirkel { X = _randX, Y = _randY };
        }

        public void Dood()
        {
            if (Snake[0].X > 33 || Snake[0].Y > 33 || Snake[0].X < 0 || Snake[0].Y < 0)
            {
                GameStatus = true;
                _myscore.Points = Score;
                _myscore.WriteFile();
                //WriteFile();            
                OnDeadMessage?.Invoke(this,EventArgs.Empty);
                Conitnue = true;
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
                Bodypart = new Cirkel { X = Snake[^1].X + 1, Y = Snake[^1].Y + 1 };
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
            Exit = true;
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
            var sr = new StreamReader(SourceFile);
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
            var sw = new StreamWriter(SourceFile);
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
