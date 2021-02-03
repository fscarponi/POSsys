using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSsys.Model;

namespace POSsys.Persistence
{
    public class PersonaleFactoryLoader : ILoader
    {

        public void Load()
        {
            PersonaleLoad();
        }

        private void PersonaleLoad()
        {
            #region Coodinatori
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Stefano", "Grandi", "StefanoGrandi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Coordinatore,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ferruccio", "Calabresi", "FerruccioCalabresi", new DateTime(1949, 5, 20),
              new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Coordinatore,
              new Indirizzo("Via Callicratide", "52", "Chitignano", 52010, "AR", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Cettina", "Giordano", "CettinaGiordano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Coordinatore,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia"),
                new Indirizzo("Via Callicratide", "52", "Chitignano", 52010, "AR", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Sesto", "Nucci", "SestoNucci", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Coordinatore,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Cristina", "Endrizzi", "CristinaEndrizzi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Coordinatore,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Doroty", "Di Pietrantonio", "DPTDTY87B60G878F", new DateTime(1987, 2, 20),
                new LuogoNascita("Popoli", "PE", "Italia"), new DateTime(2010, 11, 1), Qualifica.Coordinatore,
                new Indirizzo("via provinciale per manoppello", "3", "Lettomanoppello", 65202, "PE", "Italia"),
                new Indirizzo("via Montefiorino", "1", "Bologna", 40134, "BO", "Italia")));
            #endregion
            #region Capi Unita
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Giacinto", "Greece", "GiacintoGreece", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("Via Callicratide", "52", "Chitignano", 52010, "AR", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Cataldo", "Costa", "CataldoCosta", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Eufrosina", "Siciliano", "EufrosinaSiciliano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("Via Callicratide", "52", "Chitignano", 52010, "AR", "Italia"),
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Luigia", "Marcelo", "LuigiaMarcelo", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia"),
                new Indirizzo("Via Callicratide", "52", "Chitignano", 52010, "AR", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Bernardo", "Bellucci", "BernardoBellucci", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Belinda", "Greece", "BelindaGreece", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Enza", "Lucciano", "EnzaLucciano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Dalia", "Pugliesi", "DaliaPugliesi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Melania", "Mancini", "MelaniaMancini", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Antonina", "Onio", "AntoninaOnio", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.CapoUnita,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            #endregion
            #region Defizione Steward
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Gina", "Siciliano", "GinaSiciliano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Melissa", "Trevisano", "MelissaTrevisano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Lavinia", "Marcelo", "LaviniaMarcelo", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Crispino", "De Luca", "CrispinoDeLuca", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Prospero", "Piazza", "ProsperoPiazza", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Eliano", "Greece", "ElianoGreece", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Marcello", "Pisano", "MarcelloPisano", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Vitale", "Bellucci", "VitaleBellucci", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Amalia", "Trentini", "AmaliaTrentini", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Angelo", "Fallaci", "AngeloFallaci", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Alberto", "Mancini", "AlbertoMancini", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Adele", "Milanesi", "AdeleMilanesi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Candido", "Sal", "CandidoSal", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ferruccio", "Calabrese", "FerruccioCalabrese", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Delfio", "Lombardi", "DelfioLombardi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Adalrico", "Calabrese", "AdalricoCalabrese", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Tiziana", "Beneventi", "TizianaBeneventi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Cecilia", "Marcelo", "CeciliaMarcelo", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ausilio", "Palerma", "AusilioPalerma", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Natascia", "Mazzi", "NatasciaMazzi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Adalgisa", "Lombardi", "AdalgisaLombardi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Michelina", "Manfrin", "MichelinaManfrin", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ermenegilda", "Costa", "ErmenegildaCosta", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Geraldino", "Udinesi", "GeraldinoUdinesi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Greta", "Arcuri", "GretaArcuri", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ermenegilda", "Mazzi", "ErmenegildaMazzi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Cassio", "Piccio", "CassioPiccio", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Giuliano", "Zetticci", "GiulianoZetticci", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Maura", "Sabbatini", "MauraSabbatini", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Mariano", "Bianchi", "MarianoBianchi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            PersonaleFactory.AddPersonale(new AddettoAllaSicurezza("Ella", "Calabresi", "EllaCalabresi", new DateTime(1991, 5, 21),
                new LuogoNascita("Bologna", "BO", "Italia"), new DateTime(2010, 1, 1), Qualifica.Steward,
                new Indirizzo("via Darwin", "57", "Bologna", 40131, "BO", "Italia")));
            #endregion
        }
    }
}
