
namespace Zoo
{
    // Static interface for getting a summary of the info about the given species class
    interface ISpeciesInfo
    {
        public abstract static string GetSpeciesInfo();

        // Must be overridden for each leaf class that defines a `GetSpeciesInfo`,
        // to allow for calling from interface references
        public abstract string GetDerivedSpeciesInfo();
    }
}
