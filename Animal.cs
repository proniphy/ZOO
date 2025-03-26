class Animal
{
    public string Name { get; set; }
    public int Age { get; private set; }
    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}