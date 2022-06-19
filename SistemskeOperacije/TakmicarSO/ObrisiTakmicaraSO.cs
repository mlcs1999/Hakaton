using Domen;
using System;

namespace SistemskeOperacije.TakmicarSO
{
    public class ObrisiTakmicaraSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Obrisi((Takmicar)domenskiObjekat) > 0;
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
