
// Implemented by animals that can be adopted (financially supported) by a person
public interface IAdoptable
{
    // Animals can start with no adopter but can be later (re-)adopted
    public string? Adopter { get; }

    public void Adopt(string? newAdopter);
}