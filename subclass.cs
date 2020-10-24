using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{


    class Subclass
    {
        private int value1;
        private bool value2;
        public Subclass(int value1, bool value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int getValue1()
        {
            return value1;
        }
        public bool getValue2()
        {
            return value2;
        }

    }
}
