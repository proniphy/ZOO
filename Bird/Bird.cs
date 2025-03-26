class Bird : Animal 
{
    public string Flying {get;set;}
    public Bird(string name, int age, string flying) : base(name, age)
    {
        this.Flying=flying;
    }
}