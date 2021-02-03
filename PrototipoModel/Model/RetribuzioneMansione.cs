using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model 
{
    public class RetribuzioneMansione : IComparable
    {
        private DateTime _dataInizioValidita;
        private DateTime _dataFineValitida;
        private readonly double _compenso;

        public RetribuzioneMansione(DateTime dataInzioValidita, double compenso)
            : this(dataInzioValidita, DateTime.MaxValue, compenso)
        {
        }

        public RetribuzioneMansione(DateTime dataInzioValidita, DateTime dataFineValidita, double compenso)
        {
            if (dataInzioValidita>dataFineValidita)
                throw new ArgumentException("Date errate, dataInzioValidita > dataFineValidita");
            _dataInizioValidita = dataInzioValidita;
            _dataFineValitida = dataFineValidita;
            if (compenso < 0)
                throw new ArgumentException("Compenso Negativo");
            _compenso = compenso;
        }

        public DateTime DataInizioValidita
        {
            get { return _dataInizioValidita; }
            set { _dataInizioValidita = value; }
        }

        public DateTime DataFineValitida
        {
            get { return _dataFineValitida; }
            set { _dataFineValitida = value; }

        }

        public double Compenso
        {
            get { return _compenso; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                RetribuzioneMansione rm = (RetribuzioneMansione)obj;
                return (DataInizioValidita == rm.DataInizioValidita) && (DataFineValitida == rm.DataFineValitida) &&
                    (Compenso == rm.Compenso);
            }
        }

        public override int GetHashCode()
        {
            return DataInizioValidita.GetHashCode() ^ DataFineValitida.GetHashCode() ^ 
                Compenso.GetHashCode();
        }

        public override string ToString()
        {
            return "Data Inizio: " + DataInizioValidita + " Data fine: " + DataFineValitida + " Compenso:" + Compenso;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType() != GetType())  
                throw new ArgumentException();
            RetribuzioneMansione p = (RetribuzioneMansione)obj;
            return DataInizioValidita.CompareTo(p.DataInizioValidita);
        }
    }

    public class RetribuzioneMansioneComparer : IComparer<RetribuzioneMansione>
    {

        public int Compare(RetribuzioneMansione obj1, RetribuzioneMansione obj2)
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
