using Domen;
using System;
using System.ComponentModel;
using System.Linq;

namespace Klijent.Kontroleri
{
    public class KreiranjeTimaController
    {
        BindingList<Takmicar> takmicari = new BindingList<Takmicar>();
        BindingList<Takmicar> ubaceniTakmicari = new BindingList<Takmicar>(); 
        #region singleton
        private static KreiranjeTimaController instance;
        public static KreiranjeTimaController Instance
        {
            get
            {
                if (instance == null) instance = new KreiranjeTimaController();
                return instance;
            }
        }
        #endregion

        internal BindingList<Takmicar> VratiSveTakmicare()
        {
            var takmicariDB = Komunikacija.Instance.UcitajTakmicare();
            if( takmicariDB != null)
            {
                foreach (var t in takmicariDB)
                {
                    if (t.Tim.TimId == null)
                    {
                        takmicari.Add(t);
                    }
                }
            }
            return takmicari;
        }

        internal BindingList<Takmicar> DodajTakmicara(object selectedItem)
        {
            ubaceniTakmicari.Add((Takmicar)selectedItem);
            takmicari.Remove((Takmicar)selectedItem);

            return ubaceniTakmicari;
        }

        internal void ObrisiTakmicara(object dataBoundItem)
        {
            takmicari.Add((Takmicar)dataBoundItem);
            ubaceniTakmicari.Remove((Takmicar)dataBoundItem);
        }

        internal bool ZapamtiTim(string nazivTima)
        {
            return Komunikacija.Instance.ZapamtiTim(new Tim {
                   Naziv = nazivTima,
                   Takmicari = ubaceniTakmicari.ToList()
            });
        }

        internal void Reset()
        {
            VratiSveTakmicare();
            ubaceniTakmicari.Clear();
        }
    }
}
