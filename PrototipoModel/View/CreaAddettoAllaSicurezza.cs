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
    public partial class CreaAddettoAllaSicurezza : Form
    {
        public CreaAddettoAllaSicurezza()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDomicilio.Checked == true)
            {
                this.panelDomicilio.Visible = true;
            }
            else { this.panelDomicilio.Visible = false; }
        }

        private void CreaAddettoAllaSicurezzaLoad(object sender, EventArgs e)
        {
            comboBoxQualifica.DataSource = Enum.GetValues(typeof(Qualifica));
            /*DropDownStyle su DropDownList per bloccare la modifica della combobox*/
        }


        #region clickOnEvents

        private void txtTipoIndirizzoResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtTipoIndirizzoResidenza.Text = "";

        }

        private void txtViaResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtViaResidenza.Clear();
        }

        private void txtCivicoResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtCivicoResidenza.Clear();
        }

        private void txtComuneResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtComuneResidenza.Clear();
        }

        private void txtCAPResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtCAPResidenza.Clear();
        }

        private void txtProvinciaResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtProvinciaResidenza.Clear();
        }

        private void txtNazioneResidenza_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNazioneResidenza.Clear();
        }

        private void txtTipoIndirizzoDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtTipoIndirizzoDomicilio.Clear();
        }


        private void txtViaDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtViaDomicilio.Clear();
        }

        private void txtCivicoDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtCivicoDomicilio.Clear();
        }


        private void txtComuneDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtComuneDomicilio.Clear();
        }

        private void txtCAPDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtCAPDomicilio.Clear();
        }

        private void txtProvinciaDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtProvinciaDomicilio.Clear();
        }

        private void txtNazioneDomicilio_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNazioneDomicilio.Clear();
        }

        private void txtCAPResidenza_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.txtCAPResidenza.Clear();
        }

        private void txtComuneNascita_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtComuneNascita.Clear();
        }

        private void txtProvinciaNascita_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtProvinciaNascita.Clear();
        }

        private void txtNazioneNascita_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNazioneNascita.Clear();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
           

            this.Hide();
        }
        #endregion

        private void buttonSalva_Click(object sender, EventArgs e)
        {

            #region controlliInserimento

            bool controlPassed = true;
            errorProvider.Clear();
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Inserire il nome dell'addetto");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtCognome.Text) || String.IsNullOrWhiteSpace(txtCognome.Text))
            {
                errorProvider.SetError(txtCognome, "Inserire il cognome dell'addetto");
                controlPassed = false;
            }
            if (String.IsNullOrWhiteSpace(txtCodiceFiscale.Text) || txtCodiceFiscale.Text.Length != 16)
            {
                errorProvider.SetError(txtCodiceFiscale, "Inserire il codice fiscale dell'addetto: 16 caratteri");
                controlPassed = false;
            }
            if (dateTimeNascita.Value.AddYears(16).CompareTo(DateTime.Today) > 0)
            {
                errorProvider.SetError(dateTimeNascita, "Data di nascita non ammessa");
                controlPassed = false;
            }

            if (String.IsNullOrEmpty(txtComuneNascita.Text) || String.IsNullOrWhiteSpace(txtComuneNascita.Text) || txtComuneNascita.Text == "Comune")
            {
                errorProvider.SetError(lblLuogoDiNascita, "Inserire un comune di nascita valido");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtProvinciaNascita.Text) || String.IsNullOrWhiteSpace(txtProvinciaNascita.Text) || txtProvinciaNascita.Text == "Provincia")
            {
                errorProvider.SetError(lblLuogoDiNascita, "Inserire una provincia di nascita valida");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtNazioneNascita.Text) || String.IsNullOrWhiteSpace(txtNazioneNascita.Text) || txtNazioneNascita.Text == "Nazione")
            {
                errorProvider.SetError(lblLuogoDiNascita, "Inserire una nazione di nascita valida");
                controlPassed = false;
            }
            /*controllo indirizzo residenza*/
            if (String.IsNullOrEmpty(txtTipoIndirizzoResidenza.Text) || String.IsNullOrWhiteSpace(txtTipoIndirizzoResidenza.Text) || txtTipoIndirizzoResidenza.Text == "Indirizzo")
            {

                errorProvider.SetError(lblIndirizzoResidenza, "Inserire la specifica dell'indirizzo es via,piazza...");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtViaResidenza.Text) || String.IsNullOrWhiteSpace(txtViaResidenza.Text) || txtViaResidenza.Text == "Indirizzo")
            {

                errorProvider.SetError(lblIndirizzoResidenza, "Inserire il nome della via");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtCivicoResidenza.Text) || String.IsNullOrWhiteSpace(txtCivicoResidenza.Text) || txtCivicoResidenza.Text == "n.civico")
            {

                errorProvider.SetError(lblIndirizzoResidenza, "Inserire il numero civico");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtComuneResidenza.Text) || String.IsNullOrWhiteSpace(txtComuneResidenza.Text) || txtComuneResidenza.Text == "Comune")
            {

                errorProvider.SetError(lblIndirizzoResidenza, "Inserire il comune di residenza");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtCAPResidenza.Text) || String.IsNullOrWhiteSpace(txtCAPResidenza.Text) || txtCAPResidenza.Text == "Comune")
            {

                errorProvider.SetError(lblIndirizzoResidenza, "Inserire il CAP");
                controlPassed = false;
            }
            int app;
            if (!Int32.TryParse(txtCAPResidenza.Text,out app) && controlPassed)
            {
                errorProvider.SetError(lblIndirizzoResidenza, "Il CAP deve essere di sole cifre");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtProvinciaResidenza.Text) || String.IsNullOrWhiteSpace(txtProvinciaResidenza.Text) || txtProvinciaResidenza.Text == "Provincia")
            {
                errorProvider.SetError(lblIndirizzoResidenza, "Inserire una provincia di residenza valida");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtNazioneResidenza.Text) || String.IsNullOrWhiteSpace(txtNazioneResidenza.Text) || txtNazioneResidenza.Text == "Provincia")
            {
                errorProvider.SetError(lblIndirizzoResidenza, "Inserire una nazione di residenza valida");
                controlPassed = false;
            }

            if (checkBoxDomicilio.Checked){/*controllo idirizzo domicilio*/
                if (String.IsNullOrEmpty(txtTipoIndirizzoDomicilio.Text) || String.IsNullOrWhiteSpace(txtTipoIndirizzoDomicilio.Text) || txtTipoIndirizzoDomicilio.Text == "Indirizzo")
            {

                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire la specifica dell'indirizzo es via,piazza...");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtViaDomicilio.Text) || String.IsNullOrWhiteSpace(txtViaDomicilio.Text) || txtViaDomicilio.Text == "Indirizzo")
            {

                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire il nome della via");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtCivicoDomicilio.Text) || String.IsNullOrWhiteSpace(txtCivicoDomicilio.Text) || txtCivicoDomicilio.Text == "n.civico")
            {

                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire il numero civico");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtComuneDomicilio.Text) || String.IsNullOrWhiteSpace(txtComuneDomicilio.Text) || txtComuneDomicilio.Text == "Comune")
            {

                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire il comune di residenza");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtCAPDomicilio.Text) || String.IsNullOrWhiteSpace(txtCAPDomicilio.Text) || txtCAPDomicilio.Text == "Comune")
            {

                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire il CAP");
                controlPassed = false;
            }
            if (!Int32.TryParse(txtCAPDomicilio.Text,out app) && controlPassed)
            {
                errorProvider.SetError(lblIndirizzoDomicilio, "Il CAP deve essere di sole cifre");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtProvinciaDomicilio.Text) || String.IsNullOrWhiteSpace(txtProvinciaDomicilio.Text) || txtProvinciaDomicilio.Text == "Provincia")
            {
                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire una provincia di residenza valida");
                controlPassed = false;
            }
            if (String.IsNullOrEmpty(txtNazioneDomicilio.Text) || String.IsNullOrWhiteSpace(txtNazioneDomicilio.Text) || txtNazioneDomicilio.Text == "Provincia")
            {
                errorProvider.SetError(lblIndirizzoDomicilio, "Inserire una nazione di residenza valida");
                controlPassed = false;
            }
            }
            /*controllo data assunzione*/
             if (dateTimeAssunzione.Value.CompareTo(DateTime.Today.AddDays(1)) > 0)
            {
                errorProvider.SetError(dateTimeAssunzione, "La data di assunzione non può essere futura");
                controlPassed = false;
            }

            #endregion
                if (controlPassed)
                {
                    #region Inserimento_addetto
                    
                    String ind = txtTipoIndirizzoResidenza.Text + " " + txtViaResidenza.Text;
                    Indirizzo residenza = new Indirizzo(ind, txtCivicoResidenza.Text, txtComuneResidenza.Text, Int32.Parse(txtCAPResidenza.Text), txtProvinciaResidenza.Text, txtNazioneResidenza.Text);
                    
                    Indirizzo domicilio=null;
                    IPersonale s;
                    if (checkBoxDomicilio.Checked)
                    {//con domicilio diverso da residenza
                        
                        domicilio = new Indirizzo(txtTipoIndirizzoDomicilio.Text + " " + txtViaDomicilio.Text, txtCivicoDomicilio.Text, txtComuneDomicilio.Text, Int32.Parse(txtCAPDomicilio.Text), txtProvinciaDomicilio.Text, txtNazioneDomicilio.Text);
                        s = new AddettoAllaSicurezza(txtNome.Text, txtCognome.Text, txtCodiceFiscale.Text, dateTimeNascita.Value, new LuogoNascita(txtComuneNascita.Text, txtProvinciaNascita.Text, txtNazioneNascita.Text), dateTimeAssunzione.Value, residenza, domicilio);
                    }
                    else {//con domicilio coincidente alla residenza
                        s = new AddettoAllaSicurezza(txtNome.Text, txtCognome.Text, txtCodiceFiscale.Text, dateTimeNascita.Value, new LuogoNascita(txtComuneNascita.Text, txtProvinciaNascita.Text, txtNazioneNascita.Text), dateTimeAssunzione.Value, residenza);
                    }


                    
                    s.Qualifica = (Qualifica) comboBoxQualifica.SelectedItem;
                    if (!PersonaleFactory.GetTuttoPersonale().Contains(s)) { 

                        PersonaleFactory.AddPersonale(s);
                    MessageBox.Show("Inserimento avvenuto con successo!","Inserimento Avvenuto",MessageBoxButtons.OK);
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Inserimento Negato, elemento già presente nel sistema", "Inserimento Fallito", MessageBoxButtons.OK);
                    }
                    
                    
                    #endregion
                }
            }



        }














    

}