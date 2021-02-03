using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSsys.Model;

namespace POSsys.View
{
    public partial class CreaNuovoEvento : Form
    {
        private Evento partita;
        private readonly Dictionary<ISettore, Assegnamenti> disposizionePersonale = new Dictionary<ISettore, Assegnamenti>();

        public Dictionary<ISettore, Assegnamenti> DisposizionePersonale
        {
            get { return disposizionePersonale; }
        }

        public System.Windows.Forms.ListBox ListSettoriAperti
        {
            get { return _listSettoriAperti; }
        }

        public CreaNuovoEvento()
        {
            InitializeComponent();
        }

        private void CreaNuovoEvento_Load(object sender, EventArgs e)
        {
            foreach (ISettore settore in Impianto.GetInstance().GetSettoriAttivi())
            {
                checkListSettoriAperti.Items.Add(settore);
            }
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonIncludiSettori_Click(object sender, EventArgs e)
        {
            foreach (ISettore set in checkListSettoriAperti.CheckedItems)
            {
                if (!disposizionePersonale.ContainsKey(set))
                {
                    disposizionePersonale.Add(set, new Assegnamenti());
                    _listSettoriAperti.Items.Add(set);
                    _listSettoriAperti.Enabled = true;
                }
            }
        }

        private void buttonRimuoviSettori_Click(object sender, EventArgs e)
        {
            ISettore settore = (ISettore)_listSettoriAperti.SelectedItem;
   
            if (disposizionePersonale.ContainsKey(settore))
            {
                disposizionePersonale.Remove(settore);
                _listSettoriAperti.Items.Remove(settore);
            }
        }

        private void ListSettoriAperti_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_listSettoriAperti.SelectedItem != null)
            {
                panelPersonaleAssegnato.Visible = true;
                buttonRimuoviSettori.Enabled = true;
                ISettore settore = (ISettore)_listSettoriAperti.SelectedItem;
                if (disposizionePersonale[settore] != null)
                {
                    listBoxAssegnamenti.DataSource = disposizionePersonale[settore].GetAddetti();
                }
            }
            else
            {
                panelPersonaleAssegnato.Visible = false;
                buttonRimuoviSettori.Enabled = false;
            }
        }

        private void buttonAggiungiAddetto(object sender, EventArgs e)
        {
            SelezionaAddetti formaddetti = new SelezionaAddetti(this);
            formaddetti.ShowDialog();
        }

        private void buttonConvalida_Click(object sender, EventArgs e)
        {
            #region controlliEventi
            bool controlPassed = true;
            errorProviderEvento.Clear();
            if (String.IsNullOrEmpty(txtNomeEvento.Text) || String.IsNullOrWhiteSpace(txtNomeEvento.Text))
            {
                errorProviderEvento.SetError(txtNomeEvento, "Inserire il nome evento");
                controlPassed = false;
            }
            if (dateTimePickerFineEvento.Value.CompareTo(dateTimePickerInizioEvento.Value) <= 0)
            {
                errorProviderEvento.SetError(dateTimePickerFineEvento, "La Data di fine evento deve essere futura a quella di inizio evento");
                controlPassed = false;
            }
            if (dateTimePickerInizioEvento.Value<= DateTime.Now)
            {
                errorProviderEvento.SetError(dateTimePickerInizioEvento, "La Data di inizio evento deve essere futura");
                controlPassed = false;
            }
            int result;
            if (!Int32.TryParse(txtGradoDiRischio.Text, out result) || result < 1 || result > 10)
            {

                errorProviderEvento.SetError(txtGradoDiRischio, "Inserire un numero da 1 a 10");
                controlPassed = false;
            }
            if (checkListSettoriAperti.CheckedIndices.Count == 0)
            {
                errorProviderEvento.SetError(checkListSettoriAperti, "Devi selezionare almeno un settore da includere");
                controlPassed = false;
            }
            #endregion

            if (controlPassed)
            {
                partita = new Evento(txtNomeEvento.Text, dateTimePickerInizioEvento.Value, dateTimePickerFineEvento.Value, result, disposizionePersonale.Keys.ToList());
                foreach (ISettore set in disposizionePersonale.Keys.ToList())
                    partita.AddAssegnamentiSettore(set, DisposizionePersonale[set]);
                try
                {
                    partita.Accept(new RegolaCoordinatore());
                    partita.Accept(new RegolaSteward());
                    partita.Accept(new RegolaCapoUnita());
                    partita.Accept(new GeneraPOS());

                    MessageBox.Show("Convalida Effettuata, POS generato!", "", MessageBoxButtons.OK);
                    _buttonSalva.Enabled = true;
                }
                catch (ViolatedRuleException ruleExc)
                {
                    MessageBox.Show(ruleExc.Message);
                }
                catch (NullReferenceException nullExc)
                {
                    MessageBox.Show("L'evento non è stato creato");
                }
            }
        }
        private void buttonRimuoviAdetto_Click(object sender, EventArgs e)
        {
            IPersonale rimuovi = (AddettoAllaSicurezza)listBoxAssegnamenti.SelectedItem;
            if (rimuovi != null)
            {
                _buttonSalva.Enabled = false;
                DisposizionePersonale[(Settore)ListSettoriAperti.SelectedItem].RemoveAddetto(rimuovi);
                ListSettoriAperti.SetSelected(ListSettoriAperti.SelectedIndex, true);
            }
        }

        private void _buttonSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Eventi.GetInstance().AddEvento(partita);
                MessageBox.Show("Evento Salvato");
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
