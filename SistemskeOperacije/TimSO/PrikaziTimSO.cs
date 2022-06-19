using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TimSO
{
    public class PrikaziTimSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            var timDB = broker.VratiSve((Tim)domenskiObjekat)
                         .OfType<Tim>()
                         .ToList()
                         .FirstOrDefault(tim => tim.TimId == ((Tim)domenskiObjekat).TimId);

            Plasman p = new Plasman
            {
                Kriterijum = $"Plasman.TimId = {timDB.TimId}"
            };

            timDB.Plasmani = broker.Pretrazi(p)
                                   .OfType<Plasman>()
                                   .ToList();

            return timDB;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if (!(domenskiObjekat is Tim))
            {
                throw new ArgumentException();
            }
        }
    }
}
