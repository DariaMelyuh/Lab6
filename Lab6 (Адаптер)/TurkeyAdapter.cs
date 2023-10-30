using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6__Адаптер_
{
    public class TurkeyAdapter : Duck
    {
        private Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            ArgumentNullException.ThrowIfNull(turkey);
            this._turkey = turkey;
        }

        public override void Quack()
        {
            _turkey.Gobble();
        }

        public override void Fly()
        {
            _turkey.Fly();
        }
    }
}
