using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        internal List<Takmicenje> TraziTakmicenje(Takmicenje takmicenje)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.TraziTakmicenja,
                    Takmicenje = takmicenje
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnaPretragaTakmicenja)
                {
                    return odgovor.Takmicenja;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal bool ZapamtiRezultat(List<Plasman> plasmani)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.ZapamtiRezultat,
                    Plasmani = plasmani
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnoZapamcenRezultat)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal List<Takmicenje> UcitajTakmicenja()
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.UcitajTakmicenja
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.TakmicenjaUspesnoVracena)
                {
                    return odgovor.Takmicenja;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal List<Tim> TraziTimove(Tim tim)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.TraziTimove,
                    Tim = tim
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnaPretragaTimova)
                {
                    return odgovor.Timovi;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal Takmicenje PrikaziTakmicenje(Takmicenje izabranoTakmicenje)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PrikaziTakmicenje,
                    Takmicenje = izabranoTakmicenje
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.TakmicenjeUspesnoNadjeno)
                {
                    return odgovor.Takmicenje;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }



        internal bool ZapamtiTakmicenje(Takmicenje takmicenje)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.ZapamtiTakmicenje,
                    Takmicenje = takmicenje
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnoZapamcenoTakmicenje)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal List<Mesto> UcitajMesta()
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.UcitajMesta
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.MestaUspesnoVracena)
                {
                    return odgovor.Mesta;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal Tim PrikaziTim(Tim izabranTim)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PrikaziTim,
                    Tim = izabranTim
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.TimUspesnoNadjen)
                {
                    return odgovor.Tim;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal bool AzurirajTim(Tim tim)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.AzurirajTim,
                    Tim = tim
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnoAzuriranTim)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        internal List<Takmicar> UcitajTakmicare()
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        internal bool ZapamtiTim(Tim tim)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.ZapamtiTim,
                    Tim = tim
                };

                formatter.Serialize(stream, zahtev);
                Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
                if (odgovor.Signal == Signal.UspesnoZapamcenTim)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        internal Takmicar PrikaziTakmicara(Takmicar takmicar)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        internal bool ObrisiTakmicara(Takmicar takmicar)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        internal List<Takmicar> TraziTakmicare(Takmicar takmicar)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        internal List<Tim> UcitajTimove()
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        internal bool AzurirajTakmicara(Takmicar takmicar)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        internal bool ZapamtiTakmicara(Takmicar takmicar)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
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
