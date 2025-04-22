
public interface INamed
{
    public string Name { get; }

    public void Rename(string newName);

    public void ShowAnimalName()
    {
        Console.WriteLine($"This animal is named: '{Name}'");
    }
}
