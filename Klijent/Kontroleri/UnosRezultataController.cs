using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    public class UnosRezultataController
    {

        BindingList<Tim> timovi = new BindingList<Tim>();
        BindingList<Plasman> plasmani = new BindingList<Plasman>();

        #region singleton
        private static UnosRezultataController instance;
        public static UnosRezultataController Instance
        {
            get
            {
                if (instance == null) instance = new UnosRezultataController();
                return instance;
            }
        }
        #endregion

        internal object VratiSveTimove(object plasmani)
        {
            timovi.Clear();
            this.plasmani.Clear();

            List<Plasman> plasmanii = (List<Plasman>)plasmani;
            if(plasmanii != null)
            {
                foreach (var p in plasmanii)
                {
                    timovi.Add(p.Tim);
                }
            } 
            else
            {
                return null;
            }
            return timovi;
        }

        internal BindingList<Plasman> UnesiRezultat(object tim, string brPoena, string rang, object plasmani)
        {
            List<Plasman> plasmanii = (List<Plasman>)plasmani;
            Tim timm = (Tim)tim;
            Plasman plasman = plasmanii.FirstOrDefault(p => p.Tim.TimId == timm.TimId);
            plasman.BrojPoena = Int32.Parse(brPoena);
            plasman.Rang = Int32.Parse(rang);
            this.plasmani.Add(plasman);
            timovi.Remove(timm);
            return this.plasmani;
        }

        internal bool KompletniPodaciZaSveTimove()
        {
            return !timovi.Any();
        }

        internal bool SacuvajRezultat()
        {
            return Komunikacija.Instance.ZapamtiRezultat(plasmani.ToList());
        }
    }
}
