using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class Settore : ISettore
    {
        public string _nome;
        public int _capienza;
        private bool _disattivato;

        public Settore(string nome, int capienza)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("String.IsNullOrEmpty(nome)");
            _nome = nome;
            if (capienza <= 0)
                throw new ArgumentException("capienza <= 0");
            _capienza = capienza;
            _disattivato = false;
        }

        public int GetCapienzaInData(DateTime data, IGetLavoro finder)
        {
            int capienzaData = Capienza;
            List<Lavoro> lavori = finder.GetLavoriPerSettore(this);
            foreach (Lavoro lavoro in lavori)
            {
                if (data.CompareTo(lavoro.DataInizio) >= 0 && data.CompareTo(lavoro.DataFine) <= 0)
                {
                    capienzaData += lavoro.SpecifichePerSettore(this).ModTemCapienza;
                }
                else if (data.CompareTo(lavoro.DataFine) > 0)
                {
                    capienzaData += lavoro.SpecifichePerSettore(this).ModDefCapienza;
                }
            }
            return capienzaData;


        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Capienza
        {
            get { return _capienza; }
            set { _capienza = value; }
        }

        public bool Disattivato
        {
            get { return _disattivato; }
            set { _disattivato = value; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Settore s = (Settore)obj;
                return Nome.Equals(s.Nome, StringComparison.OrdinalIgnoreCase);
            }
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() ^ Capienza.GetHashCode();
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}
