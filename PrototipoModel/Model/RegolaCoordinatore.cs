using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class RegolaCoordinatore : IVisitor
    {
        private readonly int _minimoCoordinatori;

        public RegolaCoordinatore()
        {
            _minimoCoordinatori = 1;
        }

        public void Visit(Evento evento)
        {
            int numCoordinatoriSettore;
            foreach (Settore settore in evento.SettoriAperti)
            {
                numCoordinatoriSettore = evento.GetAssegnamentiSettore(settore).GetAddetti(MansioneFactory.GetMansione("Coordinatore")).Count;
                if (numCoordinatoriSettore < MinimoCoordinatori)
                    throw new ViolatedRuleException(MinimoCoordinatori - numCoordinatoriSettore,
                        String.Format("Settore {0} viola la regola di numero minimo di Coordinatori per la mancanza di {1} Coordinatore", settore.Nome, MinimoCoordinatori - numCoordinatoriSettore));
            }
        }

        private int MinimoCoordinatori
        {
            get { return _minimoCoordinatori; }
        }
    }
}
