using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class MansioneStewardLunga : MansioneSteward
    {
        public MansioneStewardLunga()
            : base(Servizio.Lunga) { }

        public override string ToString()
        {
            return "Steward Lunga";
        }
    }
}
