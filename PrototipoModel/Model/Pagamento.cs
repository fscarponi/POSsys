using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace POSsys.Model
{
    public class Pagamento
    {
        private readonly DateTime _dataInizio;
        private readonly DateTime _dataFine;
        private readonly Dictionary<IPersonale, double> _compensoAddetti = new Dictionary<IPersonale, double>();
        private XmlWriter _writer;

        public Pagamento(DateTime dataInizio, DateTime dataFine)
        {
            if (dataInizio.CompareTo(dataFine) > 0)
                throw new ArgumentException("Date errate, dataInizio > dataFine");
            _dataInizio = dataInizio;
            _dataFine = dataFine;
            CalcoloCompenso();
            GeneraXML();
        }

        private void GeneraXML()
        {
            _writer = XmlWriter.Create("../../Pagamenti/" + DataInizio.ToString("dd-MM-yyyy") + " - " + DataFine.ToString("dd-MM-yyyy") + ".xml", new XmlWriterSettings() { Indent = true });
            _writer.WriteStartDocument();
            _writer.WriteStartElement("Pagamento");
            _writer.WriteAttributeString("DataInizio", DataInizio.ToString("d/MM/yyyy"));
            _writer.WriteAttributeString("DataFine", DataFine.ToString("d/MM/yyyy"));
            SavePagamento();
            _writer.WriteEndElement();  //  Pagamento
            _writer.WriteEndDocument();
            _writer.Close();
        }

        private void SavePagamento()
        {
            foreach (IPersonale persona in CompensoAddetti.Keys.ToList())
            {
                _writer.WriteStartElement("Persona");
                _writer.WriteAttributeString("Nome", persona.Nome);
                _writer.WriteStartElement("Compenso");
                _writer.WriteString(CompensoAddetti[persona].ToString());
                _writer.WriteEndElement();  //  Compenso
                _writer.WriteEndElement();  //  Persona
            }
        }

        private void CalcoloCompenso()
        {
            Assegnamenti assegnamenti;
            foreach (Evento evento in Eventi.GetInstance().GetEventi(DataInizio, DataFine))
            {
                foreach (Settore settore in evento.SettoriAperti)
                {
                    assegnamenti = evento.GetAssegnamentiSettore(settore);
                    foreach (IPersonale personale in assegnamenti.GetAddetti())
                    {
                        if (CompensoAddetti.ContainsKey(personale))
                        {
                            CompensoAddetti[personale] += assegnamenti.GetAssegnamento(personale).GetRetribuzione(evento.DataInizio).Compenso;
                        }
                        else
                        {
                            CompensoAddetti[personale] = assegnamenti.GetAssegnamento(personale).GetRetribuzione(evento.DataInizio).Compenso;
                        }
                    }
                }
            }     
        }

        public DateTime DataInizio
        {
            get { return _dataInizio; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
        }

        public Dictionary<IPersonale, double> CompensoAddetti
        {
            get { return _compensoAddetti; }
        }

        public override string ToString()
        {
            return "Pagamento inizio: "+DataInizio+" Fine: "+DataFine;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Pagamento p = (Pagamento)obj;
                return DataInizio==p.DataInizio && DataFine==p.DataFine;
            }
        }

        public override int GetHashCode()
        {
            return DataInizio.GetHashCode() ^ DataFine.GetHashCode() ^ CompensoAddetti.GetHashCode();
        }
    }
}
