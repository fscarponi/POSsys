using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSsys.Persistence;


namespace POSsys.Model
{
    public class Eventi
    {
        private readonly List<Evento> _listaEventi = new List<Evento>();
        private static Eventi _instance = null;

        protected Eventi() { }

        public static Eventi GetInstance()
        {
            if (_instance == null) _instance = new Eventi();
            return _instance;
        }

        public void AddEvento(Evento evento)
        {
            if (evento == null || ListaEventi.Contains(evento))
                throw new ArgumentException("evento==null || Evento gia' definito");
            foreach (Evento singoliEventi in ListaEventi)
            {
                if (((evento.DataInizio + evento.Durata) > singoliEventi.DataInizio && evento.DataInizio < singoliEventi.DataInizio)
                    || ((evento.DataFine - evento.Durata) < singoliEventi.DataFine && evento.DataFine > singoliEventi.DataFine)
                    || (evento.DataInizio >= singoliEventi.DataInizio && evento.DataFine <= singoliEventi.DataFine))
                    throw new ArgumentException("L'evento coincide con un altro evento programmato");
            }
            ListaEventi.Add(evento);
            ListaEventi.Sort(new EventoComparer());
        }

        public Evento GetEvento(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("String.IsNullOrEmpty(nome)");
            foreach (Evento evento in ListaEventi)
            {
                if (evento.Nome == nome) return evento;
            }
            return null;
        }

        public List<Evento> GetEventi(DateTime dataInizio, DateTime dataFine)
        {
            List<Evento> listaEventi = new List<Evento>();
            foreach (Evento evento in ListaEventi)
            {
                if (evento.DataInizio >= dataInizio &&
                    evento.DataInizio <= dataFine)
                    listaEventi.Add(evento);
            }
            return listaEventi;
        }

        public List<Evento> GetEventiFuturi()
        {
            List<Evento> listaEventi = new List<Evento>();
            foreach (Evento evento in ListaEventi)
            {
                if (evento.DataInizio >= DateTime.Now)
                    listaEventi.Add(evento);
            }
            return listaEventi;
        }

        public bool RemoveEvento(Evento evento)
        {
            if(GetEventiFuturi().Contains(evento))
                return ListaEventi.Remove(evento);
            return false;
        }

        public List<Evento> ListaEventi
        {
            get { return _listaEventi; }
        }

        public void Load()
        {
            PersistenceFactory.getEventiLoarder().Load();
        }
    }
}
