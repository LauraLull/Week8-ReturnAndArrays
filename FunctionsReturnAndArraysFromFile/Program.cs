﻿using System;

namespace FunctionsReturnAndArraysFromFile
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
            string[] foods = { "Chicken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}.");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Apple juice", "Coke", "Fanta", "Sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}.");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "'Die Hard'", "'The Boy in the Striped Pajamas'", "'The Wolf of Wall Street'", "'Gladiator'", "'The Lord of the Rings'" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}.");
        }
    }
}
