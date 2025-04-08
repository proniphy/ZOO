public abstract class Omnivore : Mammal, IEat
{
    public abstract string FavoriteFoods { get; set; }

    protected Omnivore(string name, DateTime birthDate, double weightInKg, string? habitat)
        : base(name, birthDate, weightInKg, true, habitat)
    {
    }

    public abstract void Eat();

    public override void ShowMammalInformation()
    {
        base.ShowMammalInformation();
        Console.WriteLine("This mammal is an omnivore.");
    }
}
public class Bear : Omnivore, ISleep, IRun
{
    public override string FavoriteFoods { get; set; } = "Berries, Fish, Honey";

    public Bear() : base("Bear", new DateTime(2015, 7, 21), 350, "Mountains") { }

    public override void Eat()
    {
        Console.WriteLine("The bear eats berries, fish, and sometimes small animals.");
    }

    public void Sleep()
    {
        Console.WriteLine("The bear hibernates during winter.");
    }

    public void Run()
    {
        Console.WriteLine("The bear runs surprisingly fast.");
    }
}
public class Pig : Omnivore, ISleep
{
    public override string FavoriteFoods { get; set; } = "Roots, Insects, Grains";

    public Pig() : base("Pig", new DateTime(2020, 1, 1), 100, "Farm") { }

    public override void Eat()
    {
        Console.WriteLine("The pig eats almost anything edible.");
    }

    public void Sleep()
    {
        Console.WriteLine("The pig naps frequently during the day.");
    }
}
public interface IEat
{
    string FavoriteFoods { get; set; }
    void Eat();
}

public interface ISleep
{
    void Sleep();
}

public interface IRun
{
    void Run();
}
public class OmnivoreDemo
{
    public static void RunDemo()
    {
        List<IEat> eaters = new List<IEat> { new Bear(), new Pig() };
        foreach (var eater in eaters)
        {
            eater.Eat();
        }

        List<ISleep> sleepers = new List<ISleep> { new Bear(), new Pig() };
        foreach (var s in sleepers)
        {
            s.Sleep();
        }

        List<IRun> runners = new List<IRun> { new Bear(), new Bear() }; 
        foreach (var r in runners)
        {
            r.Run();
        }
    }
}