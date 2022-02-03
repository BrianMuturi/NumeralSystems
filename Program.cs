using System;

namespace NumeralSystems
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            MainProgram();

            void MainProgram()
            {
                Console.WriteLine("Type a number:");
                string input = Console.ReadLine();
                try
                {
                    NumberSystem numberSystem;
                    if (input[0] == '0' && input[1] != 'x' && input[1] != 'X' && input[1] != ',')   
                    {
                        numberSystem = new Octal(input);
                    }
                    else if (input[1] == 'x' || input[1] == 'X') 
                    {
                        numberSystem = new Hexadecimal(input);
                    }
                    else 
                    {
                        numberSystem = new Decimal(input);
                    }
                    numberSystem.ShowResults();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                LoopOfMainProgram();
            }
            
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("Do you want to Convert another number?  Type 'yes' or 'no'");
                    string answer = Console.ReadLine();
                    if (answer != "no")
                    {
                        if (answer == "yes") { Console.Clear(); MainProgram(); break; }
                        else Console.WriteLine("Wrong answer");
                    }
                    else { Environment.Exit(0); break; }
                }
            }
        }
    }
}
