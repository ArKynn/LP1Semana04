using System;

namespace Lucas
{
    class Program
    {
        private static int Lucas(int n)
        {
            int answer = 2;
            
            
            if (n == 1)
            {
                answer = n;
            }
            else if (n > 1)
            {
                answer = Lucas(n - 1) + Lucas(n - 2);
            }

            return answer;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert number to find in Lucas' sequence");
            int lucasNum = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine(Lucas(lucasNum));
        }
    }
}
