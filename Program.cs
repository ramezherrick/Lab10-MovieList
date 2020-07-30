using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Lab10_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y"; string input;
            int number;

            List<string> alphorder = new List<string>() { };

            List<MovieClass> MovieList = new List<MovieClass>() { };

            MovieList.Add(new MovieClass("star wars", "scifi"));
            MovieList.Add(new MovieClass("The ring", "horror"));
            MovieList.Add(new MovieClass("Forest Gump", "drama"));
            MovieList.Add(new MovieClass("Cast Away", "drama"));
            MovieList.Add(new MovieClass("Toy Story", "animated"));
            MovieList.Add(new MovieClass("The terminal", "drama"));
            MovieList.Add(new MovieClass("Bridge of spies", "drama"));
            MovieList.Add(new MovieClass("The exorcism of emily rose", "horror"));
            MovieList.Add(new MovieClass("The matrix", "scifi"));
            MovieList.Add(new MovieClass("The lion king", "animated"));

            Console.WriteLine("Welcome to the Movie List Application!\n");

            Console.WriteLine($"There are {MovieList.Count} movies in this list.\n");

            Console.WriteLine("Enter (1) for drama");
            Console.WriteLine("Enter (2) for horror");
            Console.WriteLine("Enter (3) for animated");
            Console.WriteLine("Enter (4) for scifi");

            while (cont == "y")
            {
                Console.Write("\nWhat category are you interested in? ");

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("invalid entry - What category are you interested in? ");
                }

                //1 Point: Standardize the category codes by displaying a menu of categories and
                //having the user select the category by number rather than entering the name.
                while (true)
                {

                    if (1 <= number && number <= 4)
                    {
                        if (number == 1)
                        {
                            input = "drama";
                            break;
                        }
                        else if (number == 2)
                        {
                            input = "horror";
                            break;
                        }
                        else if (number == 3)
                        {
                            input = "animated";
                            break;
                        }
                        else if (number == 4)
                        {
                            input = "scifi";
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("invalid entry - What category are you interested in? ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("invalid entry - What category are you interested in? ");
                        }
                    }

                }

                //1 Point: Display the movies for the selected category in alphabetical order.
                // created alphorder list + clear it from previous run + populated it + sort it + print it
                alphorder.Clear();

                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Category == input)
                    {
                        alphorder.Add(MovieList[i].Title);
                    }
                }

                alphorder.Sort();

                for (int i = 0; i < alphorder.Count; i++)
                {
                    Console.WriteLine(alphorder[i]);
                }

                cont = Continue("Continue? (y/n): ");
            }

        }
        public static string Continue(string str)
        {
            string input = "y";
            bool condition = true;
            while (condition)
            {
                Console.Write(str);
                input = Console.ReadLine().ToLower();

                if (input == "y" || input == "n")
                {
                    condition = false;
                }
            }
            return input;
        }
    }
}
