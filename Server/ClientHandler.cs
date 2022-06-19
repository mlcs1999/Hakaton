using Kontroler;
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
            while (true)
            {
                Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                Odgovor odgovor = new Odgovor();

                switch (zahtev.Operacija)
                {
                    case Operacija.Login:
                        break;
                    case Operacija.ZapamtiTakmicara:
                        ZapamtiTakmicare(zahtev, odgovor);
                        break;
                    case Operacija.TraziTakmicare:
                        TraziTakmicare(zahtev, odgovor);
                        break;
                }
            }
        }

        private void TraziTakmicare(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Takmicari = Controller.Instance.TraziTakmicare(zahtev.Takmicar);
            odgovor.Signal = odgovor.Takmicari != null ? Signal.UspesnaPretragaTakmicara : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }

        private void ZapamtiTakmicare(Zahtev zahtev, Odgovor odgovor)
        {
            odgovor.Signal = Controller.Instance.ZapamtiTakmicara(zahtev.Takmicar) ? Signal.UspesnoZapamcenTakmicar : Signal.GreskaPriZahtevu;
            formatter.Serialize(stream, odgovor);
        }
    }
}
