using System.Dynamic;

class Animal
{
    public string Name { get; set; }
    public int Age { get; private set; }
    public int Weight {get; private set; }

    public Animal(string name, int age, int weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight= weight;
    }
}