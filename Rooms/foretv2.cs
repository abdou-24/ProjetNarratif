using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class foretv2 : Room
    {
        internal override string CreateDescription() =>
@"Tu es revienu à l'endroit où il y a eu l'accident pour explorer les autres chemins 
Trois chemins s'offrent à toi

Un vers la [droite] où des traces de pas ont été laissées
Un autre vers la [gauche] où des troncs d'arbres sacagés se retrouvent éparpillés sur le sol
Pour finir, un vers le [milieu] où des cris se font entendre.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "droite":
                    Console.WriteLine("Après avoir remarqué les traces de pas, tu te dis que tes amis se sont sûrement rendu là-bas.");
                    Console.WriteLine("Tu décide donc, de te rendre vers le chemin de droite.");
                    Game.Transition<Droite>();
                    break;
                case "gauche":
                    Console.WriteLine("Malgré les decombres qui se trouve devant toi, tu sembles plus curieux sur ce qui s'est passé plutôt que sur ce qui t'attend. ");
                    Console.WriteLine("Tu décide donc, de te rendre vers le chemin de gauche.");
                    Game.Transition<Gauche>();
                    break;
                case "milieu":
                    Console.WriteLine("En entendant ces cris, tu penses directement à tes amis? Que se passe-t-il? Sont-ils en danger?" +
                        "Pas le temps de se poser des questions. ");
                    Console.WriteLine("Tu décide donc, de te rendre vers le chemin du milieu.");
                    Game.Transition<Milieu>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
