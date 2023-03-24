using System;

namespace Power2Method
{
    class Program
    {
        private static void PowerOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            PowerOf2Until5();
            PowerOf2Until5();
            
            PowersOf2UntilN(3);
            PowersOf2UntilN(4);
        }
    }
}