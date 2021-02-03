using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSsys.Persistence;

namespace POSsys.Model
{
    public class Impianto : IGetLavoro
    {
        private readonly List<ISettore> _settori = new List<ISettore>();
        private readonly List<Lavoro> _lavori = new List<Lavoro>();
        private static Impianto _instance = null;


        protected Impianto() { }

        public static Impianto GetInstance()
        {
            if (_instance == null)
                _instance = new Impianto();
            return _instance;
        }

        public void AddSettore(String name, int capienza)
        {
            ISettore nuovoSettore = new Settore(name, capienza);
            if (GetSettoriAttivi().Contains(nuovoSettore)) throw new ArgumentException("Settore gia estistente");
            else if (Settori.Contains(nuovoSettore))
            {
                Settori.Find(settore => settore.Nome == name).Capienza = capienza;
                Settori.Find(settore => settore.Nome == name).Disattivato = false;
            }
            else
                Settori.Add(nuovoSettore);
        }

        public void AddSettore(ISettore nuovoSettore)
        {
            if (nuovoSettore == null || GetSettoriAttivi().Contains(nuovoSettore))
                throw new ArgumentException("nuovoSettore == null || Settore gia estistente");
            else if (Settori.Contains(nuovoSettore))
            {
                Settori.Find(settore => settore.Nome.Equals(nuovoSettore.Nome, StringComparison.OrdinalIgnoreCase)).Capienza = nuovoSettore.Capienza;
                Settori.Find(settore => settore.Nome.Equals(nuovoSettore.Nome, StringComparison.OrdinalIgnoreCase)).Disattivato = false;
            }
            else
                Settori.Add(nuovoSettore);
        }

        public ISettore GetSettorePerNome(string nome)
        {
            foreach (ISettore settore in GetSettoriAttivi())
            {
                if (settore.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)) return settore;
            }
            return null;
        }

        public List<ISettore> GetSettoriAttivi()
        {        
            return Settori.FindAll(settore => settore.Disattivato == false);
        }

        public bool RemoveSettore(ISettore settore)
        {
            if (settore == null || settore.Disattivato == true)
                return false;
            foreach (Evento evento in Eventi.GetInstance().ListaEventi)
            {
                if (evento.SettoriAperti.Contains(settore))
                    return GetSettorePerNome(settore.Nome).Disattivato = true;
            }
            return Settori.Remove(settore);
        }

        public void AddLavoro(Lavoro lavoro)
        {
            if (lavoro == null || Lavori.Contains(lavoro))
                throw new ArgumentException("lavoro==null || lavoro gia estistente");
            Lavori.Add(lavoro);
            Lavori.Sort(new LavoroComparer());
        }

        public List<Lavoro> GetLavoriPerSettore(ISettore settore)
        {
            List<Lavoro> lavori = new List<Lavoro>();
            if (!Settori.Contains(settore)) return lavori;
            foreach (Lavoro lavoro in Lavori)
            {
                if (lavoro.InteressaSettore(settore)) lavori.Add(lavoro);
            }
            return lavori;
        }

        public bool RemoveLavoro(Lavoro lavoro)
        {
            return Lavori.Remove(lavoro);
        }

        public List<Lavoro> Lavori
        {
            get { return _lavori; }
        }

        public List<ISettore> Settori
        {
            get { return _settori; }
        }

        public void Load()
        {
            PersistenceFactory.getImpiantoLoader().Load();
        }
    }
}
