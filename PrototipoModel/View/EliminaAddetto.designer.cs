namespace POSsys.View
{
    partial class EliminaAddetto
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
            this._buttonSalva = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this._comboBoxLicenziaAddetto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._dateTimePickerDataLicenziamento = new System.Windows.Forms.DateTimePicker();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luogoNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAssunzioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLicenziamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(591, 47);
            this._buttonSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(100, 28);
            this._buttonSalva.TabIndex = 32;
            this._buttonSalva.Text = "Salva";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAnnulla.Location = new System.Drawing.Point(699, 47);
            this._buttonAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this._buttonAnnulla.TabIndex = 31;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // _comboBoxLicenziaAddetto
            // 
            this._comboBoxLicenziaAddetto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLicenziaAddetto.FormattingEnabled = true;
            this._comboBoxLicenziaAddetto.Location = new System.Drawing.Point(61, 46);
            this._comboBoxLicenziaAddetto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxLicenziaAddetto.Name = "_comboBoxLicenziaAddetto";
            this._comboBoxLicenziaAddetto.Size = new System.Drawing.Size(200, 24);
            this._comboBoxLicenziaAddetto.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seleziona l\'addetto alla sicurezza da licenziare:";
            // 
            // _panelBottom
            // 
            this._panelBottom.Controls.Add(this._dateTimePickerDataLicenziamento);
            this._panelBottom.Controls.Add(this._buttonSalva);
            this._panelBottom.Controls.Add(this.label1);
            this._panelBottom.Controls.Add(this._comboBoxLicenziaAddetto);
            this._panelBottom.Controls.Add(this._buttonAnnulla);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 280);
            this._panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(815, 90);
            this._panelBottom.TabIndex = 33;
            // 
            // _dateTimePickerDataLicenziamento
            // 
            this._dateTimePickerDataLicenziamento.CustomFormat = "dd/MM/yy HH:mm";
            this._dateTimePickerDataLicenziamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePickerDataLicenziamento.Location = new System.Drawing.Point(315, 47);
            this._dateTimePickerDataLicenziamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dateTimePickerDataLicenziamento.Name = "_dateTimePickerDataLicenziamento";
            this._dateTimePickerDataLicenziamento.Size = new System.Drawing.Size(159, 22);
            this._dateTimePickerDataLicenziamento.TabIndex = 46;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToOrderColumns = true;
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.cfDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.luogoNascitaDataGridViewTextBoxColumn,
            this.residenzaDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.dataAssunzioneDataGridViewTextBoxColumn,
            this.dataLicenziamentoDataGridViewTextBoxColumn,
            this.qualificaDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.bindingSource1;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(815, 280);
            this._dataGridView.TabIndex = 34;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(POSsys.Model.AddettoAllaSicurezza);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cfDataGridViewTextBoxColumn
            // 
            this.cfDataGridViewTextBoxColumn.DataPropertyName = "Cf";
            this.cfDataGridViewTextBoxColumn.HeaderText = "Codice Fiscale";
            this.cfDataGridViewTextBoxColumn.Name = "cfDataGridViewTextBoxColumn";
            this.cfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "Data Nascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luogoNascitaDataGridViewTextBoxColumn
            // 
            this.luogoNascitaDataGridViewTextBoxColumn.DataPropertyName = "LuogoNascita";
            this.luogoNascitaDataGridViewTextBoxColumn.HeaderText = "Luogo Nascita";
            this.luogoNascitaDataGridViewTextBoxColumn.Name = "luogoNascitaDataGridViewTextBoxColumn";
            this.luogoNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residenzaDataGridViewTextBoxColumn
            // 
            this.residenzaDataGridViewTextBoxColumn.DataPropertyName = "Residenza";
            this.residenzaDataGridViewTextBoxColumn.HeaderText = "Residenza";
            this.residenzaDataGridViewTextBoxColumn.Name = "residenzaDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // dataAssunzioneDataGridViewTextBoxColumn
            // 
            this.dataAssunzioneDataGridViewTextBoxColumn.DataPropertyName = "DataAssunzione";
            this.dataAssunzioneDataGridViewTextBoxColumn.HeaderText = "Data Assunzione";
            this.dataAssunzioneDataGridViewTextBoxColumn.Name = "dataAssunzioneDataGridViewTextBoxColumn";
            this.dataAssunzioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLicenziamentoDataGridViewTextBoxColumn
            // 
            this.dataLicenziamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLicenziamento";
            this.dataLicenziamentoDataGridViewTextBoxColumn.HeaderText = "Data Licenziamento";
            this.dataLicenziamentoDataGridViewTextBoxColumn.Name = "dataLicenziamentoDataGridViewTextBoxColumn";
            // 
            // qualificaDataGridViewTextBoxColumn
            // 
            this.qualificaDataGridViewTextBoxColumn.DataPropertyName = "Qualifica";
            this.qualificaDataGridViewTextBoxColumn.HeaderText = "Qualifica";
            this.qualificaDataGridViewTextBoxColumn.Name = "qualificaDataGridViewTextBoxColumn";
            // 
            // EliminaAddetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 370);
            this.ControlBox = false;
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._panelBottom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminaAddetto";
            this.Text = "Licenzia Addetto Alla Sicurezza";
            this.Load += new System.EventHandler(this.EliminaAddetto_Load);
            this._panelBottom.ResumeLayout(false);
            this._panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.ComboBox _comboBoxLicenziaAddetto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DateTimePicker _dateTimePickerDataLicenziamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luogoNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAssunzioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLicenziamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}