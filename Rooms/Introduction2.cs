using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Introduction2 : Room
    {
        internal override string CreateDescription() =>

@"30 minutes avant l'accident
Voulant passer le temps Maeva pose la question suivante:

Maeva: Imaginons que vous avez la posiblité de sauver une personne d'une situation dangereuse et cela vous inclus,
qui sauveriez-vous dans notre groupe? Pour ma part, je ne pourrais survivre sans William donc, il serait mon premier choix.

William: Oh, arrête tu vas me faire rougir Maeva! Eh bien, pour ma part, mon choix est déjà fait aussi.
Je sauverai la femme de ma vie et ce, avec tout le courage possible! Quand à vous, quel aurait été votre choix?

Josh: Honnêtement, plusieurs facteurs pourrait influencer mon choix,mais ce qui est sûr,
si la situation de vous sauver me mettrait en danger, je prendrais mes jambes à mon cou.

Lily: Eh bien, on voit que tu possèdes une grande bravoure Josh. 
Selon moi, j'essayerais d'aider tout le monde et non une seule personne.

Votre choix: 
[Lily]
[Groupe]
[Personne]
";  
        


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "Lily":
                    Console.WriteLine
 (@"Effet Papillon
                        
Tu dis que dans cette situation, la seule personne qui compterait à tes yeux seraient Lily et donc,
elle serait la personne que tu sauverais et ce, même si tu mets ta vie en jeu.
Celle-ci semble surprise mais, heureuse d'entendre cette réponse venant de votre part.

*Lily se souviendra de vos paroles.");
Game.Transition<Introduction3>();
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
