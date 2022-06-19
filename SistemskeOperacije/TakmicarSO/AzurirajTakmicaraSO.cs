using Domen;
using System;

namespace SistemskeOperacije.TakmicarSO
{
    public class AzurirajTakmicaraSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Izmeni((Takmicar)domenskiObjekat) > 0;
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
