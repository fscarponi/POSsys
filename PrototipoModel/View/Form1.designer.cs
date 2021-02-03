namespace POSsys.View
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestioneEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaNuovoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneImpiantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaNuovoSettoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaSettoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pianificaLavoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaSettoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionePersonaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaDatiAddettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disattivaAddettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcolaCompensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetribuzioniMansioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._dataGridViewEventi = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._dataGridViewLavoro = new System.Windows.Forms.DataGridView();
            this._dataGridViewSettori = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoRischioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourceEvento = new System.Windows.Forms.BindingSource(this.components);
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourceLavoro = new System.Windows.Forms.BindingSource(this.components);
            this._bindingSourceSettori = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capienzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disattivatoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEventi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewLavoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSettori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceLavoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceSettori)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioneEventoToolStripMenuItem,
            this.gestioneImpiantoToolStripMenuItem,
            this.gestionePersonaleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestioneEventoToolStripMenuItem
            // 
            this.gestioneEventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaNuovoEventoToolStripMenuItem,
            this.modificaEventoToolStripMenuItem,
            this.annullaEventoToolStripMenuItem});
            this.gestioneEventoToolStripMenuItem.Name = "gestioneEventoToolStripMenuItem";
            this.gestioneEventoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.gestioneEventoToolStripMenuItem.Text = "Gestione Evento";
            // 
            // creaNuovoEventoToolStripMenuItem
            // 
            this.creaNuovoEventoToolStripMenuItem.Name = "creaNuovoEventoToolStripMenuItem";
            this.creaNuovoEventoToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.creaNuovoEventoToolStripMenuItem.Text = "Crea Nuovo Evento";
            this.creaNuovoEventoToolStripMenuItem.Click += new System.EventHandler(this.creaNuovoEventoToolStripMenuItem_Click);
            // 
            // modificaEventoToolStripMenuItem
            // 
            this.modificaEventoToolStripMenuItem.Name = "modificaEventoToolStripMenuItem";
            this.modificaEventoToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.modificaEventoToolStripMenuItem.Text = "Modifica Evento";
            this.modificaEventoToolStripMenuItem.Click += new System.EventHandler(this.modificaEventoToolStripMenuItem_Click);
            // 
            // annullaEventoToolStripMenuItem
            // 
            this.annullaEventoToolStripMenuItem.Name = "annullaEventoToolStripMenuItem";
            this.annullaEventoToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.annullaEventoToolStripMenuItem.Text = "Annulla Evento";
            this.annullaEventoToolStripMenuItem.Click += new System.EventHandler(this.annullaEventoToolStripMenuItem_Click);
            // 
            // gestioneImpiantoToolStripMenuItem
            // 
            this.gestioneImpiantoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaNuovoSettoreToolStripMenuItem,
            this.modificaSettoreToolStripMenuItem,
            this.pianificaLavoroToolStripMenuItem,
            this.eliminaSettoreToolStripMenuItem});
            this.gestioneImpiantoToolStripMenuItem.Name = "gestioneImpiantoToolStripMenuItem";
            this.gestioneImpiantoToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.gestioneImpiantoToolStripMenuItem.Text = "Gestione Impianto";
            // 
            // creaNuovoSettoreToolStripMenuItem
            // 
            this.creaNuovoSettoreToolStripMenuItem.Name = "creaNuovoSettoreToolStripMenuItem";
            this.creaNuovoSettoreToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.creaNuovoSettoreToolStripMenuItem.Text = "Crea Nuovo Settore";
            this.creaNuovoSettoreToolStripMenuItem.Click += new System.EventHandler(this.creaNuovoSettoreToolStripMenuItem_Click);
            // 
            // modificaSettoreToolStripMenuItem
            // 
            this.modificaSettoreToolStripMenuItem.Name = "modificaSettoreToolStripMenuItem";
            this.modificaSettoreToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.modificaSettoreToolStripMenuItem.Text = "Modifica Settore";
            this.modificaSettoreToolStripMenuItem.Click += new System.EventHandler(this.modificaSettoreToolStripMenuItem_Click);
            // 
            // pianificaLavoroToolStripMenuItem
            // 
            this.pianificaLavoroToolStripMenuItem.Name = "pianificaLavoroToolStripMenuItem";
            this.pianificaLavoroToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.pianificaLavoroToolStripMenuItem.Text = "Programma Lavoro";
            this.pianificaLavoroToolStripMenuItem.Click += new System.EventHandler(this.pianificaLavoroToolStripMenuItem_Click);
            // 
            // eliminaSettoreToolStripMenuItem
            // 
            this.eliminaSettoreToolStripMenuItem.Name = "eliminaSettoreToolStripMenuItem";
            this.eliminaSettoreToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.eliminaSettoreToolStripMenuItem.Text = "Elimina Settore";
            this.eliminaSettoreToolStripMenuItem.Click += new System.EventHandler(this.eliminaSettoreToolStripMenuItem_Click);
            // 
            // gestionePersonaleToolStripMenuItem
            // 
            this.gestionePersonaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem,
            this.modificaDatiAddettoToolStripMenuItem,
            this.disattivaAddettoToolStripMenuItem,
            this.calcolaCompensiToolStripMenuItem,
            this.RetribuzioniMansioniToolStripMenuItem});
            this.gestionePersonaleToolStripMenuItem.Name = "gestionePersonaleToolStripMenuItem";
            this.gestionePersonaleToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.gestionePersonaleToolStripMenuItem.Text = "Gestione Personale";
            // 
            // inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem
            // 
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem.Name = "inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem";
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem.Text = "Inserisci Nuovo Addetto";
            this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem.Click += new System.EventHandler(this.inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem_Click);
            // 
            // modificaDatiAddettoToolStripMenuItem
            // 
            this.modificaDatiAddettoToolStripMenuItem.Name = "modificaDatiAddettoToolStripMenuItem";
            this.modificaDatiAddettoToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.modificaDatiAddettoToolStripMenuItem.Text = "Modifica Dati Addetto";
            this.modificaDatiAddettoToolStripMenuItem.Click += new System.EventHandler(this.modificaDatiAddettoToolStripMenuItem_Click);
            // 
            // disattivaAddettoToolStripMenuItem
            // 
            this.disattivaAddettoToolStripMenuItem.Name = "disattivaAddettoToolStripMenuItem";
            this.disattivaAddettoToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.disattivaAddettoToolStripMenuItem.Text = "Elimina Addetto";
            this.disattivaAddettoToolStripMenuItem.Click += new System.EventHandler(this.disattivaAddettoToolStripMenuItem_Click);
            // 
            // calcolaCompensiToolStripMenuItem
            // 
            this.calcolaCompensiToolStripMenuItem.Name = "calcolaCompensiToolStripMenuItem";
            this.calcolaCompensiToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.calcolaCompensiToolStripMenuItem.Text = "Calcola Compensi";
            this.calcolaCompensiToolStripMenuItem.Click += new System.EventHandler(this.calcolaCompensiToolStripMenuItem_Click);
            // 
            // RetribuzioniMansioniToolStripMenuItem
            // 
            this.RetribuzioniMansioniToolStripMenuItem.Name = "RetribuzioniMansioniToolStripMenuItem";
            this.RetribuzioniMansioniToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.RetribuzioniMansioniToolStripMenuItem.Text = "Retribuzioni Mansioni";
            this.RetribuzioniMansioniToolStripMenuItem.Click += new System.EventHandler(this.RetribuzioniMansioniToolStripMenuItem_Click);
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 28);
            this._splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._dataGridViewEventi);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this._splitContainer.Size = new System.Drawing.Size(942, 374);
            this._splitContainer.SplitterDistance = 177;
            this._splitContainer.SplitterWidth = 5;
            this._splitContainer.TabIndex = 1;
            // 
            // _dataGridViewEventi
            // 
            this._dataGridViewEventi.AutoGenerateColumns = false;
            this._dataGridViewEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridViewEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewEventi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.dataInizioDataGridViewTextBoxColumn,
            this.dataFineDataGridViewTextBoxColumn,
            this.gradoRischioDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn});
            this._dataGridViewEventi.DataSource = this._bindingSourceEvento;
            this._dataGridViewEventi.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewEventi.Enabled = false;
            this._dataGridViewEventi.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewEventi.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewEventi.Name = "_dataGridViewEventi";
            this._dataGridViewEventi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewEventi.Size = new System.Drawing.Size(942, 177);
            this._dataGridViewEventi.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._dataGridViewLavoro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._dataGridViewSettori);
            this.splitContainer1.Size = new System.Drawing.Size(942, 192);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // _dataGridViewLavoro
            // 
            this._dataGridViewLavoro.AutoGenerateColumns = false;
            this._dataGridViewLavoro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewLavoro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descrizioneDataGridViewTextBoxColumn,
            this.dataInizioDataGridViewTextBoxColumn1,
            this.dataFineDataGridViewTextBoxColumn1});
            this._dataGridViewLavoro.DataSource = this._bindingSourceLavoro;
            this._dataGridViewLavoro.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewLavoro.Enabled = false;
            this._dataGridViewLavoro.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewLavoro.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewLavoro.Name = "_dataGridViewLavoro";
            this._dataGridViewLavoro.Size = new System.Drawing.Size(348, 192);
            this._dataGridViewLavoro.TabIndex = 2;
            // 
            // _dataGridViewSettori
            // 
            this._dataGridViewSettori.AutoGenerateColumns = false;
            this._dataGridViewSettori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSettori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.capienzaDataGridViewTextBoxColumn,
            this.disattivatoDataGridViewCheckBoxColumn});
            this._dataGridViewSettori.DataSource = this._bindingSourceSettori;
            this._dataGridViewSettori.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewSettori.Enabled = false;
            this._dataGridViewSettori.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewSettori.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewSettori.Name = "_dataGridViewSettori";
            this._dataGridViewSettori.Size = new System.Drawing.Size(589, 192);
            this._dataGridViewSettori.TabIndex = 3;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataInizioDataGridViewTextBoxColumn
            // 
            this.dataInizioDataGridViewTextBoxColumn.DataPropertyName = "DataInizio";
            this.dataInizioDataGridViewTextBoxColumn.HeaderText = "Data di Inizio";
            this.dataInizioDataGridViewTextBoxColumn.Name = "dataInizioDataGridViewTextBoxColumn";
            // 
            // dataFineDataGridViewTextBoxColumn
            // 
            this.dataFineDataGridViewTextBoxColumn.DataPropertyName = "DataFine";
            this.dataFineDataGridViewTextBoxColumn.HeaderText = "Data di Fine";
            this.dataFineDataGridViewTextBoxColumn.Name = "dataFineDataGridViewTextBoxColumn";
            // 
            // gradoRischioDataGridViewTextBoxColumn
            // 
            this.gradoRischioDataGridViewTextBoxColumn.DataPropertyName = "GradoRischio";
            this.gradoRischioDataGridViewTextBoxColumn.HeaderText = "Grado di Rischio";
            this.gradoRischioDataGridViewTextBoxColumn.Name = "gradoRischioDataGridViewTextBoxColumn";
            this.gradoRischioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "Durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "Durata";
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            this.durataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _bindingSourceEvento
            // 
            this._bindingSourceEvento.DataSource = typeof(POSsys.Model.Evento);
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInizioDataGridViewTextBoxColumn1
            // 
            this.dataInizioDataGridViewTextBoxColumn1.DataPropertyName = "DataInizio";
            this.dataInizioDataGridViewTextBoxColumn1.HeaderText = "Data di Inizio";
            this.dataInizioDataGridViewTextBoxColumn1.Name = "dataInizioDataGridViewTextBoxColumn1";
            this.dataInizioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataFineDataGridViewTextBoxColumn1
            // 
            this.dataFineDataGridViewTextBoxColumn1.DataPropertyName = "DataFine";
            this.dataFineDataGridViewTextBoxColumn1.HeaderText = "Data di Fine";
            this.dataFineDataGridViewTextBoxColumn1.Name = "dataFineDataGridViewTextBoxColumn1";
            this.dataFineDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _bindingSourceLavoro
            // 
            this._bindingSourceLavoro.DataSource = typeof(POSsys.Model.Lavoro);
            // 
            // _bindingSourceSettori
            // 
            this._bindingSourceSettori.DataSource = typeof(POSsys.Model.Settore);
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // capienzaDataGridViewTextBoxColumn
            // 
            this.capienzaDataGridViewTextBoxColumn.DataPropertyName = "Capienza";
            this.capienzaDataGridViewTextBoxColumn.HeaderText = "Capienza";
            this.capienzaDataGridViewTextBoxColumn.Name = "capienzaDataGridViewTextBoxColumn";
            // 
            // disattivatoDataGridViewCheckBoxColumn
            // 
            this.disattivatoDataGridViewCheckBoxColumn.DataPropertyName = "Disattivato";
            this.disattivatoDataGridViewCheckBoxColumn.HeaderText = "Disattivato";
            this.disattivatoDataGridViewCheckBoxColumn.Name = "disattivatoDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 402);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "POSsys";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEventi)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewLavoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSettori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceLavoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceSettori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestioneEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaNuovoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneImpiantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaNuovoSettoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaSettoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pianificaLavoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionePersonaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciNuovoAddettoAllaSicurezzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaDatiAddettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disattivaAddettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaSettoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcolaCompensiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.DataGridView _dataGridViewEventi;
        private System.Windows.Forms.ToolStripMenuItem RetribuzioniMansioniToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoRischioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource _bindingSourceEvento;
        private System.Windows.Forms.BindingSource _bindingSourceLavoro;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView _dataGridViewLavoro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView _dataGridViewSettori;
        private System.Windows.Forms.BindingSource _bindingSourceSettori;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capienzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disattivatoDataGridViewCheckBoxColumn;
    }
}