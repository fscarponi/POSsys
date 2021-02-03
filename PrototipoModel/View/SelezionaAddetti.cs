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
    public partial class SelezionaAddetti : Form
    {
        private CreaNuovoEvento formEvento;
        public SelezionaAddetti(CreaNuovoEvento form)
        {
            InitializeComponent();
            formEvento = form;
        }

        private void SelezionaAddetti_Load(object sender, EventArgs e)
        {
            foreach(Mansione mansione in MansioneFactory.GetMansioni())
                comboBoxIncarico.Items.Add(mansione);
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            ISettore settore =(ISettore) formEvento.ListSettoriAperti.SelectedItem;
            foreach(IPersonale personale in listBoxAddettidisponibili.SelectedItems){
                formEvento.DisposizionePersonale[settore].AddAssegnamento(personale, MansioneFactory.GetMansione(comboBoxIncarico.SelectedItem.ToString()));
            }
            formEvento.ListSettoriAperti.SetSelected(formEvento.ListSettoriAperti.SelectedIndex, true);
            this.Hide();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxIncarico_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPersonale> addetti = PersonaleFactory.GetPersonaleQualificato(((Mansione)comboBoxIncarico.SelectedItem).Incarico);
            List<IPersonale> addettiNonAssegnati = new List<IPersonale>();
            List<Assegnamenti> assegnamenti = formEvento.DisposizionePersonale.Values.ToList();
            bool presente;
            foreach (IPersonale a in addetti)
            {
                presente = false;
                foreach (Assegnamenti assegnato in assegnamenti)
                {
                    if (assegnato.GetAddetti().Contains(a)) presente = true;
                }
                if (!presente) addettiNonAssegnati.Add(a);
            }
            listBoxAddettidisponibili.DataSource = addettiNonAssegnati;
            listBoxAddettidisponibili.ClearSelected();
        }
    }
}
