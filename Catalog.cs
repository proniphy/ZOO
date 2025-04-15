using System;
using System.Diagnostics.CodeAnalysis;

class Catalog
{
    private AnimalCollection animals = new AnimalCollection();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void DisplayMammalCatalog()
    {
        List<Mammal> mammals = animals.GetAnimalsOfType<Mammal>();
        if (mammals.Any())
        {
            Console.WriteLine("Mammal Catalog: ");
            Console.WriteLine(Mammal.GetSpeciesInfo());
            foreach (var mammal in mammals)
            {
                mammal.ShowAnimalInformation();
            }
        }
        else
        {
            Console.WriteLine("Currently there are no mammals in this catalog.");
        }
    }

    public void DisplayBirdCatalog()
    {
        List<Bird> birds = animals.GetAnimalsOfType<Bird>();
        if (birds.Any())
        {
            Console.WriteLine("Bird Catalog: ");
            Console.WriteLine(Bird.GetSpeciesInfo());
            foreach (var bird in birds)
            {
                bird.ShowBirdInformation();
            }
        }
        else
        {
            Console.WriteLine("Currently there are no birds in this catalog.");
        }
    }

    public void DisplaySharkCatalog()
    {
        List<Shark> sharks = animals.GetAnimalsOfType<Shark>();
        if (sharks.Any())
        {
            Console.WriteLine("Shark Catalog: ");
            Console.WriteLine(Shark.GetSpeciesInfo());
            foreach (var shark in sharks)
            {
                shark.ShowAnimalInformation();
            }
        }
        else
        {
            Console.WriteLine("Currently there are no sharks in this catalog.");
        }
    }
}
