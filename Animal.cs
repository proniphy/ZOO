using System.Dynamic;

class Animal
{
    private int age;
    public string Name { get; set; }
    public int Age { get; private set; }
    public int Weight 
    {
        get {return age;}
        private set
        {
            if(age<0)
                Console.WriteLine("Animal can't be under age of 0 years.");
            else if(age>100)
                Console.WriteLine("Animals can't be over the age of 150 years.");
            else   
                Age=value;
        } 
    }
    public Animal(string name, int age, int weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight= weight;
    }
}