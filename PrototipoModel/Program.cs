using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSsys.Persistence;
using POSsys.Model;
using System.Windows.Forms;
using POSsys.View;

namespace POSsys
{
    public class Program
    {

        static void Main(string[] args)
        {
            Impianto.GetInstance().Load();
            #region Stampe Impianto
            //foreach (Settore s in Impianto.GetInstance().Settori)
            //    Console.WriteLine(s);          
            //foreach (Lavoro l in Impianto.GetInstance().Lavori)            
            //    Console.WriteLine(l);                       
            #endregion
            PersonaleFactory.Load();
            #region Stampe Personale
            //Console.WriteLine("Numero Coordinatori: " + PersonaleFactory.GetPersonaleQualificato(Qualifica.Coordinatore).Count);
            //Console.WriteLine("Numero Capi Unita: " + (PersonaleFactory.GetPersonaleQualificato(Qualifica.CapoUnita).Count -
            //    PersonaleFactory.GetPersonaleQualificato(Qualifica.Coordinatore).Count));
            //Console.WriteLine("Numero Steward: " + (PersonaleFactory.GetPersonaleQualificato(Qualifica.Steward).Count -
            //    PersonaleFactory.GetPersonaleQualificato(Qualifica.CapoUnita).Count));
            //foreach (IPersonale p in PersonaleFactory.GetTuttoPersonale())            
            //    Console.WriteLine(p);             
            #endregion
            MansioneFactory.Load();
            #region Stampe Mansione
            //foreach (Mansione m in MansioneFactory.GetMansioni())
            //{
            //    Console.WriteLine(m);
            //    foreach (RetribuzioneMansione rm in m.Retribuzioni)
            //        Console.WriteLine(rm);
            //} 
            #endregion
            Eventi.GetInstance().Load();
            #region Stampe Eventi
            //foreach (Evento e in Eventi.GetInstance().ListaEventi)
            //    Console.WriteLine(e);  
            #endregion           
            Pagamenti.GetInstance().Load();
            #region Stampe Pagamenti
            //foreach (Pagamento p in Pagamenti.GetInstance().ListaPagamenti)
             //   Console.WriteLine(p);  
            #endregion           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
