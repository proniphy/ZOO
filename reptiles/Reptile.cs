class Reptile : Animal
{
    private int legs;
    private string habitat;
    public int legs
    {
        get {return legs;}
        private set
        {
            if(legs<0)
            {
                Console.WriteLine("A reptile cannot have less than 0 legs.");
            } else
            {
                legs=value;
            }
        }
    }
    public string? Habitat
    {
        get {return habitat;}
        private set {havitat=value;}
    }
    public Reptile(string name, DateTime birthDate, double weight, int legs, string habitat) : base(name, birthDate, weight)
    {
        this.Legs = legs;
        this.Habitat = habitat;
    }
    public void Sunbathe()
    {
        Console.WriteLine("The Reptile is sunbathing currently...");
        Console.WriteLine("This is done so that the reptile regulates its internal temperature.");
    }
    public static void InformationAboutReptiles()
    {
        Console.WriteLine("1. The reptiles are air-breathing vertebrates.");
        Console.WriteLine("2. The reptiles' skin is either made up of bony plates or scales. ");
        Console.WriteLine("3. There are many types of reptiles, such as lizards, tortoises, turtles, snakes and many more.");
        Console.WriteLine("4. Important dearure is that reptiles cannot regulate their body temperature internally.");
        Console.WriteLine("5. Most reptiles reproduce via laying eggs, however, some give birth to their offspring.");
    }
}