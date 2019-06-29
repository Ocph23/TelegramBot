using Ocph.Bots;
using System;

namespace TestApp
{
   public class Program
    {
        public static Bot bot { get; private set ; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bot = new Bot("785057197:AAFEFTwd1SK3Whvw4a506YY7Bocu9dLK3F4");
            Console.Read();
        }
    }
}
