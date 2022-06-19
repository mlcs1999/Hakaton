using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.KoordinatorSO
{
    public class LoginSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Pretrazi((KoordinatorLogistike)domenskiObjekat)
                          .OfType<KoordinatorLogistike>()
                          .ToList()
                          .FirstOrDefault();
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            KoordinatorLogistike koordinator = (KoordinatorLogistike)domenskiObjekat;
            if (!(domenskiObjekat is KoordinatorLogistike) || koordinator.Username == null || koordinator.Password == null)
            {
                throw new ArgumentException();
            }
        }
    }
}
