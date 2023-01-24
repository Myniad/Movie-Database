using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }

        //constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
        public string GetDetails()
        {
            return $"-{Title}";
        }


        public static bool GetContinue(string msg)
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine($"{msg} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    Console.WriteLine("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }

        //public static bool GetSelection()
        //{
        //    while (true)
        //    {

        //    }
        //}








    }


}
