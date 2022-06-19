using Domen;
using System;
using System.Linq;

namespace SistemskeOperacije.TakmicarSO
{
    public class PrikaziTakmicaraSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            //kastujem za brokera
            return broker.VratiSve((Takmicar)domenskiObjekat)
                         .OfType<Takmicar>()
                         .ToList()
                         //vraca prvog koji odgovara ili vraca null ako ne nadje nista po tom kriterijumu
                         .FirstOrDefault(takmicar => takmicar.TakmicarId == ((Takmicar)domenskiObjekat).TakmicarId);
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
