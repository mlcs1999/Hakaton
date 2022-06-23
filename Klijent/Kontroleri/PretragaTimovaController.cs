using Domen;
using Klijent.Forme;
using System;
using System.ComponentModel;
using System.Linq;

namespace Klijent.Kontroleri
{
    public class PretragaTimovaController
    {
        BindingList<Tim> ucitaniTimovi = new BindingList<Tim>();
        #region singleton
        private static PretragaTimovaController instance;
        public static PretragaTimovaController Instance
        {
            get
            {
                if (instance == null) instance = new PretragaTimovaController();
                return instance;
            }
        }
        #endregion

        internal BindingList<Tim> UcitajTimove()
        {
            ucitaniTimovi.Clear();
            var timoviDB = Komunikacija.Instance.UcitajTimove();

            if(timoviDB != null)
            {
                foreach (var t in timoviDB)
                {
                    ucitaniTimovi.Add(t);
                }
            }
            return ucitaniTimovi;
        }

        internal bool TraziTimove(string text)
        {
            ucitaniTimovi.Clear();
            var timoviDB = Komunikacija.Instance.TraziTimove(new Tim
            {
                Naziv = text
            });
            foreach (var t in timoviDB)
            {
                ucitaniTimovi.Add(t);
            }
           return ucitaniTimovi.Any();
        }

        internal object OtvoreniFormuZaIzmenu(object dataBoundItem)
        {
            var izabranTim = (Tim)dataBoundItem;
            var timDB = Komunikacija.Instance.PrikaziTim(izabranTim);
            if(timDB != null)
            {
                FrmPromenaPodatakaTima frm = new FrmPromenaPodatakaTima(timDB.TimId, timDB.Naziv, timDB.Plasmani);
                frm.ShowDialog();
            }
            return timDB;
        }
    }
}
