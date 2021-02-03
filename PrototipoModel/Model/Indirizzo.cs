using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class Indirizzo
    {
        private readonly string _via;
        private readonly string _numCivico;
        private readonly string _comune;
        private readonly int _cap;
        private readonly string _provincia;
        private readonly string _nazione;


        public Indirizzo(string via, string numCivico, string comune, int cap, string provincia, string nazione)
        {
            if (String.IsNullOrEmpty(via))
                throw new ArgumentNullException("String.IsNullOrEmpty(via)");
            _via = via;
            if (String.IsNullOrEmpty(numCivico))
                throw new ArgumentNullException("String.IsNullOrEmpty(numCivico)");
            _numCivico = numCivico;
            if (String.IsNullOrEmpty(comune))
                throw new ArgumentNullException("String.IsNullOrEmpty(comune)");
            _comune = comune;
            if ( cap <= 0 || cap >= 100000 )
                throw new ArgumentException("cap < 0 || cap > 100000");
            _cap = cap; 
            if (String.IsNullOrEmpty(provincia))
                throw new ArgumentNullException("String.IsNullOrEmpty(provincia)");
            _provincia = provincia;
            if (String.IsNullOrEmpty(nazione))
                throw new ArgumentNullException("String.IsNullOrEmpty(nazione)");
            _nazione = nazione;
        }

        public string Via
        {
            get { return _via; }
        }

        public string NumCivico
        {
            get { return _numCivico; }
        }

        public string Comune
        {
            get { return _comune; }
        }

        public int Cap
        {
            get { return _cap; }
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
            return Via + " n°" + NumCivico + ", " + Cap + " " + Comune + " " + Provincia + ", " + Nazione; 
        }

    }
}
