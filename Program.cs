using System;

namespace OOP_TARpv21
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.Write("Sisesta Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.Write("Sisesta Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitame();
            }

            Inimene mees = new Inimene();
            mees.Eesnimi = "Mati";
            Console.WriteLine("Ma olen {0}. Kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();

            Inimene naine = new Inimene("Marina", 19);
            naine.Tervitame();

            Console.ReadKey();
        }
    }
}
