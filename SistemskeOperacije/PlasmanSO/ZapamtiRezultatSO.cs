using Domen;
using System;
using System.Collections.Generic;

namespace SistemskeOperacije.PlasmanSO
{
    public class ZapamtiRezultatSO : OpstaSistemskaOperacija
    {
        private List<Plasman> plasmani { get; set; }

        public ZapamtiRezultatSO(List<Plasman> plasmani)
        {
            this.plasmani = plasmani;
        }
        protected override object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat)
        {
            foreach (var p in plasmani)
            {
                if(broker.Izmeni(p) <= 0)
                {
                    throw new Exception("Plasman nije sacuvan.");
                }
            }
            return true;
        }

        protected override void Validacija(OpstiDomenskiObjekat domenskiObjekat)
        {
            if(!(domenskiObjekat is Plasman))
            {
                throw new ArgumentException();
            }
        }
    }
}
