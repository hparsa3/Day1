using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Day01Helloworld

{

    namespace ConsoleApp1

    {

        internal class Program

        {

            static void Main(string[] args)

            {

                Console.Write("what is your name?");

                string name = Console.ReadLine();

                Console.WriteLine("Hello" + " " + name + "!");

                Console.ReadKey();

            }

        }

    }

}