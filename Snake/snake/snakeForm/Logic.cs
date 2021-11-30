using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm
{
    public enum Directions
    { 
        Left,
        Right,
        Up,
        Down
    };
    class Logic
    {
        private int width;
        public int Width 
        { get { return width; } 
          set { width = value; } 
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int speed;
        public int Speed
        {
            get => speed;
            set
            {
                speed = value;
            }

        }
        private int score { get; set; }
       
        private bool gameStatus;
        public bool GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }
        private Directions direction;
        public Directions Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        
        

        public Logic()
        {
            Width = 16;
            Height = 16;
            speed = 15;
            score = 0;
            gameStatus = false;
            direction = Directions.Left;

            
        }
    }
}
