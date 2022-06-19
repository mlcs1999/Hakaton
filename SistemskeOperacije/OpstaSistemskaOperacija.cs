using DbBroker;
using Domen;
using System;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected abstract object Izvrsavanje(OpstiDomenskiObjekat domenskiObjekat);
        protected abstract void Validacija(OpstiDomenskiObjekat domenskiObjekat);

        protected Broker broker;

        public OpstaSistemskaOperacija()
        {
            broker = new Broker();
        }
        public object IzvrsiSO(OpstiDomenskiObjekat domenskiObjekat)
        {
            object rezultat = null;
            try
            {
                Validacija(domenskiObjekat);
                broker.OtvaranjeKonekcije();
                broker.ZapocniTransakciju();
                rezultat = Izvrsavanje(domenskiObjekat);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
            }
            finally
            {
                broker.ZatvaranjeKonekcije();
            }
            return rezultat; 
        }
    }
}
