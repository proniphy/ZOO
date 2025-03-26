using System.Dynamic;

class Animal
{
    private int age;
    private int weight;
    public string Name { get; set; }
    public int Age
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
    public int Weight
    {
        get {return weight;}
        private set
        {
            if(weight<0)
                Console.WriteLine("Animal can't weigh less than 0 kg.");
            else if(weight>100)
                Console.WriteLine("Animals can't weigh over 4500 kg.");
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
    
    public void ShowAnimalName()
    {
        Console.WriteLine($"The animal's name is: {Name}");
    }
    public void ShowAnimalInformation()
    {
        Console.WriteLine($"This animal is: {Name}, it's age is {Age} and it weighs {Weight}");
    }
}