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
Dans cet endroit avide, nulle forme de vie ne semble y exister...
Tu t'es tellement aventuré dans cet univers sans fin que la notion du temps semble avoir disparu pour toi...
Pourtant, une figure au loin se forme...
Un mirage? Une illusion? Sans réponse, tu décides de t'approcher de la silhouette…
[suite]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "suite":
Console.WriteLine(
@"Inconnu: Hmm? Oh! De la compagnie! Il fut bien longtemps que j'en avais pas eu!

* La personne que tu viens de rencontrer semble vraiment heureuse de te voir. 
En la regardant, tu remarques que celle-ci n'est autre qu'un humain, mais principalement un homme.. 

Inconnu: Pardonnez mon enthousiasme, cela fait des lustres que j'habite ces ténèbres sans la moindre forme de vie. 
Mon nom est Kingsley et vous êtes… ? 
");

string name;
Console.Write("Votre nom: ");
name = Console.ReadLine();

                    
Console.WriteLine($"Enchanté de faire votre connaissance {name} !");

Console.WriteLine("                                                                                       ");

Console.WriteLine(
@"Kingsley: C'est très bizarre que nous soyons les deux seules personnes à être présentes dans cet endroit. 
Avez-vous le moindre souvenir de comment vous avez pu atterrir ici?

* Tu lui réponds que ta mémoire semble vague et que tu n'as aucun souvenir de comment ni pourquoi tu es ici. 
La seule chose dont tu te rappelles est ton nom...

Kingsley: Hmm... Intriguant. Pour ma part, je ne pourrais point dire si nous sommes morts ou bien piégés.
dans une autre dimension, mais ce que je sais, c'est que ma mémoire semble avoir gardé quelques souvenirs de ma vie.

Kingsley: Puisque vous êtes la première personne que je croise, j’aimerais bien vous raconter une histoire. Avant cela, pourriez-vous répondre à cette question ?
");
 while (true)
 {
Console.WriteLine(
@"Croyez-vous à l'effet papillon? 
Que l'impact d'un petit choix qu'on prend peut engendrer des effets incroyables sur le futur? 

[oui]/[non]
");


                        string choix = Console.ReadLine();
 if ("oui" == choix)

 {
  Console.WriteLine("                                                 ");

 Console.WriteLine(
@"Hmm... Intéressant...
Il semblerait que vous êtes une personne qui prend des décisions avec délicatesse.
Peut-être qu'il vous est déjà arrivé des situations de ce type dans votre vie antérieure...
Mais enfin, voyons voir si vos choix concordent avec vos paroles...

Sur ces dernières paroles, tu sens tes paupières devenir lourdes et la fatigue prendre le dessus.
Ne pouvant plus résister, tu t'endors immédiatement..."
); Game.Transition<devinette>();
 break;
 }
 
 else

if ("non" == choix)

{
Console.WriteLine("                                                 ");

Console.WriteLine(
 @"Oh? Nous avons quelqu'un de brave, de ce que je vois...
 Votre vie a sûrement dû être remplie de bonheur et de chance pour que vous refusiez d'y croire.
Espérons que cette chance puisse continuer à vous suivre...

Sur ces dernières paroles, tu sens tes paupières devenir lourdes et la fatigue prendre le dessus.
Ne pouvant plus résister, tu t'endors immédiatement...
");Game.Transition<devinette>();
break;
 }
}


                    break;
                    
                    
                
            }
        }
    }
}
