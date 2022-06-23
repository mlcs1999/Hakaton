using Kontroler;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Zajednicki;

namespace Server
{
    public class ClientHandler
    {
        public Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public ClientHandler(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            stream = new NetworkStream(klijentskiSoket);
            formatter = new BinaryFormatter();
        }

        internal void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor = new Odgovor();

                    switch (zahtev.Operacija)
                    {
                        case Operacija.Login:
                            Login(zahtev, odgovor);
                            break;
                        case Operacija.ZapamtiTakmicara:
                            ZapamtiTakmicara(zahtev, odgovor);
                            break;
                        case Operacija.TraziTakmicare:
                            TraziTakmicare(zahtev, odgovor);
                            break;
                        case Operacija.AzurirajTakmicara:
                            AzurirajTakmicara(zahtev, odgovor);
                            break;
                        case Operacija.ObrisiTakmicara:
                            ObrisiTakmicara(zahtev, odgovor);
                            break;
                        case Operacija.PrikaziTakmicara:
                            PrikaziTakmicara(zahtev, odgovor);
                            break;
                        case Operacija.UcitajTakmicare:
                            UcitajTakmicare(zahtev, odgovor);
                            break;
                        case Operacija.UcitajTimove:
                            UcitajTimove(zahtev, odgovor);
                            break;
                        case Operacija.ZapamtiTim:
                            ZapamtiTim(zahtev, odgovor);
                            break;
                        case Operacija.AzurirajTim:
                            AzurirajTim(zahtev, odgovor);
                            break;
                        case Operacija.TraziTimove:
                            TraziTimove(zahtev, odgovor);
                            break;
                        case Operacija.PrikaziTim:
                            PrikaziTim(zahtev, odgovor);
                            break;
                        case Operacija.UcitajMesta:
                            UcitajMesta(zahtev, odgovor);
                            break;
                        case Operacija.ZapamtiTakmicenje:
                            ZapamtiTakmicenje(zahtev, odgovor);
                            break;
                        case Operacija.TraziTakmicenja:
                            TraziTakmicenja(zahtev, odgovor);
                            break;
                        case Operacija.UcitajTakmicenja:
                            UcitajTakmicenja(zahtev, odgovor);
                            break;
                        case Operacija.PrikaziTakmicenje:
                            PrikaziTakmicenje(zahtev, odgovor);
                            break;
                        case Operacija.ZapamtiRezultat:
                            ZapamtiRezultat(zahtev, odgovor);
                            break;
                    }
                }
            }
            catch (IOException)
            {

            }
        }

        private void ZapamtiRezultat(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ZapamtiRezultat(zahtev.Plasmani) ? Signal.UspesnoZapamcenRezultat : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void PrikaziTakmicenje(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicenje = Controller.Instance.PrikaziTakmicenje(zahtev.Takmicenje);
            odgovor.Signal = odgovor.Takmicenje != null ? Signal.TakmicenjeUspesnoNadjeno : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void UcitajTakmicenja(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicenja = Controller.Instance.UcitajTakmicenja();
            odgovor.Signal = odgovor.Takmicenja != null ? Signal.TakmicenjaUspesnoVracena : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void TraziTakmicenja(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicenja = Controller.Instance.TraziTakmicenja(zahtev.Takmicenje);
            odgovor.Signal = odgovor.Takmicenja != null ? Signal.UspesnaPretragaTakmicenja : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void ZapamtiTakmicenje(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ZapamtiTakmicenje(zahtev.Takmicenje) ? Signal.UspesnoZapamcenoTakmicenje : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void UcitajMesta(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Mesta = Controller.Instance.UcitajMesta();
            odgovor.Signal = odgovor.Mesta != null ? Signal.MestaUspesnoVracena : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void PrikaziTim(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Tim = Controller.Instance.PrikaziTim(zahtev.Tim);
            odgovor.Signal = odgovor.Tim != null ? Signal.TimUspesnoNadjen : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void TraziTimove(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Timovi = Controller.Instance.TraziTimove(zahtev.Tim);
            odgovor.Signal = odgovor.Timovi != null ? Signal.UspesnaPretragaTimova : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void AzurirajTim(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.AzurirajTim(zahtev.Tim) ? Signal.UspesnoAzuriranTim : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void ZapamtiTim(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ZapamtiTim(zahtev.Tim) ? Signal.UspesnoZapamcenTim : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void UcitajTimove(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Timovi = Controller.Instance.UcitajTimove();
            odgovor.Signal = odgovor.Timovi != null ? Signal.TimoviUspesnoVraceni : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void UcitajTakmicare(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicari = Controller.Instance.UcitajTakmicare();
            odgovor.Signal = odgovor.Takmicari != null ? Signal.TakmicariUspesnoVraceni : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void PrikaziTakmicara(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicar = Controller.Instance.PrikaziTakmicara(zahtev.Takmicar);
            odgovor.Signal = odgovor.Takmicar != null ? Signal.TakmicarUspesnoNadjen : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void ObrisiTakmicara(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ObrisiTakmicara(zahtev.Takmicar) ? Signal.TakmicarUspesnoObrisan : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void Login(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Koordinator = Controller.Instance.Login(zahtev.Koordinator);
            odgovor.Signal = odgovor.Koordinator != null ? Signal.UspesnoPrijavljenKoordinator : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void AzurirajTakmicara(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.AzurirajTakmicara(zahtev.Takmicar) ? Signal.UspesnoAzuriranTakmicar : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void TraziTakmicare(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicari = Controller.Instance.TraziTakmicare(zahtev.Takmicar);
            odgovor.Signal = odgovor.Takmicari != null ? Signal.UspesnaPretragaTakmicara : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void ZapamtiTakmicara(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ZapamtiTakmicara(zahtev.Takmicar) ? Signal.UspesnoZapamcenTakmicar : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }
    }
}
