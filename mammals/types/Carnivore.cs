public interface IAnimal
{
    string Species { get; }
    void MakeSound();
}
public abstract class AbstractAnimalInfo : IAnimal
{
    public abstract string Species { get; }
    public abstract string DietType { get; }
    public abstract void MakeSound();
    public abstract void PrintSpecialInfo();

    public virtual string GetGeneralInfo() => "This is a carnivorous animal.";
}
public abstract class CarnivorousMammalBase : AbstractAnimalInfo
{
    public override string DietType => "Carnivore";

    public void DescribeHuntingStyle()
    {
        Console.WriteLine("This animal hunts meat.");
    }
}
public class Carnivore : CarnivorousMammalBase
{
    public override string Species { get; } = "Lion";

    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }

    public override void PrintSpecialInfo()
    {
        Console.WriteLine("Carnivores eat other animals. They're often top predators.");
    }

    public void Hunt()
    {
        Console.WriteLine($"{Species} is hunting...");
    }
}
public class ZooDemo1
{
    public static void Run()
    {
        List<AbstractAnimalInfo> carnivores = new List<AbstractAnimalInfo>
        {
            new Carnivore(),
            new Carnivore { }
        };

        foreach (var animal in carnivores)
        {
            Console.WriteLine(animal.GetGeneralInfo());
            animal.PrintSpecialInfo();
            animal.MakeSound();
        }
    }
}
public interface IHunt
{
    void Hunt();
}
public interface IMove
{
    void Move();
}
public class Wolf : IHunt, IMove
{
    public void Hunt() => Console.WriteLine("Wolf is hunting...");
    public void Move() => Console.WriteLine("Wolf is running...");
}

public class Tiger : IHunt, IMove
{
    public void Hunt() => Console.WriteLine("Tiger stalks and pounces on its prey...");
    public void Move() => Console.WriteLine("Tiger moves silently through the jungle...");
}
public class ZooDemo2
{
    public static void Run()
    {
        List<IHunt> hunters = new List<IHunt> { new Wolf(), new Tiger() };
        List<IMove> movers = new List<IMove> { new Tiger(), new Wolf() };
        List<object> both = new List<object> { new Wolf(), new Tiger() };

        Console.WriteLine("\n--- Hunters:");
        foreach (var h in hunters) h.Hunt();

        Console.WriteLine("\n--- Movers:");
        foreach (var m in movers) m.Move();
    }
}