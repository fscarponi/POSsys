namespace POSsys.View
{
    partial class CreaNuovoEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradoDiRischio = new System.Windows.Forms.TextBox();
            this.errorProviderEvento = new System.Windows.Forms.ErrorProvider(this.components);
            this._buttonConvalida = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._buttonSalva = new System.Windows.Forms.Button();
            this.checkListSettoriAperti = new System.Windows.Forms.CheckedListBox();
            this._listSettoriAperti = new System.Windows.Forms.ListBox();
            this.buttonIncludiSettori = new System.Windows.Forms.Button();
            this.panelPersonaleAssegnato = new System.Windows.Forms.Panel();
            this.buttonRimuoviAdetto = new System.Windows.Forms.Button();
            this._buttonAggiungiAddetto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAssegnamenti = new System.Windows.Forms.ListBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dateTimePickerInizioEvento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFineEvento = new System.Windows.Forms.DateTimePicker();
            this.panelCentrale = new System.Windows.Forms.Panel();
            this.buttonRimuoviSettori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).BeginInit();
            this.panelPersonaleAssegnato.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCentrale.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAnnulla.Location = new System.Drawing.Point(835, 18);
            this._buttonAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this._buttonAnnulla.TabIndex = 25;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome Evento*";
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(39, 60);
            this.txtNomeEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(159, 22);
            this.txtNomeEvento.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data e ora di Inizio*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Data e ora di Fine*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Grado di rischio stimato*";
            // 
            // txtGradoDiRischio
            // 
            this.txtGradoDiRischio.Location = new System.Drawing.Point(40, 252);
            this.txtGradoDiRischio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradoDiRischio.Name = "txtGradoDiRischio";
            this.txtGradoDiRischio.Size = new System.Drawing.Size(149, 22);
            this.txtGradoDiRischio.TabIndex = 34;
            // 
            // errorProviderEvento
            // 
            this.errorProviderEvento.ContainerControl = this;
            // 
            // _buttonConvalida
            // 
            this._buttonConvalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonConvalida.Location = new System.Drawing.Point(619, 18);
            this._buttonConvalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonConvalida.Name = "_buttonConvalida";
            this._buttonConvalida.Size = new System.Drawing.Size(100, 28);
            this._buttonConvalida.TabIndex = 37;
            this._buttonConvalida.Text = "Convalida";
            this._buttonConvalida.UseVisualStyleBackColor = true;
            this._buttonConvalida.Click += new System.EventHandler(this.buttonConvalida_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Seleziona settori aperti";
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Enabled = false;
            this._buttonSalva.Location = new System.Drawing.Point(725, 18);
            this._buttonSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(100, 28);
            this._buttonSalva.TabIndex = 38;
            this._buttonSalva.Text = "Salva";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this._buttonSalva_Click);
            // 
            // checkListSettoriAperti
            // 
            this.checkListSettoriAperti.CheckOnClick = true;
            this.checkListSettoriAperti.FormattingEnabled = true;
            this.checkListSettoriAperti.Location = new System.Drawing.Point(275, 57);
            this.checkListSettoriAperti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkListSettoriAperti.Name = "checkListSettoriAperti";
            this.checkListSettoriAperti.Size = new System.Drawing.Size(245, 89);
            this.checkListSettoriAperti.TabIndex = 39;
            // 
            // _listSettoriAperti
            // 
            this._listSettoriAperti.Enabled = false;
            this._listSettoriAperti.FormattingEnabled = true;
            this._listSettoriAperti.ItemHeight = 16;
            this._listSettoriAperti.Location = new System.Drawing.Point(275, 207);
            this._listSettoriAperti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._listSettoriAperti.Name = "_listSettoriAperti";
            this._listSettoriAperti.Size = new System.Drawing.Size(245, 116);
            this._listSettoriAperti.TabIndex = 40;
            this._listSettoriAperti.SelectedValueChanged += new System.EventHandler(this.ListSettoriAperti_SelectedValueChanged);
            // 
            // buttonIncludiSettori
            // 
            this.buttonIncludiSettori.Location = new System.Drawing.Point(275, 160);
            this.buttonIncludiSettori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIncludiSettori.Name = "buttonIncludiSettori";
            this.buttonIncludiSettori.Size = new System.Drawing.Size(120, 34);
            this.buttonIncludiSettori.TabIndex = 41;
            this.buttonIncludiSettori.Text = "Includi Settori";
            this.buttonIncludiSettori.UseVisualStyleBackColor = true;
            this.buttonIncludiSettori.Click += new System.EventHandler(this.buttonIncludiSettori_Click);
            // 
            // panelPersonaleAssegnato
            // 
            this.panelPersonaleAssegnato.Controls.Add(this.buttonRimuoviAdetto);
            this.panelPersonaleAssegnato.Controls.Add(this._buttonAggiungiAddetto);
            this.panelPersonaleAssegnato.Controls.Add(this.label6);
            this.panelPersonaleAssegnato.Controls.Add(this.listBoxAssegnamenti);
            this.panelPersonaleAssegnato.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPersonaleAssegnato.Location = new System.Drawing.Point(526, 0);
            this.panelPersonaleAssegnato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPersonaleAssegnato.Name = "panelPersonaleAssegnato";
            this.panelPersonaleAssegnato.Size = new System.Drawing.Size(425, 416);
            this.panelPersonaleAssegnato.TabIndex = 42;
            this.panelPersonaleAssegnato.Visible = false;
            // 
            // buttonRimuoviAdetto
            // 
            this.buttonRimuoviAdetto.Location = new System.Drawing.Point(277, 252);
            this.buttonRimuoviAdetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRimuoviAdetto.Name = "buttonRimuoviAdetto";
            this.buttonRimuoviAdetto.Size = new System.Drawing.Size(131, 33);
            this.buttonRimuoviAdetto.TabIndex = 38;
            this.buttonRimuoviAdetto.Text = "Rimuovi Adetto";
            this.buttonRimuoviAdetto.UseVisualStyleBackColor = true;
            this.buttonRimuoviAdetto.Click += new System.EventHandler(this.buttonRimuoviAdetto_Click);
            // 
            // _buttonAggiungiAddetto
            // 
            this._buttonAggiungiAddetto.Location = new System.Drawing.Point(277, 212);
            this._buttonAggiungiAddetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._buttonAggiungiAddetto.Name = "_buttonAggiungiAddetto";
            this._buttonAggiungiAddetto.Size = new System.Drawing.Size(131, 34);
            this._buttonAggiungiAddetto.TabIndex = 37;
            this._buttonAggiungiAddetto.Text = "Aggiungi Addetto";
            this._buttonAggiungiAddetto.UseVisualStyleBackColor = true;
            this._buttonAggiungiAddetto.Click += new System.EventHandler(this.buttonAggiungiAddetto);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Personale assegnato";
            // 
            // listBoxAssegnamenti
            // 
            this.listBoxAssegnamenti.FormattingEnabled = true;
            this.listBoxAssegnamenti.ItemHeight = 16;
            this.listBoxAssegnamenti.Location = new System.Drawing.Point(9, 57);
            this.listBoxAssegnamenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAssegnamenti.Name = "listBoxAssegnamenti";
            this.listBoxAssegnamenti.Size = new System.Drawing.Size(263, 276);
            this.listBoxAssegnamenti.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this._buttonConvalida);
            this.panelBottom.Controls.Add(this._buttonAnnulla);
            this.panelBottom.Controls.Add(this._buttonSalva);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 416);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(951, 62);
            this.panelBottom.TabIndex = 43;
            // 
            // dateTimePickerInizioEvento
            // 
            this.dateTimePickerInizioEvento.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePickerInizioEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInizioEvento.Location = new System.Drawing.Point(39, 124);
            this.dateTimePickerInizioEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerInizioEvento.Name = "dateTimePickerInizioEvento";
            this.dateTimePickerInizioEvento.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerInizioEvento.TabIndex = 44;
            // 
            // dateTimePickerFineEvento
            // 
            this.dateTimePickerFineEvento.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePickerFineEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFineEvento.Location = new System.Drawing.Point(40, 188);
            this.dateTimePickerFineEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFineEvento.Name = "dateTimePickerFineEvento";
            this.dateTimePickerFineEvento.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerFineEvento.TabIndex = 45;
            // 
            // panelCentrale
            // 
            this.panelCentrale.Controls.Add(this.buttonRimuoviSettori);
            this.panelCentrale.Controls.Add(this.txtGradoDiRischio);
            this.panelCentrale.Controls.Add(this.dateTimePickerFineEvento);
            this.panelCentrale.Controls.Add(this.panelPersonaleAssegnato);
            this.panelCentrale.Controls.Add(this.label4);
            this.panelCentrale.Controls.Add(this.buttonIncludiSettori);
            this.panelCentrale.Controls.Add(this.dateTimePickerInizioEvento);
            this.panelCentrale.Controls.Add(this._listSettoriAperti);
            this.panelCentrale.Controls.Add(this.label1);
            this.panelCentrale.Controls.Add(this.checkListSettoriAperti);
            this.panelCentrale.Controls.Add(this.txtNomeEvento);
            this.panelCentrale.Controls.Add(this.label5);
            this.panelCentrale.Controls.Add(this.label2);
            this.panelCentrale.Controls.Add(this.label3);
            this.panelCentrale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentrale.Location = new System.Drawing.Point(0, 0);
            this.panelCentrale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCentrale.Name = "panelCentrale";
            this.panelCentrale.Size = new System.Drawing.Size(951, 416);
            this.panelCentrale.TabIndex = 46;
            // 
            // buttonRimuoviSettori
            // 
            this.buttonRimuoviSettori.Enabled = false;
            this.buttonRimuoviSettori.Location = new System.Drawing.Point(400, 160);
            this.buttonRimuoviSettori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRimuoviSettori.Name = "buttonRimuoviSettori";
            this.buttonRimuoviSettori.Size = new System.Drawing.Size(120, 34);
            this.buttonRimuoviSettori.TabIndex = 46;
            this.buttonRimuoviSettori.Text = "Rimuovi Settori";
            this.buttonRimuoviSettori.UseVisualStyleBackColor = true;
            this.buttonRimuoviSettori.Click += new System.EventHandler(this.buttonRimuoviSettori_Click);
            // 
            // CreaNuovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 478);
            this.ControlBox = false;
            this.Controls.Add(this.panelCentrale);
            this.Controls.Add(this.panelBottom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreaNuovoEvento";
            this.Text = "Crea Nuovo Evento";
            this.Load += new System.EventHandler(this.CreaNuovoEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).EndInit();
            this.panelPersonaleAssegnato.ResumeLayout(false);
            this.panelPersonaleAssegnato.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelCentrale.ResumeLayout(false);
            this.panelCentrale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradoDiRischio;
        private System.Windows.Forms.ErrorProvider errorProviderEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.CheckedListBox checkListSettoriAperti;
        private System.Windows.Forms.Button buttonIncludiSettori;
        private System.Windows.Forms.ListBox _listSettoriAperti;       
        private System.Windows.Forms.Panel panelPersonaleAssegnato;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button _buttonAggiungiAddetto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAssegnamenti;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizioEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFineEvento;
        private System.Windows.Forms.Panel panelCentrale;
        private System.Windows.Forms.Button _buttonConvalida;
        private System.Windows.Forms.Button buttonRimuoviAdetto;
        private System.Windows.Forms.Button buttonRimuoviSettori;
    }
}