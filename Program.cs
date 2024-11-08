namespace WhatToBuy
{
    class Program
    {
        static void Main()
        {
            Product product1 = GetProductDetails(1);
            Product product2 = GetProductDetails(2);

            int score1 = product1.CalculateScore();
            int score2 = product2.CalculateScore();

            string recommendation = GetRecommendation(product1, score1, product2, score2);

            Console.WriteLine($"\nPoeng:");
            Console.WriteLine($"{product1.Name} Poeng: {score1}");
            Console.WriteLine($"{product2.Name} Poeng: {score2}");
            Console.WriteLine($"\n{recommendation}");
        }

        static Product GetProductDetails(int productNumber)
        {
            Console.WriteLine($"Skriv inn produkt {productNumber}:");

            Console.Write("Navn : ");
            string name = Console.ReadLine();

            Console.Write("Pris: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rating (1-5): ");
            double rating = Convert.ToDouble(Console.ReadLine());

            return new Product(name, price, rating);
        }

        static string GetRecommendation(Product product1, int score1, Product product2, int score2)
        {
            return score1.CompareTo(score2) switch
            {
                1 => $"{product1.Name} er det beste valget basert på poengene.",
                -1 => $"{product2.Name} er det beste valget basert på poengene.",
                _ => "Begge produktene har like poeng. Velg basert på preferanse!"
            };
        }
    }
}