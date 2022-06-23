using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    public class PromenaPodataTimaController
    {
        #region singleton
        private static PromenaPodataTimaController instance;
        public static PromenaPodataTimaController Instance
        {
            get
            {
                if (instance == null) instance = new PromenaPodataTimaController();
                return instance;
            }
        }
        #endregion

        internal bool AzurirajTim(string id, string naziv)
        {
            return Komunikacija.Instance.AzurirajTim(new Tim {
                   TimId = Int32.Parse(id),
                   Naziv = naziv
            });
        }
    }
}
