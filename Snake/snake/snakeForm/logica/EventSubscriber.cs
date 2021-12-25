using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForm.logica
{
    public delegate String  notify(String str);
   
    public class EventSubscriber
    {
        public event notify Message;


        public void StartProcess()
        {
            Console.WriteLine("start process");
           this.Message +=  new notify(this.OnMessage);
        }
        public String OnMessage(String input)
        {
            Console.WriteLine("on message");
            Message?.Invoke(input);
            return input;
        }

        public String Test_OnMessagefailed(String Message)
        {
            return "Didnt finish! check for error " + Message;
            
        }

    }
}
