using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)

        {
            Subclass sbc = new Subclass(1, true);
            Superclass sc = new Superclass(2, false, 6);

            int  v1 = sc.getValue1();
            bool v2 = sc.getValue2();
            int  v3 = sc.getValue3();

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

        }
    }
}
