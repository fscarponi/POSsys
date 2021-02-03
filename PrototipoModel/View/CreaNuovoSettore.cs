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
    public partial class CreaNuovoSettore : Form
    {
        public CreaNuovoSettore()
        {
            InitializeComponent();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool controllpass = true;
            #region controlli
            if (String.IsNullOrEmpty(_textBoxNomeSettore.Text) || String.IsNullOrWhiteSpace(_textBoxNomeSettore.Text))
            {
                errorProvider1.SetError(_textBoxNomeSettore, "Nome settore non valido");
                controllpass = false;
            }
            if (Impianto.GetInstance().GetSettorePerNome(_textBoxNomeSettore.Text) != null)
            {
                errorProvider1.SetError(_textBoxNomeSettore, "E' già presente un settore con questo nome");
                controllpass = false;
            }
            string nomeSett = _textBoxNomeSettore.Text;
            int numPosti;
            if (!Int32.TryParse(_textBoxCapienzaSettore.Text, out numPosti) || numPosti <= 0)
            {
                errorProvider1.SetError(_textBoxCapienzaSettore, "Hai inserito un numero di posti non valido");
                controllpass = false;
            }
            #endregion

            #region istanzia
            if (controllpass)
            {
                Impianto.GetInstance().AddSettore(new Settore(nomeSett, numPosti));
                this.Hide();
            }
            #endregion
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }    

    }
}
