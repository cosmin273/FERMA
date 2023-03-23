using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    public class Animal
    {
        public string nume { get; set; }
        public string culoare { get; set; }
        public double greutate { get; set; }
        public double varsta { get; set; }
        public string tip { get; set; }
        public int nrMatricol { get; set; }
        public Animal()
        {
            nume = "";
            greutate = 0;
            varsta = 0;
            culoare = "";
            tip = "";
        }
        public Animal(string nume="nedefinit",double greutate=0,double varsta = 0,string culoare="nedfinit",string tip="M",int nrMatricol=0)
        {
            this.nume = nume;
            this.greutate = greutate;
            this.varsta = varsta;
            this.culoare = culoare;
            this.tip = tip;
            this.nrMatricol = nrMatricol;
        }
        public Animal(Animal A)
        {
            nume = A.nume;
            greutate = A.greutate;
            varsta = A.varsta;
            culoare = A.culoare;
            tip = A.tip;
            nrMatricol = A.nrMatricol;
        }
        public void citireTastatura()
        {
            Console.WriteLine("Introduceti numarul matricol:");
            nrMatricol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti numele:");
            nume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta:");
            varsta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti greutatea:");
            greutate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti tipul(M/F):");
            tip = Console.ReadLine();
            Console.WriteLine("Introduceti culoarea:");
            culoare = Console.ReadLine();
        }
        public void CitireLinie(string linieFisier)
        {
            var dateFisier = linieFisier.Split(",");
            nrMatricol = Convert.ToInt32(dateFisier[0]);
            nume = dateFisier[1];
            varsta = Convert.ToDouble(dateFisier[2]);
            greutate = Convert.ToDouble(dateFisier[3]);
            tip = dateFisier[4];
            culoare = dateFisier[5];
        }
        public string AfisareAnimal()
        {
            string info=string.Format($"Animalul cu numarul matricol {this.nrMatricol} are numele {this.nume}" +
                $",culoarea {this.culoare},greutatea de {this.greutate} kg,varsta de {this.varsta} ani si are genul {this.tip}");
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string animalFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                ",",
                this.nrMatricol.ToString(),
                this.nume,
                this.culoare,
                this.greutate.ToString(),
                this.varsta.ToString(),
                this.tip
               );
            return animalFisier;
        }
        //public string Nume { get; set; }
        //public float Varsta { get; set; }
        //public float Greutate { get; set; }
        /// <summary>
        ///public string Culoare { get; set; }
        /// </summary>
        //public string Tip { get; set; }
    }
    class Cow:Animal
    {
        double litriiLapte { get; set; }
        bool gestanta { get; set; }
        int nrVitei { get; set; }
        public Cow():base()
        {
            litriiLapte = 0;
            gestanta = false;
            nrVitei = 0;
        }
        public Cow(string nume = "nedefinit", double greutate = 0, double varsta = 0, string culoare = "nedfinit", string tip = "M",int nrMatricol=0, double litriiLapte = 0,bool gestanta=false,int nrVitei=0):base(nume,greutate,varsta,culoare,tip,nrMatricol)
        {
            this.litriiLapte = litriiLapte;
            this.gestanta = gestanta;
            this.nrVitei = nrVitei;
        }
        public Cow(Cow C):base(C.nume,C.greutate,C.varsta,C.culoare,C.tip)
        {
            litriiLapte = C.litriiLapte;
            gestanta = C.gestanta;
            nrVitei = C.nrVitei;
        }
    }
    class Horse:Animal
    {

    }
    class Hen:Animal
    {

    }
}
