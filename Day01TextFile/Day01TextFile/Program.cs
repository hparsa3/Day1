using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



namespace SaveToFileTAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ?");
            string Name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            // Console.ReadKey();
            StreamWriter sw = new StreamWriter("D:\\john abbott\\Application Development I\\AppDev1\\Day1\\Day01TextFile\\Test.txt");
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine(Name);
            }
            sw.Close();
            //******************
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("D:\\john abbott\\Application Development I\\AppDev1\\Day1\\Day01TextFile\\Test.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}