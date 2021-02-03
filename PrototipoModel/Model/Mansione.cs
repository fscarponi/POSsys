using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsys.Model
{
    public abstract class Mansione
    {
        protected readonly List<RetribuzioneMansione> _retribuzioni = new List<RetribuzioneMansione>();
        protected readonly Qualifica _incarico;
        protected readonly Servizio _servizio;

        public Mansione(Qualifica incarico, Servizio servizio)
        {
            _incarico = incarico;
            _servizio = servizio;
            Retribuzioni.Add(new RetribuzioneMansione(DateTime.MinValue, DateTime.MaxValue, 0));
        }

        public void AddRetribuzione(RetribuzioneMansione retribuzione)
        {
            #region Vecchio Algoritmo di elmininazione delle inclusioni
            //List<RetribuzioneMansione> eliminareTemp=new List<RetribuzioneMansione>();
            //foreach (RetribuzioneMansione singoleRetribuzioni in Retribuzioni)
            //{
            //    if (singoleRetribuzioni.DataInizioValidita.CompareTo(retribuzione.DataInizioValidita) >= 0 &&
            //        singoleRetribuzioni.DataFineValitida.CompareTo(retribuzione.DataFineValitida) <= 0)
            //        eliminareTemp.Add(singoleRetribuzioni);
            //}
            //foreach (RetribuzioneMansione singoleRetribuzioni in eliminareTemp)
            //{
            //    RemoveRetribuzione(singoleRetribuzioni);
            //} 
            #endregion
            if (retribuzione == null)
                throw new ArgumentException("retribuzione == null");
            // Elimina tutte le retribuzioni incluse, estremi inclusi
            if (Retribuzioni.RemoveAll(singoleRetribuzioni => singoleRetribuzioni.DataInizioValidita >= retribuzione.DataInizioValidita &&
                            singoleRetribuzioni.DataFineValitida <= retribuzione.DataFineValitida) == 0)
            {
                /* Se la retribuzione NON includeva nessuna retribuzione, allora vi è la possibilita che
                 sia essa inclusa in una preesistente, quindi ciclo su tutte le retribuzioni
                 fino a trovarne una che la include completamente, estremi esclusi,
                 e la spezza e si inserisce
                 Gli estremi sono ESCLUSI per non causare errori di ArgumentOutOfRangeException:DateTime*/
                foreach (RetribuzioneMansione singoleRetribuzioni in Retribuzioni)
                {
                    if (singoleRetribuzioni.DataInizioValidita < retribuzione.DataInizioValidita &&
                        singoleRetribuzioni.DataFineValitida > retribuzione.DataFineValitida)
                    {
                        Retribuzioni.Add(new RetribuzioneMansione(retribuzione.DataFineValitida.AddMilliseconds(1), singoleRetribuzioni.DataFineValitida, singoleRetribuzioni.Compenso));
                        singoleRetribuzioni.DataFineValitida = retribuzione.DataInizioValidita.AddMilliseconds(-1);
                        break;
                    }
                }
            }
            /* Se la retribuzione inizia in una retribuzione e finisci in un'altra
             queste istruzioni modificano le date di inizio e fine delle retribuzioni 
             nella quale la ritribuzione passata si inserisce e le modifica
             se la retribuzione passata ha impostato MaxValue o MinValue, ed esiste già una retribuzione
             preesistente con quei valori, il programma non fallisce grazie all'istruzione di controllo*/
            RetribuzioneMansione lastTemp = GetRetribuzione(retribuzione.DataFineValitida);
            if (lastTemp != null && retribuzione.DataFineValitida != DateTime.MaxValue)
                lastTemp.DataInizioValidita = retribuzione.DataFineValitida.AddMilliseconds(1);
            RetribuzioneMansione firstTemp = GetRetribuzione(retribuzione.DataInizioValidita);
            if (firstTemp != null && retribuzione.DataInizioValidita != DateTime.MinValue)
                firstTemp.DataFineValitida = retribuzione.DataInizioValidita.AddMilliseconds(-1);

            // Dopo aver apportato tutte le modifiche alle retribuzioni,
            // inserisco la retribuzione fornita.
            Retribuzioni.Add(retribuzione);
            Retribuzioni.Sort(new RetribuzioneMansioneComparer());
        }

        // Restituisce la Retribuzione che appartiene alla data passata come agomento
        public RetribuzioneMansione GetRetribuzione(DateTime data)
        {
            foreach (RetribuzioneMansione retribuzione in Retribuzioni)
            {
                if (data >= retribuzione.DataInizioValidita && data <= retribuzione.DataFineValitida)
                {
                    return retribuzione;
                }
            }
            return null;
        }

        private bool RemoveRetribuzione(RetribuzioneMansione retribuzione)
        {
            return Retribuzioni.Remove(retribuzione);
        }

        public Qualifica Incarico
        {
            get { return _incarico; }
        }

        public Servizio Servizio
        {
            get { return _servizio; }
        }

        public List<RetribuzioneMansione> Retribuzioni
        {
            get { return _retribuzioni; }
        }


        public override string ToString()
        {
            return Incarico + " in servizio di: " + Servizio;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Mansione m = (Mansione)obj;
                return Incarico == m.Incarico && Servizio == m.Servizio;
            }
        }

        public override int GetHashCode()
        {
            return Incarico.GetHashCode() ^ Servizio.GetHashCode() ^ Retribuzioni.GetHashCode();
        }
    }
}
