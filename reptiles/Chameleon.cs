class Chameleon : Reptile, ICamouflaging
{
    public Chameleon(string name, DateTime birthDate, double weight, HabitatTypes habitat,
        string? origin)
        : base(name, birthDate, weight, habitat, origin, 4, true)     // Chameleons can only have 4 legs and can lay eggs.
    {
    }

    public override void Vocalize()
    {
        Console.WriteLine($"{Name} makes soft clicking sounds and hisss");
    }

    public override void GetAnimalInformation()
    {
        string info = $"    This animal is named: {Name}, it is {AgeInYears} years old, " +
            $"it weighs {Weight} kg and is native to the {NativeHabitat.FriendlyName()} habitat. \n" + 
            $"  1. It's a color-shifting chameleon. While most people think chameleons change color only to blend into their environment, \n" +
            "they actually do it to communicate emotions like aggression, fear, or readiness to mate. Temperature and light also influence the change. \n" +
            "   2. A chameleon's tongue can be up to twice the length of its body and can launch out at lightning speed—up to 0.07 seconds—to snatch insects with sticky precision. \n" +
            "   3. Chameleons have independently rotating eyes—each eye can move in a different direction. This gives them a full 360° field of vision \n" +
            "and precise depth perception for spotting prey. \n";
        if (!string.IsNullOrEmpty(RegionOfOrigin))
        {
            info += $" It was captured from the region {RegionOfOrigin}. ";
        }
        return info;
    }

    public void Camouflage()
    {
        Console.WriteLine($"{Name} blends into the surroundings.");
    }
}