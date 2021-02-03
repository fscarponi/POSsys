using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class RegolaSteward : IVisitor
    {

        public void Visit(Evento evento)
        {
            int nas;
            int numStewardSettore;
            foreach (Settore settore in evento.SettoriAperti)
            {
                nas = (int)Math.Ceiling((settore.GetCapienzaInData(evento.DataInizio, Impianto.GetInstance()) / 250.0) * (1 + (evento.GradoRischio / 10.0)));
                numStewardSettore = (evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Steward Corta")).Count +
                    evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Steward Lunga")).Count);
                if (numStewardSettore < nas)
                    throw new ViolatedRuleException(nas - numStewardSettore,
                        String.Format("Settore {0} viola la regola di numero minimo di Steward per la mancanza di {1} Steward", settore.Nome, nas - numStewardSettore));

            }
        }

    }
}
