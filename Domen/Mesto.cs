using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Mesto : OpstiDomenskiObjekat
    {

        public int PostanskiBroj { get; set; }
        public string Naziv { get; set; }
        public string NazivTabele => "Mesto";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => $"{PostanskiBroj}, '{Naziv}'";

        public string VrednostiZaIzmenu => $"PostanskiBroj = {PostanskiBroj}, Naziv = '{Naziv}'";

        public string KriterijumObrade => $"PostanskiBroj = {PostanskiBroj}";

        public string KriterijumPretrage => string.Empty;

        public string Join => string.Empty;

        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> mesta = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                Mesto m = new Mesto
                {
                    PostanskiBroj = reader.GetInt32(0),
                    Naziv = (string)reader["Naziv"]
                };
                mesta.Add(m);
            }

            return mesta;
        }
    }
}
