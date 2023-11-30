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
Selon moi, la peur prendrait le dessus et je ne pourrait être capable d'aider quelqu'un dans une telle situation
,mais ce qui est sûr, je connais quelqu'un qui viendrait à mon secours.

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
 (@"Tu dis que dans cette situation, la seule personne qui compterait à tes yeux serait Lily et donc,
elle serait la personne que tu sauverais et ce, même si tu mets ta vie en jeu.
Celle-ci semble heureuse d'entendre votre réponse et décide te donner un bisou en retour.

*Lily se souviendra de vos paroles.");
Game.Transition<Introduction3>();
                    break;



case "Groupe":
Console.WriteLine
(@"Hésitant vraiment sur le choix, tu n'arrives pas à prendre une personne et oublier les autres
Donc, tu dis à tout le monde que le choix serait beaucoup trop difficile à faire et
que tu essayerais de sauver tout le monde puisque de ton point vue, chaque personne compte et ce peut importe les différences.

*Le groupe apprécie et se souviendra de ta réponse honnête.");
                    Game.Transition<Introduction3>();
                    break;

case "Personne":
Console.WriteLine
(@"*Effet Papillon

N'ayant pas de honte, tu mentionnes que sauver potentiellement une vie pour ,
en contrepartie, peut-être, perdre la sienene serait une action stupide. Tu dis donc, que tu ne sauverais personne
et que tu prioriserait ta survie avant celle des autres.

Tout le groupe , à part Josh, semble abasourdis de ta réponse, mais ta copine, Lily, semble la plus contrariée
et déçue de ta réponse
");
                    Game.Transition<Introduction3>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }

    
            
    }
}
