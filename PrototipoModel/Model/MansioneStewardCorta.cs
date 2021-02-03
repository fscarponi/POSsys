using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class MansioneStewardCorta : MansioneSteward
    {
        public MansioneStewardCorta()
            : base(Servizio.Corta) { }

        public override string ToString()
        {
            return "Steward Corta";
        }
    }
}
