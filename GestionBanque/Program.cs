using System;

namespace GestionBanque
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CompteCourant compteCourantDeNicolas = new CompteCourant("Nicolas", 2000);
            CompteCourant compteCourantDeJeremie = new CompteCourant("Jeremie", 500);
            CompteEpargne compteEpargneDeNicolas = new CompteEpargne("Nicolas", 0.02);
            compteCourantDeNicolas.Crediter(100);
            compteCourantDeNicolas.Debiter(50);
            compteCourantDeNicolas.Crediter(compteEpargneDeNicolas, 20);
            compteEpargneDeNicolas.Crediter(100);
            compteEpargneDeNicolas.Crediter(compteCourantDeNicolas, 20);
            compteCourantDeJeremie.Debiter(500);
            compteCourantDeJeremie.Crediter(compteCourantDeNicolas, 200);

            Console.WriteLine("Solde compte courant de Nicolas : " + compteCourantDeNicolas.Solde);
            Console.WriteLine("Solde compte épargne de Nicolas : " + compteEpargneDeNicolas.Solde);
            Console.WriteLine("Solde compte courant de Jérémie : " + compteCourantDeJeremie.Solde);

            Console.WriteLine();

            compteCourantDeNicolas.Resumer();
            compteEpargneDeNicolas.Resumer();
            compteCourantDeJeremie.Resumer();
        }
    }
}
