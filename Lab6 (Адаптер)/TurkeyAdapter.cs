using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6__Адаптер_
{
    public class TurkeyAdapter : Duck
    {
        private Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            ArgumentNullException.ThrowIfNull(turkey);
            this.turkey = turkey;
        }

        public override void Quack()
        {
            turkey.Gobble();
        }

        public override void Fly()
        {
            turkey.Fly();
        }
    }
}
