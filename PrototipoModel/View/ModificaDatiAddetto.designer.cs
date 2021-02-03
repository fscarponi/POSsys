namespace POSsys.View
{
    partial class ModificaDatiAddetto
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
            this.comboBoxAddetto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.panelIndirizzo = new System.Windows.Forms.Panel();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.txtComune = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.txtCivico = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.lblIndirizzoDomicilio = new System.Windows.Forms.Label();
            this.checkBoxModInd = new System.Windows.Forms.CheckBox();
            this.comboBoxIndirizzo = new System.Windows.Forms.ComboBox();
            this.checkBoxModQualifica = new System.Windows.Forms.CheckBox();
            this.comboBoxQualifica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQualificaAttuale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personaleFactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelIndirizzo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaleFactoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAddetto
            // 
            this.comboBoxAddetto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddetto.FormattingEnabled = true;
            this.comboBoxAddetto.Location = new System.Drawing.Point(403, 27);
            this.comboBoxAddetto.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddetto.Name = "comboBoxAddetto";
            this.comboBoxAddetto.Size = new System.Drawing.Size(263, 24);
            this.comboBoxAddetto.Sorted = true;
            this.comboBoxAddetto.TabIndex = 37;
            this.comboBoxAddetto.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddetto_SelectedIndexChanged);
            this.comboBoxAddetto.SelectedValueChanged += new System.EventHandler(this.comboBoxAddetto_SelectedValueChanged);
            this.comboBoxAddetto.TextChanged += new System.EventHandler(this.comboBoxAddetto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Seleziona l\'Addetto che intendi modificare:";
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(650, 15);
            this.buttonSalva.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(100, 28);
            this.buttonSalva.TabIndex = 40;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Location = new System.Drawing.Point(758, 15);
            this.buttonChiudi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(100, 28);
            this.buttonChiudi.TabIndex = 39;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = true;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // panelIndirizzo
            // 
            this.panelIndirizzo.Controls.Add(this.txtNazione);
            this.panelIndirizzo.Controls.Add(this.txtComune);
            this.panelIndirizzo.Controls.Add(this.txtProvincia);
            this.panelIndirizzo.Controls.Add(this.txtCAP);
            this.panelIndirizzo.Controls.Add(this.txtCivico);
            this.panelIndirizzo.Controls.Add(this.txtIndirizzo);
            this.panelIndirizzo.Controls.Add(this.lblIndirizzoDomicilio);
            this.panelIndirizzo.Location = new System.Drawing.Point(35, 128);
            this.panelIndirizzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIndirizzo.Name = "panelIndirizzo";
            this.panelIndirizzo.Size = new System.Drawing.Size(899, 50);
            this.panelIndirizzo.TabIndex = 52;
            this.panelIndirizzo.Visible = false;
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(675, 22);
            this.txtNazione.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(143, 22);
            this.txtNazione.TabIndex = 56;
            this.txtNazione.Tag = "";
            this.txtNazione.Text = "Nazione";
            // 
            // txtComune
            // 
            this.txtComune.Location = new System.Drawing.Point(368, 22);
            this.txtComune.Margin = new System.Windows.Forms.Padding(4);
            this.txtComune.Name = "txtComune";
            this.txtComune.Size = new System.Drawing.Size(160, 22);
            this.txtComune.TabIndex = 55;
            this.txtComune.Tag = "";
            this.txtComune.Text = "Comune";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(595, 22);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(73, 22);
            this.txtProvincia.TabIndex = 54;
            this.txtProvincia.Tag = "";
            this.txtProvincia.Text = "Provincia";
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(536, 22);
            this.txtCAP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCAP.MaxLength = 5;
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(47, 22);
            this.txtCAP.TabIndex = 53;
            this.txtCAP.Tag = "";
            this.txtCAP.Text = "CAP";
            // 
            // txtCivico
            // 
            this.txtCivico.Location = new System.Drawing.Point(292, 22);
            this.txtCivico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCivico.Name = "txtCivico";
            this.txtCivico.Size = new System.Drawing.Size(67, 22);
            this.txtCivico.TabIndex = 52;
            this.txtCivico.Text = "n.civico";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(12, 22);
            this.txtIndirizzo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(272, 22);
            this.txtIndirizzo.TabIndex = 50;
            this.txtIndirizzo.Text = "via/viale";
            // 
            // lblIndirizzoDomicilio
            // 
            this.lblIndirizzoDomicilio.AutoSize = true;
            this.lblIndirizzoDomicilio.Location = new System.Drawing.Point(11, 1);
            this.lblIndirizzoDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndirizzoDomicilio.Name = "lblIndirizzoDomicilio";
            this.lblIndirizzoDomicilio.Size = new System.Drawing.Size(60, 17);
            this.lblIndirizzoDomicilio.TabIndex = 49;
            this.lblIndirizzoDomicilio.Text = "Indirizzo";
            // 
            // checkBoxModInd
            // 
            this.checkBoxModInd.AutoSize = true;
            this.checkBoxModInd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxModInd.Location = new System.Drawing.Point(35, 102);
            this.checkBoxModInd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxModInd.Name = "checkBoxModInd";
            this.checkBoxModInd.Size = new System.Drawing.Size(138, 21);
            this.checkBoxModInd.TabIndex = 53;
            this.checkBoxModInd.Text = "Modifica Indirizzo";
            this.checkBoxModInd.UseVisualStyleBackColor = true;
            this.checkBoxModInd.CheckedChanged += new System.EventHandler(this.checkBoxModInd_CheckedChanged);
            // 
            // comboBoxIndirizzo
            // 
            this.comboBoxIndirizzo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndirizzo.Enabled = false;
            this.comboBoxIndirizzo.FormattingEnabled = true;
            this.comboBoxIndirizzo.Location = new System.Drawing.Point(196, 98);
            this.comboBoxIndirizzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIndirizzo.Name = "comboBoxIndirizzo";
            this.comboBoxIndirizzo.Size = new System.Drawing.Size(171, 24);
            this.comboBoxIndirizzo.TabIndex = 54;
            this.comboBoxIndirizzo.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndirizzo_SelectedIndexChanged);
            // 
            // checkBoxModQualifica
            // 
            this.checkBoxModQualifica.AutoSize = true;
            this.checkBoxModQualifica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxModQualifica.Location = new System.Drawing.Point(35, 219);
            this.checkBoxModQualifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxModQualifica.Name = "checkBoxModQualifica";
            this.checkBoxModQualifica.Size = new System.Drawing.Size(138, 21);
            this.checkBoxModQualifica.TabIndex = 55;
            this.checkBoxModQualifica.Text = "Modifica Quaifica";
            this.checkBoxModQualifica.UseVisualStyleBackColor = true;
            this.checkBoxModQualifica.CheckedChanged += new System.EventHandler(this.checkBoxModQualifica_CheckedChanged);
            // 
            // comboBoxQualifica
            // 
            this.comboBoxQualifica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualifica.Enabled = false;
            this.comboBoxQualifica.FormattingEnabled = true;
            this.comboBoxQualifica.Location = new System.Drawing.Point(196, 262);
            this.comboBoxQualifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxQualifica.Name = "comboBoxQualifica";
            this.comboBoxQualifica.Size = new System.Drawing.Size(145, 24);
            this.comboBoxQualifica.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Attuale qualifica";
            // 
            // txtQualificaAttuale
            // 
            this.txtQualificaAttuale.Location = new System.Drawing.Point(45, 263);
            this.txtQualificaAttuale.Margin = new System.Windows.Forms.Padding(4);
            this.txtQualificaAttuale.Name = "txtQualificaAttuale";
            this.txtQualificaAttuale.ReadOnly = true;
            this.txtQualificaAttuale.Size = new System.Drawing.Size(127, 22);
            this.txtQualificaAttuale.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nuova qualifica";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalva);
            this.panel1.Controls.Add(this.buttonChiudi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 51);
            this.panel1.TabIndex = 60;
            // 
            // personaleFactoryBindingSource
            // 
            this.personaleFactoryBindingSource.DataSource = typeof(POSsys.Model.PersonaleFactory);
            // 
            // ModificaDatiAddetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 356);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQualificaAttuale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxQualifica);
            this.Controls.Add(this.checkBoxModQualifica);
            this.Controls.Add(this.comboBoxIndirizzo);
            this.Controls.Add(this.checkBoxModInd);
            this.Controls.Add(this.panelIndirizzo);
            this.Controls.Add(this.comboBoxAddetto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificaDatiAddetto";
            this.Text = "Modifica Dati Addetto Alla Sicurezza";
            this.Load += new System.EventHandler(this.ModificaDatiAddetto_Load);
            this.panelIndirizzo.ResumeLayout(false);
            this.panelIndirizzo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personaleFactoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAddetto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.Panel panelIndirizzo;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.TextBox txtComune;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.TextBox txtCivico;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label lblIndirizzoDomicilio;
        private System.Windows.Forms.CheckBox checkBoxModInd;
        private System.Windows.Forms.ComboBox comboBoxIndirizzo;
        private System.Windows.Forms.CheckBox checkBoxModQualifica;
        private System.Windows.Forms.ComboBox comboBoxQualifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQualificaAttuale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource personaleFactoryBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}