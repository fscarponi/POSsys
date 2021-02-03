using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class Assegnamenti
    {


        private readonly Dictionary<IPersonale, Mansione> _assegnamento = new Dictionary<IPersonale, Mansione>();

        // Aggiunge la persona passata come parametro al dizionario, associandogli la mansione fornita
        public void AddAssegnamento(IPersonale persona, Mansione mansione)
        {
            if (persona == null || mansione == null || Assegnamento.ContainsKey(persona) || persona.Qualifica < mansione.Incarico)
                throw new ArgumentException("persona == null, mansione == null || Alla persona e' gia' stata assegnata una mansione || Persona non abbastanza qualificata per la mansione");
            else
                Assegnamento[persona] = mansione;
        }

        //Restituisce la masione assegnata all'addetto passato come argomento
        public Mansione GetAssegnamento(IPersonale persona)
        {
            if (persona != null && Assegnamento.ContainsKey(persona))
                return Assegnamento[persona];
            else
                return null;
        }

        //Restituisce tutti le chiavi, quindi tutti gli addetti alla sicurezza che hanno una mansione assegnata
        public List<IPersonale> GetAddetti()
        {
            return Assegnamento.Keys.ToList();
        }

        //Restituisce tutti gli addetti a cui è stata assegnata la mansione passata come argomento
        public List<IPersonale> GetAddetti(Mansione mansione)
        {
            List<IPersonale> lista = new List<IPersonale>();
            foreach (IPersonale persona in Assegnamento.Keys)
                if (Assegnamento[persona].Equals(mansione))
                    lista.Add(persona);
            return lista;
        }

        public bool RemoveAddetto(IPersonale persona)
        {
            return Assegnamento.Remove(persona);
        }

        private Dictionary<IPersonale, Mansione> Assegnamento
        {
            get { return _assegnamento; }
        }
    }
}
