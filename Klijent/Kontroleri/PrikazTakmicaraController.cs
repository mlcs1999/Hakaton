using Domen;
using Klijent.Forme;
using System.ComponentModel;
using System.Linq;

namespace Klijent.Kontroleri
{
    public class PrikazTakmicaraController
    {
        BindingList<Takmicar> takmicari = new BindingList<Takmicar>();

        #region singleton
        private static PrikazTakmicaraController instance;
        public static PrikazTakmicaraController Instance
        {
            get
            {
                if (instance == null) instance = new PrikazTakmicaraController();
                return instance;
            }
        }
        #endregion

        internal BindingList<Takmicar> VratiSveTakmicare()
        {
            takmicari.Clear();
            var takmicariDB = Komunikacija.Instance.UcitajTakmicare();
            if(takmicariDB != null)
            {
                foreach (var t in takmicariDB)
                {
                    takmicari.Add(t);
                }
            }

            return takmicari;
        }

        internal bool PretraziTakmicare(string kriterijum)
        {
            takmicari.Clear();
            var takmicariDB = Komunikacija.Instance.TraziTakmicare(new Takmicar
            {
                Ime = kriterijum
            }); 

            if(takmicariDB != null)
            {
                foreach (var t in takmicariDB)
                {
                    takmicari.Add(t);
                }
                return takmicariDB.Any();
            }
            return false;
        }

        internal bool ObrisiTakmicara(object takmicar)
        {
            return Komunikacija.Instance.ObrisiTakmicara((Takmicar)takmicar);
        }

        internal object AzurirajTakmicara(object dataBoundItem)
        {
            var takmicar = (Takmicar)dataBoundItem;
            //lazy loading
            var takmicarDB = Komunikacija.Instance.PrikaziTakmicara(takmicar);
            if(takmicarDB != null)
            {
                FrmKreiranjeTakmicara frm = new FrmKreiranjeTakmicara(true, takmicarDB.TakmicarId, takmicarDB.JMBG, takmicarDB.Ime, takmicarDB.Prezime, takmicarDB.Pol, takmicarDB.Tim);
                frm.ShowDialog();
            }
            return takmicarDB;
        }
    }
}
