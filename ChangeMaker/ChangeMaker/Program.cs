using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);
            ChangeAmount(222.22m);
            
            Console.ReadKey();
        }


        ///function will take any dollar amount and make change with quarters, dimes, nickels, and pennies in the most effecient way 
        /// <param name="chaChing">amount that you want split up into change</param>
        /// <returns></returns>
        public static Change ChangeAmount(decimal chaChing)
        {
            //when change is made how much of new coins will be returned "new"
            Change amountAsChange = new Change();

            
            Console.WriteLine("Amount: {0}", chaChing);


            //keeps looping through until the number reaches zero
            while (chaChing > 0)
            {
                //if the amount is higher then 25 cents  it will keep subtracting 25 cents until its below that number
                if (chaChing >= 0.25m)
                {
                    chaChing -= 0.25m;
                    amountAsChange.Quarters++;
                }
                //if number is above 10 cents, but below 25 cents it will subtract ten cents 
                else if (chaChing >= 0.10m)
                {
                    chaChing -= 0.10m;
                    amountAsChange.Dimes++;
                }
                else if (chaChing >= 0.05m)
                {
                    chaChing -= 0.05m;
                    amountAsChange.Nickles++;
                }
                else
                {
                    chaChing -= 0.01m;
                    amountAsChange.Pennies++;
                }
            }
            //TODO: Fill in the the code to make this function work

            Console.WriteLine("Quarters: {0}", amountAsChange.Quarters);
            Console.WriteLine("Dimes: {0}", amountAsChange.Dimes);
            Console.WriteLine("Nickles: {0}", amountAsChange.Nickles);
            Console.WriteLine("Pennies: {0}", amountAsChange.Pennies);
            Console.WriteLine("\n");

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        ///  property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        ///  property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        ///  property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        //public int hundreds { get; set; }
        //public int fiddies { get; set; }
        //public int twenties { get; set; }
        //public int tens { get; set; }
        //public int fivers { get; set; }
        //public int ones { get; set; }
        /// <summary>
        
        /// </summary>
        public Change()
        {
            //this.hundreds = 0;
            //this.fiddies = 0;
            //this.twenties = 0;
            //this.tens = 0;
            //this.fivers = 0;
            //this.ones = 0;
            
            
            
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
