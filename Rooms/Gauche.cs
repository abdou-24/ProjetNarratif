using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Gauche : Room
    {
        internal override string CreateDescription() =>
@"Après de longues minutes de marche, tu tombes enfin sur la scène du crime.
Des corps d'animaux éparpillés se retrouvent dans une marée de sang.
En t'approchant, tu remarques de plus près que ces animaux semblent avoir des blessures anormales.
Aucune bête ne pourrait infliger ce type de blessure à des animaux comme le loup, l'ours, le coyote, et pourtant, 
ceux-ci ne semblaient pas pouvoir se relever.

Pourtant, une a
À travers le bain de sang, un autre corps semblait se distinguer des autres.
Du sang était recouvert sur de nombreux endroits de son corps et sa nuque semblait avoir été brisée.
Il était très grand, avait des griffes et des dents pointues imbibées de sang. 
Il était tellement mince qu'on voyait la majorité des os et sa composition corporelle ressemblait beaucoup à celle d'un humain...

Quelle était cette créature? Qui a pu causer ce carnage?
Tant de questions sans réponses...
[retour]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "retour":
                    Console.WriteLine("N'ayant rien trouvé de plus, tu décides de retourner sur tes pas.");
                    Game.Transition<foretv2>();
                    break;
        
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
