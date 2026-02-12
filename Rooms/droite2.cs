using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class droite2 : Room
    {
        internal override string CreateDescription() =>
@"Après plusieurs minutes de marche, tu tombes sur 
un grande base protégée par de nombreux hommes armés.
Un hélicoptère se fait entendre et commence à atterrir sur une zone dédiée.
D'autres mercenaires armés et un homme de grande taille y sortent et
se rend vers un bâtiment de la base.
Par la suite, de nombreux véhicules entrèrent dans la base et
soudains, tu aperçois ton groupe d'amis, et l'un d'entre eux,
menottés et cagoulés se dirigeant eux aussi vers le même bâtiment.
Il n'y a plus de raison à hésiter tu DOIS aller les sauver.
[suite]
";

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
