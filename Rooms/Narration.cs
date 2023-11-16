using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Narration : Room
    {
        internal override string CreateDescription() =>

@"... 
De la brume...
Encore de la brume...
Dans cette endroit avide, nul forme de vie semble y exister...
Tu t'es tellement aventuré dans cette univers sans fin que la notion du temps semble avoir disparu pour toi...
Pourtant, une figure au loin se forme...
Un mirage? Une illusion? Sans réponse tu décides de t'approccher de la silouhette...
[suite]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
                    Console.WriteLine("Inconnu: Hmm? Oh! De la compagnie! Il fut bien longtemps que j'en avais pas eu!");
                    
                    Console.WriteLine("                                                                                ");
                    
                    Console.WriteLine("* La personne que tu viens de rencontrer semble vraiment heureux de te voir." +
                        "En la regardant tu remarques que celle-ci n'est autre qu'un humain, mais principalement un homme.");

                    Console.WriteLine("                                                                                    ");
                    
                    Console.WriteLine("Inconnu: Pardonnez mon enthousiasme, " +
                        "cela fait des lustres que " +
                        " j'habite ces ténébres sans la moindre" +
                        " forme de vie. Mon nom est Kingsley et vous êtes... ?");
                   
                    Console.WriteLine("                                                                                     ");
                    
                    string name;
                    Console.Write("Votre nom: ");
                    name = Console.ReadLine();

                    
                    Console.WriteLine("Enchanté de faire votre connaissance " + name + " !");
                    
                    Console.WriteLine("                                                                                       ");
                    
                    Console.WriteLine("Kingsley: Cela est très bizarre que nous sommes les deux seuls personnes à être présents dans cette endroit." +
                        "Avez-vous le moindre souvenir de comment vous avez pu atterir ici?");

                    Console.WriteLine("                                                                                        ");

                    Console.WriteLine("* Tu lui réponds que ta mémoire semble vague et que tu n'as aucun souvenir de comment ni" +
                        "pourquoi tu es ici. La seule chose dont tu te rappelles est ton nom...");

                    Console.WriteLine("                                                                                         ");

                    Console.WriteLine("Kingsley: Hmm... Intriguant. Pour ma part, je ne pourrait point dire si nous sommes mort ou bien piéger" +
                        "dans une autre dimension, mais ce que je sais, c'est que ma mémoire semble avoir garder quelques souvenir de ma vie.");

                    Console.WriteLine("                                                                                                      ");

                    Console.WriteLine("Kingsley: Puisque vous êtes la première personne que je croise, laisser moi vous raconter une histoire de " +
                        "là où je viens, mais tout d'abord,laisser moi vous posez une question...");

                    Console.WriteLine("                                                                                                      ");

                    Console.WriteLine("Croyez-vous à l'effet papillon? Que l'impact d'un petit choix qu'on prend peut " +
                        "engendrer des effets incroyables sur le futur? [oui]/[non] ");

                    Console.WriteLine("Votre choix: ");

              
                    

                    break;
                    
                    
                
            }
        }
    }
}
