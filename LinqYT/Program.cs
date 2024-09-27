using System.Xml.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqYT
{
    internal class Program
    {
        // LINQ(Language Integrated Query) är ett sätt att hantera och
        // fråga efter data i.NET, liknande hur du skriver SQL-frågor
        // för databaser.
        //
        // Det låter dig skriva frågor direkt i C# för att hämta,
        // filtrera, och sortera data från olika källor, som listor,
        // arrays, eller databaser.
        //
        // LINQ gör det enklare och mer läsbart att arbeta med data
        // genom att använda metoder som...
        // .Where(), .Select(), och .OrderBy().

        static void Main(string[] args)
        {
            // Where ===================================================
            int[] numbers = { 1, 2, 3, 4, 5 };

            // IEnumerable Interface gör det möjligt att använda Foreach!
            IEnumerable<int> evenNumbers = numbers
                .Where(n => n % 2 == 0);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number); // Skriver ut 2 och 4
            }
            // Nu har vi sparat resultatet som en List<int> istället
            // för en IEnumerable<int>, vilket kan vara användbart om
            // vi vill ha funktionaliteten som finns i en lista,
            // som tillgång till element via index.
            List<int> evenNumbersList = numbers
            .Where(n => n % 2 == 0)
            .ToList();

            Console.WriteLine("-------------------");

            // Select ===================================================
            // Select - funktionen i LINQ används för att transformera
            // varje element i en samling till något annat.
            // Den låter dig skapa en ny samling genom att utföra en viss
            // operation på varje objekt i den ursprungliga samlingen.
            var people = new List<Person>
            {
                new Person { Name = "Anna", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };

            var names = people.Select(p => p.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name); // Skriver ut "Anna", "Bob"
            }

            Console.WriteLine("-------------------");

            // Order By =================================================
            int[] numbersNotSOrted = { 5, 3, 8, 1, 2 };
            var sortedNumbers = numbersNotSOrted.OrderBy(n => n);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number); // Skriver ut 1, 2, 3, 5, 8
            }

            Console.WriteLine("-------------------");

            // Count =================================================
            int[] numbersCount = { 1, 2, 3, 4, 5, 6 };
            var count = numbersCount.Count(n => n > 3);

            // Skriver ut 3 (4, 5, 6 är större än 3)
            Console.WriteLine(count);

            Console.WriteLine("-------------------");

            Console.ReadLine();
        }
    }
}
