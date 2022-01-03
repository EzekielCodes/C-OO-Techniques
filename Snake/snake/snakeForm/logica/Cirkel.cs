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

        public Cirkel(int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public Cirkel(int xpoint, int ypoint)
        {
            _x = xpoint;  
            _y = ypoint;
        }

        public Cirkel()
        {
            _x = 0;
            _y = 0;
        }


        public override string ToString() => $"X value: {_x} , Y value {_y}";
              

        public override String GetCordinate()
        {
            String result = "Xcordinate "+ _x + " Ycordinate " + _y; 
            return result;
        }
    }
}
