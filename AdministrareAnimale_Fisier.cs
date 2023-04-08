using System;
using Ferma;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    public class AdministrareAnimale_Fisier
    {
        private const int NR_MAX_ANIMALE = 50;
        private string numeFisier;
        public AdministrareAnimale_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddAnimal(Animal animal)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(animal.ConversieLaSir_PentruFisier());
            }
        }
        public Animal[] GetAnimale(out int nrAnimale)
        {
            Animal[] animale = new Animal[NR_MAX_ANIMALE];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrAnimale = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    animale[nrAnimale++] = new Animal(linieFisier);
                    //animale[nrAnimale].nrMatricol = nrAnimale;
                }
            }
                return animale;
        }
    }
}
