using System;

namespace CalcTable
{
    class ConvertLetter
    {
        /* This class converts the letter typed to a word related to operation */
        protected string OptionChosen;

        protected string SelectOperation(string optionSelected)
        {

            switch (this.OptionChosen)
            {
                case "a":
                    optionSelected = "sum";
                    Console.WriteLine($"Estou aqui {OptionChosen}");
                    break;
                case "s":
                    optionSelected = "sub";
                    break;
                case "m":
                    optionSelected = "multiply";
                    break;
                case "d":
                    optionSelected = "divide";
                    break;
            }

            return  OptionChosen = optionSelected;
        }
    }
}
