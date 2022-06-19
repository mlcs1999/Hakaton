using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TimSO
{
    public class ZapamtiTimSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            Tim tim = (Tim)domenskiObjekat;

            if(broker.Sacuvaj(tim) <= 0)
            {
                throw new Exception("Tim nije sacuvan.");
            }

            var timId = broker.VratiMaxId(new Tim());

            foreach (var takmicar in tim.Takmicari)
            {
                takmicar.Tim = new Tim
                {
                    TimId = timId
                };

                if(broker.Izmeni(takmicar) <= 0)
                {
                    throw new Exception("Takmicar nije dodat u tim.");
                }
            }
            return true;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Tim) || !((Tim)domenskiObjekat).Takmicari.Any())
            {
                throw new ArgumentException();
            }
        }
    }
}
