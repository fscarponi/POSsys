using POSsys.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Model
{
    public static class MansioneFactory
    {

        private static readonly Dictionary<string, Mansione> _mansioni =
            new Dictionary<string, Mansione>();

        public static Mansione GetMansione(string key){
            if (!_mansioni.ContainsKey(key))
            {
                _mansioni.Add(key, CreateInstance(key));
            }
            return _mansioni[key];
        }

        public static List<Mansione> GetMansioni()
        {
            return _mansioni.Values.ToList();
        }

        private static Mansione CreateInstance(string key)
        {
            switch (key)
            {
                case "Coordinatore":
                    return new MansioneCoordinatore();
                case "Capo Unità":
                    return new MansioneCapoUnita();
                case "Steward Lunga":
                    return new MansioneStewardLunga();
                case "Steward Corta":
                    return new MansioneStewardCorta();
                default:
                    throw new ArgumentException(key);
            }
        }

        public static void Load()
        {
            PersistenceFactory.getMansioniLoader().Load();
        }
    }
}
