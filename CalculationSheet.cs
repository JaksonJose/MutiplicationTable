using System;

namespace CalcTable
{
    class CalculationSheet : ConvertLetter
    {
        /* this class receive the number and the operation choosed and relize it. */
        private int Number;

        public string SetLetter 
        {
            set
            {
                this.OptionChosen = value;
                SelectOperation(this.OptionChosen);
            }
                
        }

        public int SetNumber
        {
            set
            {
                this.Number = value;
                Calculate();
            }
        }
        private void Calculate()
        {
            int count = 0;
            int tableLength = 10;
            int result = 0;
            string operatorSign = "";

            switch (this.OptionChosen)
            {
                case "divide":
                    tableLength = this.Number * 10;
                    break;
                case "sub":
                    tableLength = this.Number + 10;
                    break;
            }

            while (count < tableLength)
            {
                count = (this.OptionChosen == "divide") ? count + this.Number : count + 1;

                switch (this.OptionChosen)
                {
                    case "sum":
                        operatorSign = "+";
                        result = this.Number + count;
                        break;
                    case "sub":
                        operatorSign = "-";
                        result = count - this.Number;
                        break;
                    case "multiply":
                        operatorSign = "*";
                        result = this.Number * count;
                        break;
                    case "divide":
                        operatorSign = ":";
                        result = count / this.Number;
                        break;
                }

                if (this.OptionChosen == "sum" | this.OptionChosen == "myltiply")
                {
                    Console.WriteLine($"{this.Number} {operatorSign} {count,2:D} = {result,2}");
                }
                else if (result >= 0)
                {
                    Console.WriteLine($"{count,2:D} {operatorSign} {this.Number} = {result,2:D}");
                }
            }  
        }
    }
}
