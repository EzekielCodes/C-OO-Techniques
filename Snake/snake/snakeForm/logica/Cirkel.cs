using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm.logica
{
    public class Cirkel:Figuur
    {
        private int _x;
        public int X
        {
            get { 
                return _x;
            }
            set {
                _x = value;
            }
        }
        private int _y;
        public int Y
        {
            get { 
                return _y; 
            }
            set { 
                _y = value;
            }
        }
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

        public Cirkel(int X, int Y, int Height, int Width)
        {
            _x = X;
            _y = Y;
            _width = Width;
            _height = Height;
        }

        public Cirkel(int X, int Y)
        {
            X = _x;  
            Y = _y;
        }

        public Cirkel()
        {
            _x = 0;
            _y = 0;
        }


        public override string ToString()
        {
            return $"X value: {_x} , Y value {_y}";
               
        }

        public override String GetCordinate()
        {
            String result = "Xcordinate "+ _x + " Ycordinate " + _y; 
            return result;
        }
    }
}
