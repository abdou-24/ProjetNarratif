using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Base : Room
    {
        internal override string CreateDescription() =>;
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
                    Game.Transition<Fin>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
