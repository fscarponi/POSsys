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
    public partial class ModificaEvento : Form
    {
        public ModificaEvento()
        {
            InitializeComponent();
        }

        private void SelezionaEvento_Load(object sender, EventArgs e)
        {
            foreach (Evento ev in Eventi.GetInstance().GetEventiFuturi())
                _comboBoxEventoDaModificare.Items.Add(ev);
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonModificaNomeEvento_Click(object sender, EventArgs e)
        {
            txtNomeDaModificare.Enabled = true;
        }

        private void buttonModificaDataInizio_Click(object sender, EventArgs e)
        {
            dateTimePickerInizioEvento.Enabled = true;
        }

        private void buttonModificaDataFine_Click(object sender, EventArgs e)
        {
            dateTimePickerFineEvento.Enabled = true;
        }

        private void _comboBoxEventoDaModificare_SelectedIndexChanged(object sender, EventArgs e)
        {
            _panelFill.Visible = true;
            Evento evento = (Evento)_comboBoxEventoDaModificare.SelectedItem;
            txtNomeDaModificare.Text = evento.Nome;
            dateTimePickerInizioEvento.Value = evento.DataInizio;
            dateTimePickerFineEvento.Value = evento.DataFine;
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            bool controlPassed = true;
            errorProviderModEvento.Clear();
            Evento evento = (Evento)_comboBoxEventoDaModificare.SelectedItem;
            if (String.IsNullOrEmpty(txtNomeDaModificare.Text) || String.IsNullOrWhiteSpace(txtNomeDaModificare.Text))
            {
                errorProviderModEvento.SetError(txtNomeDaModificare, "Inserire il nome dell'evento");
                controlPassed = false;
            }

            if (dateTimePickerFineEvento.Value < dateTimePickerInizioEvento.Value)
            {
                errorProviderModEvento.SetError(dateTimePickerFineEvento, "Inserire un data futura rispetto a quella di inizio evento");
                controlPassed = false;
            }
            if (controlPassed)
            {
                if (txtNomeDaModificare.Enabled == true)
                    evento.Nome = txtNomeDaModificare.Text;
                if (dateTimePickerInizioEvento.Enabled == true)
                    evento.DataInizio = dateTimePickerInizioEvento.Value;
                if (dateTimePickerInizioEvento.Enabled == true)
                    evento.DataFine = dateTimePickerFineEvento.Value;
                evento.Accept(new GeneraPOS());
                this.Hide();
            }
        }
    }
}
