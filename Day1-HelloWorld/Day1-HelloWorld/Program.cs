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
                string name =Console.ReadLine();
                Console.Write("what is your Age?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Hello" + " " + name + "!" + "Your Age is: " + age);
                //Console.WriteLine("Name is :{0} /t Age is: {1}",name,age);
                Console.ReadKey();
            }

        }

    }

}