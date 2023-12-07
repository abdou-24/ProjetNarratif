using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Narration());
game.Add(new devinette());
game.Add(new Introduction());
game.Add(new Introduction2());
game.Add(new Introduction3());
game.Add(new Introduction_Fin());
game.Add(new Foret());
game.Add(new foretv2());
game.Add(new Milieu());
game.Add(new Milieu2());
game.Add(new Gauche());
game.Add(new Droite());
game.Add(new droite2());
game.Add(new Fin());
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new AtticRoom());



while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();