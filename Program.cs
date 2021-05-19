using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var chipsMachine = new ChipsMachine();
            while(!chipsMachine.checkTotal())
            {
                Console.WriteLine("Please Enter Coins (nickles(5 $),dimes(10 $)) or Quarters (15 $)");
                chipsMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }
            chipsMachine.DisplayDrinksSelections();
            Console.ReadLine();

        }
    }
}
