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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pianificaLavoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgrammaLavoro formPLavoro = new ProgrammaLavoro();
            this.Enabled = false;
            formPLavoro.ShowDialog();
            //aggiorna();
            this.Enabled = true;
        }

        private void aggiorna()
        {
            BindingSource bindingSourceEventi = new BindingSource();
            bindingSourceEventi.AllowNew = false;
            bindingSourceEventi.DataSource = Eventi.GetInstance().GetEventiFuturi();
            _dataGridViewEventi.DataSource = bindingSourceEventi;
            BindingSource bindingSourceLavori = new BindingSource();
            bindingSourceLavori.AllowNew = false;
            bindingSourceLavori.DataSource = Impianto.GetInstance().Lavori;
            _dataGridViewLavoro.DataSource = bindingSourceLavori;
            BindingSource bindingSourceSettori = new BindingSource();
            bindingSourceSettori.AllowNew = false;
            bindingSourceSettori.DataSource = Impianto.GetInstance().Settori;
            _dataGridViewSettori.DataSource = bindingSourceSettori;
        }

        private void inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreaAddettoAllaSicurezza FormAddetto = new CreaAddettoAllaSicurezza();
            this.Enabled = false;
            FormAddetto.ShowDialog();
            this.Enabled = true;
            
        }

        private void creaNuovoSettoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreaNuovoSettore FormSettore = new CreaNuovoSettore();
            this.Enabled = false;
            FormSettore.ShowDialog();
            this.Enabled = true;
        }

        private void modificaSettoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaSettore FormModSettore = new ModificaSettore();
            this.Enabled = false;
            FormModSettore.ShowDialog();
            this.Enabled = true;
        }

        private void creaNuovoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreaNuovoEvento formCreaEvento = new CreaNuovoEvento();
            this.Enabled = false;
            formCreaEvento.ShowDialog();
            //aggiorna();
            this.Enabled = true;
        }

        private void eliminaSettoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminaSettore formEliminaSettore = new EliminaSettore();
            this.Enabled = false;
            formEliminaSettore.ShowDialog();
            this.Enabled = true;
        }

        private void modificaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaEvento fomSelEvento = new ModificaEvento();
            this.Enabled = false;
            fomSelEvento.ShowDialog();
            //aggiorna();
            this.Enabled = true;
        }

        private void annullaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnullaEvento formAnnullaEvento = new AnnullaEvento();
            this.Enabled = false;
            formAnnullaEvento.ShowDialog();
            //aggiorna();
            this.Enabled = true;
        }

        private void modificaDatiAddettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaDatiAddetto formModificaDatiAddetto = new ModificaDatiAddetto();
            this.Enabled = false;
            formModificaDatiAddetto.ShowDialog();
            this.Enabled = true;
        }

        private void disattivaAddettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminaAddetto formEliminaAddetto = new EliminaAddetto();
            this.Enabled = false;
            formEliminaAddetto.ShowDialog();
            this.Enabled = true;
        }

        private void calcolaCompensiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaCompensi formCalcolaCompensi = new CalcolaCompensi();
            this.Enabled = false;
            formCalcolaCompensi.ShowDialog();
            this.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                aggiorna();
            }
        }

        private void RetribuzioniMansioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetribuzioniMansioni formRetribuzioniMansioni = new RetribuzioniMansioni();
            this.Enabled = false;
            formRetribuzioniMansioni.ShowDialog();
            this.Enabled = true;
        }
    }
}
