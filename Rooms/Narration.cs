using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
Console.WriteLine(
@"Inconnu: Hmm? Oh! De la compagnie! Il fut bien longtemps que j'en avais pas eu!

* La personne que tu viens de rencontrer semble vraiment heureux de te voir. 
En la regardant tu remarques que celle-ci n'est autre qu'un humain, mais principalement un homme. 

Inconnu: Pardonnez mon enthousiasme, cela fait des lustres que j'habite ces ténêbres sans la moindre forme de vie. 
Mon nom est Kingsley et vous êtes... ? 
");

string name;
Console.Write("Votre nom: ");
name = Console.ReadLine();

                    
Console.WriteLine($"Enchanté de faire votre connaissance {name} !");

Console.WriteLine("                                                                                       ");

Console.WriteLine(
@"Kingsley: Cela est très bizarre que nous sommes les deux seuls personnes à être présents dans cette endroit. 
Avez-vous le moindre souvenir de comment vous avez pu atterir ici?

* Tu lui réponds que ta mémoire semble vague et que tu n'as aucun souvenir de comment ni pourquoi tu es ici. 
La seule chose dont tu te rappelles est ton nom...

Kingsley: Hmm... Intriguant. Pour ma part, je ne pourrait point dire si nous sommes mort ou bien piéger
dans une autre dimension, mais ce que je sais, c'est que ma mémoire semble avoir garder quelques souvenir de ma vie.

Kingsley: Puisque vous êtes la première personne que je croise, laisser moi vous raconter une histoire de là où je viens, mais tout d'abord, laisser moi vous posez une question...

Croyez-vous à l'effet papillon? 
Que l'impact d'un petit choix qu'on prend peut engendrer des effets incroyables sur le futur? 

[oui]/[non]
");


 if ("oui" == Console.ReadLine())

 {
  Console.WriteLine("                                                 ");

 Console.WriteLine(
@"Hmm... Intéressant...
Il semblerait que vous êtes une personne qui prend des décisions avec délicatesse.
Peut-être qu'il vous est déjà arrivé des situations de ce type dans votre vie antérieure...
Mais enfin, voyons voir si vos choix concordent avec vos paroles..."
);
 }
 
 else

if ("non" == Console.ReadLine())

{
Console.WriteLine("                                                 ");

Console.WriteLine(
 @"Oh? Nous avons quelqu'un de brave de ce que je vois...
 Votre vie a sûrement du être remplis de bonheur et de chance pour que vous refusiez d'y croire.
Espérons que cette chance puisse vous continuez à vous suivre...
");
 }




                    

              
                    

                    break;
                    
                    
                
            }
        }
    }
}
