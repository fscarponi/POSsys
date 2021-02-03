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
    public partial class AnnullaEvento : Form
    {
        public AnnullaEvento()
        {
            InitializeComponent();
        }

        private void AnnullaEvento_Load(object sender, EventArgs e)
        {
            List<String> s = new List<String>();
            foreach (Evento ev in Eventi.GetInstance().GetEventiFuturi())
                _comboBoxEventoDaAnnullare.Items.Add(ev);
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Attenzione! La cancellazione dell'evento sarà definitiva, continuare?", "Conferma Annullamento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Eventi.GetInstance().RemoveEvento((Evento)_comboBoxEventoDaAnnullare.SelectedItem);
                this.Hide();
            }
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
