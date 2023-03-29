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
        public string ConversieLaSir_PentruFisier()
        {
            string animalFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                ",",
                this.nrMatricol.ToString(),
                this.nume,
                this.varsta.ToString(),
                this.greutate.ToString(),
                this.tip,
                this.culoare
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
        public void CitireLinieCow(string linie)
        {
            this.CitireLinie(linie);
            var dateFisier = linie.Split(",");
            litriiLapte = Convert.ToDouble(dateFisier[6]);
            gestanta = Convert.ToBoolean(dateFisier[7]);
            nrVitei = Convert.ToInt32(dateFisier[8]);
        }
        public string ConversieLaSirPentruFisierCow()
        {
            string CowFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                ",",
                this.ConversieLaSir_PentruFisier(),
                litriiLapte.ToString(),
                gestanta.ToString(),
                nrVitei.ToString());
            return CowFisier;
            
        }
    }
    class Horse:Animal
    {
        double vitezaAlergare { get; set; }
        bool poctovit { get; set; }
        public Horse() : base()
        {
            vitezaAlergare = 0;
            poctovit = false;
        }
        public Horse(string nume = "nedefinit", double greutate = 0, double varsta = 0, string culoare = "nedfinit", string tip = "M", int nrMatricol = 0,double vitezaAlergare=0,bool poctovit=false): base(nume, greutate, varsta, culoare, tip, nrMatricol)
        {
            this.vitezaAlergare = vitezaAlergare;
            this.poctovit = poctovit;
        }
        public Horse(Horse H) : base(H.nume, H.greutate, H.varsta, H.culoare, H.tip)
        {
            vitezaAlergare = H.vitezaAlergare;
            poctovit = H.poctovit;
        }
        public void CitireLinieHorse(string linie)
        {
            this.CitireLinie(linie);
            var dateFisier = linie.Split(",");
            vitezaAlergare = Convert.ToDouble(dateFisier[6]);
            poctovit = Convert.ToBoolean(dateFisier[7]);
        }
        public string ConversieLaSirPentruFisierHorse()
        {
            string HorseFisier = string.Format("{1}{0}{2}{0}{3}",
                ",",
                this.ConversieLaSir_PentruFisier(),
                vitezaAlergare.ToString(),
                poctovit.ToString());
            return HorseFisier;

        }



    }
    class Hen:Animal
    {
        double nrOuaPerLuna { get; set; }
        bool closca { get; set; }
        public Hen() : base()
        {
            nrOuaPerLuna = 0;
            closca = false;
        }
        public Hen(string nume = "nedefinit", double greutate = 0, double varsta = 0, string culoare = "nedfinit", string tip = "M", int nrMatricol = 0,double nrOuaPerLuna=0,bool closca=false):base(nume, greutate, varsta, culoare, tip, nrMatricol)
        {
            this.nrOuaPerLuna = nrOuaPerLuna;
            this.closca = closca;
        }
        public Hen(Hen H):base(H.nume, H.greutate, H.varsta, H.culoare, H.tip)
        {
            nrOuaPerLuna = H.nrOuaPerLuna;
            closca = H.closca;
        }
        public void CitireLinieHen(string linie)
        {
            this.CitireLinie(linie);
            var dateFisier = linie.Split(",");
            nrOuaPerLuna = Convert.ToDouble(dateFisier[6]);
            closca = Convert.ToBoolean(dateFisier[7]);
        }
        public string ConversieLaSirPentruFisierHen()
        {
            string HenFisier = string.Format("{1}{0}{2}{0}{3}",
                ",",
                this.ConversieLaSir_PentruFisier(),
                nrOuaPerLuna.ToString(),
                closca.ToString());
            return HenFisier;

        }
    }
}
