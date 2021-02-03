using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class SettoreInteressato
    {
        private readonly ISettore _settore;
        private int _modTemCapienza;
        private int _modDefCapienza;

        public SettoreInteressato(ISettore settore)
        {
            if (settore == null)
                throw new ArgumentException("Settore == null");
            _settore = settore;
        }
        public SettoreInteressato(ISettore settore, int modTemCapienza, int modDefCapienza)
        {
            if (settore == null)
                throw new ArgumentException("Settore == null");
            _settore = settore;
            _modTemCapienza = modTemCapienza;
            _modDefCapienza = modDefCapienza;
        }

        public ISettore Settore
        {
            get { return _settore; }
        }

        public int ModTemCapienza
        {
            get { return _modTemCapienza; }
            set { _modTemCapienza = value; }
        }

        public int ModDefCapienza
        {
            get { return _modDefCapienza; }
            set { _modDefCapienza = value; }
        }

        public override bool Equals(Object obj)/*_tipolavoro non è considerato discriminante per univocità dell'elemento*/
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                SettoreInteressato s = (SettoreInteressato)obj;
                return Settore.Equals(s.Settore) && ModTemCapienza == s.ModTemCapienza &&
                    ModDefCapienza == s.ModDefCapienza;
            }
        }

        public override int GetHashCode()
        {
            return Settore.GetHashCode() ^ ModTemCapienza.GetHashCode() ^ ModDefCapienza.GetHashCode();
        }

        public override string ToString()
        {
            return Settore.ToString();
        }
    }
}
