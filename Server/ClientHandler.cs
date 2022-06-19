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
                    }
                }
            }
            catch (IOException)
            {
            }
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
