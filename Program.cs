﻿using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Narration());
game.Add(new Introduction());
game.Add(new Introduction2());
game.Add(new Foret());
game.Add(new Milieu());
game.Add(new Gauche());
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new AtticRoom());
game.Add(new foretv2());


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