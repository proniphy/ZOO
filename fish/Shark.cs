public class Shark : Fish, ISpeciesInfo
{
    // All sharks are jawed, cartilaginous fish that are neither ray-finned, nor lobe-finned
    public override bool IsJawed => true;
    public override bool IsBony => false;
    public override bool IsRayFinned => false;
    public override bool IsLobeFinned => false;

    public override uint GillCount
    {
        get => base.GillCount;
        set {
            if (value < 10 || value > 14)
            {
                throw new ArgumentException("Sharks can have only 5 to 7 gills per side");
            }
            base.GillCount = value;
        }
    }

    public override uint FinCount
    {
        get => base.FinCount;
        set {
            if (value < 6)
            {
                throw new ArgumentException("Sharks have at least 6 fins");
            }
            base.FinCount = value;
        }
    }

    public static string GetSpeciesInfo()
    {
        return """
            Sharks are ancient, cartilaginous fish with over 500 diverse species
            inhabiting oceans worldwide. As apex predators, they play a vital
            role in maintaining healthy marine ecosystems by regulating other
            populations. Unfortunately, many shark species are currently
            threatened due to overfishing, habitat loss, and accidental capture,
            highlighting the need for conservation efforts.
            """;
    }
}