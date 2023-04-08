using Ferma;
using System;
using System.IO;
using System.Net.NetworkInformation;

public class Program
{
    public enum Specie
    {
        Cow,
        Hen,
        Horse
    }
    public static void Main(string[] args)
    {
        string numeFisier = "date.txt";
        AdministrareAnimale_Fisier adminAnimale = new AdministrareAnimale_Fisier(numeFisier);
        Administrare_Consola adminC = new Administrare_Consola();
        int nrAnimale = 0;
        Animal animal = new Animal();
        Animal[] animale = adminAnimale.GetAnimale(out nrAnimale);
        Animal hen = new Hen();
        
        string optiune;
        do
        {
            Console.WriteLine("I:Introducere informatii animal");
            Console.WriteLine("A:Afisare informatii ultimul animal");
            Console.WriteLine("F:Afisare animale din fisier");
            Console.WriteLine("S:Salvare animal in fisier");
            Console.WriteLine("C:Cautare dupa numar matricol");
            Console.WriteLine("X:Inchidere program");
            Console.WriteLine("Alegeti optiunea");
            optiune = Console.ReadLine() ?? "X";
            switch (optiune.ToUpper())
            {
                case "I":
                    adminC.citireTastatura(animal);
                    animal.nrMatricol = nrAnimale +1;
                    animale[nrAnimale++] = animal;
                    Specie optiuneAnimal;
                    //Console.WriteLine("Introduceti specia de animal(Cow,Hen,Horse)");
                    //optiuneAnimal = (Specie)Enum.Parse(typeof(Specie), Console.ReadLine());

                    break;
                case "A":
                    adminC.AfisareAnimal(animal);
                    break;
                case "F":
                    for (int i = 0; i < nrAnimale; i++)
                        adminC.AfisareAnimal(animale[i]);
                    
                    break;
                case "S":
                    using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                    {
                        streamWriterFisierText.WriteLine(animal.ConversieLaSir_PentruFisier());
                    }
                    break;
                case "C":
                    Console.WriteLine("Introduceti numarul matricol:");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < nrAnimale; i++)
                        if (nr == animale[i].nrMatricol)
                        {
                            nr = 0;
                            adminC.AfisareAnimal(animale[i]);
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