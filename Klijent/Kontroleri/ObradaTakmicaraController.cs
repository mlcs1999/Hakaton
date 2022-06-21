using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    public class ObradaTakmicaraController
    {
        #region singleton
        private static ObradaTakmicaraController instance;
        public static ObradaTakmicaraController Instance
        {
            get
            {
                if (instance == null) instance = new ObradaTakmicaraController();
                return instance;
            }
        }
        #endregion

        internal List<Tim> VratiSveTimove()
        {
            return Komunikacija.Instance.UcitajTimove();
        }

        internal int PostaviTim(object tim, List<Tim> timovi)
        {
            tim = (Tim)tim;

            foreach (var t in timovi)
            {
                if(t.ToString() == tim.ToString())
                {
                    return timovi.IndexOf(t);
                }
            }
            return -1;
        }

        internal bool IzmeniPodatkeTakmicara(string id, string jmbg, string ime, string prezime, string pol, object tim)
        {
            return Komunikacija.Instance.AzurirajTakmicara(new Takmicar
            {
                TakmicarId = Int32.Parse(id),
                JMBG = jmbg,
                Ime = ime,
                Prezime = prezime,
                Pol = pol,
                Tim = tim as Tim
            });
        }

        internal bool KreirajTakmicara(string jmbg, string ime, string prezime, string pol)
        {
            return Komunikacija.Instance.ZapamtiTakmicara(new Takmicar
            {
                JMBG = jmbg,
                Ime = ime,
                Prezime = prezime,
                Pol = pol
            });
        }
    }
}
