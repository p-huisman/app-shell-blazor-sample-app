namespace CatalogApp.Models;

class RobotCatalog
{
    private readonly Dictionary<string, Robot> _robots;

    public RobotCatalog()
    {
        _robots = new()
        {
            {
                "jerry",
                new(
                    "Jerry",
                    3000,
                    Quality.New,
                    "Fully-configurable food processing bot",
                    "https://robohash.org/Jerry?set=set2"
                )
            },
            {
                "mia",
                new(
                    "Mia",
                    2350,
                    Quality.Functioning,
                    "Discrete finite automaton",
                    "https://robohash.org/Mia?set=set2"
                )
            },
            {
                "quentin",
                new(
                    "Quentin",
                    1300,
                    Quality.Salvage,
                    "Parallel task processor",
                    "https://robohash.org/Quentin?set=set2"
                )
            },
            {
                "lonie",
                new(
                    "Lonie",
                    1700,
                    Quality.Functioning,
                    "Secured terraforming drone",
                    "https://robohash.org/Lonie?set=set2"
                )
            },
            {
                "maximo",
                new(
                    "Maximo",
                    750,
                    Quality.Salvage,
                    "Versatile droid with unbeatable performance",
                    "https://robohash.org/Maximo?set=set2"
                )
            }
        };
    }

    public Robot Get(string name) => _robots[name];

    public IEnumerable<Robot> GetRobots() => _robots.Values;
}
