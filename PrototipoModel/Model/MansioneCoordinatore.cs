using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class MansioneCoordinatore : Mansione
    {

        public MansioneCoordinatore()
            : base(Qualifica.Coordinatore, Servizio.Lunga) { }

        public override string ToString()
        {
            return "Coordinatore";
        }
    }
}
