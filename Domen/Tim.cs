using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Tim : OpstiDomenskiObjekat
    {
        public int? TimId { get; set; }
        public string Naziv { get; set; }
        public List<Takmicar> Takmicari { get; set; }
        public List<Plasman> Plasmani { get; set; }

        [Browsable (false)]
        public string NazivTabele => "Tim";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{Naziv}'";

        [Browsable(false)]
        public string VrednostiZaIzmenu => $"naziv = '{Naziv}'";

        [Browsable(false)]
        public string KriterijumObrade => $"timId = {TimId}";

        [Browsable(false)]
        public string KriterijumPretrage => $"naziv like '%{Naziv}%'";

        [Browsable(false)]
        public string Join => string.Empty;

        [Browsable(false)]
        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> timovi = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                Tim tim = new Tim
                {
                    TimId = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                timovi.Add(tim);
            }

            return timovi;
        }

        [Browsable(false)]
        public override string ToString()
        {
            return Naziv;
        }
    }
}
