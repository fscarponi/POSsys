using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class Lavoro : IComparable
    {
        private readonly DateTime _dataInizio;
        private readonly DateTime _dataFine;
        private readonly List<SettoreInteressato> _settoriInteressati;
        private readonly string _descrizione;

        public Lavoro(DateTime dataInizio, DateTime dataFine, List<SettoreInteressato> settoriInteressati, string descrizione)
        {
            if (dataInizio > dataFine)
                throw new ArgumentException("Date lavoro errate, lavoro finito ancora prima di iniziare");
            _dataInizio = dataInizio;
            _dataFine = dataFine;
            if (settoriInteressati == null || settoriInteressati.Count == 0)
                throw new ArgumentException("non interessa alcun settore");
            _settoriInteressati = settoriInteressati;
            if (String.IsNullOrEmpty(descrizione))
                throw new ArgumentNullException("String.IsNullOrEmpty(descrizione)");
            _descrizione = descrizione;
        }

        public bool InteressaSettore(ISettore settore)
        {
            foreach (SettoreInteressato settoreInressato in SettoriInteressati)
            {
                if (settoreInressato.Settore.Equals(settore)) return true;
            }
            return false;
        }

        public SettoreInteressato SpecifichePerSettore(ISettore settore)
        {
            foreach (SettoreInteressato settoreInressato in SettoriInteressati)
            {
                if (settoreInressato.Settore.Equals(settore)) return settoreInressato;
            }
            return null;

        }

        public DateTime DataInizio
        {
            get { return _dataInizio; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
        }

        public List<SettoreInteressato> SettoriInteressati
        {
            get { return _settoriInteressati; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Lavoro l = (Lavoro)obj;

                if (DataInizio != l.DataInizio || DataFine != l.DataFine ||
                    !(SettoriInteressati.Count == l.SettoriInteressati.Count)) return false;
                foreach (SettoreInteressato s in SettoriInteressati)
                {
                    if (!l.InteressaSettore(s.Settore)) return false;
                }
                return true;
            }

        }

        public override int GetHashCode()
        {
            return DataInizio.GetHashCode() ^ DataFine.GetHashCode() ^ SettoriInteressati.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType() != GetType())
                throw new ArgumentException();
            Lavoro e = (Lavoro)obj;
            return DataInizio.CompareTo(e.DataInizio);
        }

        public override string ToString()
        {
            return "Lavoro con Inizio: " + DataInizio + " Fine: " + DataFine + " Descrizione: " + Descrizione;
        }
    }

    public class LavoroComparer : IComparer<Lavoro>
    {

        public int Compare(Lavoro obj1, Lavoro obj2)
        {
            int retCode;
            if (obj1 == obj2)
                retCode = 0;
            else if (obj1 == null)
                retCode = -1;
            else if (obj2 == null)
                retCode = 1;
            else
                retCode = obj1.CompareTo(obj2);
            return retCode;
        }

    }
}
