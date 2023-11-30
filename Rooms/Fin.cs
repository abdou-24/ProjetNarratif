using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Fin : Room
    {
        internal override string CreateDescription() =>
@"Voici la fin pour la première version de ce jeu.
Il se peut que trouver des fautes de frappe, des bugs lors de votre test 
donc, n'hésiter pas à les mentionner. De plus, si vous avez des idées qui pourrait améliorer mon jeu,
il me fera plaisir de les entendre. Je continuerai à améliorer ce jeu pour obtenir la meilleure version
et surtout concevoir les meilleurs fins (car oui il y aura plusieurs fins!) en réponse de vos actions.

Merci beaucoup!

Abdoulaye
[fin]
";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "fin":
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }


        }
    }
}
