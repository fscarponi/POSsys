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
    public partial class EliminaAddetto : Form
    {
        public EliminaAddetto()
        {
            InitializeComponent();
        }

        private void EliminaAddetto_Load(object sender, EventArgs e)
        {
            _dataGridView.DataSource = PersonaleFactory.GetTuttoPersonale();
            foreach(IPersonale persona in PersonaleFactory.GetPersonaleAttivo()){
                _comboBoxLicenziaAddetto.Items.Add(persona);
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            IPersonale personaSelezionata =(IPersonale) _comboBoxLicenziaAddetto.SelectedItem;
            PersonaleFactory.GetPersonale(personaSelezionata.Cf).DataLicenziamento = _dateTimePickerDataLicenziamento.Value;
            this.Hide();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
