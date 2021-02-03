namespace POSsys.View
{
    partial class ProgrammaLavoro
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
            this._labelDescrizioneLavoro = new System.Windows.Forms.Label();
            this._textBoxDescrizioneLavoro = new System.Windows.Forms.TextBox();
            this._labelSettoriInteressati = new System.Windows.Forms.Label();
            this._checkedListBoxSettoriInteressati = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._dateTimePickerFineLavoro = new System.Windows.Forms.DateTimePicker();
            this._dateTimePickerInizioLavoro = new System.Windows.Forms.DateTimePicker();
            this._labelDataInizio = new System.Windows.Forms.Label();
            this._labelDataFine = new System.Windows.Forms.Label();
            this._errorProviderProgrammaLavoro = new System.Windows.Forms.ErrorProvider(this.components);
            this._comboBoxSettoreInteressato = new System.Windows.Forms.ComboBox();
            this._panelSettoreInteressato = new System.Windows.Forms.Panel();
            this._labelModTemporanea = new System.Windows.Forms.Label();
            this._textBoxModDefinitiva = new System.Windows.Forms.TextBox();
            this._textBoxModTemporanea = new System.Windows.Forms.TextBox();
            this._labelModDefinitiva = new System.Windows.Forms.Label();
            this._labelModificaCapienza = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderProgrammaLavoro)).BeginInit();
            this._panelSettoreInteressato.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelDescrizioneLavoro
            // 
            this._labelDescrizioneLavoro.AutoSize = true;
            this._labelDescrizioneLavoro.Location = new System.Drawing.Point(37, 33);
            this._labelDescrizioneLavoro.Name = "_labelDescrizioneLavoro";
            this._labelDescrizioneLavoro.Size = new System.Drawing.Size(94, 13);
            this._labelDescrizioneLavoro.TabIndex = 1;
            this._labelDescrizioneLavoro.Text = "Descrizione lavoro";
            // 
            // _textBoxDescrizioneLavoro
            // 
            this._textBoxDescrizioneLavoro.Location = new System.Drawing.Point(40, 49);
            this._textBoxDescrizioneLavoro.Name = "_textBoxDescrizioneLavoro";
            this._textBoxDescrizioneLavoro.Size = new System.Drawing.Size(208, 20);
            this._textBoxDescrizioneLavoro.TabIndex = 2;
            // 
            // _labelSettoriInteressati
            // 
            this._labelSettoriInteressati.AutoSize = true;
            this._labelSettoriInteressati.Location = new System.Drawing.Point(261, 88);
            this._labelSettoriInteressati.Name = "_labelSettoriInteressati";
            this._labelSettoriInteressati.Size = new System.Drawing.Size(139, 13);
            this._labelSettoriInteressati.TabIndex = 3;
            this._labelSettoriInteressati.Text = "Seleziona i settori interessati";
            // 
            // _checkedListBoxSettoriInteressati
            // 
            this._checkedListBoxSettoriInteressati.CheckOnClick = true;
            this._checkedListBoxSettoriInteressati.FormattingEnabled = true;
            this._checkedListBoxSettoriInteressati.Location = new System.Drawing.Point(264, 104);
            this._checkedListBoxSettoriInteressati.Name = "_checkedListBoxSettoriInteressati";
            this._checkedListBoxSettoriInteressati.Size = new System.Drawing.Size(136, 79);
            this._checkedListBoxSettoriInteressati.TabIndex = 6;
            this.toolTip1.SetToolTip(this._checkedListBoxSettoriInteressati, "Seleziona solo i settori che sono stati coinvolti dai lavori");
            this._checkedListBoxSettoriInteressati.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._checkedListBoxSettoriInteressati_ItemCheck);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalva.Location = new System.Drawing.Point(581, 10);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 23);
            this.buttonSalva.TabIndex = 24;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnulla.Location = new System.Drawing.Point(662, 10);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulla.TabIndex = 23;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalva);
            this.panel1.Controls.Add(this.buttonAnnulla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 45);
            this.panel1.TabIndex = 25;
            // 
            // _dateTimePickerFineLavoro
            // 
            this._dateTimePickerFineLavoro.CustomFormat = "dd/MM/yy HH:mm";
            this._dateTimePickerFineLavoro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePickerFineLavoro.Location = new System.Drawing.Point(41, 156);
            this._dateTimePickerFineLavoro.Margin = new System.Windows.Forms.Padding(2);
            this._dateTimePickerFineLavoro.Name = "_dateTimePickerFineLavoro";
            this._dateTimePickerFineLavoro.Size = new System.Drawing.Size(120, 20);
            this._dateTimePickerFineLavoro.TabIndex = 49;
            // 
            // _dateTimePickerInizioLavoro
            // 
            this._dateTimePickerInizioLavoro.CustomFormat = "dd/MM/yy HH:mm";
            this._dateTimePickerInizioLavoro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePickerInizioLavoro.Location = new System.Drawing.Point(40, 104);
            this._dateTimePickerInizioLavoro.Margin = new System.Windows.Forms.Padding(2);
            this._dateTimePickerInizioLavoro.Name = "_dateTimePickerInizioLavoro";
            this._dateTimePickerInizioLavoro.Size = new System.Drawing.Size(120, 20);
            this._dateTimePickerInizioLavoro.TabIndex = 48;
            // 
            // _labelDataInizio
            // 
            this._labelDataInizio.AutoSize = true;
            this._labelDataInizio.Location = new System.Drawing.Point(37, 87);
            this._labelDataInizio.Name = "_labelDataInizio";
            this._labelDataInizio.Size = new System.Drawing.Size(95, 13);
            this._labelDataInizio.TabIndex = 46;
            this._labelDataInizio.Text = "Data e ora di Inizio";
            // 
            // _labelDataFine
            // 
            this._labelDataFine.AutoSize = true;
            this._labelDataFine.Location = new System.Drawing.Point(37, 139);
            this._labelDataFine.Name = "_labelDataFine";
            this._labelDataFine.Size = new System.Drawing.Size(91, 13);
            this._labelDataFine.TabIndex = 47;
            this._labelDataFine.Text = "Data e ora di Fine";
            // 
            // _errorProviderProgrammaLavoro
            // 
            this._errorProviderProgrammaLavoro.ContainerControl = this;
            // 
            // _comboBoxSettoreInteressato
            // 
            this._comboBoxSettoreInteressato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxSettoreInteressato.FormattingEnabled = true;
            this._comboBoxSettoreInteressato.Location = new System.Drawing.Point(406, 88);
            this._comboBoxSettoreInteressato.Name = "_comboBoxSettoreInteressato";
            this._comboBoxSettoreInteressato.Size = new System.Drawing.Size(211, 21);
            this._comboBoxSettoreInteressato.TabIndex = 50;
            this._comboBoxSettoreInteressato.SelectionChangeCommitted += new System.EventHandler(this._comboBoxSettoreInteressato_SelectionChangeCommitted);
            // 
            // _panelSettoreInteressato
            // 
            this._panelSettoreInteressato.Controls.Add(this._labelModTemporanea);
            this._panelSettoreInteressato.Controls.Add(this._textBoxModDefinitiva);
            this._panelSettoreInteressato.Controls.Add(this._textBoxModTemporanea);
            this._panelSettoreInteressato.Controls.Add(this._labelModDefinitiva);
            this._panelSettoreInteressato.Controls.Add(this._labelModificaCapienza);
            this._panelSettoreInteressato.Location = new System.Drawing.Point(406, 115);
            this._panelSettoreInteressato.Name = "_panelSettoreInteressato";
            this._panelSettoreInteressato.Size = new System.Drawing.Size(211, 68);
            this._panelSettoreInteressato.TabIndex = 51;
            this._panelSettoreInteressato.Visible = false;
            // 
            // _labelModTemporanea
            // 
            this._labelModTemporanea.AutoSize = true;
            this._labelModTemporanea.Location = new System.Drawing.Point(3, 24);
            this._labelModTemporanea.Name = "_labelModTemporanea";
            this._labelModTemporanea.Size = new System.Drawing.Size(67, 13);
            this._labelModTemporanea.TabIndex = 31;
            this._labelModTemporanea.Text = "Temporanea";
            // 
            // _textBoxModDefinitiva
            // 
            this._textBoxModDefinitiva.Location = new System.Drawing.Point(76, 47);
            this._textBoxModDefinitiva.Name = "_textBoxModDefinitiva";
            this._textBoxModDefinitiva.Size = new System.Drawing.Size(100, 20);
            this._textBoxModDefinitiva.TabIndex = 30;
            this._textBoxModDefinitiva.TextChanged += new System.EventHandler(this._textBoxModDefinitiva_TextChanged);
            // 
            // _textBoxModTemporanea
            // 
            this._textBoxModTemporanea.Location = new System.Drawing.Point(76, 24);
            this._textBoxModTemporanea.Name = "_textBoxModTemporanea";
            this._textBoxModTemporanea.Size = new System.Drawing.Size(100, 20);
            this._textBoxModTemporanea.TabIndex = 29;
            this._textBoxModTemporanea.TextChanged += new System.EventHandler(this._textBoxModTemporanea_TextChanged);
            // 
            // _labelModDefinitiva
            // 
            this._labelModDefinitiva.AutoSize = true;
            this._labelModDefinitiva.Location = new System.Drawing.Point(3, 50);
            this._labelModDefinitiva.Name = "_labelModDefinitiva";
            this._labelModDefinitiva.Size = new System.Drawing.Size(51, 13);
            this._labelModDefinitiva.TabIndex = 28;
            this._labelModDefinitiva.Text = "Definitiva";
            // 
            // _labelModificaCapienza
            // 
            this._labelModificaCapienza.AutoSize = true;
            this._labelModificaCapienza.Location = new System.Drawing.Point(-3, 0);
            this._labelModificaCapienza.Name = "_labelModificaCapienza";
            this._labelModificaCapienza.Size = new System.Drawing.Size(113, 13);
            this._labelModificaCapienza.TabIndex = 27;
            this._labelModificaCapienza.Text = "Modifica alla Capienza";
            // 
            // ProgrammaLavoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 303);
            this.ControlBox = false;
            this.Controls.Add(this._panelSettoreInteressato);
            this.Controls.Add(this._comboBoxSettoreInteressato);
            this.Controls.Add(this._dateTimePickerFineLavoro);
            this.Controls.Add(this._dateTimePickerInizioLavoro);
            this.Controls.Add(this._labelDataInizio);
            this.Controls.Add(this._labelDataFine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._checkedListBoxSettoriInteressati);
            this.Controls.Add(this._labelSettoriInteressati);
            this.Controls.Add(this._textBoxDescrizioneLavoro);
            this.Controls.Add(this._labelDescrizioneLavoro);
            this.Name = "ProgrammaLavoro";
            this.Text = "ProgrammaLavoro";
            this.Load += new System.EventHandler(this.ProgrammaLavoro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderProgrammaLavoro)).EndInit();
            this._panelSettoreInteressato.ResumeLayout(false);
            this._panelSettoreInteressato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizioneLavoro;
        private System.Windows.Forms.TextBox _textBoxDescrizioneLavoro;
        private System.Windows.Forms.Label _labelSettoriInteressati;
        private System.Windows.Forms.CheckedListBox _checkedListBoxSettoriInteressati;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker _dateTimePickerFineLavoro;
        private System.Windows.Forms.DateTimePicker _dateTimePickerInizioLavoro;
        private System.Windows.Forms.Label _labelDataInizio;
        private System.Windows.Forms.Label _labelDataFine;
        private System.Windows.Forms.ErrorProvider _errorProviderProgrammaLavoro;
        private System.Windows.Forms.ComboBox _comboBoxSettoreInteressato;
        private System.Windows.Forms.Panel _panelSettoreInteressato;
        private System.Windows.Forms.TextBox _textBoxModDefinitiva;
        private System.Windows.Forms.TextBox _textBoxModTemporanea;
        private System.Windows.Forms.Label _labelModDefinitiva;
        private System.Windows.Forms.Label _labelModificaCapienza;
        private System.Windows.Forms.Label _labelModTemporanea;
    }
}