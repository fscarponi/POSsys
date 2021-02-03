using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class ViolatedRuleException : Exception
    {
        private readonly int _numMancante;

        protected ViolatedRuleException()
            : base() { }

        public ViolatedRuleException(int NumMancante) :
            base(String.Format("Regola violata a causa della mancanza di {0} personale", NumMancante))
        {
            _numMancante = NumMancante;
        }

        public ViolatedRuleException(int NumMancante, string message)
            : base(message)
        {
            _numMancante = NumMancante;
        }

        public int NumMancante
        {
            get { return _numMancante; }
        }
    }
}
