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
    public partial class ModificaSettore : Form
    {
        public ModificaSettore()
        {
            InitializeComponent();
        }

        private void ModificaSettore_Load(object sender, EventArgs e)
        {
            foreach (ISettore k in Impianto.GetInstance().GetSettoriAttivi())
                _comboBoxModificaSettore.Items.Add(k.Nome);
        }


        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if (_textBoxModificaCapienza.Enabled || _textBoxModificaNome.Enabled)
            {
                _textBoxModificaNome.Enabled = false;
                _textBoxModificaCapienza.Enabled = false;

                ISettore seleziona = Impianto.GetInstance().GetSettorePerNome(_comboBoxModificaSettore.SelectedItem.ToString());
                seleziona.Nome = _textBoxModificaNome.Text;
                int app;
                Int32.TryParse(_textBoxModificaCapienza.Text, out app);
                seleziona.Capienza = app;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nessunna modifica rilevata");
            }
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxSettore_SelectedValueChanged(object sender, EventArgs e)
        {
            this.panelModificaSettore.Visible = true;
            ISettore seleziona = Impianto.GetInstance().GetSettorePerNome(_comboBoxModificaSettore.SelectedItem.ToString());
            _textBoxModificaNome.Text = seleziona.Nome;
            _textBoxModificaCapienza.Text = seleziona.Capienza.ToString();
            _textBoxModificaCapienza.Enabled = false;
            _textBoxModificaNome.Enabled = false;
        }

        private void buttonAbilitaModificaNome_Click(object sender, EventArgs e)
        {
            _textBoxModificaNome.Enabled = true;
        }

        private void buttonAbilitaModificaCapienza_Click(object sender, EventArgs e)
        {
            _textBoxModificaCapienza.Enabled = true;
        }

    }
}
