using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class MansioneCapoUnita : Mansione
    {

        public MansioneCapoUnita()
            : base(Qualifica.CapoUnita, Servizio.Lunga) { }

        public override string ToString()
        {
            return "Capo Unità";
        }
    }
}
