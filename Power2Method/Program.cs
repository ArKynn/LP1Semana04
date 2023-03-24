using System;

namespace Power2Method
{
    /// <summary>
    /// Defines and runs PowersOf2Until5 and PowersOf2UntilN
    /// </summary>
    class Program
    {
        /// <summary>
        /// Returns each power of 2 in a separate line until the 5th
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }
        /// <summary>
        /// Returns each power of 2 in a separate line until the nth
        /// </summary>
        /// <param name="n">Defines the last power of 2 to return</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Calls PowersOf2Until5 two times followed by calling PowersOf2UntilN two times with n = 3 and 4, respectively
        /// </summary>
        static void Main()
        {
            PowersOf2Until5();
            PowersOf2Until5();
            
            PowersOf2UntilN(3);
            PowersOf2UntilN(4);
        }
    }
}