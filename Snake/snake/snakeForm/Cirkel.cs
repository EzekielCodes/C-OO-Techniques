using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm
{
    class Cirkel
    {
        private int X;
        public int x
        {
            get { 
                return X;
            }
            set {
                X = value;
            }
        }
        private int Y;
        public int y
        {
            get { 
                return Y; 
            }
            set { 
                Y = value;
            }
        }
        public Cirkel()
        {
            X = 0;  
            Y = 0;
        }
      
    }
}
