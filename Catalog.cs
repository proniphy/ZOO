using System;
using System.Diagnostics.CodeAnalysis;

class Catalog
{
    private List<Mammal> mammalList = new List<Mammal>();
    private List<Bird> birdList = new List<Bird>();

    public void AddMammal(Mammal mammal)
    {
        mammalList.Add(mammal);
    }

    public void AddBird(Bird bird)
    {
        birdList.Add(bird);
    }

    public void DisplayMammalCatalog()
    {
        if (mammalList.Any())
        {
            Console.WriteLine("Mammal Catalog: ");
            Console.WriteLine(Mammal.GetSpeciesInfo());
            foreach (var mammal in mammalList)
            {
                mammal.ShowMammalInformation();
            }
        }
        else
        {
            Console.WriteLine("Currently there are no mammals in this catalog.");
        }
    }

    public void DisplayBirdCatalog()
    {
        if (birdList.Any())
        {
            Console.WriteLine("Bird Catalog: ");
            Console.WriteLine(Bird.GetSpeciesInfo());
            foreach (var bird in birdList)
            {
                bird.ShowBirdInformation();
            }
        }
        else
        {
            Console.WriteLine("Currently there are no birds in this catalog.");
        }
    }
}
