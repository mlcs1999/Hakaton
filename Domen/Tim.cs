using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Tim : OpstiDomenskiObjekat
    {
        public int TimId { get; set; }
        public string Naziv { get; set; }
        public List<Takmicar> Takmicari { get; set; }

        public string NazivTabele => "Tim";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => $"{Naziv}";

        public string VrednostiZaIzmenu => $"naziv = '{Naziv}'";

        public string KriterijumObrade => $"timId = {TimId}";

        public string KriterijumPretrage => $"naziv like '%{Naziv}%'";

        public string Join => string.Empty;

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
    }
}
