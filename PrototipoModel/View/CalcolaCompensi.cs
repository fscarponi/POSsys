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
    public partial class CalcolaCompensi : Form
    {
        public CalcolaCompensi()
        {
            InitializeComponent();
        }

        private void CalcolaCompensi_Load(object sender, EventArgs e)
        {
            dateTimePickerDataPagamento.MaxDate = DateTime.Today;
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Pagamenti.GetInstance().AddPagamento(dateTimePickerDataPagamento.Value);
                this.Hide();
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

    }
}
