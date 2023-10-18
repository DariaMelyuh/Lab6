using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6__Адаптер_
{
    public class WildDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Дикая утка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("Дикая утка летает");
        }
    }
}
