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
    public partial class ProgrammaLavoro : Form
    {
        public ProgrammaLavoro()
        {
            InitializeComponent();
        }
        private void ProgrammaLavoro_Load(object sender, EventArgs e)
        {
            foreach (ISettore settore in Impianto.GetInstance().GetSettoriAttivi())
                _checkedListBoxSettoriInteressati.Items.Add(settore);
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            _errorProviderProgrammaLavoro.Clear();
            bool controllpass = true;
            #region controlli
            if (String.IsNullOrEmpty(_textBoxDescrizioneLavoro.Text) || String.IsNullOrWhiteSpace(_textBoxDescrizioneLavoro.Text))
            {
                _errorProviderProgrammaLavoro.SetError(_textBoxDescrizioneLavoro, "Descrizione non valida");
                controllpass = false;
            }
            string descrizione = _textBoxDescrizioneLavoro.Text;
            if (_dateTimePickerInizioLavoro.Value > _dateTimePickerFineLavoro.Value)
            {
                _errorProviderProgrammaLavoro.SetError(_dateTimePickerFineLavoro, "Data fine precedente alla data di inizio");
                controllpass = false;
            }
            DateTime dataInizio = _dateTimePickerInizioLavoro.Value;
            DateTime dataFine = _dateTimePickerFineLavoro.Value;
            if (_checkedListBoxSettoriInteressati.CheckedItems.Count == 0)
            {
                _errorProviderProgrammaLavoro.SetError(_checkedListBoxSettoriInteressati, "Selezionare almeno un settore");
                controllpass = false;
            }
            #endregion
            #region istanzia
            if (controllpass)
            {
                List<SettoreInteressato> settoriInteressati = new List<SettoreInteressato>();
                foreach (SettoreInteressato settore in _comboBoxSettoreInteressato.Items)
                {
                    settoriInteressati.Add(settore);                   
                }
                Impianto.GetInstance().AddLavoro(new Lavoro(dataInizio, dataFine, settoriInteressati, descrizione));
                Console.WriteLine(Impianto.GetInstance().Lavori.Count);
                this.Hide();
            }
            #endregion
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void _checkedListBoxSettoriInteressati_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ISettore settoreSelezionato = (ISettore)_checkedListBoxSettoriInteressati.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                SettoreInteressato settoreInteressato = new SettoreInteressato(settoreSelezionato);
                _comboBoxSettoreInteressato.Items.Add(settoreInteressato);
            }
            else
            {
                SettoreInteressato settore = null;
                foreach (SettoreInteressato settoreInteressato in _comboBoxSettoreInteressato.Items)
                    if (settoreInteressato.Settore.Equals(settoreSelezionato))
                        settore = settoreInteressato;               
                _comboBoxSettoreInteressato.Items.Remove(settore);
            }
            if(_comboBoxSettoreInteressato.SelectedItem==null)
                _panelSettoreInteressato.Visible = false;
        }

        private void _comboBoxSettoreInteressato_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SettoreInteressato settoreSelezionato = (SettoreInteressato)_comboBoxSettoreInteressato.SelectedItem;
            if (settoreSelezionato != null)
            {
                _panelSettoreInteressato.Visible = true;
                _textBoxModTemporanea.Text = settoreSelezionato.ModTemCapienza.ToString();
                _textBoxModDefinitiva.Text = settoreSelezionato.ModDefCapienza.ToString();

            }           
        }

        private void _textBoxModTemporanea_TextChanged(object sender, EventArgs e)
        {
            _errorProviderProgrammaLavoro.Clear();
            int num=0;
            if (!String.IsNullOrWhiteSpace(_textBoxModTemporanea.Text) && Int32.TryParse(_textBoxModTemporanea.Text,out num))
            {
                SettoreInteressato settoreSelezionato = (SettoreInteressato)_comboBoxSettoreInteressato.SelectedItem;
                settoreSelezionato.ModTemCapienza = num;
            }
            else
            {
                _errorProviderProgrammaLavoro.SetError(_textBoxModTemporanea, "Inserire un numero");
                _textBoxModTemporanea.Text = ""; 
            }
        }

        private void _textBoxModDefinitiva_TextChanged(object sender, EventArgs e)
        {
            _errorProviderProgrammaLavoro.Clear();
            int num=0;
            if (!String.IsNullOrWhiteSpace(_textBoxModDefinitiva.Text) && Int32.TryParse(_textBoxModDefinitiva.Text, out num))
            {
                SettoreInteressato settoreSelezionato = (SettoreInteressato)_comboBoxSettoreInteressato.SelectedItem;
                settoreSelezionato.ModDefCapienza = num;
            }
            else
            {
                _errorProviderProgrammaLavoro.SetError(_textBoxModDefinitiva, "Inserire un numero");
                _textBoxModDefinitiva.Text = "";
            }
        }
    }
}







