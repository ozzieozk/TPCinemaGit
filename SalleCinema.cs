using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCinema
{
    class SalleCinema
    {
        private string titre;
        private int nbPlaces;
        private double tarifN;
        private int nbPlaceTarifN = 0;
        private int nbPlaceTarifR = 0;

        public SalleCinema(string leTitre, int lesPlaces, double tarifNormal, int leNbPlaceTarifN, int leNbPlaceTarifR)
        {
            this.Titre = leTitre;
            this.NbPlaces = lesPlaces;
            this.TarifN = tarifNormal;
            this.NbPlaceTarifN = leNbPlaceTarifN;
            this.NbPlaceTarifR = leNbPlaceTarifR;
        }

        public string Titre
        {
            get => titre; set => titre = value;
        }
        public int NbPlaces
        {
            get => nbPlaces; set => nbPlaces = value;
        }
        public double TarifN
        {
            get => tarifN; set => tarifN = value;
        }
        public int NbPlaceTarifN
        {
            get => nbPlaceTarifN; set => nbPlaceTarifN = value;
        }
        public int NbPlaceTarifR
        {
            get => nbPlaceTarifR; set => nbPlaceTarifR = value;
        }
        public int nbPlacesDisponible()
        {
            int nbPlacesDispo;
            nbPlacesDispo = nbPlaces - (nbPlaceTarifN + nbPlaceTarifR);
            return nbPlacesDispo;
        }
        public bool vendrePlaces(int nbre, bool tarifReduit)
        {
            if (tarifReduit == true)
            {
                this.tarifN = tarifN - (80 / 100);
            }
            else
            {
                this.tarifN = tarifN * 1;
            }
            if (nbre>nbPlacesDisponible())
            {
                this.nbPlaces = nbPlaces - nbre; 
                return true;
            }
            else
            {
                return false;
            }
        }
        public void remiseAZero()        {
            this.nbPlaces = 0;
            this.nbPlaceTarifN = 0;
            this.nbPlaceTarifR = 0;
        }

    }
}
