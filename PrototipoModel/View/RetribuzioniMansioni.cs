using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSsys.Model;

namespace POSsys.View
{
    public partial class RetribuzioniMansioni : Form
    {
        public RetribuzioniMansioni()
        {
            InitializeComponent();
        }

        private void RetribuzioniMansioni_Load(object sender, EventArgs e)
        {
            foreach (Mansione mansione in MansioneFactory.GetMansioni())
                _comboBoxMansioni.Items.Add(mansione);
        }

        private void _comboBoxMansioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_comboBoxMansioni.SelectedItem != null)
            {
                AggiornaDataGrid();
                _buttonAggiungi.Enabled = true;
            }
            else
            {
                _buttonAggiungi.Enabled = false;
                _dataGridView.DataSource = null;
                _panelAggiungi.Visible = false;
            }
        }

        private void AggiornaDataGrid()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.AllowNew = false;
            Mansione mansione = (Mansione)_comboBoxMansioni.SelectedItem;
            bindingSource.DataSource = mansione.Retribuzioni;
            _dataGridView.DataSource = bindingSource;
        }

        private void _buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (_comboBoxMansioni.SelectedItem != null)
            {
                _panelAggiungi.Visible = true;
            }
        }

        private void _buttonSalva_Click(object sender, EventArgs e)
        {
            #region controlliEventi
            bool controlPassed = true;
            _errorProvider.Clear();
            if (_dateTimePickerFine.Enabled == true)
            {
                if (_dateTimePickerFine.Value.CompareTo(_dateTimePickerInizio.Value) <= 0)
                {
                    _errorProvider.SetError(_dateTimePickerFine, "La Data di fine retribuzione deve essere futura a quella di inizio");
                    controlPassed = false;
                }
            }
            int result;
            if (!Int32.TryParse(_textBoxCompenso.Text, out result) || result < 0)
            {
                _errorProvider.SetError(_textBoxCompenso, "Inserire un numero da 1 a 10");
                controlPassed = false;
            }
            #endregion

            if (controlPassed)
            {
                RetribuzioneMansione retr;
                if (_dateTimePickerFine.Enabled == true)
                    retr = new RetribuzioneMansione(_dateTimePickerInizio.Value, _dateTimePickerFine.Value, result);
                else
                    retr = new RetribuzioneMansione(_dateTimePickerInizio.Value, result);
                Mansione man =(Mansione) _comboBoxMansioni.SelectedItem;
                man.AddRetribuzione(retr);
                AggiornaDataGrid();
                _panelAggiungi.Visible = false;
            }
        }

        private void _buttonChiudi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void _buttonImposta_Click(object sender, EventArgs e)
        {
            _dateTimePickerFine.Enabled = true;
        }
    }
}
