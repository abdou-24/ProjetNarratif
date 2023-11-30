using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Milieu2 : Room
    {
        internal override string CreateDescription() =>
@"Après 30 minutes, tu décides de sortir de ta cachette.
En sortant, tu apperçois des cadavres mutilés et déchictés
éparpillés partout sur le sol.
Comment une créature a pu vaincre autant de mercenaires armés?
Un grissement se fait entendre vers la tante du campement
Est-ce un piège? Devrais-je y aller?

Choix:
[oui]
[non]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "oui":
                    Console.WriteLine
(@"En entrant dans la tente, tu apperçois un enregistrement répété en boucle.
'À tous les chasseurs présents, ici votre commandant.
Les Wen.... sont présents sur le terrain, je répète les Wen.... sont présents sur le terrain.
Utiliser tout l'arsenal qu'il faut pour les éliminer , mais ramener moi à tout pris le cadavre du .....'
Fin de l'enregistrement.

Ils seraient donc, entrain de chasser quelqu'un ou quelque chose...
Mais pourquoi? Et puis il a mentionné un cadavre à rapporter...
Que peut-il bien se passer dans cette forêt?

Je devrais partir et continuer ma recherche pour trouver les autres...
" 
); Game.Transition<foretv2>();
                    break;
                
                    
                
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
