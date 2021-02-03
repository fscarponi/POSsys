using POSsys.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public static class PersonaleFactory
    {
        private static readonly Dictionary<string, IPersonale> _personale =
            new Dictionary<string, IPersonale>();


        // Prende in ingresso una nuova istanza di IPersonale, la inserisce nel dizionario e restiuisce la chiave associata
        public static void AddPersonale(IPersonale persona)
        {
            if (persona == null || Personale.ContainsKey(persona.Cf))
            {
                throw new ArgumentException("Persona gia' definita nel personale");
            }
            else
            {
                Personale[persona.Cf] = persona;
            }
        }

        // Restituisce la persona associata alla chiave passata come argomento
        public static IPersonale GetPersonale(string key)
        {
            if (!String.IsNullOrEmpty(key) && Personale.ContainsKey(key))
            {
                return Personale[key];
            }
            else
            {
                return null;
            }
        }

        // Restituisce tutto il personale
        public static List<IPersonale> GetTuttoPersonale()
        {
            return Personale.Values.ToList();
        }

        // Restituisce tutto il personale che può lavorare
        public static List<IPersonale> GetPersonaleAttivo()
        {
            List<IPersonale> lista = new List<IPersonale>();
            foreach (IPersonale persona in GetTuttoPersonale())
            {
                if (persona.IsAttivo())
                {
                    lista.Add(persona);
                }
            }
            return lista;
        }

        // Restituisce tutto il personale che non può lavorare
        public static List<IPersonale> GetPersonaleLicenziato()
        {
            List<IPersonale> lista = new List<IPersonale>();
            foreach (IPersonale persona in GetTuttoPersonale())
            {
                if (!persona.IsAttivo())
                {
                    lista.Add(persona);
                }
            }
            return lista;
        }

        // Restituisce tutto il personale che era attivo nella data passata come argomento
        public static List<IPersonale> GetPersonaleAttivoEntro(DateTime data)
        {
            List<IPersonale> lista = GetPersonaleAttivo();
            foreach (IPersonale persona in GetPersonaleLicenziato())
            {
                if (persona.DataLicenziamento > data)
                {
                    lista.Add(persona);
                }
            }
            return lista;
        }

        // Restituisce tutto il personale che possiede la qualifica passata come argomento, o superiore
        public static List<IPersonale> GetPersonaleQualificato(Qualifica qualifica)
        {
            List<IPersonale> lista = new List<IPersonale>();
            foreach (IPersonale persona in GetTuttoPersonale())
            {
                if (persona.Qualifica >= qualifica)
                {
                    lista.Add(persona);
                }
            }
            return lista;
        }

        private static Dictionary<string, IPersonale> Personale
        {
            get { return _personale; }
        }


        public  static void Load()
        {
            PersistenceFactory.getPersonaleFactoryLoader().Load();
        }
    }
}
