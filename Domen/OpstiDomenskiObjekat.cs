using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string NazivTabele { get; }
        string PovratneVrednosti { get; }
        string VrednostiZaUnos { get; }
        string VrednostiZaIzmenu { get; }
        string KriterijumObrade { get; }
        string KriterijumPretrage { get; }
        string Join { get; }
        List<OpstiDomenskiObjekat> ProcitajObjekte(SqlDataReader reader);
    }
}
