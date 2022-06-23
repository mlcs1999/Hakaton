using Domen;
using Klijent.Forme;
using Klijent.Forme.FormeTakmicenje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class PretragaTakmicenjaController
    {
        BindingList<Takmicenje> ucitanaTakmicenja = new BindingList<Takmicenje>();
        #region singleton
        private static PretragaTakmicenjaController instance;
        public static PretragaTakmicenjaController Instance
        {
            get
            {
                if (instance == null) instance = new PretragaTakmicenjaController();
                return instance;
            }
        }
        #endregion

        internal object UcitajTakmicenja()
        {
            ucitanaTakmicenja.Clear();
            var takmicenjaDB = Komunikacija.Instance.UcitajTakmicenja();

            if (takmicenjaDB != null)
            {
                foreach (var t in takmicenjaDB)
                {
                    ucitanaTakmicenja.Add(t);
                }
            }
            return ucitanaTakmicenja;
        }

        internal bool TraziTakmicenja(string naziv)
        {
            ucitanaTakmicenja.Clear();
            var takmicenjaDB = Komunikacija.Instance.TraziTakmicenje(new Takmicenje
            {
                Naziv = naziv
            });
            if(takmicenjaDB != null)
            {
                foreach (var t in takmicenjaDB)
                {
                    ucitanaTakmicenja.Add(t);
                }
                return ucitanaTakmicenja.Any();
            }
            return false;
        }

        internal object OtvoriFormuZaUnos(object takmicenje)
        {
            var izabranoTakmicenje = (Takmicenje)takmicenje;
            var takmicenjeDB = Komunikacija.Instance.PrikaziTakmicenje(izabranoTakmicenje);
            if (takmicenjeDB != null)
            {
                FrmUnosRezultata frm = new FrmUnosRezultata(takmicenjeDB.Naziv, takmicenjeDB.Plasmani);
                frm.ShowDialog();
            }
            return takmicenjeDB;
        }
    }
}
