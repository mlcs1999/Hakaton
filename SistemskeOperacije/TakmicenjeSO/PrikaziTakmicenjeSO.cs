using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class PrikaziTakmicenjeSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            Takmicenje takmicenje = (Takmicenje)domenskiObjekat;
            var takmicenjeDB = broker.VratiSve(takmicenje)
                         .OfType<Takmicenje>()
                         .ToList()
                         .FirstOrDefault(t => t.TakmicenjeId == takmicenje.TakmicenjeId);

            Plasman p = new Plasman
            {
                Kriterijum = $"Plasman.TakmicenjeId = {takmicenjeDB.TakmicenjeId}"
            };

            takmicenjeDB.Plasmani = broker.Pretrazi(p)
                                          .OfType<Plasman>()
                                          .ToList();

            return takmicenjeDB;
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
