using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public abstract class MansioneSteward : Mansione
    {

        public MansioneSteward(Servizio servizio)
            : base(Qualifica.Steward, servizio) { }

    }
}
