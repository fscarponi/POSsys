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
    public partial class ModificaDatiAddetto : Form
    {
        public ModificaDatiAddetto()
        {
            InitializeComponent();
        }

        private void ModificaDatiAddetto_Load(object sender, EventArgs e)
        {
            foreach (IPersonale personale in PersonaleFactory.GetTuttoPersonale())
            {
                comboBoxAddetto.Items.Add(personale);   
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {

            IPersonale p=(IPersonale) comboBoxAddetto.SelectedItem;

            if(checkBoxModInd.Checked){
                if (string.IsNullOrWhiteSpace(txtIndirizzo.Text)){
                    MessageBox.Show("Formato nuovo indirizzo non valido, ripristinato il precedente!", "Errore nuovo indirizzo", MessageBoxButtons.OK);
                }else {
                    Indirizzo ind = new Indirizzo(txtIndirizzo.Text, txtCivico.Text, txtComune.Text, Int32.Parse(txtCAP.Text), txtProvincia.Text, txtNazione.Text);
                    if(comboBoxIndirizzo.SelectedIndex==0){
                        p.Residenza=ind;
                    }else{
                        p.Domicilio=ind;
                    }
                    MessageBox.Show("Variazione indirizzo effettuato con successo", "Indirizzo Modificato", MessageBoxButtons.OK);
                    checkBoxModInd.Checked = false;
                }
            }
            if (checkBoxModQualifica.Checked)
            {
                {
                    p.Qualifica = (Qualifica)comboBoxQualifica.SelectedItem;
                    MessageBox.Show("Variazione qulifica effettuata con successo", "Qualifica Modificata", MessageBoxButtons.OK);
                    checkBoxModInd.Checked = false;
                }
            }
            
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void comboBoxAddetto_TextChanged(object sender, EventArgs e)
        {
            string actual = comboBoxAddetto.Text;
            int index = comboBoxAddetto.FindString(actual);
            if (index < -1)
            {
                comboBoxAddetto.SelectedItem = index;
            }
            comboBoxAddetto.Refresh();
        }

        private void comboBoxAddetto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actual = comboBoxAddetto.Text;
            int index = comboBoxAddetto.FindString(actual);
            if (index < -1)
            {
                comboBoxAddetto.SelectedItem = index;
            }
        }

        
        private void comboBoxAddetto_SelectedValueChanged(object sender, EventArgs e)
        {
            AggiornaContestoIndirizzo();
            AggiornaContestoQualifica();
        }

        private void checkBoxModInd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModInd.Checked)
            {
                AggiornaContestoIndirizzo();
                comboBoxIndirizzo.Enabled = true;
            }
            else
            {
                panelIndirizzo.Visible = false;
                comboBoxIndirizzo.Enabled = false;
                comboBoxIndirizzo.Items.Clear();
            }
        }

        private void comboBoxIndirizzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIndirizzo.SelectedItem != null)
            {
                panelIndirizzo.Visible = true;
                AggiornaContestoIndirizzo();
            }
        }
        private void AggiornaContestoIndirizzo()
        {
            if (comboBoxAddetto.SelectedItem != null)
            {
                IPersonale p = (IPersonale)comboBoxAddetto.SelectedItem;
                if (!comboBoxIndirizzo.Items.Contains("Residenza"))
                    comboBoxIndirizzo.Items.Add("Residenza");
                if (p.HasDomicilio() && !comboBoxIndirizzo.Items.Contains("Domicilio"))
                    comboBoxIndirizzo.Items.Add("Domicilio");
                else if (!p.HasDomicilio() && comboBoxIndirizzo.Items.Contains("Domicilio"))
                    comboBoxIndirizzo.Items.Remove("Domicilio");
                if ((string)comboBoxIndirizzo.SelectedItem == "Residenza")
                {
                    txtIndirizzo.Text = p.Residenza.Via;
                    txtComune.Text = p.Residenza.Comune;
                    txtCivico.Text = p.Residenza.NumCivico;
                    txtProvincia.Text = p.Residenza.Provincia;
                    txtCAP.Text = p.Residenza.Cap.ToString();
                    txtNazione.Text = p.Residenza.Nazione;

                }
                else if ((string)comboBoxIndirizzo.SelectedItem == "Domicilio")
                {
                    txtIndirizzo.Text = p.Domicilio.Via;
                    txtComune.Text = p.Domicilio.Comune;
                    txtCivico.Text = p.Domicilio.NumCivico;
                    txtProvincia.Text = p.Domicilio.Provincia;
                    txtCAP.Text = p.Domicilio.Cap.ToString();
                    txtNazione.Text = p.Domicilio.Nazione;

                }
                else if (comboBoxIndirizzo.SelectedItem == null)
                    panelIndirizzo.Visible = false;
            }
        }

        

        private void checkBoxModQualifica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModQualifica.Checked)
            {
                comboBoxQualifica.Enabled = true;
                AggiornaContestoQualifica();
            }
            else
            {
                comboBoxQualifica.SelectedItem = null;
                comboBoxQualifica.Enabled = false;
            }
        }

        private void AggiornaContestoQualifica()
        {
            if (comboBoxAddetto.SelectedItem != null)
            {
                IPersonale p = (IPersonale)comboBoxAddetto.SelectedItem;
                txtQualificaAttuale.Text = p.Qualifica.ToString();
                if (comboBoxQualifica.Items.Count == 0)
                {
                    foreach (Qualifica qualifica in Enum.GetValues(typeof(Qualifica)))
                    {
                        comboBoxQualifica.Items.Add(qualifica);
                    }
                }
                
            }
        }
    }
}
