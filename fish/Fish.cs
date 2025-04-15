/// <summary>
/// Base class for all aquatic, gill-bearing vertebrates
/// </summary>
public abstract class Fish : Animal
{
    /// <summary>
    /// True if species belongs to the Gnathostomata infraphylum
    /// </summary>
    public virtual bool IsJawed { get => false; }

    /// <summary>
    /// True if species belong to the Osteichthyes class
    /// </summary>
    public virtual bool IsBony { get => false; }

    /// <summary>
    /// True if species belongs to Actinopterygii class
    /// </summary>
    public virtual bool IsRayFinned
    {
        get => isRayFinned;
        set {
            if (value && !IsBony)
            {
                throw new ArgumentException("Only bony fish can be ray-finned");
            }
            if (value && IsLobeFinned)
            {
                throw new ArgumentException("Cannot be both lobe-finned and bone-finned");
            }
            isRayFinned = value;
        }
    }
    protected bool isRayFinned = false;

    /// <summary>
    /// True if species belongs to Sarcopterygii class
    /// </summary>
    public virtual bool IsLobeFinned
    {
        get => false;
        set {
            if (value && !IsBony)
            {
                throw new ArgumentException("Only bony fish can be lobe-finned");
            }
            if (value && IsRayFinned)
            {
                throw new ArgumentException("Cannot be both lobe-finned and bone-finned");
            }
            isLobeFinned = value;
        }
    }
    protected bool isLobeFinned = false;

    /// <summary>
    /// Number of swimming fins the species has in total
    /// </summary>
    public virtual uint FinCount
    {
        get => finCount;
        set {
            if (value < 1)
            {
                throw new ArgumentException("Fish must have at least 1 fin");
            }
            finCount = value;
        }
    }
    protected uint finCount = 0;

    /// <summary>
    /// Numeber of gill openings the species has in total. Most bony fish have
    /// a single gill opening on each side (2 in total), but some species, such
    /// as sharks and lampreys possess multiple gill openings per side.
    /// </summary>
    public virtual uint GillCount
    {
        get => gillCount;
        set {
            if (value < 1)
            {
                throw new ArgumentException("Fish must have at least one gill opening");
            }
            gillCount = value;
        }
    }
    protected uint gillCount = 0;

    /// <summary>
    /// Fish length (in meters)
    /// </summary>
    public virtual double Length
    {
        get => 0;
        set {
            if (value <= 0)
            {
                throw new ArgumentException("Length must be a positive value");
            }
            length = value;
        }
    }
    protected double length = 0;

    public override HabitatTypes NativeHabitat
    {
        get => base.NativeHabitat;
        set {
            if (value != HabitatTypes.OceanAndCoast
                && value != HabitatTypes.RiversAndLakes
                && value != HabitatTypes.Wetlands)
            {
                throw new ArgumentException("Invalid habitat for Fish");
            }
            base.NativeHabitat = value;
        }
    }

    public override string GetAnimalInformation()
    {
        string info = base.GetAnimalInformation();
        info += IsJawed ? "It is a jawed, " : "It is a jawless, ";
        info += IsRayFinned ? "ray-finned, " : "";
        info += IsLobeFinned ? "lobe-finned, " : "";
        info += IsBony ? "bony fish, " : "cartilaginous fish, ";
        info += $"with {finCount} fins and {gillCount} gills and length {length} m. ";
        return info;
    }
}