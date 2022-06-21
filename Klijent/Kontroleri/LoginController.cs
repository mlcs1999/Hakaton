using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    class LoginController
    {
        internal string Login(string username, string password)
        {
            if(!Komunikacija.Instance.Konektuj())
            {
                return ConfigurationManager.AppSettings["neuspesnoPovezivanje"];
            }

            KoordinatorLogistike koordinator = new KoordinatorLogistike
            {
                Username = username,
                Password = password
            };

            var koord = Komunikacija.Instance.Login(koordinator);
            if(koord != null)
            {

                return $"Dobrodosli, {koord.Ime} {koord.Prezime}";
            }
            else
            {
                return ConfigurationManager.AppSettings["neuspesnaPrijava"];
            }
        }

        internal void PokreniGlavnuFormu()
        {
            FrmGlavna frm = new FrmGlavna();
            frm.ShowDialog();
        }
    }
}
