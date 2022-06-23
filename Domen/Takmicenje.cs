using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Browsable(false)]
        public string NazivTabele => "Takmicenje";

        [Browsable (false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{Naziv}', {Mesto.PostanskiBroj}";

        [Browsable(false)]
        public string VrednostiZaIzmenu => $"Naziv = '{Naziv}', MestoId = {Mesto.PostanskiBroj}";

        [Browsable(false)]
        public string KriterijumObrade => $"TakmicenjeId = {TakmicenjeId}";

        [Browsable(false)]
        public string KriterijumPretrage => $"Takmicenje.Naziv like '%{Naziv}%'";

        [Browsable(false)]
        public string Join => " JOIN Mesto on (Takmicenje.MestoId = Mesto.PostanskiBroj)";

        [Browsable(false)]
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

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
