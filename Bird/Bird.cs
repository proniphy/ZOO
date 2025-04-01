class Bird : Animal
{
    public string Flying {get;set;}

    public Bird(string name, int age, int weight, string flying)
        : base(name, age, weight)
    {
        this.Flying=flying;
    }
}
