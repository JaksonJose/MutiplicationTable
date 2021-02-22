using System;
using System.Text;

namespace CalcTable
{
    class LetterOptionValidation
    {
        public string Print()
        {
            bool letterValid = false;
            string letter = "";

            var dashedLine = new StringBuilder();
            dashedLine.Append('-', 60);

            while (letterValid == false)
            {
                Console.Write("What kind of calculation do you want? \n[A] to Sum \n[S] to Subtraction \n[M] to Multiply \n[D] to Divide \nType a letter related with the operation you want: ");
                letter = Console.ReadLine().ToLower();
                Console.WriteLine(dashedLine);

                switch (letter)
                {
                    case "a":
                        letterValid = true;
                        break;
                    case "s":
                        letterValid = true;
                        break;
                    case "m":
                        letterValid = true;
                        break;
                    case "d":
                        letterValid = true;
                        break;
                    default:
                        Console.WriteLine($"ERROR!!! Type an valid option...");
                        Console.WriteLine(dashedLine);
                        break;
                }               
            }

            return letter;
            
        }
    }
}
