using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class KoordinatorLogistike : OpstiDomenskiObjekat
    {
        public int KoordinatorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string NazivTabele => "KoordinatorLogistike";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => string.Empty;

        public string VrednostiZaIzmenu => string.Empty;

        public string KriterijumObrade => $"KoordinatorId = {KoordinatorId}";

        public string KriterijumPretrage => $"Username = '{Username}' and Password = '{Password}' ";

        public string Join => string.Empty;

        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> koordinatori = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                KoordinatorLogistike koordinator = new KoordinatorLogistike
                {
                    KoordinatorId = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Username = reader.GetString(3),
                    Password = reader.GetString(4)
                };

                koordinatori.Add(koordinator);
            }

            return koordinatori;
        }
    }
}
