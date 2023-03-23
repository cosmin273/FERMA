using Ferma;

using System;
using System.IO;
using System.Net.NetworkInformation;

public class Program
{
    public static void Main(string[] args)
    {
        string numeFisier = "date.txt";
        Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
        streamFisierText.Close();
        int nrAnimale = 0;
        Animal Animal = new Animal();
        Animal[] animale = new Animal[10];
        string optiune;
        do
        {
            Console.WriteLine("I:Introducere informatii animal");
            Console.WriteLine("A:Afisare informatii ultimul animal");
            Console.WriteLine("F:Afisare animale din fisier");
            Console.WriteLine("S:Salvare student in fisier");
            Console.WriteLine("C:Cautare dupa numar matricol");
            Console.WriteLine("X:Inchidere program");
            Console.WriteLine("Alegeti optiunea");
            optiune = Console.ReadLine();
            switch (optiune.ToUpper())
            {
                case "I":
                    Animal.citireTastatura();
                    break;
                case "A":
                    Console.WriteLine(Animal.AfisareAnimal());
                    break;
                case "F":
                    //using (StreamReader streamReader = new StreamReader(numeFisier)) ;
                    //{
                    //    string linieFisier;
                    //    nrAnimale = 0;
                    //    linieFisier = streamReader.ReadLine();
                    //    while(linieFisier!=null)
                    //    {
                    //        animale[nrAnimale++] = new Animal(linieFisier);
                    //    }

                    //}
                    break;
                case "S":
                    using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                    {
                        streamWriterFisierText.WriteLine(Animal.ConversieLaSir_PentruFisier());
                    }
                    break;
                case "C":
                    Console.WriteLine("Introduceti numarul matricol:");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < nrAnimale; i++)
                        if (nr == animale[i].nrMatricol)
                        {
                            nr = 0;
                            animale[i].AfisareAnimal();
                        }
                    if (nr != 0)
                        Console.WriteLine("Animalul nu a fost gasit");
                            

                    break;
                case "X":

                    return;
                default:
                    Console.WriteLine("Optiune inexistenta");
                    break;
            }
        } while (optiune.ToUpper() != "X");
        Console.ReadKey();
    }
}