using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public class Evento : IComparable
    {

        private string _nome;
        private DateTime _dataInizio;
        private DateTime _dataFine;
        private readonly int _gradoRischio;
        private readonly List<ISettore> _settoriAperti;
        private readonly Dictionary<ISettore, Assegnamenti> _disposizionePersonale = new Dictionary<ISettore, Assegnamenti>();


        public Evento(string nome, DateTime dataInizio, DateTime dataFine, int gradoRischio, List<ISettore> settoriAperti)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("String.IsNullOrEmpty(nome)");
            _nome = nome;
            if (dataInizio.CompareTo(dataFine) > 0)
                throw new ArgumentException("Date errate, dataInizio > dataFine");
            _dataInizio = dataInizio;
            _dataFine = dataFine;
            if (gradoRischio <= 0 || gradoRischio >= 11)
                throw new ArgumentException("gradoRischio <= 0 || gradoRischio >= 11");
            _gradoRischio = gradoRischio;
            if (settoriAperti == null || settoriAperti.Count == 0)
                throw new ArgumentException("settoriAperti.Count == 0");
            _settoriAperti = settoriAperti;
            foreach (ISettore settore in settoriAperti)
            {
                DisposizionePersonale[settore] = new Assegnamenti();
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        // Dato un settore, una persona e una mansione, inserisce l'assegnazione nel settore
        public void AddPersonaleSettore(ISettore settore, IPersonale persona, Mansione mansione)
        {
            if (settore == null || persona == null || mansione == null || !SettoriAperti.Contains(settore))
                throw new ArgumentException("settore == null || persona == null || mansione == null || Settore passato non aperto");
            foreach (Assegnamenti assegnamento in DisposizionePersonale.Values.ToList())
            {
                if (assegnamento.GetAssegnamento(persona) != null)
                    throw new ArgumentException("La persona è gia' stata assegnata in un altro settore");
            }
            DisposizionePersonale[settore].AddAssegnamento(persona, mansione);
        }

        public bool RemovePersonale(IPersonale persona)
        {
            foreach (Settore settore in SettoriAperti)
            {
                if (GetAssegnamentiSettore(settore) != null)
                    if (GetAssegnamentiSettore(settore).RemoveAddetto(persona) == true) return true;
            }
            return false;
        }

        public void AddAssegnamentiSettore(ISettore settore, Assegnamenti assegnamento)
        {
            if (settore == null || assegnamento == null || !SettoriAperti.Contains(settore))
                throw new ArgumentException("settore == null || assegnamento == null || Settore passato non aperto");
            else
                DisposizionePersonale[settore] = assegnamento;
        }

        // Per un settore passato come argomenti, restituisce tutti gli assegnamenti
        public Assegnamenti GetAssegnamentiSettore(ISettore settore)
        {
            if (settore != null && DisposizionePersonale.ContainsKey(settore))
                return DisposizionePersonale[settore];
            else
                return null;
        }
        public void ApriNuovoSettore(ISettore settore)
        {
            if (SettoriAperti.Contains(settore))
                throw new ArgumentException("Settore gia' aperto");
            SettoriAperti.Add(settore);
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        public int GradoRischio
        {
            get { return _gradoRischio; }
        }

        public TimeSpan Durata
        {
            get { return (DataFine - DataInizio); }
        }

        public List<ISettore> SettoriAperti
        {
            get { return _settoriAperti; }
        }

        public Dictionary<ISettore, Assegnamenti> DisposizionePersonale
        {
            get { return _disposizionePersonale; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType() != GetType())
                throw new ArgumentException();
            Evento e = (Evento)obj;
            return DataInizio.CompareTo(e.DataInizio);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Evento e = (Evento)obj;
                if (Nome != e.Nome || DataInizio != e.DataInizio || DataFine != e.DataFine ||
                    GradoRischio != e.GradoRischio || SettoriAperti.Count != e.SettoriAperti.Count) return false;
                foreach (ISettore settore in e.SettoriAperti)
                {
                    if (!SettoriAperti.Contains(settore)) return false;
                }
                return true;
            }
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() ^ DataInizio.GetHashCode() ^ DataFine.GetHashCode() ^ GradoRischio.GetHashCode() ^
                Durata.GetHashCode() ^ SettoriAperti.GetHashCode() ^ DisposizionePersonale.GetHashCode();
        }

        public override string ToString()
        {
            return "Evento: " + Nome + " Inizio: " + DataInizio + " Fine: " + DataFine;
        }
    }

    public class EventoComparer : IComparer<Evento>
    {

        public int Compare(Evento obj1, Evento obj2)
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
