using POSsys.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public class Pagamenti
    {
        private readonly List<Pagamento> _listaPagamenti = new List<Pagamento>();
        private static Pagamenti _instance = null;

        protected Pagamenti() { }

        public static Pagamenti GetInstance()
        {
            if (_instance == null) _instance = new Pagamenti();
            return _instance;
        }

        public void AddPagamento(DateTime dataFine)
        {
            if (dataFine > DateTime.Now)
                throw new ArgumentException("Inserire un pagamento non futuro");
            else if (ListaPagamenti.Count == 0)
            {
                ListaPagamenti.Add(new Pagamento(DateTime.MinValue, dataFine));
            }
            else
            {
                ListaPagamenti.Add(new Pagamento(ListaPagamenti.Last().DataFine, dataFine));
            }
        }

        public Pagamento GetPagamento(DateTime data)
        {
            foreach (Pagamento pagamento in ListaPagamenti)
            {
                if (pagamento.DataInizio.CompareTo(data) <= 0 && pagamento.DataFine.CompareTo(data) > 0)
                    return pagamento;
            }
            return null;
        }
        public List<Pagamento> ListaPagamenti
        {
            get { return _listaPagamenti; }
        }

        internal void Load()
        {
            PersistenceFactory.getPagamentiLoader().Load();
        }
    }


}
