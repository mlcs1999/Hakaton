using Domen;
using System;

namespace SistemskeOperacije.TimSO
{
    public class AzurirajTimSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            return broker.Izmeni((Tim)domenskiObjekat) > 0;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if(!(domenskiObjekat is Tim))
            {
                throw new ArgumentException();
            }
        }
    }
}
