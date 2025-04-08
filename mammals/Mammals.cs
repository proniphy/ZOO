public abstract class Mammal : Animal
{
    public abstract bool IsWarmBlooded {get; } //Mammals are warm blooded
    public abstract string? Habitat {get; set;} //living habitat of an animal
    public abstract void MammalInformation(); //Basic mammal info
    public abstract void FeedWithBabyMilk();

    public Mammal(string name, DateTime birthDate, double weightInKg) : base (name,birthDate,weightInKg)
    {
    }
    
}