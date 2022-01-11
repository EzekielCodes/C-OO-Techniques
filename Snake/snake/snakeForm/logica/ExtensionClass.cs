using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using snakeForm.logica;

namespace snakeForm.logica
{
    public static class ExtensionClass
    {
        
       public static void SnakeLeft(this List<Cirkel> snake)
        {
            snake[0].X--;
            
        }
        public static void SnakeRight(this List<Cirkel> snake)
        {
            snake[0].X++;
        }
        public static void SnakeUp(this List<Cirkel> snake)
        {
            snake[0].Y--;
        }
        public static void SnakeDown(this List<Cirkel> snake)
        {
            snake[0].Y++;
        }
    }
}
