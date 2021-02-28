using System;

namespace Projet1
{
    class Program
    {

        

        static int DemanderAge()
        {
            int ageConvert = 0;
            while (ageConvert <= 0)
            {
                try
                {
                    Console.Write("Quel est ton age? ");
                    string TonAge = Console.ReadLine();
                    ageConvert = int.Parse(TonAge);

                    if (ageConvert <= 0)
                    {
                        Console.WriteLine("Erreur tu viens de taper un chiffre négatif ou égal à zéro");
                    }

                }

                catch
                {
                    Console.WriteLine("Erreur, vous devez rentrer un age valide.");
                }
                
            }
            return ageConvert;
        }

        static string DemanderNom()
        {
            string TonNom = "";

            while (TonNom == "")
            {

                Console.Write("Quel est ton nom? ");
                TonNom = Console.ReadLine();
                TonNom = TonNom.Trim();
                if (TonNom == "")
                {
                    Console.WriteLine("Erreur le champs est vide, veuillez écrire un prénom");
                }

            }
            return TonNom;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            //DEMANDER LE NOM
            string TonNom = DemanderNom();

            //DEMANDER L'AGE
            int ageConvert = DemanderAge();

            //AFFICHER LE MESSAGE
            ageConvert = ageConvert + 1;
            Console.WriteLine("Vous avez " + ageConvert + " ans et vous vous appelez " + TonNom);








        }
    }
}
