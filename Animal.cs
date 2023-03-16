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
        public Animal()
        {
            nume = "";
            greutate = 0;
            varsta = 0;
            culoare = "";
            tip = "";
        }
        public Animal(string nume="nedefinit",double greutate=0,double varsta = 0,string culoare="nedfinit",string tip="M")
        {
            this.nume = nume;
            this.greutate = greutate;
            this.varsta = varsta;
            this.culoare = culoare;
            this.tip = tip;
        }
        public Animal(Animal A)
        {
            nume = A.nume;
            greutate = A.greutate;
            varsta = A.varsta;
            culoare = A.culoare;
            tip = A.tip;
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
        public Cow(string nume = "nedefinit", double greutate = 0, double varsta = 0, string culoare = "nedfinit", string tip = "M", double litriiLapte = 0,bool gestanta=false,int nrVitei=0):base(nume,greutate,varsta,culoare,tip)
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
