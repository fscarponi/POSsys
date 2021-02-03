using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace POSsys.Model
{
    public class GeneraPOS : IVisitor
    {

        private XmlWriter _writer;

        public void Visit(Evento evento)
        {
            _writer = XmlWriter.Create("../../POS Eventi/" + evento.Nome + ".xml", new XmlWriterSettings() { Indent = true });
            _writer.WriteStartDocument();
            _writer.WriteStartElement("Evento");
            SaveEvento(evento);

            _writer.WriteEndElement();  //  Evento
            _writer.WriteEndDocument();
            _writer.Close();
        }

        private void SaveEvento(Evento evento)
        {
            _writer.WriteStartElement("Nome");
            _writer.WriteString(evento.Nome);
            _writer.WriteEndElement();  //  Nome
            _writer.WriteStartElement("DataInizio");
            _writer.WriteString(evento.DataInizio.ToString("dd/MM/yyyy HH:mm"));
            _writer.WriteEndElement();  //  DataInizio
            _writer.WriteStartElement("DataFine");
            _writer.WriteString(evento.DataFine.ToString("dd/MM/yyyy HH:mm"));
            _writer.WriteEndElement();  //  DataFine
            _writer.WriteStartElement("Durata");
            _writer.WriteString(evento.Durata.ToString(@"hh\:mm"));
            _writer.WriteEndElement();  //  Durata
            _writer.WriteStartElement("GradoDiRischio");
            _writer.WriteString(evento.GradoRischio.ToString());
            _writer.WriteEndElement();  //  GradoDiRischio
            _writer.WriteStartElement("SettoriAperti");
            foreach (Settore settore in evento.SettoriAperti)
            {
                _writer.WriteStartElement("Settore");
                _writer.WriteAttributeString("Nome", settore.Nome);
                SavePersonale(evento.GetAssegnamentiSettore(settore));
                _writer.WriteEndElement();  //  Settore
            }
            _writer.WriteEndElement();  //  SettoriAperti

        }

        private void SavePersonale(Assegnamenti assegnamento)
        {
            foreach (IPersonale personale in assegnamento.GetAddetti())
            {
                _writer.WriteStartElement("Personale");
                _writer.WriteAttributeString("Nome", personale.Nome);
                _writer.WriteAttributeString("Cognome", personale.Cognome);
                _writer.WriteAttributeString("CF", personale.Cf);
                _writer.WriteAttributeString("Qualifica", personale.Qualifica.ToString());
                _writer.WriteStartElement("Mansione");
                SaveMansione(assegnamento.GetAssegnamento(personale));
                _writer.WriteEndElement();  //  Mansione
                _writer.WriteEndElement();  //  Personale
            }
        }

        private void SaveMansione(Mansione mansione)
        {
            _writer.WriteAttributeString("Incarico", mansione.Incarico.ToString());
            _writer.WriteAttributeString("Servizio", mansione.Servizio.ToString());
        }
    }
}
