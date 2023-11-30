﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Milieu : Room
    {
        internal override string CreateDescription() =>
@"En arrivant sur les lieux tu aperçois un champ de bataille.
Des hommes armés d'armes à feux semblent tirer sur quelqu'un ou quelque chose.
Ce qui est sûr, c'est que leur adversaires ne semblent point leurs laisser de 
répis vu les cris poussés par ceux-ci. Après un long moment, un silence se ressentir 
aucun des mercenaires semblent être en vie. Peut être que leur ennemi a fuit?
Pourtant le stress que tu ressens te fait douter si tu devrais sortir de ta cachette.

Choix: 
[sortir]
[rester]";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "rester":
                    Console.WriteLine
                     (@"Ton instinct semble favoriser la sécurité avant tout.
Tu décides donc, d'attendre plusieurs minutes avant de sortir.");
                    Game.Transition<Milieu2>();
                    break;

                case "sortir":
                    Console.WriteLine
                    (@"Prenant ton courage à deux mains tu décides de sortir de ta cachette.
Cela fut une erreur fatale.
En face de toi, se trouve de nombreux cadavres et la créatures qui semblent les avoir tués.
Elle semblait se nourir d'un des cadavres jusqu'à ce que tu sortes de ta cachette.
Celle-ci se retourna immédiatement et te tua immédiatemment sur le coup.

Sur tes derniers moments, tu penses à tes amis et comment tu aurais voulu 
opter pour un autre choix...

Tu entends une dernière voix..
???: Il faut être fou pour pouvoir sortir avec une créature dans les parages...
Peut être que la PATIENCE pourrait t'aider..."
                                            );
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
