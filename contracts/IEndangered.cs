
namespace Zoo
{
    // Animal extinction threat levels based on the Red List of Threatened Species
    // classification by the International Union for Conservation of Nature
    public enum RedListCategory
    {
        DataDeficient,
        LeastConcern,
        NearThreatened,
        Vulnerable,
        Endangered,
        CriticallyEndangered,
        ExtinctInTheWild,
        Extinct,
    }

    public static class RedListCategoryExtension
    {
        public static string FriendlyName(this RedListCategory type)
        {
            switch (type)
            {
            case RedListCategory.DataDeficient:
                return "(DD) Data Deficient";
            case RedListCategory.LeastConcern:
                return "(LC) Least Concern";
            case RedListCategory.NearThreatened:
                return "(NT) Near Threatened";
            case RedListCategory.Vulnerable:
                return "(VU) Vulnerable";
            case RedListCategory.Endangered:
                return "(EN) Endangered";
            case RedListCategory.CriticallyEndangered:
                return "(CR) Critically Endangered";
            case RedListCategory.ExtinctInTheWild:
                return "(EW) Extinct in the Wild";
            case RedListCategory.Extinct:
                return "(EX) Extinct";
            default:
                return "(NE) Not Evaluated";
            }
        }
    }

    public interface IEndangered
    {
        public RedListCategory Endangerment { get; }
    }
}