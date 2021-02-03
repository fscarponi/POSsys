using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public interface ISettore
    {
        string Nome { get; set; }
        int Capienza { get; set; }
        bool Disattivato { get; set; }

        int GetCapienzaInData(DateTime data, IGetLavoro finder);
    }
}
