using POSsys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSsys.Persistence
{
    public class EventiLoader : ILoader
    {
        string nomeBulgarelli = "Bulgarelli";
        string nomeDistinti = "Distinti";
        string nomeTribuna = "Tribuna";
        string nomeOspiti = "Ospiti";
        List<IPersonale> addetti;

        public void Load()
        {

            addetti = PersonaleFactory.GetPersonaleAttivo();
            #region Evento1 Bologna-Milan 15/11/2013 15:00 15/11/2013 17:00 3 Aperti(Bulgarelli, Tribuna)
            List<ISettore> lista1 = new List<ISettore>();
            lista1.Add(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli));
            lista1.Add(Impianto.GetInstance().GetSettorePerNome(nomeTribuna));
            Evento evento1 = new Evento("Bologna-Milan", new DateTime(2013, 11, 15, 15, 0, 0), new DateTime(2013, 11, 15, 17, 0, 0), 3, lista1);
            #region Assegnamenti Bulgarelli
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("StefanoGrandi"), MansioneFactory.GetMansione("Coordinatore"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("CristinaEndrizzi"), MansioneFactory.GetMansione("Capo Unità"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("CataldoCosta"), MansioneFactory.GetMansione("Capo Unità"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("GinaSiciliano"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("MelissaTrevisano"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("LaviniaMarcelo"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("CrispinoDeLuca"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ProsperoPiazza"), MansioneFactory.GetMansione("Steward Lunga"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ElianoGreece"), MansioneFactory.GetMansione("Steward Lunga"));
            #endregion
            #region Assegnamenti Tribuna
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("FerruccioCalabresi"), MansioneFactory.GetMansione("Coordinatore"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("EufrosinaSiciliano"), MansioneFactory.GetMansione("Capo Unità"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("LuigiaMarcelo"), MansioneFactory.GetMansione("Capo Unità"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("MarcelloPisano"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("VitaleBellucci"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AmaliaTrentini"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AngeloFallaci"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AlbertoMancini"), MansioneFactory.GetMansione("Steward Corta"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AdeleMilanesi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CandidoSal"), MansioneFactory.GetMansione("Steward Lunga"));
            evento1.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("FerruccioCalabrese"), MansioneFactory.GetMansione("Steward Lunga"));
            #endregion
            evento1.Accept(new RegolaCoordinatore());
            evento1.Accept(new RegolaCapoUnita());
            evento1.Accept(new RegolaSteward());
            evento1.Accept(new GeneraPOS());
            #endregion
            #region Evento2 Bologna-Juventus 23/12/2013 15:00 23/12/2013 17:00 7 Aperti(Bulgarelli, Ospiti)
            List<ISettore> lista2 = new List<ISettore>();
            lista2.Add(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli));
            lista2.Add(Impianto.GetInstance().GetSettorePerNome(nomeOspiti));
            Evento evento2 = new Evento("Bologna-Juventus", new DateTime(2013, 12, 23, 15, 0, 0), new DateTime(2013, 12, 23, 17, 0, 0), 7, lista2);
            #region assegnamenti Bulgarelli
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("StefanoGrandi"), MansioneFactory.GetMansione("Coordinatore"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("GiacintoGreece"), MansioneFactory.GetMansione("Capo Unità"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("GinaSiciliano"), MansioneFactory.GetMansione("Steward Lunga"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("MelissaTrevisano"), MansioneFactory.GetMansione("Steward Lunga"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("LaviniaMarcelo"), MansioneFactory.GetMansione("Steward Corta"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("CrispinoDeLuca"), MansioneFactory.GetMansione("Steward Corta"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ProsperoPiazza"), MansioneFactory.GetMansione("Steward Corta"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ElianoGreece"), MansioneFactory.GetMansione("Steward Corta"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("MarcelloPisano"), MansioneFactory.GetMansione("Steward Corta"));
            #endregion
            #region assegnamenti ospiti
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("CristinaEndrizzi"), MansioneFactory.GetMansione("Coordinatore"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("AntoninaOnio"), MansioneFactory.GetMansione("Capo Unità"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("VitaleBellucci"), MansioneFactory.GetMansione("Steward Lunga"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("AmaliaTrentini"), MansioneFactory.GetMansione("Steward Lunga"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("AngeloFallaci"), MansioneFactory.GetMansione("Steward Lunga"));
            evento2.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("AlbertoMancini"), MansioneFactory.GetMansione("Steward Corta"));
            #endregion
            evento2.Accept(new RegolaCoordinatore());
            evento2.Accept(new RegolaCapoUnita());
            evento2.Accept(new RegolaSteward());
            evento2.Accept(new GeneraPOS());
            #endregion
            #region Evento3 Bologna-Inter 1/2/2014 20:45 1/2/2014 23:00 10 Aperti(Distinti)
            List<ISettore> lista3 = new List<ISettore>();
            lista3.Add(Impianto.GetInstance().GetSettorePerNome(nomeDistinti));
            Evento evento3 = new Evento("Bologna-Inter", new DateTime(2014, 2, 1, 20, 45, 0), new DateTime(2014, 2, 1, 23, 0, 0), 10, lista3);
            #region assegnamenti Distinti
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("StefanoGrandi"), MansioneFactory.GetMansione("Coordinatore"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("LuigiaMarcelo"), MansioneFactory.GetMansione("Capo Unità"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("EufrosinaSiciliano"), MansioneFactory.GetMansione("Capo Unità"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("VitaleBellucci"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AngeloFallaci"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AlbertoMancini"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AdeleMilanesi"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CandidoSal"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("FerruccioCalabrese"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("DelfioLombardi"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AdalricoCalabrese"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("TizianaBeneventi"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CeciliaMarcelo"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AusilioPalerma"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("NatasciaMazzi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AdalgisaLombardi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MichelinaManfrin"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("ErmenegildaCosta"), MansioneFactory.GetMansione("Steward Corta"));
            evento3.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MarianoBianchi"), MansioneFactory.GetMansione("Steward Corta"));
            #endregion
            evento3.Accept(new RegolaCoordinatore());
            evento3.Accept(new RegolaCapoUnita());
            evento3.Accept(new RegolaSteward());
            evento3.Accept(new GeneraPOS());
            #endregion
            #region Evento4 Bologna-Roma 15/3/2014 15:00 15/3/2014 17:00 2 Aperti(Tribuna, Ospiti, Bulgarelli)
            List<ISettore> lista4 = new List<ISettore>();
            lista4.Add(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli));
            lista4.Add(Impianto.GetInstance().GetSettorePerNome(nomeTribuna));
            lista4.Add(Impianto.GetInstance().GetSettorePerNome(nomeOspiti));
            Evento evento4 = new Evento("Bologna-Roma", new DateTime(2014, 3, 15, 15, 0, 0), new DateTime(2014, 3, 15, 17, 0, 0), 2, lista4);
            #region assegnamenti Tribuna
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CettinaGiordano"), MansioneFactory.GetMansione("Coordinatore"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AntoninaOnio"), MansioneFactory.GetMansione("Capo Unità"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("EllaCalabresi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("MarianoBianchi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("MauraSabbatini"), MansioneFactory.GetMansione("Steward Lunga"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("GiulianoZetticci"), MansioneFactory.GetMansione("Steward Lunga"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CassioPiccio"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AdalgisaLombardi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("NatasciaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AusilioPalerma"), MansioneFactory.GetMansione("Steward Lunga"));
            #endregion
            #region assegnamenti Bulgarelli
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("SestoNucci"), MansioneFactory.GetMansione("Coordinatore"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("MelaniaMancini"), MansioneFactory.GetMansione("Capo Unità"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ErmenegildaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("GretaArcuri"), MansioneFactory.GetMansione("Steward Lunga"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("GeraldinoUdinesi"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("ErmenegildaCosta"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeBulgarelli), PersonaleFactory.GetPersonale("MichelinaManfrin"), MansioneFactory.GetMansione("Steward Corta"));

            #endregion
            #region assegnamenti Ospiti
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("CristinaEndrizzi"), MansioneFactory.GetMansione("Coordinatore"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("BelindaGreece"), MansioneFactory.GetMansione("Capo Unità"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("GinaSiciliano"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("MelissaTrevisano"), MansioneFactory.GetMansione("Steward Corta"));
            evento4.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeOspiti), PersonaleFactory.GetPersonale("LaviniaMarcelo"), MansioneFactory.GetMansione("Steward Corta"));

            #endregion
            evento4.Accept(new RegolaCoordinatore());
            evento4.Accept(new RegolaCapoUnita());
            evento4.Accept(new RegolaSteward());
            evento4.Accept(new GeneraPOS());
            #endregion
            #region Evento5 Bologna-Lazio 30/9/2014 15:00 30/9/2014 17:00 Aperti(Distinti, Tribuna)
            List<ISettore> lista5 = new List<ISettore>();
            lista5.Add(Impianto.GetInstance().GetSettorePerNome(nomeDistinti));
            lista5.Add(Impianto.GetInstance().GetSettorePerNome(nomeTribuna));
            Evento evento5 = new Evento("Bologna-Lazio", new DateTime(2014, 9, 30, 15, 0, 0), new DateTime(2014, 9, 30, 17, 0, 0), 5, lista5);
            #region assegnamenti Distinti
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("StefanoGrandi"), MansioneFactory.GetMansione("Coordinatore"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GiacintoGreece"), MansioneFactory.GetMansione("Capo Unità"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CataldoCosta"), MansioneFactory.GetMansione("Capo Unità"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("EllaCalabresi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MarianoBianchi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MauraSabbatini"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GiulianoZetticci"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CassioPiccio"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("ErmenegildaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GretaArcuri"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GeraldinoUdinesi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("ErmenegildaCosta"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MichelinaManfrin"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AdalgisaLombardi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("NatasciaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CrispinoDeLuca"), MansioneFactory.GetMansione("Steward Corta"));                                    
            #endregion
            #region assegnamenti Tribuna
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CettinaGiordano"), MansioneFactory.GetMansione("Coordinatore"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("MelaniaMancini"), MansioneFactory.GetMansione("Capo Unità"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AusilioPalerma"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CeciliaMarcelo"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AdalricoCalabrese"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("TizianaBeneventi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("DelfioLombardi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("FerruccioCalabrese"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("CandidoSal"), MansioneFactory.GetMansione("Steward Lunga"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AdeleMilanesi"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("AlbertoMancini"), MansioneFactory.GetMansione("Steward Corta"));
            evento5.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeTribuna), PersonaleFactory.GetPersonale("ProsperoPiazza"), MansioneFactory.GetMansione("Steward Corta"));      
            #endregion
            evento5.Accept(new RegolaCoordinatore());
            evento5.Accept(new RegolaCapoUnita());
            evento5.Accept(new RegolaSteward());
            evento5.Accept(new GeneraPOS());
            #endregion
            #region Evento6 Bologna-Pescara 30/11/2014 15:00 30/11/2014 17:00 Aperti(Distinti)
            List<ISettore> lista6 = new List<ISettore>();
            lista6.Add(Impianto.GetInstance().GetSettorePerNome(nomeDistinti));
            Evento evento6 = new Evento("Bologna-Pescara", new DateTime(2014, 11, 30, 15, 0, 0), new DateTime(2014, 11, 30, 17, 0, 0), 5, lista6);
            #region assegnamenti Distinti
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("StefanoGrandi"), MansioneFactory.GetMansione("Coordinatore"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GiacintoGreece"), MansioneFactory.GetMansione("Capo Unità"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CataldoCosta"), MansioneFactory.GetMansione("Capo Unità"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("EllaCalabresi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MarianoBianchi"), MansioneFactory.GetMansione("Steward Lunga"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MauraSabbatini"), MansioneFactory.GetMansione("Steward Lunga"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GiulianoZetticci"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CassioPiccio"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("ErmenegildaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GretaArcuri"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("GeraldinoUdinesi"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("ErmenegildaCosta"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("MichelinaManfrin"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("AdalgisaLombardi"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("NatasciaMazzi"), MansioneFactory.GetMansione("Steward Corta"));
            evento6.AddPersonaleSettore(Impianto.GetInstance().GetSettorePerNome(nomeDistinti), PersonaleFactory.GetPersonale("CrispinoDeLuca"), MansioneFactory.GetMansione("Steward Corta"));
            #endregion            
            evento6.Accept(new RegolaCoordinatore());
            evento6.Accept(new RegolaCapoUnita());
            evento6.Accept(new RegolaSteward());
            evento6.Accept(new GeneraPOS());
            #endregion
            Eventi.GetInstance().AddEvento(evento1);
            Eventi.GetInstance().AddEvento(evento5);
            Eventi.GetInstance().AddEvento(evento3);
            Eventi.GetInstance().AddEvento(evento2);
            Eventi.GetInstance().AddEvento(evento4);
            Eventi.GetInstance().AddEvento(evento6);

        }
    }
}
