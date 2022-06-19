using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DbBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString);
        }

        public void OtvaranjeKonekcije()
        {
            connection.Open();
        }

        public void ZatvaranjeKonekcije()
        {
            connection.Close();
        }

        public void ZapocniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public int Sacuvaj(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"Insert into {domenskiObjekat.NazivTabele} values ({domenskiObjekat.VrednostiZaUnos})";

            return command.ExecuteNonQuery();
        }

        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.NazivTabele} {domenskiObjekat.Join}";

            SqlDataReader reader = command.ExecuteReader();

            List<OpstiDomenskiObjekat> rezultat = domenskiObjekat.ProcitajObjekte(reader);
            reader.Close();

            return rezultat;
        }

        public int VratiMaxId(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"SELECT MAX({domenskiObjekat.NazivTabele}id) FROM {domenskiObjekat.NazivTabele}";

            var id = command.ExecuteScalar();

            if (id == DBNull.Value)
            {
                return 1;
            }
            else
            {
                return (int)id;
            }
        }

        public List<OpstiDomenskiObjekat> Pretrazi(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.NazivTabele} {domenskiObjekat.Join} WHERE {domenskiObjekat.KriterijumPretrage}";
           
            SqlDataReader reader = command.ExecuteReader();
            
            List<OpstiDomenskiObjekat> rezultat = domenskiObjekat.ProcitajObjekte(reader);
           
            reader.Close();
            
            return rezultat;
        }

        public int Izmeni(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            
            command.CommandText = $"UPDATE {domenskiObjekat.NazivTabele} SET {domenskiObjekat.VrednostiZaIzmenu} WHERE {domenskiObjekat.KriterijumObrade}";
            
            var rezultat = command.ExecuteNonQuery();
           
            return rezultat;
        }

        public int Obrisi(OpstiDomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"DELETE FROM {domenskiObjekat.NazivTabele} WHERE {domenskiObjekat.KriterijumObrade}";

            int rezultat = command.ExecuteNonQuery();

            return rezultat;
        }
    }
}
