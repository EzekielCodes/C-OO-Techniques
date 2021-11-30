using System.Diagnostics;

namespace snakeForm
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        private Cirkel food = new Cirkel();
        private List<Cirkel> Snake = new List<Cirkel>();
        private bool goLeft, goRight, goDown, goUp;
        private delegate void dead();
        private dead deadStatus; 

        public Form1()
        {
           
            InitializeComponent();
           /* Console.WriteLine("Direction");
            Console.WriteLine(logic.directionState);
            Console.WriteLine(goLeft);*/
            gameTimer.Interval = 100;
            deadStatus = () => {  logic.GameStatus = true; };

            StartGame();

        }

        private void StartGame()
        {
            new Logic();
            Snake.Clear();
            Cirkel head = new Cirkel { x = 17 , y = 17};
            //Cirkel headd = new Cirkel { x = 18, y = 18 };
            Snake.Add(head);
           // Snake.Add(headd);
            GenerateFood();
            gameTimer.Start();

        }

        private void GenerateFood()
        {
            int maxXpos = canvasMain.Size.Width / logic.Width;
            int maxYpos = canvasMain.Size.Height / logic.Height;
            Console.WriteLine(maxXpos);
            Console.WriteLine(maxXpos);

            Random random = new Random();
            food = new Cirkel { x = random.Next(0, maxXpos), y = random.Next(0, maxYpos) };


        }

        private void RefreshGraphics(object sender, PaintEventArgs e)
        {


            
            Graphics canvasGraphics = e.Graphics;
            for (int i = 0; i < Snake.Count; i++)
            {
                canvasGraphics.FillEllipse(Brushes.Green,
                    new Rectangle(Snake[i].x * logic.Width,
                    Snake[0].y * logic.Height,
                    logic.Width, logic.Height));
            }
            //if uit maxx en y
            //deadStatus();
            

            canvasGraphics.FillEllipse(Brushes.Red,
                    new Rectangle(food.x * logic.Width,
                    food.y * logic.Height,
                    logic.Width, logic.Height));
            
           

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            /*Console.WriteLine("Tick");
            Console.WriteLine(logic.directionState);*/
            if (goLeft)
            {
                logic.Direction = Directions.Left;

            }
            if (goRight)
            {
                logic.Direction = Directions.Right;
            }
            if (goDown)
            {
                logic.Direction = Directions.Down;

            }
            if (goUp)
            {
                logic.Direction = Directions.Up;
            }
            Eat();
            SnakeMovement();
           /* Console.WriteLine(logic.Direction);
            Console.WriteLine(Snake[0].x);
            Console.WriteLine(Snake[0].y);*/


            canvasMain.Invalidate();
        }

        private void SnakeMovement()
        {
            switch (logic.Direction)

            {

                case Directions.Left:
                    Snake[0].x--;

                    break;
                case Directions.Right:
                    Snake[0].x++;
                    break;
                case Directions.Down:
                    Snake[0].y++;
                    break;
                case Directions.Up:
                    Snake[0].y--;
                    break;

            }
        }
        private void Eat()
        {
            if(Snake[0].x == food.x)
            {
                if(Snake[0].y == food.y)
                {
                    Console.WriteLine("Eat");
                    GenerateFood();
                }
            }
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*Console.WriteLine("keycode");
            Console.WriteLine(e.KeyCode);*/
            if (e.KeyCode == Keys.Left && logic.Direction != Directions.Right)
            {
                goLeft = true;
                //Console.WriteLine("going left");

            }
            if (e.KeyCode == Keys.Right && logic.Direction != Directions.Left)
            {
                goRight = true;
                //Console.WriteLine("going right");
            }
            if (e.KeyCode == Keys.Up && logic.Direction != Directions.Down)
            {
                goUp = true;
                //Console.WriteLine("going up");
            }
            if (e.KeyCode == Keys.Down && logic.Direction != Directions.Up)
            {
                goDown = true;
                //Console.WriteLine("going down");
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
           
        }
    }
}