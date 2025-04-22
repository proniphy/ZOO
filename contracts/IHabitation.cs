
namespace Zoo
{
    // List of possible natrual habitats our species can be native to
    public enum HabitatTypes
    {
        Desert,
        Island,
        Mountains,
        OceanAndCoast,
        PrarieAndSteppes,
        RiversAndLakes,
        Savanna,
        Scrubland,
        TemperateForestAndTaiga,
        TropicalRainforest,
        Tundra,
        Wetlands,
    }

    public static class HabitatTypesExtension
    {
        public static string FriendlyName(this HabitatTypes type)
        {
            switch (type)
            {
            case HabitatTypes.Desert:
                return "Desert";
            case HabitatTypes.Island:
                return "Island";
            case HabitatTypes.Mountains:
                return "Mountains";
            case HabitatTypes.OceanAndCoast:
                return "Ocean and Coastline";
            case HabitatTypes.PrarieAndSteppes:
                return "Prarie and Steppes";
            case HabitatTypes.RiversAndLakes:
                return "Rivers and Lakes";
            case HabitatTypes.Savanna:
                return "Savanna";
            case HabitatTypes.Scrubland:
                return "Scrubland";
            case HabitatTypes.TemperateForestAndTaiga:
                return "Temperate Forest and Taiga";
            case HabitatTypes.Tundra:
                return "Tundra";
            case HabitatTypes.Wetlands:
                return "Wetlands";
            default:
                return "Unknown habitat";
            }
        }
    }

    // Implemented by animals that have a native habitat
    public interface IHabitation
    {
        public HabitatTypes NativeHabitat { get; }
    }
}
