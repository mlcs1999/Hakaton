using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Browsable(false)]
        public Tim Tim { get; set; }

        [Browsable (false)]
        public string NazivTabele => "Takmicar";

        [Browsable(false)]
        public string PovratneVrednosti => "*";
        [Browsable(false)]
        public string VrednostiZaUnos => $"'{JMBG}', '{Ime}','{Prezime}', '{Pol}', null";
        [Browsable(false)]
        public string VrednostiZaIzmenu => $"JMBG = '{JMBG}', Ime = '{Ime}',Prezime = '{Prezime}', Pol = '{Pol}', TimId = {Tim.TimId}";
        [Browsable(false)]
        public string KriterijumObrade => $"TakmicarId = {TakmicarId}";
        [Browsable(false)]
        public string KriterijumPretrage => $"t.Ime like '%{Ime}%' or t.Prezime like '%{Ime}%' or t.JMBG like '%{Ime}%' or concat(t.Ime, concat(' ', t.Prezime)) " +
            $"like '%{Ime}%' ";

        [Browsable(false)]
        public string Join => "t LEFT JOIN Tim ti on (t.TimId = ti.TimId)";

        [Browsable(false)]
        public List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader)
        {
            List<OpstiDomenskiObjekat> takmicari = new List<OpstiDomenskiObjekat>();

            while(reader.Read())
            {
                int? id = (int?)null;
                if(reader["TimId"]!=DBNull.Value)
                {
                    id = (int?)Int32.Parse(reader["TimId"].ToString());
                }
                Takmicar takmicar = new Takmicar
                {
                    TakmicarId = reader.GetInt32(0),
                    JMBG = (string)reader["JMBG"],
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    Pol = (string)reader["Pol"],
                    Tim = new Tim
                    {
                        TimId = id,
                        Naziv = reader["Naziv"] as string
                    }
                };
                takmicari.Add(takmicar);
            }

            return takmicari;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}