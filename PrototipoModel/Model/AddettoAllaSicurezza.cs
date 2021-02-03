using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class AddettoAllaSicurezza : IPersonale
    {

        private readonly string _nome;
        private readonly string _cognome;
        private readonly string _cf;
        private readonly DateTime _dataNascita;
        private readonly LuogoNascita _luogoNascita;
        private Indirizzo[] _indirizzi = new Indirizzo[2];
        private readonly DateTime _dataAssunzione;
        private DateTime _dataLicenziamento = DateTime.MaxValue;
        private Qualifica _qualifica;


        public AddettoAllaSicurezza(string nome, string cognome, string cf, DateTime dataNascita,
            LuogoNascita luogoNascita, DateTime dataAssunzione, params Indirizzo[] indirizzi)
            : this(nome, cognome, cf, dataNascita, luogoNascita,
                dataAssunzione, Qualifica.Steward, indirizzi)
        {
        }

        public AddettoAllaSicurezza(string nome, string cognome, string cf, DateTime dataNascita,
            LuogoNascita luogoNascita, DateTime dataAssunzione, Qualifica qualifica, params Indirizzo[] indirizzi)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("String.IsNullOrEmpty(nome)");
            _nome = nome;
            if (String.IsNullOrEmpty(cognome))
                throw new ArgumentException("String.IsNullOrEmpty(cognome)");
            _cognome = cognome;
            if (String.IsNullOrEmpty(cf))
                throw new ArgumentException("String.IsNullOrEmpty(cf)");
            _cf = cf;
            if (dataNascita.AddYears(16) > DateTime.Now)/*controllo età minima anni 16*/
                throw new ArgumentException("la data di nascita non è ammisibile!");
            _dataNascita = dataNascita;
            if (luogoNascita == null)
                throw new ArgumentException("luogoNascita == null");
            _luogoNascita = luogoNascita;
            if (indirizzi == null || indirizzi[0] == null || indirizzi.Length > 2)
                throw new ArgumentException("indirizzi == null || Indirizzo residenza non fornito|| indirizzi.Length>2");
            else
            {
                _indirizzi[0] = indirizzi[0];
                if (indirizzi.Length == 2 && indirizzi[1] != null)
                {
                    _indirizzi[1] = indirizzi[1];
                }
                else if (indirizzi.Length == 2 && indirizzi[1] == null)
                    throw new ArgumentException("indirizzi[1] != null ");
            }
            if (dataAssunzione > DateTime.Now)
                throw new ArgumentException("non e' ancora stato assunto");
            _dataAssunzione = dataAssunzione;
            _qualifica = qualifica;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string Cognome
        {
            get { return _cognome; }
        }

        public string Cf
        {
            get { return _cf; }
        }

        public DateTime DataNascita
        {
            get { return _dataNascita; }
        }

        public LuogoNascita LuogoNascita
        {
            get { return _luogoNascita; }
        }

        public Indirizzo Residenza
        {
            get { return _indirizzi[0]; }
            set { _indirizzi[0] = value; }
        }
        public Indirizzo Domicilio
        {
            get { return _indirizzi[1]; }
            set { _indirizzi[1] = value; }
        }

        public DateTime DataAssunzione
        {
            get { return _dataAssunzione; }
        }

        public DateTime DataLicenziamento
        {
            get { return _dataLicenziamento; }
            set { _dataLicenziamento = value; }
        }

        public Qualifica Qualifica
        {
            get { return _qualifica; }
            set { _qualifica = value; }
        }

        public bool IsAttivo()
        {

            return DataLicenziamento == DateTime.MaxValue;
        }

        public bool HasDomicilio()
        {
            return Domicilio != null;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                AddettoAllaSicurezza a = (AddettoAllaSicurezza)obj;
                return Cf == a.Cf;
            }
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() ^ Cognome.GetHashCode() ^ Cf.GetHashCode() ^ DataNascita.GetHashCode() ^
                LuogoNascita.GetHashCode() ^ Residenza.GetHashCode() ^ DataAssunzione.GetHashCode() ^ Qualifica.GetHashCode();
        }

    }
}
