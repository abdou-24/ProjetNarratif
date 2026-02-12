using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Introduction3 : Room
    {
        internal override string CreateDescription() =>
@"20h30
Après de longues minutes de route, William mentionne que vous êtes bientôt arrivé à la destination.
Maeva et Lily, heureuses, semblent déjà prévoir les activités qu'elles vont faire. 
Quant à Josh, celui-ci semble fatigué et veut simplement dormir.
Soudainement, une figure se vit au loin malgré les nombreux flocons.
William arrêta la voiture et pourtant la mystérieuse figure semble se rapprocher.
De plus en vite… Comme si quelqu'un courait… Mais, à une vitesse anormale...
Stressant de la menace, William décide de faire marche arrière le plus vite qu'il peut,
mais cela semblait trop tard.
[suite]
";           
      

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
                    Game.Transition<Introduction_Fin>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
            
        }
    }
}
