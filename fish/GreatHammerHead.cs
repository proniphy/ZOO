class GreatHammerHead : HammerHead
{
    public override RedListCategory Endangerment
    {
        get => RedListCategory.CriticallyEndangered;
    }

    public static new string GetSpeciesInfo()
    {
        return """
            Great hammerhead sharks (Sphyrna mokarran) are the largest of the
            hammerhead species, known for their impressive size—often exceeding
            6m in length. They are swift, powerful predators found in tropical
            and warm-temperate waters, frequently seen patrolling reefs and
            continental shelves in search of prey like stingrays, bony fish,
            and smaller sharks. Unlike many other hammerheads, great hammerheads
            sometimes exhibit schooling behavior, and are considered an
            endangered species due to overfishing and finning.
            """;
    }

    public override string GetDerivedSpeciesInfo() => GetSpeciesInfo();
}