using POSsys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Persistence
{
    public class MansioniLoader : ILoader
    {
        string coordinatore = "Coordinatore";
        private string capoUnita = "Capo Unità";
        private string stewardLunga = "Steward Lunga";
        private string stewardCorta = "Steward Corta";
        public void Load()
        {
            MansioneFactory.GetMansione(coordinatore).AddRetribuzione(new RetribuzioneMansione(DateTime.MinValue, 45));
            MansioneFactory.GetMansione(capoUnita).AddRetribuzione(new RetribuzioneMansione(DateTime.MinValue, 35));
            MansioneFactory.GetMansione(stewardLunga).AddRetribuzione(new RetribuzioneMansione(DateTime.MinValue, 35));
            MansioneFactory.GetMansione(stewardCorta).AddRetribuzione(new RetribuzioneMansione(DateTime.MinValue, 23));
            MansioneFactory.GetMansione(coordinatore).AddRetribuzione(new RetribuzioneMansione(new DateTime(2014,1,1), 50));
            MansioneFactory.GetMansione(capoUnita).AddRetribuzione(new RetribuzioneMansione(new DateTime(2014, 1, 1), 37.5));
            MansioneFactory.GetMansione(stewardLunga).AddRetribuzione(new RetribuzioneMansione(new DateTime(2014, 1, 1), 37.5));
            MansioneFactory.GetMansione(stewardCorta).AddRetribuzione(new RetribuzioneMansione(new DateTime(2014, 1, 1), 30));
        }
    }
}
