using Domen;
using Klijent.Forme;
using System;
using System.ComponentModel;

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
            var takmicariDB = Komunikacija.Instance.UcitajTakmicare();
            foreach (var t in takmicariDB)
            {
                takmicari.Add(t);
            }
            return takmicari;
        }

        internal void PretraziTakmicare(string kriterijum)
        {
            takmicari.Clear();
            var takmicariDB = Komunikacija.Instance.TraziTakmicare(new Takmicar
            {
                Ime = kriterijum
            }); 

            foreach (var t in takmicariDB)
            {
                takmicari.Add(t);
            }
        }

        internal bool ObrisiTakmicara(object takmicar)
        {
            return Komunikacija.Instance.ObrisiTakmicara((Takmicar)takmicar);
        }

        internal void AzurirajTakmicara(object dataBoundItem)
        {
            var takmicar = (Takmicar)dataBoundItem;
            //lazy loading
            var takmicarDB = Komunikacija.Instance.PrikaziTakmicara(takmicar);
            if(takmicarDB != null)
            {
                FrmKreiranjeTakmicara frm = new FrmKreiranjeTakmicara(true, takmicarDB.TakmicarId, takmicarDB.JMBG, takmicarDB.Ime, takmicarDB.Prezime, takmicarDB.Pol, takmicarDB.Tim);
                frm.ShowDialog();
            }
        }
    }
}
