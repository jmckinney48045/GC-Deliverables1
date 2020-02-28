using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kind of vacation would you like to go on, musical, tropical, or adventurous? ");
            string vacationType = Console.ReadLine();

            Console.Write("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());

            string vacationDest = "";
            string travelSugg = "";

            if (groupSize <= 2)
                travelSugg = "first class";
            if (groupSize >= 3 && groupSize <= 5)
                travelSugg = "helicopter";
            if (groupSize >= 6)
                travelSugg = "charter flight";

            switch (vacationType)
            {
                case "tropical": vacationDest = ("a beach vacation in Mexico"); break;
                case "musical": vacationDest = ("New Orleans"); break;
                case "adventurous": vacationDest = ("go whitewater rafting on the Grand Canyon"); break;

            }

            string result = "Since you have a group of " + groupSize + " and would like a(n) " + vacationType + " type of vacation, "
                             + "you should travel by " + travelSugg + " to " + vacationDest + ".";
           
            Console.WriteLine(result);


        }


    }

}
