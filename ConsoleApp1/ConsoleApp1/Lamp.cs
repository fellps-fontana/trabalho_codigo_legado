using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lamp : IDevices
    {
        public StateEnum State { get; set; }
        public Lamp()
        {
            State = StateEnum.Off;
        }

        public void operate()
        {
            State = State == StateEnum.On ? StateEnum.Off : StateEnum.On;
            Console.WriteLine("Luz " + (State == StateEnum.On ? "Ligada" : "Desligada"));
        }
    }
}
