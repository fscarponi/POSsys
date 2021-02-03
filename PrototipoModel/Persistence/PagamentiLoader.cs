using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSsys.Model;

namespace POSsys.Persistence
{
    public class PagamentiLoader : ILoader
    {
        public void Load()
        {

            #region Pagamento1 MinValue-1/1/2013
            Pagamenti.GetInstance().AddPagamento(new DateTime(2014, 1, 1));
            #endregion
            #region Pagamento2 1/1/2014-1/6/2014
            Pagamenti.GetInstance().AddPagamento(new DateTime(2014, 6, 1));
            #endregion
        }
    }
}
