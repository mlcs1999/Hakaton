using Domen;
using SistemskeOperacije;
using SistemskeOperacije.TakmicarSO;
using System.Collections.Generic;

namespace Kontroler
{
    public class Controller
    {

        #region singleton
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        #endregion

        public bool ZapamtiTakmicara(Takmicar takmicar)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiTakmicaraSO();

            return (bool)operacija.IzvrsiSO(takmicar);
        }

        public List<Takmicar> TraziTakmicare(Takmicar takmicar)
        {
            OpstaSistemskaOperacija operacija = new TraziTakmicareSO();

            return (List<Takmicar>)operacija.IzvrsiSO(takmicar);
        }

        public Takmicar PrikaziTakmicara(Takmicar takmicar)
        {
            OpstaSistemskaOperacija operacija = new PrikaziTakmicaraSO();

            return (Takmicar)operacija.IzvrsiSO(takmicar);
        }

        public List<Takmicar> UcitajTakmicare()
        {
            OpstaSistemskaOperacija operacija = new UcitajTakmicareSO();

            return (List<Takmicar>)operacija.IzvrsiSO(new Takmicar());
        }

        public bool AzurirajTakmicara(Takmicar takmicar)
        {
            OpstaSistemskaOperacija operacija = new AzurirajTakmicaraSO();

            return (bool)operacija.IzvrsiSO(takmicar);
        }

        public bool ObrisiTakmicara(Takmicar takmicar)
        {
            OpstaSistemskaOperacija operacija = new ObrisiTakmicaraSO();

            return (bool)operacija.IzvrsiSO(takmicar);
        }
    }

}
