using System.Linq;
//using LINQ;


List<string> videoGames = new List<string>()
{
    
    "Doom Eternal",
    "Super Mario Galaxy",
    "Call of Duty Black Ops 2",
    "Halo Master Chief Collection",
    "Vanquish",
    "Sunset Overdrive",
    "Trepang2",
    "Mario Kart",
    "Ultrakill",
    "Monster Hunter Rise"
    
};


var orderedGames = videoGames.OrderBy(game => game.Length).ToList();


Console.WriteLine("Here are my favorite video games in order: ");

foreach (var game in orderedGames)
{
    Console.WriteLine(game);
}