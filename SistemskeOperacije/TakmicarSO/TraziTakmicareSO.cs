using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TakmicarSO
{
    public class TraziTakmicareSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Pretrazi((Takmicar)domenskiObjekat)
                         .OfType<Takmicar>()
                         .ToList();
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Takmicar))
            {
                throw new ArgumentException();
            }
        }
    }
}
