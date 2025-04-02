using System;
using System.Dynamic;

class Program
{
    static DateTime YearsInPastFromToday(int yearsToSubtract)
    {
        return DateTime.Today.Subtract(new TimeSpan(yearsToSubtract * 365, 0, 0, 0));
    }

    static void Main()
    {
        Catalog animalCatalog = new Catalog();

        animalCatalog.AddMammal(new Mammal(
            "Sealy the seal", YearsInPastFromToday(2), 80.0, true, "Arctic"
        ));

        while (true)
        {
            Console.WriteLine("Choose an option: \n1. Add an animal to the catalog \n2. View the catalogs \n3. Exit");
            string choice = GetStringInput("Enter your choice: ");

            if (choice == "3") break;

            if (choice == "1")
            {
                animalCatalog = GetCatalog(animalCatalog);
            }
            else if (choice == "2")
            {
                animalCatalog.DisplayMammalCatalog();
                animalCatalog.DisplayBirdCatalog();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }
        }
    }

    public static int GetIntInput(string message) //Function to get Int, also checks for correct input
    {
        int value;
        do
        {
            Console.Write(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value < 0);

        return value;
    }
    public static double GetDoubleInput(string message) //Function to get Int, also checks for correct input
    {
        double value;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out value) || value < 0);

        return value;
    }

    public static string GetStringInput(string message) //analog to GetIntInput for Strings.
    {
        string? value;
        do
        {
            Console.Write(message);
            value = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(value));

        return value;
    }

    public static Catalog GetCatalog(Catalog animalCatalog)
    {
        while (true)
        {
            string type = GetStringInput("Enter animal type (mammal/bird/exit): ").ToLower();

            if (type == "exit") break;

            string name = GetStringInput("Enter animal's name: ");
            int birthYear = GetIntInput("Enter animal's birth year: ");
            int birthMonth = GetIntInput("Enter animal's birth month (1-12): ");
            double weight = GetDoubleInput("Enter animal's weight: ");

            var birthDate = new DateTime(birthYear, birthMonth, 1);
            if (type == "mammal")
            {
                string habitat = GetStringInput("Enter animal's habitat: ");
                Mammal mammal = new Mammal(name, birthDate, weight, true, habitat);
                animalCatalog.AddMammal(mammal);
            }
            else if (type == "bird")
            {
                bool flying = GetStringInput("Can the bird fly? (yes/no): ") == "yes";
                Bird bird = new Bird(name, birthDate, weight, flying);
                animalCatalog.AddBird(bird);
            }
            else
            {
                Console.WriteLine("Invalid type. Please enter Mammal or Bird.");
            }
        }
        return animalCatalog;
    }
}