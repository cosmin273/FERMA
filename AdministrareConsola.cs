using System;
using Ferma;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    public class Administrare_Consola
    {
        public void citireTastatura(Animal A)
        {
            //Console.WriteLine("Introduceti numarul matricol:");
            //A.nrMatricol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti numele:");
            A.nume = Console.ReadLine() ?? "nedefinit";
            Console.WriteLine("Introduceti varsta:");
            A.varsta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti greutatea:");
            A.greutate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti tipul(Masculin/Feminin):");
            A.tip = (Tip)Enum.Parse(typeof(Tip), Console.ReadLine());
            Console.WriteLine("Introduceti culoarea:");
            A.culoare = (Culoare)Enum.Parse(typeof(Culoare), Console.ReadLine());
        }
        public void AfisareAnimal(Animal A)
        {
            string info = string.Format($"Animalul cu numarul matricol {A.nrMatricol} are numele {A.nume}" +
                $",culoarea {A.culoare},greutatea de {A.greutate} kg,varsta de {A.varsta} ani si are genul {A.tip}");
            Console.WriteLine(info);
        }
    }
}
