using Domen;
using SistemskeOperacije;
using SistemskeOperacije.KoordinatorSO;
using SistemskeOperacije.MestoSO;
using SistemskeOperacije.PlasmanSO;
using SistemskeOperacije.TakmicarSO;
using SistemskeOperacije.TakmicenjeSO;
using SistemskeOperacije.TimSO;
using System;
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

        public KoordinatorLogistike Login(KoordinatorLogistike koordinator)
        {
            OpstaSistemskaOperacija operacija = new LoginSO();
            return (KoordinatorLogistike)operacija.IzvrsiSO(koordinator);
        }

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

        public bool ZapamtiTim(Tim tim)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiTimSO();

            var rezultat = operacija.IzvrsiSO(tim);


            if(rezultat is bool)
            {
                return (bool)rezultat;
            }
            else
            {
                return false;
            }
        }

        public List<Tim> TraziTimove(Tim tim)
        {
            OpstaSistemskaOperacija operacija = new TraziTimoveSO();
            return (List<Tim>)operacija.IzvrsiSO(tim);
        }

        public Tim PrikaziTim(Tim tim)
        {
            OpstaSistemskaOperacija operacija = new PrikaziTimSO();
            return (Tim)operacija.IzvrsiSO(tim);
        }

        public List<Tim> UcitajTimove()
        {
            OpstaSistemskaOperacija operacija = new UcitajTimoveSO();
            return (List<Tim>)operacija.IzvrsiSO(new Tim());
        }

        public bool AzurirajTim(Tim tim)
        {
            OpstaSistemskaOperacija operacija = new AzurirajTimSO();
            return (bool)operacija.IzvrsiSO(tim);
        }

        public bool ZapamtiTakmicenje(Takmicenje takmicenje)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiTakmicenjeSO();

            var rezultat = (bool?)operacija.IzvrsiSO(takmicenje);
            if(rezultat is bool)
            {
                return (bool)rezultat;
            }
            else
            {
                return false;
            }
        }

        public List<Takmicenje> TraziTakmicenja(Takmicenje takmicenje)
        {
            OpstaSistemskaOperacija operacija = new TraziTakmicenjaSO();
            return (List<Takmicenje>)operacija.IzvrsiSO(takmicenje);
        }

        public Takmicenje PrikaziTakmicenje(Takmicenje takmicenje)
        {
            OpstaSistemskaOperacija operacija = new PrikaziTakmicenjeSO();
            return (Takmicenje)operacija.IzvrsiSO(takmicenje);
        }

        public List<Takmicenje> UcitajTakmicenja()
        {
            OpstaSistemskaOperacija operacija = new UcitajTakmicenjaSO();
            return (List<Takmicenje>)operacija.IzvrsiSO(new Takmicenje());
        }

        public List<Mesto> UcitajMesta()
        {
            OpstaSistemskaOperacija operacija = new UcitajMestaSO();
            return (List<Mesto>)operacija.IzvrsiSO(new Mesto());
        }

        public bool ZapamtiRezultat(List<Plasman> plasmani)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiRezultatSO(plasmani);
            var rezultat = (bool?)operacija.IzvrsiSO(new Plasman());
            if(rezultat is bool)
            {
                return (bool)rezultat;
            }
            else
            {
                return false;
            }
        }
    }

}
