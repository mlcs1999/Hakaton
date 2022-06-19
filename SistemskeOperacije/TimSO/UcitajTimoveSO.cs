using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TimSO
{
    public class UcitajTimoveSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.VratiSve((Tim)domenskiObjekat)
                         .OfType<Tim>()
                         .ToList();
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Tim))
            {
                throw new ArgumentException();
            }
        }
    }
}
