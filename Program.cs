namespace WhatToBuy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter details for Product 1:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();

            Console.Write("Price: ");
            double price1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rating (1-5): ");
            double rating1 = Convert.ToDouble(Console.ReadLine());

            Product product1 = new Product(name1, price1, rating1);

            Console.WriteLine("Enter details for Product 2:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Price: ");
            double price2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rating (1-5): ");
            double rating2 = Convert.ToDouble(Console.ReadLine());

            Product product2 = new Product(name2, price2, rating2);

            int score1 = product1.CalculateScore();
            int score2 = product2.CalculateScore();

            string recommendation;

            switch (score1.CompareTo(score2))
            {
                case 1:
                    recommendation = $"{product1.Name} is the better choice based on score.";
                    break;
                case -1:
                    recommendation = $"{product2.Name} is the better choice based on score.";
                    break;
                default:
                    recommendation = "Both products have similar scores. Choose based on preference!";
                    break;
            }

            Console.WriteLine($"\nScores:");
            Console.WriteLine($"{product1.Name} Score: {score1}");
            Console.WriteLine($"{product2.Name} Score: {score2}");
            Console.WriteLine($"\n{recommendation}");
        }
    }
}