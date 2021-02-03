namespace POSsys.View
{
    partial class RetribuzioniMansioni
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
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._buttonAggiungi = new System.Windows.Forms.Button();
            this._comboBoxMansioni = new System.Windows.Forms.ComboBox();
            this._labelMansione = new System.Windows.Forms.Label();
            this._panelAggiungi = new System.Windows.Forms.Panel();
            this._buttonImposta = new System.Windows.Forms.Button();
            this._textBoxCompenso = new System.Windows.Forms.TextBox();
            this._labelCompenso = new System.Windows.Forms.Label();
            this._labelFine = new System.Windows.Forms.Label();
            this._labelInizio = new System.Windows.Forms.Label();
            this._dateTimePickerFine = new System.Windows.Forms.DateTimePicker();
            this._dateTimePickerInizio = new System.Windows.Forms.DateTimePicker();
            this._buttonSalva = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._buttonChiudi = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataInizioValiditaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineValitidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compensoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._panelAggiungi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this._panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._buttonAggiungi);
            this._splitContainer.Panel1.Controls.Add(this._comboBoxMansioni);
            this._splitContainer.Panel1.Controls.Add(this._labelMansione);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._panelAggiungi);
            this._splitContainer.Panel2.Controls.Add(this._dataGridView);
            this._splitContainer.Size = new System.Drawing.Size(917, 342);
            this._splitContainer.SplitterDistance = 39;
            this._splitContainer.SplitterWidth = 5;
            this._splitContainer.TabIndex = 0;
            // 
            // _buttonAggiungi
            // 
            this._buttonAggiungi.Enabled = false;
            this._buttonAggiungi.Location = new System.Drawing.Point(332, 5);
            this._buttonAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonAggiungi.Name = "_buttonAggiungi";
            this._buttonAggiungi.Size = new System.Drawing.Size(100, 28);
            this._buttonAggiungi.TabIndex = 1;
            this._buttonAggiungi.Text = "Aggiungi Retribuzione";
            this._buttonAggiungi.UseVisualStyleBackColor = true;
            this._buttonAggiungi.Click += new System.EventHandler(this._buttonAggiungi_Click);
            // 
            // _comboBoxMansioni
            // 
            this._comboBoxMansioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxMansioni.FormattingEnabled = true;
            this._comboBoxMansioni.Location = new System.Drawing.Point(163, 7);
            this._comboBoxMansioni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxMansioni.Name = "_comboBoxMansioni";
            this._comboBoxMansioni.Size = new System.Drawing.Size(160, 24);
            this._comboBoxMansioni.TabIndex = 1;
            this._comboBoxMansioni.SelectedIndexChanged += new System.EventHandler(this._comboBoxMansioni_SelectedIndexChanged);
            // 
            // _labelMansione
            // 
            this._labelMansione.AutoSize = true;
            this._labelMansione.Location = new System.Drawing.Point(4, 11);
            this._labelMansione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelMansione.Name = "_labelMansione";
            this._labelMansione.Size = new System.Drawing.Size(150, 17);
            this._labelMansione.TabIndex = 0;
            this._labelMansione.Text = "Seleziona la Mansione";
            // 
            // _panelAggiungi
            // 
            this._panelAggiungi.Controls.Add(this._buttonImposta);
            this._panelAggiungi.Controls.Add(this._textBoxCompenso);
            this._panelAggiungi.Controls.Add(this._labelCompenso);
            this._panelAggiungi.Controls.Add(this._labelFine);
            this._panelAggiungi.Controls.Add(this._labelInizio);
            this._panelAggiungi.Controls.Add(this._dateTimePickerFine);
            this._panelAggiungi.Controls.Add(this._dateTimePickerInizio);
            this._panelAggiungi.Controls.Add(this._buttonSalva);
            this._panelAggiungi.Dock = System.Windows.Forms.DockStyle.Right;
            this._panelAggiungi.Location = new System.Drawing.Point(624, 0);
            this._panelAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panelAggiungi.Name = "_panelAggiungi";
            this._panelAggiungi.Size = new System.Drawing.Size(293, 298);
            this._panelAggiungi.TabIndex = 1;
            this._panelAggiungi.Visible = false;
            // 
            // _buttonImposta
            // 
            this._buttonImposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonImposta.Location = new System.Drawing.Point(179, 69);
            this._buttonImposta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonImposta.Name = "_buttonImposta";
            this._buttonImposta.Size = new System.Drawing.Size(99, 28);
            this._buttonImposta.TabIndex = 51;
            this._buttonImposta.Text = "Imposta";
            this._buttonImposta.UseVisualStyleBackColor = true;
            this._buttonImposta.Click += new System.EventHandler(this._buttonImposta_Click);
            // 
            // _textBoxCompenso
            // 
            this._textBoxCompenso.Location = new System.Drawing.Point(16, 117);
            this._textBoxCompenso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._textBoxCompenso.Name = "_textBoxCompenso";
            this._textBoxCompenso.Size = new System.Drawing.Size(132, 22);
            this._textBoxCompenso.TabIndex = 50;
            // 
            // _labelCompenso
            // 
            this._labelCompenso.AutoSize = true;
            this._labelCompenso.Location = new System.Drawing.Point(12, 96);
            this._labelCompenso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelCompenso.Name = "_labelCompenso";
            this._labelCompenso.Size = new System.Drawing.Size(75, 17);
            this._labelCompenso.TabIndex = 49;
            this._labelCompenso.Text = "Compenso";
            // 
            // _labelFine
            // 
            this._labelFine.AutoSize = true;
            this._labelFine.Location = new System.Drawing.Point(12, 50);
            this._labelFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelFine.Name = "_labelFine";
            this._labelFine.Size = new System.Drawing.Size(119, 17);
            this._labelFine.TabIndex = 48;
            this._labelFine.Text = "Fine Retribuzione";
            // 
            // _labelInizio
            // 
            this._labelInizio.AutoSize = true;
            this._labelInizio.Location = new System.Drawing.Point(12, 5);
            this._labelInizio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelInizio.Name = "_labelInizio";
            this._labelInizio.Size = new System.Drawing.Size(124, 17);
            this._labelInizio.TabIndex = 47;
            this._labelInizio.Text = "Inizio Retribuzione";
            // 
            // _dateTimePickerFine
            // 
            this._dateTimePickerFine.CustomFormat = "dd/MM/yy HH:mm";
            this._dateTimePickerFine.Enabled = false;
            this._dateTimePickerFine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePickerFine.Location = new System.Drawing.Point(12, 69);
            this._dateTimePickerFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dateTimePickerFine.Name = "_dateTimePickerFine";
            this._dateTimePickerFine.Size = new System.Drawing.Size(159, 22);
            this._dateTimePickerFine.TabIndex = 46;
            // 
            // _dateTimePickerInizio
            // 
            this._dateTimePickerInizio.CustomFormat = "dd/MM/yy HH:mm";
            this._dateTimePickerInizio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePickerInizio.Location = new System.Drawing.Point(16, 23);
            this._dateTimePickerInizio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dateTimePickerInizio.Name = "_dateTimePickerInizio";
            this._dateTimePickerInizio.Size = new System.Drawing.Size(159, 22);
            this._dateTimePickerInizio.TabIndex = 45;
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(87, 262);
            this._buttonSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(127, 28);
            this._buttonSalva.TabIndex = 0;
            this._buttonSalva.Text = "Salva";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this._buttonSalva_Click);
            // 
            // _dataGridView
            // 
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataInizioValiditaDataGridViewTextBoxColumn,
            this.dataFineValitidaDataGridViewTextBoxColumn,
            this.compensoDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.bindingSource1;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(917, 298);
            this._dataGridView.TabIndex = 0;
            // 
            // _panelBottom
            // 
            this._panelBottom.Controls.Add(this._buttonChiudi);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 342);
            this._panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(917, 42);
            this._panelBottom.TabIndex = 2;
            // 
            // _buttonChiudi
            // 
            this._buttonChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonChiudi.Location = new System.Drawing.Point(801, 10);
            this._buttonChiudi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonChiudi.Name = "_buttonChiudi";
            this._buttonChiudi.Size = new System.Drawing.Size(100, 28);
            this._buttonChiudi.TabIndex = 0;
            this._buttonChiudi.Text = "Chiudi";
            this._buttonChiudi.UseVisualStyleBackColor = true;
            this._buttonChiudi.Click += new System.EventHandler(this._buttonChiudi_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(POSsys.Model.RetribuzioneMansione);
            // 
            // dataInizioValiditaDataGridViewTextBoxColumn
            // 
            this.dataInizioValiditaDataGridViewTextBoxColumn.DataPropertyName = "DataInizioValidita";
            this.dataInizioValiditaDataGridViewTextBoxColumn.HeaderText = "Data Inizio Validità";
            this.dataInizioValiditaDataGridViewTextBoxColumn.Name = "dataInizioValiditaDataGridViewTextBoxColumn";
            // 
            // dataFineValitidaDataGridViewTextBoxColumn
            // 
            this.dataFineValitidaDataGridViewTextBoxColumn.DataPropertyName = "DataFineValitida";
            this.dataFineValitidaDataGridViewTextBoxColumn.HeaderText = "Data Fine Valitidà";
            this.dataFineValitidaDataGridViewTextBoxColumn.Name = "dataFineValitidaDataGridViewTextBoxColumn";
            // 
            // compensoDataGridViewTextBoxColumn
            // 
            this.compensoDataGridViewTextBoxColumn.DataPropertyName = "Compenso";
            this.compensoDataGridViewTextBoxColumn.HeaderText = "Compenso";
            this.compensoDataGridViewTextBoxColumn.Name = "compensoDataGridViewTextBoxColumn";
            this.compensoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RetribuzioniMansioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 384);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this._panelBottom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RetribuzioniMansioni";
            this.Text = "RetribuzioniMansioni";
            this.Load += new System.EventHandler(this.RetribuzioniMansioni_Load);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._panelAggiungi.ResumeLayout(false);
            this._panelAggiungi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this._panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Label _labelMansione;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.ComboBox _comboBoxMansioni;
        private System.Windows.Forms.Button _buttonAggiungi;
        private System.Windows.Forms.Panel _panelAggiungi;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonChiudi;
        private System.Windows.Forms.TextBox _textBoxCompenso;
        private System.Windows.Forms.Label _labelCompenso;
        private System.Windows.Forms.Label _labelFine;
        private System.Windows.Forms.Label _labelInizio;
        private System.Windows.Forms.DateTimePicker _dateTimePickerFine;
        private System.Windows.Forms.DateTimePicker _dateTimePickerInizio;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button _buttonImposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioValiditaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineValitidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compensoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}