using System;

namespace ZombieToolbox.System.Console2
{
    public static class ConsoleShorthand
    {
        /// <summary>
        /// Writes <see cref="s"/> to the console and then prints a new line.
        /// </summary>
        /// <param name='s'>
        /// The string to be written to the console
        /// </param>
        public static void Wl(this string s)
        {
            Console.WriteLine(s);
        }

        /// <summary>
        /// Writes <see cref="s"/> to the console.
        /// </summary>
        /// <param name='s'>
        /// The string to be written to the console
        /// </param>
        public static void W(this string s)
        {
            Console.Write(s);
        }
    }
}

