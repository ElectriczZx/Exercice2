using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    class Superclass : Subclass
    {
        int value3;
        
        public Superclass(int value1, bool value2, int value3):
            base(value1, value2)
            {
            this.value3 = value3;
            }

        public int getValue3()
        {
            return value3;
        }


    }
}
