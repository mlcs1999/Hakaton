using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Plasman : OpstiDomenskiObjekat
    {
        public int RedniBroj { get; set; }
        public Tim Tim { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public int? BrojPoena { get; set; }
        public int? Rang { get; set; }

        [Browsable (false)]
        public string NazivTabele => "Plasman";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string VrednostiZaUnos => $"{RedniBroj}, {Tim.TimId}, {Takmicenje.TakmicenjeId}, null, null";
        [Browsable(false)]
        public string VrednostiZaIzmenu => $"BrojPoena = {BrojPoena}, Rang = {Rang}";
        [Browsable(false)]
        public string KriterijumObrade => $"TakmicenjeId = {Takmicenje.TakmicenjeId} and TimId = {Tim.TimId}";
        [Browsable(false)]
        public string Kriterijum { get; set; }
        [Browsable(false)]
        public string KriterijumPretrage => Kriterijum;
        [Browsable(false)]
        public string Join => " JOIN Takmicenje on (Plasman.TakmicenjeId = Takmicenje.TakmicenjeId) " +
                              " JOIN Tim on (Plasman.TimId = Tim.TimId) ";
        [Browsable(false)]
        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> plasmani = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                int? brPoena = (int?)null;
                int? rang = (int?)null;
                if (reader["BrojPoena"] != DBNull.Value)
                {
                    brPoena = (int?)Int32.Parse(reader["BrojPoena"].ToString());
                }
                if (reader["Rang"] != DBNull.Value)
                {
                    rang = (int?)Int32.Parse(reader["Rang"].ToString());
                }
                Plasman p = new Plasman
                {
                    Takmicenje = new Takmicenje
                    {
                        TakmicenjeId = (int)reader["TakmicenjeId"],
                        Naziv = (string)reader["Naziv"]
                    },
                    Tim = new Tim
                    {
                        TimId = (int)reader["TimId"],
                        Naziv = reader.GetString(9)
                    },
                    RedniBroj = (int)reader["RedniBroj"],
                    BrojPoena = brPoena,
                    Rang = rang
                };
                plasmani.Add(p);
            }
            return plasmani;
        }
    }
}
