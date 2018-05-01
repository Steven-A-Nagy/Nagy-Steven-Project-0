using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsModels;
using BusinessLogic;
using NLog;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetLogger("file");
            Console.WriteLine("Local Gourmet App");
            Console.WriteLine("-----------------");

            string input = "";
            string howMuchInfo = "";
            string ordering = "";

            //List<Restaurant> restaurants = Restaurant.GetRestaurants();
            //List<Restaurant> restaurantsTemp = null;
            // Choose initial restaurant list
            while (input != "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Type [quit] at any time");
                Console.WriteLine("Do you want to view information from [all] " +
                    "restaurants, only the [top3], or [search] by name?");
                Console.WriteLine();
                Console.Write("<input> ");
                input = Console.ReadLine().ToLower();
                log.Info(input);
                while (input != "all" && input != "top3" && input != "search"
                    && input != "quit")
                {
                    Console.WriteLine($"[{input}] is invalid. Choose [all], [top3], [search] or [quit].");
                    Console.Write("<input> ");
                    input = Console.ReadLine().ToLower();
                    log.Info(input);
                }
            }
    }
}
