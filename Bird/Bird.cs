class Bird : Animal 
{
    public bool Flying {get;set;}

    public Bird(string name, int age, bool flying, double weight) : base(name, age, weight)
    {
        this.Flying=flying;
    }

    public void ShowBirdInformation()
    {
        string canFly = Flying ? "It can fly." : "It can't fly.";
        Console.WriteLine($"{base.ShowAnimalInformation()}. {canFly}");
    }
}