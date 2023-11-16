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
@"Après de longues minutes de marche, tu tombes enfin sur la scènes du crimes
Des corps d'animaux éparpillés se retrouvent dans une marée de sang.
En t'approchant, tu remarques de plus près que ces animaux semblent avoir des blessures anormales.
Aucune bête ne pourrait infliger ce type de blessure à des animaux comme le loup,l'ours,le coyote et pourtant,
ceux-ci ne semblaient pas pouvoir se relever.

Pourtant, une autre chose capta ton attention
À travers le bain de sang, un autre coprs semblait se distinguer des autres.
Du sang était recouvert sur de nombreux endroits de son corps et sa nuque semblait avoir été brisée.
Il était très grand, avait des griffes et des dents pointus imbibées de sang. 
il était tellement mince qu'on voyait la majorité des os et sa composition corporelle ressemblait beaucoup à celle d'un humain...

Quelle était cette créature? Qui a pu causer ce carnage?
Tant de questions sans réponses...
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
