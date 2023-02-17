using System;
using System.Collections.Generic;

namespace Lists_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main List
            List<string> games = new List<string>
            {
                "Fortnite",
                "Saints Row IV",
                "Goddess of Victory:NIKKE",
                "Team Fortress 2",
                "Left 4 Dead 2"
            };
            
            // Other List
            string[] otherGames = new string[]
            {
                "COD Black Ops",
                "COD Black Ops II"
            };

            // Writes Each String in List to the Console
            foreach(string game in games)
            {
                Console.WriteLine(game);
            }

            // Counts Each Individual String and prints the total to the Console.
            Console.WriteLine($"\n Games in list: {games.Count}");

            // Adds Other list to the total
            games.AddRange(otherGames);

            // Recounts and Prints the new total to the console
            Console.WriteLine($"\n Games in list: {games.Count}");

            // Checks for a String with the word Halo
            if (games.Contains("Halo"))
            {
                // Prints Message if Word Exists
                Console.WriteLine("\nMASTER CHEIF IS IN THE HOUSE!");

            // When Word doesn't Exist
            }else
            {
                // Adds new Word to List
                games.Add("Halo");
            }

            // Integer
            int myInt = 6;

            // Checks if Game count is Higher
            if(myInt < games.Count)
            {
                // Removes the last Element from the list at that Index
                games.RemoveAt(myInt);
            }

            // When Game doesn't exist at Index
            else
            {
                // Writes Message to Console
                Console.WriteLine("\nGame not found!");
            }

            // Shows all games in the list
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sorts the List
            games.Sort();

            // Shows the sorted list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            
            // New List
            string[] newList = new string[games.Count];

            // Copys Main list to New List
            games.CopyTo(newList);

            // Clears the Main List
            games.Clear();

            // Writes to the Console
            Console.WriteLine("\nNew List:");

            // Checks for each game in New List
            foreach(string game in newList)
            {
                // Shows all games in New List
                Console.WriteLine(game);
            }
        }
    }
}
