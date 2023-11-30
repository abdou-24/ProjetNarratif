using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Droite : Room
    {
        internal override string CreateDescription() =>
@"En suivant le chemin des traces de pas, tu repenses à plusieurs choses.
Pourquoi tout cela te semble familier? L'accident, tes amis disparus...
On dirait un rêve sans fin... Comme si tu étais coincé à l'intérieur...
Est-ce votre cerveau qui vous joue des tours?
Enfin, ce n'est pas le moment de penser à ça...
Tes amis sont peut être en danger et il ne faut pas trainer...
[suite]";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
                    Game.Transition<droite2>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
