using System;

namespace VariableOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //maak hier 3 local variables aan:
             string name = "Guts";
             int hp = 69;
             int str = 420;

            //nu zou de statement hieronder moeten werken
            Console.WriteLine($"{name} {hp} {str}");
        }
    }

}