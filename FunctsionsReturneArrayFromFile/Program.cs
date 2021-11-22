using System;

namespace FunctsionsReturneArrayFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");

        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "tea", "fanta", "coffe", "cocacola", "cacao" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");

        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Harry Potter", "Avatar", "Avengers", "The Lion King", "Jurassic World" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");

        }


    }
}
