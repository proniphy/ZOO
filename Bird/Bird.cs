class Bird : Animal
{
    public bool Flying {get;set;}

    public Bird(string name, DateTime birthDate, double weightInKg, bool flying)
        : base(name, birthDate, weightInKg)
    {
        this.Flying=flying;
    }

    public void ShowBirdInformation()
    {
        string canFly = Flying ? "It can fly." : "It can't fly.";
        Console.WriteLine($"{base.ShowAnimalInformation()}. {canFly}");
    }
}