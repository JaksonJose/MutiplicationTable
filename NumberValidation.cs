using System;
using System.Text;
namespace CalcTable
{
    class NumberValidation
    {
        public int NumberChoosed()
        {
            var dashedLine = new StringBuilder();
            dashedLine.Append('-', 60);


            Console.Write("Type the number you want to make the operatiions: ");
            string option = Console.ReadLine();

            int number = (!string.IsNullOrEmpty(option)) ? Convert.ToInt32(option) : 1 ;

            Console.WriteLine(dashedLine);

           return number;
        }
    }
}
