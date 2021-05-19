using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine
{
    class ChipsMachine
    {
        const int COST_OF_ITEMS = 50;
        public int runningTotal { get; set; }

        public ChipsMachine()
        {
            runningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            //the only entries are 5,10,15
            switch(money)
            {
                case (5):
                    runningTotal += 5;
                    break;
                case (10):
                    runningTotal += 10;
                    break;
                case (15):
                    runningTotal += 15;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public bool checkTotal()
        {
            if(runningTotal>COST_OF_ITEMS)
                return true;
            else
                return false;
        }

        public void DisplayDrinksSelections()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("* C - Cola   *");
            Console.WriteLine("* H - Chips  *");
            Console.WriteLine("* D - Candy  *");
            Console.WriteLine("*****************");
            Console.WriteLine();
            Console.WriteLine("Please make your selection");
            makeCokeSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void makeCokeSelection(char selection)
        {
            bool selectionOk = false;
            while(!selectionOk)
            {
                switch (selection)
                {
                    
                    case 'C' :
                        Console.WriteLine("Thank you for choosing Coke");
                        selectionOk = true;
                        returnChange();
                        break;
                    case 'H':
                        Console.WriteLine("Thank you for choosing Chips");
                        selectionOk = true;
                        returnChange();
                        break;
                    case 'D':
                        Console.WriteLine("Thank you for choosing Candy");
                        selectionOk = true;
                        returnChange();
                        break;
                    default:
                        Console.WriteLine("Invalid selection, Please reenter your selection");
                        selection= Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOk = false;
                        break;
                            
                }
            }
        }

        private void returnChange()
        {
            if(runningTotal>COST_OF_ITEMS)
            {
                Console.WriteLine("Your change is {0:C}", runningTotal - COST_OF_ITEMS);
            }
        }


    }
}
