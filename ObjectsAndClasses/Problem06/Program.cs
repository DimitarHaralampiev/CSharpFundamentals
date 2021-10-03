using System;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product",
                "Best product of its category.",
                "Exceptional product.",
                "I cant't live without this product."
            };

            string[] events = new[]
            {
                "Now i feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now i feel awesome.",
                "Try it yourself, I am very satisfield.",
                "I feel great!"
            };

            string[] author = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                rnd.Next(0, phrases.Length);
                rnd.Next(0, events.Length);
                rnd.Next(0, author.Length);
                rnd.Next(0, cities.Length);

                Console.WriteLine($"{phrases[i]} {events[i]} {author[i]} - {cities[i]}");
            }
        }
    }
}
