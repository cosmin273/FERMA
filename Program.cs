using Ferma;

using System;
using System.IO;
using System.Net.NetworkInformation;
public class Program
{
    public static void Main(string[] args)
    {
        string numeFisier = "date.txt";
        FileStream fs = new FileStream("date.txt", FileMode.OpenOrCreate);
        fs.Close();
        int nrAnimale = 0;
        Animal animal = new Animal();
        Animal[] animale = new Animal[10];
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
                    citireTastatura(animal);
                    animale[nrAnimale++] = animal;
                    break;
                case "A":
                    AfisareAnimal(animal);
                    break;
                case "F":

                    using (StreamReader sr = new StreamReader("date.txt"))
                    {
                        string line;

                        // citim fisierul linie cu linie si afisam fiecare linie
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            animal.CitireLinie(line);
                            animale[nrAnimale++] = animal;
                        }
                    }
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
                            AfisareAnimal(animale[i]);
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
    public static void citireTastatura(Animal A)
    {
        Console.WriteLine("Introduceti numarul matricol:");
        A.nrMatricol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti numele:");
        A.nume = Console.ReadLine() ?? "nedefinit";
        Console.WriteLine("Introduceti varsta:");
        A.varsta = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduceti greutatea:");
        A.greutate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduceti tipul(M/F):");
        A.tip = Console.ReadLine() ?? "nedefinit";
        Console.WriteLine("Introduceti culoarea:");
        A.culoare = Console.ReadLine() ?? "nedefinit";
    }
    public static void AfisareAnimal(Animal A)
    {
        string info = string.Format($"Animalul cu numarul matricol {A.nrMatricol} are numele {A.nume}" +
            $",culoarea {A.culoare},greutatea de {A.greutate} kg,varsta de {A.varsta} ani si are genul {A.tip}");
        Console.WriteLine(info);
    }
}