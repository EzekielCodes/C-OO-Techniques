using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm.logica
{
    public class Cirkel
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
        public Cirkel()
        {
            X = 0;  
            _y = 0;
        }

        public override string ToString()
        {
            return $"X value: {_x} , Y value {_y}";
               
        }
        

    }
}
