namespace POSsys.View
{
    partial class ModificaEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxEventoDaModificare = new System.Windows.Forms.ComboBox();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this._panelBottom = new System.Windows.Forms.Panel();
            this.buttonSalva = new System.Windows.Forms.Button();
            this._panelTop = new System.Windows.Forms.Panel();
            this._panelFill = new System.Windows.Forms.Panel();
            this.dateTimePickerFineEvento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInizioEvento = new System.Windows.Forms.DateTimePicker();
            this.buttonModificaDataFine = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModificaDataInizio = new System.Windows.Forms.Button();
            this.txtNomeDaModificare = new System.Windows.Forms.TextBox();
            this.buttonModificaNomeEvento = new System.Windows.Forms.Button();
            this.errorProviderModEvento = new System.Windows.Forms.ErrorProvider(this.components);
            this._panelBottom.SuspendLayout();
            this._panelTop.SuspendLayout();
            this._panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona l\'evento da modificare:\r\n";
            // 
            // _comboBoxEventoDaModificare
            // 
            this._comboBoxEventoDaModificare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._comboBoxEventoDaModificare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxEventoDaModificare.FormattingEnabled = true;
            this._comboBoxEventoDaModificare.Location = new System.Drawing.Point(196, 25);
            this._comboBoxEventoDaModificare.Name = "_comboBoxEventoDaModificare";
            this._comboBoxEventoDaModificare.Size = new System.Drawing.Size(153, 21);
            this._comboBoxEventoDaModificare.TabIndex = 1;
            this._comboBoxEventoDaModificare.SelectedIndexChanged += new System.EventHandler(this._comboBoxEventoDaModificare_SelectedIndexChanged);
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnulla.Location = new System.Drawing.Point(452, 13);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulla.TabIndex = 24;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // _panelBottom
            // 
            this._panelBottom.Controls.Add(this.buttonSalva);
            this._panelBottom.Controls.Add(this.buttonAnnulla);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 182);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(539, 48);
            this._panelBottom.TabIndex = 25;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalva.Location = new System.Drawing.Point(371, 13);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 23);
            this.buttonSalva.TabIndex = 25;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // _panelTop
            // 
            this._panelTop.Controls.Add(this.label1);
            this._panelTop.Controls.Add(this._comboBoxEventoDaModificare);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Size = new System.Drawing.Size(539, 56);
            this._panelTop.TabIndex = 26;
            // 
            // _panelFill
            // 
            this._panelFill.Controls.Add(this.dateTimePickerFineEvento);
            this._panelFill.Controls.Add(this.dateTimePickerInizioEvento);
            this._panelFill.Controls.Add(this.buttonModificaDataFine);
            this._panelFill.Controls.Add(this.label6);
            this._panelFill.Controls.Add(this.label5);
            this._panelFill.Controls.Add(this.label4);
            this._panelFill.Controls.Add(this.label2);
            this._panelFill.Controls.Add(this.buttonModificaDataInizio);
            this._panelFill.Controls.Add(this.txtNomeDaModificare);
            this._panelFill.Controls.Add(this.buttonModificaNomeEvento);
            this._panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFill.Location = new System.Drawing.Point(0, 56);
            this._panelFill.Name = "_panelFill";
            this._panelFill.Size = new System.Drawing.Size(539, 126);
            this._panelFill.TabIndex = 27;
            this._panelFill.Visible = false;
            // 
            // dateTimePickerFineEvento
            // 
            this.dateTimePickerFineEvento.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePickerFineEvento.Enabled = false;
            this.dateTimePickerFineEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFineEvento.Location = new System.Drawing.Point(189, 78);
            this.dateTimePickerFineEvento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFineEvento.Name = "dateTimePickerFineEvento";
            this.dateTimePickerFineEvento.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerFineEvento.TabIndex = 56;
            // 
            // dateTimePickerInizioEvento
            // 
            this.dateTimePickerInizioEvento.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePickerInizioEvento.Enabled = false;
            this.dateTimePickerInizioEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInizioEvento.Location = new System.Drawing.Point(189, 52);
            this.dateTimePickerInizioEvento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerInizioEvento.Name = "dateTimePickerInizioEvento";
            this.dateTimePickerInizioEvento.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerInizioEvento.TabIndex = 55;
            // 
            // buttonModificaDataFine
            // 
            this.buttonModificaDataFine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificaDataFine.Location = new System.Drawing.Point(340, 75);
            this.buttonModificaDataFine.Name = "buttonModificaDataFine";
            this.buttonModificaDataFine.Size = new System.Drawing.Size(55, 23);
            this.buttonModificaDataFine.TabIndex = 52;
            this.buttonModificaDataFine.Text = "Modifica Data e ora Fine";
            this.buttonModificaDataFine.UseVisualStyleBackColor = true;
            this.buttonModificaDataFine.Click += new System.EventHandler(this.buttonModificaDataFine_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Data e ora di fine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Data e ora di inizio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nome evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(193, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Dati riassuntivi dell\'evento:";
            // 
            // buttonModificaDataInizio
            // 
            this.buttonModificaDataInizio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificaDataInizio.Location = new System.Drawing.Point(340, 49);
            this.buttonModificaDataInizio.Name = "buttonModificaDataInizio";
            this.buttonModificaDataInizio.Size = new System.Drawing.Size(55, 23);
            this.buttonModificaDataInizio.TabIndex = 43;
            this.buttonModificaDataInizio.Text = "Modifica Data e Ora nizio";
            this.buttonModificaDataInizio.UseVisualStyleBackColor = true;
            this.buttonModificaDataInizio.Click += new System.EventHandler(this.buttonModificaDataInizio_Click);
            // 
            // txtNomeDaModificare
            // 
            this.txtNomeDaModificare.Enabled = false;
            this.txtNomeDaModificare.Location = new System.Drawing.Point(189, 27);
            this.txtNomeDaModificare.Name = "txtNomeDaModificare";
            this.txtNomeDaModificare.Size = new System.Drawing.Size(145, 20);
            this.txtNomeDaModificare.TabIndex = 42;
            // 
            // buttonModificaNomeEvento
            // 
            this.buttonModificaNomeEvento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificaNomeEvento.Location = new System.Drawing.Point(340, 26);
            this.buttonModificaNomeEvento.Name = "buttonModificaNomeEvento";
            this.buttonModificaNomeEvento.Size = new System.Drawing.Size(55, 23);
            this.buttonModificaNomeEvento.TabIndex = 41;
            this.buttonModificaNomeEvento.Text = "Modifica nome Evento";
            this.buttonModificaNomeEvento.UseVisualStyleBackColor = true;
            this.buttonModificaNomeEvento.Click += new System.EventHandler(this.buttonModificaNomeEvento_Click);
            // 
            // errorProviderModEvento
            // 
            this.errorProviderModEvento.ContainerControl = this;
            // 
            // ModificaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 230);
            this.ControlBox = false;
            this.Controls.Add(this._panelFill);
            this.Controls.Add(this._panelTop);
            this.Controls.Add(this._panelBottom);
            this.Name = "ModificaEvento";
            this.Text = "Seleziona Evento";
            this.Load += new System.EventHandler(this.SelezionaEvento_Load);
            this._panelBottom.ResumeLayout(false);
            this._panelTop.ResumeLayout(false);
            this._panelTop.PerformLayout();
            this._panelFill.ResumeLayout(false);
            this._panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxEventoDaModificare;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Panel _panelFill;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonModificaDataFine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModificaDataInizio;
        private System.Windows.Forms.TextBox txtNomeDaModificare;
        private System.Windows.Forms.Button buttonModificaNomeEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFineEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizioEvento;
        private System.Windows.Forms.ErrorProvider errorProviderModEvento;
    }
}