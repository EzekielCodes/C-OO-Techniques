using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm.logica
{
    public class Cirkel:Figuur
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _width;
        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        private int _height;
        public override int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public Cirkel(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public Cirkel(int xpoint, int ypoint)
        {
            X = xpoint;  
            Y = ypoint;
        }

        public Cirkel()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString() => $"X value: {X} , Y value {Y}";
              
        public override String GetCordinate()
        {
            String result = "Xcordinate "+ X + " Ycordinate " + Y; 
            return result;
        }
    }
}
