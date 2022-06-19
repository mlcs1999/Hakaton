using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class ZapamtiTakmicenjeSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            Takmicenje takmicenje = (Takmicenje)domenskiObjekat;
            if (broker.Sacuvaj(takmicenje) <= 0)
            {
                throw new Exception("Takmicenje nije sacuvano.");
            }

            var takmicenjeId = broker.VratiMaxId(new Takmicenje());

            foreach (var plasman in takmicenje.Plasmani)
            {
                plasman.Takmicenje = new Takmicenje
                {
                    TakmicenjeId = takmicenjeId
                };

               if(broker.Sacuvaj(plasman) <= 0)
                {
                    throw new Exception("Plasman nije sacuvan za dato takmicenje.");
                }
            }
            return true;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Takmicenje) || !((Takmicenje)domenskiObjekat).Plasmani.Any())
            {
                throw new ArgumentException();
            }
        }
    }
}
