using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_Number_Processing_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program One: ACCUMULATION CALCULATOR
            //Initialize Values
            Decimal Deposit = 35.00m;
            Decimal yearlength = 365.25m;
            Decimal AnnualSum = Deposit * yearlength;

            //Program introduction
            Console.WriteLine("Welcome to the Deposit Accumulation Calculator");
            Console.WriteLine("Press ENTER to see how your $35 daily deposit will add up!");
            Console.ReadLine();

            Console.WriteLine("After one year the bank account will contain: $" + AnnualSum * 1);
            Console.WriteLine("After two years the bank account will contain: $" + AnnualSum * 2);
            Console.WriteLine("After five years the bank account will contain: $" + AnnualSum * 5);
            Console.WriteLine("After ten years the bank account will contain: $" + AnnualSum * 10);

            //Console.WriteLine("Note: I used decimals as the numeric type in this program to account for the cents and the leap year");
            Console.ReadLine();

            //Program Two: Land Cost Calculator
            // Initialize Values.
            int ParcelWidth = 0;
            int ParcelLength = 0;

            //Program introduction
            Console.WriteLine("Welcome to the Land Cost Calculator");

            // This allows user to set length and width.
            Console.WriteLine("What is the parcel width in feet?");
            ParcelWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the parcel length in feet?");
            ParcelLength = int.Parse(Console.ReadLine());

            //This divides length and width by three to convert from feet to yards, then calculates area. Next it multiplies by five to calculate cost per square yard
            Decimal LandCostSqYd = ((ParcelWidth / 3) * (ParcelLength / 3)) * 5;
            //This multiplies width by two to calculate for both sides, then multiplies length by two to calculate for top and bottom, then adds these values together.
            Decimal LandCostPerimeter = 0.75m * ((ParcelWidth * 2) + (ParcelLength * 2));

            // This calculates final total for cost of the parcel
            Console.WriteLine("This Parcel will cost $" + (LandCostSqYd + LandCostPerimeter));
            Console.ReadLine();


            //Program Three: SPACE EXPLORATION
            //Initialize Values
            double Velocity = 10000;
            int ThirtySecBurn = 10;
            int CaptBurn = 400;

            //Program introduction
            Console.WriteLine("Welcome to the Space Exploration Advisor!");
            Console.WriteLine("Press ENTER to calculate thruster burn sequences.");
            Console.ReadLine();

            for (Velocity = 10000; ThirtySecBurn > 0; ThirtySecBurn -= 1)
            {
                Console.WriteLine(Velocity = Velocity * 1.05);
            }

            Console.WriteLine("After a five minute burn, the spacecraft will be going " + (Velocity) + " MPH");
            Console.ReadLine();

            for (Velocity = 10000; CaptBurn > 0; CaptBurn -= 1)
            {
                Console.WriteLine(Velocity = Velocity * 1.05);
            }

            Console.WriteLine("After two hours of the Captain's burn sequence, the spacecraft will be going " + (Velocity) + " MPH");
            Console.ReadLine();

        }
    }
}