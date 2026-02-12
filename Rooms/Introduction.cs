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
19h30... 1h avant l'accident...
Tu te réveilles dans la voiture avec tes 4 amis: Josh, William, Maeva et Lilly.
Vous roulez en direction du chalet que vous posssédez pour profiter de vos vacances comme à chaque année.

William, étant conducteur, te demande de lui [passer] une de ses bières préférées situées dans la boite à coté de toi.
Maeva qui en est fan aussi en demande une aussi et Josh semble point intéressé à cette idée.
Ta copine, Lilly, quand à elle, te chuchote que tout cela est une mauvaise idée et que tu devrais [refuser].


";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "passer":
                    Console.WriteLine
 (@"Effet Papillon
                        
Tu dis à Lilly qu'elle s'inquiète beacoup trop et tu décides de passer pas une, mais plusieurs bouteilles à Maeva et William. 
Il n'a fallu que quelque minutes pour que Wiliam perd le contrôle et fasse un accident tuant tout le monde.
 Cette événement se répendit partout dans votre ville et dorénavant de nombreuses restrictions et règles ont été instaurées pour la conduite au volant.");
                   
 Console.WriteLine("                                                                                         ");
                        
                    Console.WriteLine
 (@"Lors de votre enterrement, parmis les nombreuses voix et les pleures, tu entends une voix familière te parler.
???: Ah..., je croyais tu avais appris de tes erreurs... N'y avait-il pas une PERSONNE qui s'était opposé à ce choix?
Quelle triste et courte fin...");
 Game.Finish();
                    break;
                
                
                
                case "refuser":
 Console.WriteLine(@"Effet papillon

D'un ton ferme, tu leurs rappelles que nous sommes toujours en déplacement 
et qu'il ne faudrait pas aller vers les problèmes si on peut les éviter.
Ils te regardent d'un air déçu et disent qu'ils pensaient que tu étais plus cool que ça
Tu ignores le commentaire car, qui sait, un accident aurait pu se produire...  ");
Game.Transition<Introduction2>();
break;
                
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
