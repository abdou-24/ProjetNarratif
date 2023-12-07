using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class devinette : Room
    {
       
        internal override string CreateDescription() =>
@"Tu es encore dans tes pensées et tu entends une autre vois 
???: Une âme espérant retrouver son passé.. 
Pour cela, vous devrez répondre à une énigme!
[suite]
";

       
        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice)
            {
                case "suite":
                    {
                        Console.WriteLine(
@"???: Je suis un endroit qui peut être monter ou descendu en été ou en hiver..
");


                        string choix = Console.ReadLine();
                        if ("montagne" == choix)

                        {
                            Console.WriteLine(" Vous êtes dignes de passer!");

                            Game.Transition<Introduction>();
                            break;
                        }
                        else
                            Console.WriteLine("Mauvaise Réponse!");
                        Console.WriteLine("Deuxième indice, je peut être recouvert de neige tout comme de verdure");
                        choix = Console.ReadLine();
                        if ("montagne" == choix)

                        {
                            Console.WriteLine(" Vous êtes dignes de passer!");

                            Game.Transition<Introduction>();
                            break;
                        }

                        else
                            Console.WriteLine("Faux!");
                        Console.WriteLine("Dernière chance, les athlètes pratiquant le ski et snowboards peuvent me descendre.");
                        choix= Console.ReadLine();
                        if ("montagne" == choix)

                        {
                            Console.WriteLine(" Vous êtes dignes de passer!");

                            Game.Transition<Introduction>();
                            break;
                        }
                        else
                            Console.WriteLine("Faux! Votre âme restera avec moi pour l'éternité!!");
                        Game.Finish();

                    }
                    break;

                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }


        }
    }
}
