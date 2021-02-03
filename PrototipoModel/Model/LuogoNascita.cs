using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class LuogoNascita
    {
        private readonly string _comune;
        private readonly string _provincia;
        private readonly string _nazione;

        public LuogoNascita(string comune, string provincia, string nazione)
        {
            if (String.IsNullOrEmpty(comune))
                throw new ArgumentNullException("String.IsNullOrEmpty(comune)");
            _comune = comune;
            if (String.IsNullOrEmpty(provincia))
                throw new ArgumentNullException("String.IsNullOrEmpty(provincia)");
            _provincia = provincia;
            if (String.IsNullOrEmpty(nazione))
                throw new ArgumentNullException("String.IsNullOrEmpty(nazione)");
            _nazione = nazione;
        }


        public string Comune
        {
            get { return _comune; }
        }

        public string Provincia
        {
            get { return _provincia; }
        }

        public string Nazione
        {
            get { return _nazione; }
        }

        public override string ToString()
        {
            return Comune + " " + Provincia + " " + Nazione;
        }
    }
}
