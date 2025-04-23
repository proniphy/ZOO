
namespace Zoo.Fish
{
    class HammerHead : Shark, IEndangered
    {
        public static new string GetSpeciesInfo()
        {
            return """
                Hammerhead sharks are a fascinating group of sharks easily recognized
                by the distinctive hammer-shaped extension of their heads, called a
                cephalofoil. This unique head shape enhances their vision and allows
                them to better detect electrical signals from prey. Found in warm
                temperate and tropical waters worldwide, these apex predators
                primarily feed on fish, squid, and crustaceans, playing a vital
                role in maintaining healthy marine ecosystems.
                """;
        }

        public override string GetDerivedSpeciesInfo() => GetSpeciesInfo();
    }
}
