using System;
using System.Diagnostics.CodeAnalysis;

namespace Zoo
{
    class Catalog
    {
        private AnimalCollection animals = new AnimalCollection();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void DisplayMammalCatalog()
        {
            var mammals = animals.GetAnimalsOfType<Mammals.Mammal>();
            if (mammals.Any())
            {
                Console.WriteLine("Mammal Catalog: ");
                Console.WriteLine(Mammals.Mammal.GetSpeciesInfo());
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
            var birds = animals.GetAnimalsOfType<Birds.Bird>();
            if (birds.Any())
            {
                Console.WriteLine("Bird Catalog: ");
                Console.WriteLine(Birds.Bird.GetSpeciesInfo());
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
            var sharks = animals.GetAnimalsOfType<Fish.Shark>();
            if (sharks.Any())
            {
                Console.WriteLine("Shark Catalog: ");
                Console.WriteLine(Fish.Shark.GetSpeciesInfo());
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
}
