using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    //----------------------------------------------
    // Title: Cost of Flooring
    // Application: Console
    // Description: Calculate the cost for flooring
    // Author: Zak
    // Date Created: 9/19/2019
    //----------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variable
            //
            string widthString;
            string lengthString;
            string costFoot;
            string room1Name = "Living Room";
            double room1Length, room1Width;
            double room1CostSqFoot;
            double room1Area;
            double room1Cost;

            string width2String;
            string length2String;
            string cost2Foot;
            string room2Name = "Kitchen";
            double room2Length, room2Width;
            double room2CostSqFoot;
            double room2Area;
            double room2Cost;


            double totalArea;
            double totalCost;


            //------------------------
            // - Greeting -
            //------------------------
            Console.WriteLine();
            Console.Write("Hello User");
            Console.WriteLine();

            //----------------------------
            // - Description -
            //----------------------------
            Console.WriteLine();
            Console.Write("I'm here to help you calculate the cost of flooring for your Living room and Kitchen.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            //-------------------------------
            // - Ask for Measurements -
            //-------------------------------
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your first room.");
            lengthString = Console.ReadLine();
            room1Length = double.Parse(lengthString);
            Console.Write("\tThe length is " + room1Length + " feet.");

            Console.WriteLine();
            Console.WriteLine("And what is the width of your first room?");
            widthString = Console.ReadLine();
            room1Width = double.Parse(widthString);
            Console.Write("\tThe width is " + room1Width + " feet.");

            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            costFoot = Console.ReadLine();
            room1CostSqFoot = double.Parse(costFoot);
            Console.Write("\tThe cost per square foot is " + room1CostSqFoot + " dollars.");


            //----------------------------------
            // - Second Room -
            //----------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your second room.");
            length2String = Console.ReadLine();
            room2Length = double.Parse(length2String);
            Console.Write("\tThe length is " + room2Length + " feet.");

            Console.WriteLine();
            Console.WriteLine("And what is the width of your second room?");
            width2String = Console.ReadLine();
            room2Width = double.Parse(width2String);
            Console.Write("\tThe width is " + room2Width + " feet.");

            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost2Foot = Console.ReadLine();
            room2CostSqFoot = double.Parse(cost2Foot);
            Console.Write("\tThe cost per square foot is " + room2CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();


            //---------------------------------
            // - Display flooring cost by room -
            //---------------------------------

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("\t\tFlooring Cost By Room.");
            Console.WriteLine();

            //--------------------------
            // - Display Table Headers -
            //--------------------------

            Console.WriteLine(
            "Room".PadRight(15) +
            "Length".PadLeft(10) +
            "Width".PadLeft(10) +
            "Area".PadLeft(10) +
            "Cost/SqFt".PadLeft(15) +
            "Cost".PadLeft(10)
             );
            Console.WriteLine(
            "----".PadRight(15) +
            "------".PadLeft(10) +
            "-----".PadLeft(10) +
            "----".PadLeft(10) +
            "---------".PadLeft(15) +
            "----".PadLeft(10)
            );

            //---------------------------
            // - Calculate Table Values -
            //---------------------------
            room1Area = room1Length * room1Width;
            room1Cost = room1Area * room1CostSqFoot;
            room2Area = room2Length * room2Width;
            room2Cost = room2Area * room2CostSqFoot;
            totalArea = room1Area + room2Area;
            totalCost = room1Cost + room2Cost;

            //-------------------------
            // - Display Table Values -
            //-------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
            room1Name.PadRight(15) +
            room1Length.ToString("f").PadLeft(10) +
            room1Width.ToString("f").PadLeft(10) +
            room1Area.ToString("f").PadLeft(10) +
            room1CostSqFoot.ToString("c").PadLeft(15) +
            room1Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room2Name.PadRight(15) +
            room2Length.ToString("f").PadLeft(10) +
            room2Width.ToString("f").PadLeft(10) +
            room2Area.ToString("#.###").PadLeft(10) +
            room2CostSqFoot.ToString("c").PadLeft(15) +
            room2Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
                "------".PadLeft(45) +
                "------".PadLeft(25)
                );

            Console.WriteLine(
            "Total".PadLeft(5) +
            totalArea.ToString("f").PadLeft(40) +
            totalCost.ToString("c").PadLeft(25)
            );


            //
            //Pause For User
            //
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Thank you for using my application.");
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();



        }
    }
}