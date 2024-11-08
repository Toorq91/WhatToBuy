namespace WhatToBuy
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public double Rating { get; }

        public Product(string name, double price, double rating)
        {
            Name = name;
            Price = price;
            Rating = rating;
        }

        public int CalculateScore()
        {
            int score = 0;

            // Scoring based on price
            score += Price < 300 ? 10 : 5;

            // Scoring based on rating
            score += Rating >= 4.5 ? 10 : 5;

            return score;
        }
    }
}

