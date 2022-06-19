using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Takmicenje : OpstiDomenskiObjekat
    {
        public int TakmicenjeId { get; set; }
        public string Naziv { get; set; }
        public Mesto Mesto { get; set; }
        public List<Plasman> Plasmani { get; set; }
        public string NazivTabele => "Takmicenje";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => $"'{Naziv}', {Mesto.PostanskiBroj}";

        public string VrednostiZaIzmenu => $"Naziv = '{Naziv}', MestoId = {Mesto.PostanskiBroj}";

        public string KriterijumObrade => $"TakmicenjeId = {TakmicenjeId}";

        public string KriterijumPretrage => $"Naziv like '%{Naziv}%'";

        public string Join => " JOIN Mesto on (Takmicenje.MestoId = Mesto.PostanskiBroj)";

        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> takmicenja = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                Takmicenje t = new Takmicenje
                {
                    TakmicenjeId = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Mesto = new Mesto
                    {
                        PostanskiBroj = reader.GetInt32(2),
                        Naziv = reader.GetString(4)
                    }
                };
                takmicenja.Add(t);
            }

            return takmicenja;
        }
    }
}
