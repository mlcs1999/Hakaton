using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    public class KreiranjaTakmicenjaController
    {
        BindingList<Tim> timovi = new BindingList<Tim>();
        BindingList<Mesto> mesta = new BindingList<Mesto>();
        BindingList<Tim> ubaceniTimovi = new BindingList<Tim>();

        #region singleton
        private static KreiranjaTakmicenjaController instance;
        public static KreiranjaTakmicenjaController Instance
        {
            get
            {
                if (instance == null) instance = new KreiranjaTakmicenjaController();
                return instance;
            }
        }
        #endregion

        internal object VratiSvaMesta()
        {
            mesta.Clear();
            var mestaDB = Komunikacija.Instance.UcitajMesta();
            if (mestaDB != null)
            {
                foreach (var m in mestaDB)
                {
                    mesta.Add(m);
                }
            }
            return mesta;
        }

        internal object VratiSveTimove()
        {
            timovi.Clear();
            var timoviDB = Komunikacija.Instance.UcitajTimove();
            if (timoviDB != null)
            {
                foreach (var t in timoviDB)
                {
                    timovi.Add(t);
                }
            }
            return timovi;
        }

        internal object DodajTim(object selectedItem)
        {
            ubaceniTimovi.Add((Tim)selectedItem);
            timovi.Remove((Tim)selectedItem);

            return ubaceniTimovi;
        }

        internal bool ZapamtiTakmicenje(string naziv, object mesto)
        {
            List<Plasman> plasmani = new List<Plasman>();

            foreach (var t in ubaceniTimovi)
            {
                Plasman p = new Plasman
                {
                    Tim = t
                };
                plasmani.Add(p);
            }

            return Komunikacija.Instance.ZapamtiTakmicenje(new Takmicenje
            {
                Naziv = naziv,
                Mesto = (Mesto)mesto,
                Plasmani = plasmani,
            });
        }

        internal void ObrisiTim(object dataBoundItem)
        {
            timovi.Add((Tim)dataBoundItem);
            ubaceniTimovi.Remove((Tim)dataBoundItem);
        }

        internal void Reset()
        {
            VratiSveTimove();
            ubaceniTimovi.Clear();
        }
    }
}
