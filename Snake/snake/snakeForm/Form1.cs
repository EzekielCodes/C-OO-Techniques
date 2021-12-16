using snakeForm.logica;
using System.Diagnostics;

namespace snakeForm
{
    public partial class Form1 : Form
    {
        private Game _game = new Game();
        //private readonly IGame _game;
        private bool _goLeft;
        private bool _goRight;
        private bool _goUp;
        private bool _goDown;
     
        public Form1(Game game)
        {
            InitializeComponent();
            _game = game;
            gameTimer.Interval = 100;
            gameTimer.Start();
            _game.Start();

        }

        private void RefreshGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvasGraphics = e.Graphics;
            for (int i = 0; i < _game.Snake.Count; i++)
            {
                if (i == 0)
                {
                    canvasGraphics.FillRectangle(Brushes.Black,
                    new Rectangle(_game.Snake[i].X * _game.Width,
                    _game.Snake[i].Y * _game.Height,
                    _game.Width, _game.Height));
                }
                else
                {
                    canvasGraphics.FillRectangle(Brushes.Green,
                    new Rectangle(_game.Snake[i].X * _game.Width,
                    _game.Snake[i].Y * _game.Height,
                    _game.Width, _game.Height));
                }
                
            }
            canvasGraphics.FillRectangle(Brushes.Red,
                    new Rectangle(_game.food.X * _game.Width,
                    _game.food.Y * _game.Height,
                    _game.Width, _game.Height));

            

        }

        private void GameTimerTick(object sender, EventArgs e)
        {
            if (_game.GameStatus == true && _game.Exit == true)
            {
                this.Close();
                Application.Exit();
                
            }

            else if (_game.Conitnue == true && _game.GameStatus == true)
            {
                this.Close();
                Application.Restart();
            }

            else if(_game.GameStatus == true)
            {
                this.Close();
                Application.Exit();
                
            }
            
            if (_goLeft)
            {
                _game.Direction = Directions.Left;

            }
            if (_goRight)
            {
                _game.Direction = Directions.Right;
            }
            if (_goDown)
            {
                _game.Direction = Directions.Down;

            }
            if (_goUp)
            {
                _game.Direction = Directions.Up;
            }
            _game.SnakeMovement();
            _game.Eat();
            scoreCounter.Text = Convert.ToString(_game.Score);
            canvasMain.Invalidate();
        }
    
       
        private void Form1KeyDown(object sender, KeyEventArgs e)
        {     
            if (e.KeyCode == Keys.Left && _game.Direction != Directions.Right)
            {
                _goLeft = true;
            }
            if (e.KeyCode == Keys.Right && _game.Direction != Directions.Left)
            {
                _goRight = true;
            }
            if (e.KeyCode == Keys.Up && _game.Direction != Directions.Down)
            {
                _goUp = true;
            }
            if (e.KeyCode == Keys.Down && _game.Direction != Directions.Up)
            {
                _goDown = true;
            }

        }
        private void Form1KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                _goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                _goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                _goDown = false;
            }
           
        }
    }
}