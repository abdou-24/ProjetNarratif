using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Introduction_Fin : Room
    {
        internal override string CreateDescription() =>
@"En un instant la voiture fut portée et envoyée dans les airs.
Elle entra en collision avec plusieurs arbres avant d'atterir.
La douleur était incroyable et tu arrivais à peine bouger.
Du sang commença à couler sur ton front et et des vertiges se firent ressentir.
Tu essayes d'appeler à l'aide.
Aucune réponse...
[suite]"; 
     

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
                    Game.Transition<Foret>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
           
            
        }
    }
}
