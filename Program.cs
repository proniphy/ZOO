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

        animalCatalog.AddAnimal(new Snake(
            "Snakey the snake", YearsInPastFromToday(2), 80.0, HabitatTypes.Tundra, null, 0, false
        ));
        animalCatalog.AddAnimal(new Bird(
            "Polly the parrot", YearsInPastFromToday(1), 1.0, HabitatTypes.TropicalRainforest
        ));

        var harry = new GreatHammerHead();
        harry.Name = "Harry the hammerhead";
        harry.BirthDate = YearsInPastFromToday(5);
        harry.Weight = 300.0;
        harry.NativeHabitat = HabitatTypes.OceanAndCoast;
        harry.GillCount = 12;
        harry.Length = 6.0;
        harry.FinCount = 7;
        animalCatalog.AddAnimal(harry);

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
                animalCatalog.DisplaySharkCatalog();
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

    public static string? GetOptionalString(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            // Coerce empty string to null
            return null;
        }
        return input;
    }

    public static HabitatTypes GetHabitatInput(string prompt)
    {
        string? input;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            bool ignoreCase = true;
            Enum.TryParse(typeof(HabitatTypes), input, ignoreCase, out object? result);
            if (result is not HabitatTypes)
            {
                Console.WriteLine("Unrecognized habitat type, the following are valid options:");
                foreach (HabitatTypes type in Enum.GetValues<HabitatTypes>())
                {
                    Console.WriteLine($"  {type}");
                }
            }
            else
            {
                return (HabitatTypes)result;
            }
        }
    }

    public static DateTime GetDateInput(string prompt)
    {
        Console.WriteLine(prompt);
        int year;
        while (true)
        {
            Console.Write("- Enter year: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int y) && y > 0)
            {
                year = y;
                break;
            }
        }
        int month;
        while (true)
        {
            Console.Write("- Enter month (1-12): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int m) && m > 0 && m <= 12)
            {
                month = m;
                break;
            }
        }
        int day;
        int maxDay = DateTime.DaysInMonth(year, month);
        while (true)
        {
            Console.Write($"- Enter day (1-{maxDay}): ");
                        string? input = Console.ReadLine();
            if (int.TryParse(input, out int d) && d > 0 && d <= maxDay)
            {
                day = d;
                break;
            }
        }
        return new DateTime(year, month, day);
    }

    public static Catalog GetCatalog(Catalog animalCatalog)
    {
        while (true)
        {
            string type = GetStringInput("Enter animal type (mammal/bird/exit): ").ToLower();

            if (type == "exit") break;

            string name = GetStringInput("Enter animal's name: ");
            DateTime birthDate = GetDateInput("Enter the animal's birth date: ");
            double weight = GetDoubleInput("Enter animal's weight: ");
            HabitatTypes habitat = GetHabitatInput("Enter the animal's habitat: ");
            string? origin = GetOptionalString("Enter the region of origin (Optional): ");

            /* TODO to be fixed with new classes
            if (type == "mammal")
            {
                Mammal mammal = new Mammal(name, birthDate, weight, habitat, origin);
                animalCatalog.AddAnimal(mammal);
            }
            else if (type == "bird")
            {
                bool flying = GetStringInput("Can the bird fly? (yes/no): ") == "yes";
                Bird bird = new Bird(name, birthDate, weight, habitat, origin, flying);
                animalCatalog.AddAnimal(bird);
            }
            else
            {
                Console.WriteLine("Invalid type. Please enter Mammal or Bird.");
            }
            */
        }
        return animalCatalog;
    }
}