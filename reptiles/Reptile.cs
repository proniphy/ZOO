namespace reptile
{
    public abstract class Reptile : Animal
    {
        private int legs = 4;
        public virtual int NumberOfLegs 
        {   
            get{return legs;}
            set{
                if (value < 0 || value > 4)
                {
                    Console.WriteLine("Reptile cannot have fewer than 0 legs. Setting legs to 0.");
                    legs=0;
                }
                else
                {
                    legs=value;
                }
            }
        } 
        public bool IsColdBlooded { get; } = true;
        public bool LaysEggs { get; set; }

        public virtual double PreferredTemperature {get; set;} = 30.0;
        
        protected Reptile(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string? origin, int numberOfLegs, bool laysEggs) 
            : base(name, birthDate, weightInKg, habitat, origin)
        {
            this.NumberOfLegs = numberOfLegs;
            this.LaysEggs = laysEggs;
        }

        public virtual void Sunbathe()
        {
            Console.WriteLine("The Reptile is sunbathing currently...");
            Console.WriteLine("This is done so that the reptile regulates its internal temperature.");
        }

        public void ShowAnimalClassInformation()
        {
            Console.WriteLine("1. The reptiles are air-breathing vertebrates.");
            Console.WriteLine("2. The reptiles' skin is either made up of bony plates or scales. ");
            Console.WriteLine("3. There are many types of reptiles, such as lizards, tortoises, turtles, snakes and many more.");
            Console.WriteLine("4. Important dearure is that reptiles cannot regulate their body temperature internally.");
            Console.WriteLine("5. Most reptiles reproduce via laying eggs, however, some give birth to their offspring.");
        }

        public abstract void Vocalize();
        public virtual void DisplayDefenceMechanism()
        {
            Console.WriteLine("The Reptile is trying to make itself look bigger and starts hissing.");
        }
    }
}