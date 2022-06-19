using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.MestoSO
{
    public class UcitajMestaSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.VratiSve((Mesto)domenskiObjekat)
                         .OfType<Mesto>()
                         .ToList();
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Mesto))
            {
                throw new ArgumentException();
            }
        }
    }
}
