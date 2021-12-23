using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm.logica
{
    public abstract class Figuur
    {
        public abstract int Height { get; set; }
        public abstract int Width { get; set; } 
        public abstract String GetCordinate();
    }
}
