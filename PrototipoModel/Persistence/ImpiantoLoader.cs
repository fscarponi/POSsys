using POSsys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Persistence
{
    public class ImpiantoLoader : ILoader
    {
        string nomeBulgarelli = "Bulgarelli";
        string nomeDistinti="Distinti";
        string nomeTribuna="Tribuna";
        string nomeOspiti="Ospiti";
        public void Load()
        {
            LoadSettori();
            LoadLavori();
        }

        private void LoadSettori()
        {
            Impianto.GetInstance().AddSettore(new Settore(nomeBulgarelli, 1000));
            Impianto.GetInstance().AddSettore(new Settore(nomeDistinti, 2000));
            Impianto.GetInstance().AddSettore(new Settore(nomeTribuna, 1500));
            Impianto.GetInstance().AddSettore(new Settore(nomeOspiti, 500));
        }

        private void LoadLavori()
        {
            #region Lavoro1 10/10/2014-20/10/2014 (Tribuna -50 -20, Distinti -30 -20) "Modifica qualcosa"
            List<SettoreInteressato> list1 = new List<SettoreInteressato>();
            list1.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), -50, -20));
            list1.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), -30, -20));
            Impianto.GetInstance().AddLavoro(new Lavoro(new DateTime(2014, 10, 10), new DateTime(2014, 10, 20),
                list1, "Modifica"));
            #endregion
            #region Lavoro2 1/2/2014-15/5/2014 (Tribuna -70 -20, Bulgarelli -30 -30)  "Aggiunta cartello pubblicitario"
            List<SettoreInteressato> list2 = new List<SettoreInteressato>();
            list2.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), -70, -20));
            list2.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), -30, -30));
            Impianto.GetInstance().AddLavoro(new Lavoro(new DateTime(2014, 2, 1), new DateTime(2014, 5, 15),
                list2, "Aggiunta cartello publicitario"));
            #endregion
            #region Lavoro3 6/6/2014-30/9/2014 (Tribuna -10 30, Bulgarelli -15 30, Distinti  -20 40) "Aggiunta posti"
            List<SettoreInteressato> list3 = new List<SettoreInteressato>();
            list3.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), -10, 30));
            list3.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), -15, 30));
            list3.Add(new SettoreInteressato(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), -20, 40));
            Impianto.GetInstance().AddLavoro(new Lavoro(new DateTime(2014, 6, 6), new DateTime(2014, 9, 30),
                list3, "Aggiunta Posti"));
            #endregion
            
        }
    }
}
