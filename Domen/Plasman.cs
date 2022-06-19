using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Plasman : OpstiDomenskiObjekat
    {
        public int RedniBroj { get; set; }
        public Tim Tim { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public int BrojPoena { get; set; }
        public DateTime Datum { get; set; }
        public int Rang { get; set; }
        public string NazivTabele => "Plasman";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => $"{RedniBroj}, {Tim.TimId}, {Takmicenje.TakmicenjeId}, {DBNull.Value}, '{Datum}', {DBNull.Value}";

        public string VrednostiZaIzmenu => $"BrojPoena = {BrojPoena}, Rang = {Rang}";

        public string KriterijumObrade => $"Takmicenje = {Takmicenje.TakmicenjeId}, Tim = {Tim.TimId}";

        public string Kriterijum { get; set; }

        public string KriterijumPretrage => Kriterijum;

        public string Join => " JOIN Takmicenje on (Plasman.TakmicenjeId = Takmicenje.TakmicenjeId) " +
                              " JOIN Tim on (Plasman.TimId = Tim.TimId) ";

        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> plasmani = new List<OpstiDomenskiObjekat>();

            while (reader.Read())
            {
                Plasman p = new Plasman
                {
                    Takmicenje = new Takmicenje
                    {
                        TakmicenjeId = (int)reader["Takmicenje.TakmicenjeId"],
                        Naziv = (string)reader["Takmicenje.Naziv"]
                    },
                    Tim = new Tim
                    {
                        TimId = (int)reader["Tim.TimId"],
                        Naziv = (string)reader["Tim.Naziv"]
                    },
                    RedniBroj = (int)reader["RedniBroj"],
                    BrojPoena = (int)reader["BrojPoena"],
                    Datum = (DateTime)reader["Datum"],
                    Rang = (int)reader["Rang"]
                };
                plasmani.Add(p);
            }

            return plasmani;
        }
    }
}
