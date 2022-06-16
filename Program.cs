List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

IEnumerable<Eruption> chileEruptions = eruptions.Where(c => c.Location == "Chile");
PrintEach(chileEruptions, "Chile eruptions.");

IEnumerable<Eruption> hawaiianEruptions = eruptions.Where(c => c.Location == "Hawaiian Is").Take(1);
PrintEach(hawaiianEruptions, "Hawaiian eruptions.");

IEnumerable<Eruption> nzEruptions = eruptions.Where(c => c.Location == "New Zealand"|| c.Year>1900).OrderBy(c=>c.Year).Take(1);
PrintEach(nzEruptions, "New Zealand eruptions.");

IEnumerable<Eruption> evEruptions = eruptions.Where(c => c.ElevationInMeters > 2000);
PrintEach(evEruptions, "Greater than 2000m");

int maxEruptions = eruptions.Max(c=>c.ElevationInMeters);
System.Console.WriteLine(maxEruptions+"max");

IEnumerable<Eruption> highestEruptions = eruptions.Where(c => c.ElevationInMeters == maxEruptions);
PrintEach(highestEruptions, "Highest eruption.");

IEnumerable<Eruption> allEruptions = eruptions.OrderBy(c=>c.Volcano);
PrintEach(allEruptions, "All eruptions.");

IEnumerable<Eruption> ceEruptions = eruptions.Where(c => c.Year < 1000).OrderBy(c=>c.Volcano);
PrintEach(ceEruptions, "Before 1000 CE eruptions.");