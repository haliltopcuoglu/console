using System;

namespace console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsmini Gir");
            string name = Console.ReadLine();
            Console.WriteLine("Soy İsmini Gir");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
