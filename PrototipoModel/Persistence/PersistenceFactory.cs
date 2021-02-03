using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Persistence
{
    public static class PersistenceFactory
    {
        public static ILoader getImpiantoLoader()
        {
            return new ImpiantoLoader();
        }

        public static ILoader getPersonaleFactoryLoader()
        {
            return new PersonaleFactoryLoader();
        }

        public static ILoader getMansioniLoader()
        {
            return new MansioniLoader();
        }

        public static ILoader getEventiLoarder()
        {
            return new EventiLoader();
        }

        internal static ILoader getPagamentiLoader()
        {
            return new PagamentiLoader();
        }
    }
}
