using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6__Адаптер_
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("Резиновая утка не умеет летать");
        }
    }
}
