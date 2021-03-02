using System;

namespace Projet1
{
    class Program
    {

        //FONCTION AFFICHAGE MESSAGE
        static void afficherInfosPersonne(string nom, int age, float taille)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans");

            //Si l'age >= à 18 -> majeur sinon mineur

            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }

            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }

            else if (age >= 60) 
            {
                Console.WriteLine("Vous êtes sénior");
            }

            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }

            else if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }

            else
            {
                Console.WriteLine("Vous êtes mineur");
            }

            //taille de la personne
            Console.WriteLine("Vous faites " + taille + "m de hauteur ");
        }

        //FONCTION AGE
        static int DemanderAge(string nomPersonne)
        {
            int ageConvert = 0;
            while (ageConvert <= 0)
            {
                try
                {
                    Console.Write("Quel est l'age de " + nomPersonne + " ? ");
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


        //FONCTION PRÉNOM
        static string DemanderNom(int numeroPersonne)
        {
            string TonNom = "";

            while (TonNom == "")
            {

                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
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
            string TonNom1 = DemanderNom(1);
            string TonNom2 = DemanderNom(2);

            //DEMANDER L'AGE
            int ageConvert1 = DemanderAge(TonNom1);
            int ageConvert2 = DemanderAge(TonNom2);

            //AFFICHER LE MESSAGE METHODE DÉBUTANT
            //Console.WriteLine();
            //Console.WriteLine("Bonjour, vous vous appelez " + TonNom1 + ", vous avez " + ageConvert1 + " ans");
            // Console.WriteLine("bientôt vous aurez " + (ageConvert1+1) + " ans");

            //Console.WriteLine();
            //Console.WriteLine("Bonjour, vous vous appelez " + TonNom2 + ", vous avez " + ageConvert2 + " ans");
            //Console.WriteLine("bientôt vous aurez " + (ageConvert2 + 1) + " ans");

            //AFFICHER LE MESSAGE METHODE PRO
            afficherInfosPersonne(TonNom1, ageConvert1, 1.75f);
            afficherInfosPersonne(TonNom2, ageConvert2, 1.85f);

        }
    }
}
