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
    public partial class EliminaSettore : Form
    {
        public EliminaSettore()
        {
            InitializeComponent();
        }

        private void EliminaSettore_Load(object sender, EventArgs e)
        {
            foreach (ISettore settore in Impianto.GetInstance().GetSettoriAttivi())
                _comboBoxEliminaSettore.Items.Add(settore.Nome);
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if (Impianto.GetInstance().RemoveSettore(Impianto.GetInstance().GetSettorePerNome(_comboBoxEliminaSettore.SelectedItem.ToString())))
                MessageBox.Show("Settore Rimosso");
            this.Hide();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
