using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class RegolaCapoUnita : IVisitor
    {

        public void Visit(Evento evento)
        {
            int minimoCapiUnita;
            int numCapiUnitaSettore;
            foreach (Settore settore in evento.SettoriAperti)
            {
                minimoCapiUnita = (int)Math.Ceiling((evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Steward Lunga")).Count +
                    evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Steward Corta")).Count)/10.0);
                numCapiUnitaSettore = evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Capo Unità")).Count;
                if (numCapiUnitaSettore < minimoCapiUnita)
                    throw new ViolatedRuleException(minimoCapiUnita - numCapiUnitaSettore,
                                            String.Format("Settore {0} viola la regola di numero minimo di Capi Unita per la mancanza di {1} Capo Unita", settore.Nome, minimoCapiUnita - numCapiUnitaSettore));
            }
        }
    }
}
