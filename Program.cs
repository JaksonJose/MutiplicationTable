using System;
using System.Text;

namespace CalcTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var dashedLine = new StringBuilder();
            dashedLine.Append('-', 60);

            /*this will print out the message to user choose one Math Operation */
            var printOption = new LetterOptionValidation();
            string operationChosed = printOption.Print();
            
            
            /* this will print out the message to user choose one number */
            var chooseNumber = new NumberValidation();
            int number = chooseNumber.NumberChoosed();

            /* This will print out the Multiplication Table on screen */
            var calculation = new CalculationSheet();
            calculation.SetLetter = operationChosed;
            calculation.SetNumber = number;
            
            Console.WriteLine(dashedLine);
        }
    }
}
