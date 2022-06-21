﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;

namespace Klijent
{
    public class Komunikacija
    {
        Socket klijentskiSoket;
        NetworkStream stream;
        BinaryFormatter formatter = new BinaryFormatter();
        public KoordinatorLogistike koordinator = new KoordinatorLogistike();

        #region singleton
        private static Komunikacija instance;
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }
        #endregion

        public bool Konektuj()
        {
            try
            {
                if (klijentskiSoket == null || !klijentskiSoket.Connected)
                {
                    klijentskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSoket.Connect("localhost", 9000);
                    stream = new NetworkStream(klijentskiSoket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }
        internal List<Takmicar> UcitajTakmicare()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajTakmicare
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.TakmicariUspesnoVraceni)
            {
                return odgovor.Takmicari;
            }
            return null;
        }

        internal Takmicar PrikaziTakmicara(Takmicar takmicar)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.PrikaziTakmicara,
                Takmicar = takmicar
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.TakmicarUspesnoNadjen)
            {
                return odgovor.Takmicar;
            }
            return null;
        }

        internal bool ObrisiTakmicara(Takmicar takmicar)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.ObrisiTakmicara,
                Takmicar = takmicar
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.TakmicarUspesnoObrisan)
            {
                return true;
            }
            return false;
        }

        internal List<Takmicar> TraziTakmicare(Takmicar takmicar)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.TraziTakmicare,
                Takmicar = takmicar
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.UspesnaPretragaTakmicara)
            {
                return odgovor.Takmicari;
            }
            return null;
        }

        internal List<Tim> UcitajTimove()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UcitajTimove
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.TimoviUspesnoVraceni)
            {
                return odgovor.Timovi;
            }
            return null;
        }

        internal bool AzurirajTakmicara(Takmicar takmicar)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.AzurirajTakmicara,
                Takmicar = takmicar
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.UspesnoAzuriranTakmicar)
            {
                return true;
            }
            return false;
        }

        internal bool ZapamtiTakmicara(Takmicar takmicar)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.ZapamtiTakmicara,
                Takmicar = takmicar
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.UspesnoZapamcenTakmicar)
            {
                return true;
            }
            return false;
        }

        public KoordinatorLogistike Login(KoordinatorLogistike koordinator)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.Login,
                Koordinator = koordinator
            };

            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if(odgovor.Signal == Signal.UspesnoPrijavljenKoordinator)
            {
                this.koordinator = odgovor.Koordinator;
                return this.koordinator;
            }
            return null;
        }

    }
}
