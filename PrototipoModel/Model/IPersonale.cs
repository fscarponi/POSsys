using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public interface IPersonale
    {
        string Nome { get; }
        string Cognome { get; }
        string Cf { get; }
        DateTime DataNascita { get; }
        LuogoNascita LuogoNascita { get; }
        Indirizzo Residenza { get; set; }
        Indirizzo Domicilio { get; set; }
        DateTime DataAssunzione { get; }
        DateTime DataLicenziamento { get; set; }
        Qualifica Qualifica { get; set; }
        bool IsAttivo();
        bool HasDomicilio();
    }
}
