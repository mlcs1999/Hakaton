using Domen;
using System;

namespace SistemskeOperacije.TakmicarSO
{
    public class ZapamtiTakmicaraSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Sacuvaj((Takmicar)domenskiObjekat) > 0;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            Takmicar takmicar = (Takmicar)domenskiObjekat;

            if (!(domenskiObjekat is Takmicar) || takmicar.Ime == null || takmicar.Prezime == null || takmicar.JMBG == null)
            {
                throw new ArgumentException();
            }
        }
    }
}
