using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class TraziTakmicenjaSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Pretrazi((Takmicenje)domenskiObjekat)
                         .OfType<Takmicenje>()
                         .ToList();
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Takmicenje))
            {
                throw new ArgumentException();
            }
        }
    }
}
