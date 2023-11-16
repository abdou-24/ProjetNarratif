using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Introduction : Room
    {
        internal override string CreateDescription() =>
@"31 Décembre 2009...
19h30... 20 minutes avant l'accident...



";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "droite":
                    Console.WriteLine("Après avoir rmarqué les traces de pas, tu te dis.");
                    Game.Transition<Droite>();
                    break;
                case "porte":
                    if (!AtticRoom.isKeyCollected)
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    else
                    {
                        Console.WriteLine("Tu ouvres la porte avec ta clé et tu sors de ta chambre.");
                        //Game.Transition<LivingRoom>();
                    }
                    break;
                case "gauche":
                    Console.WriteLine("Tu montes dans le grenier.");
                    Game.Transition<Gauche>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
