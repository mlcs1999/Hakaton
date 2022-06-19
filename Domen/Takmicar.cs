using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Takmicar:OpstiDomenskiObjekat
    {
        public int TakmicarId { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public Tim Tim { get; set; }

        public string NazivTabele => "Takmicar";

        public string PovratneVrednosti => "*";

        public string VrednostiZaUnos => $"'{JMBG}', '{Ime}','{Prezime}', '{Pol}'";

        public string VrednostiZaIzmenu => $"JMBG = '{JMBG}', Ime = '{Ime}',Prezime = '{Prezime}', Pol = '{Pol}', TimId = {Tim.TimId}";

        public string KriterijumObrade => $"TakmicarId = {TakmicarId}";

        public string KriterijumPretrage => $"t.Ime like '%{Ime}%' or t.Prezime like '%{Ime}%' or t.JMBG like '%{Ime}%' or concat(t.Ime, concat(' ', t.Prezime)) " +
            $"like '%{Ime}%' ";

        public string Join => "t JOIN Tim ti on (t.TimId = ti.TimId)";

        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> takmicari = new List<OpstiDomenskiObjekat>();

            while(reader.Read())
            {
                Takmicar takmicar = new Takmicar
                {
                    TakmicarId = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Pol = (string)reader["Pol"],
                    Tim = new Tim
                    {
                        TimId = (int)reader["TimId"],
                        Naziv = reader["Naziv"] as string
                    }
                };
                takmicari.Add(takmicar);
            }

            return takmicari;
        }
    }
}