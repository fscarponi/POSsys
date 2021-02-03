namespace POSsys.View
{
    partial class ModificaSettore
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
            this._labelSelezioneSettore = new System.Windows.Forms.Label();
            this._comboBoxModificaSettore = new System.Windows.Forms.ComboBox();
            this._buttonSalva = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this._labelSettoreSelezionato = new System.Windows.Forms.Label();
            this._labelNomeSettoreSelezionato = new System.Windows.Forms.Label();
            this._labelCapienzaSettoreSelezionato = new System.Windows.Forms.Label();
            this._textBoxModificaNome = new System.Windows.Forms.TextBox();
            this._textBoxModificaCapienza = new System.Windows.Forms.TextBox();
            this._buttonModificaNome = new System.Windows.Forms.Button();
            this._buttonModificaCapienza = new System.Windows.Forms.Button();
            this.panelModificaSettore = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelModificaSettore.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelSelezioneSettore
            // 
            this._labelSelezioneSettore.AutoSize = true;
            this._labelSelezioneSettore.Location = new System.Drawing.Point(22, 22);
            this._labelSelezioneSettore.Name = "_labelSelezioneSettore";
            this._labelSelezioneSettore.Size = new System.Drawing.Size(201, 13);
            this._labelSelezioneSettore.TabIndex = 0;
            this._labelSelezioneSettore.Text = "Seleziona il settore che intendi modificare";
            // 
            // _comboBoxModificaSettore
            // 
            this._comboBoxModificaSettore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxModificaSettore.FormattingEnabled = true;
            this._comboBoxModificaSettore.Location = new System.Drawing.Point(25, 38);
            this._comboBoxModificaSettore.Name = "_comboBoxModificaSettore";
            this._comboBoxModificaSettore.Size = new System.Drawing.Size(198, 21);
            this._comboBoxModificaSettore.TabIndex = 1;
            this._comboBoxModificaSettore.SelectedValueChanged += new System.EventHandler(this.comboBoxSettore_SelectedValueChanged);
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(355, 14);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(75, 23);
            this._buttonSalva.TabIndex = 24;
            this._buttonSalva.Text = "Salva";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAnnulla.Location = new System.Drawing.Point(436, 14);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this._buttonAnnulla.TabIndex = 23;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // _labelSettoreSelezionato
            // 
            this._labelSettoreSelezionato.AutoSize = true;
            this._labelSettoreSelezionato.Location = new System.Drawing.Point(11, 6);
            this._labelSettoreSelezionato.Name = "_labelSettoreSelezionato";
            this._labelSettoreSelezionato.Size = new System.Drawing.Size(50, 13);
            this._labelSettoreSelezionato.TabIndex = 26;
            this._labelSettoreSelezionato.Text = "Il settore ";
            // 
            // _labelNomeSettoreSelezionato
            // 
            this._labelNomeSettoreSelezionato.AutoSize = true;
            this._labelNomeSettoreSelezionato.Location = new System.Drawing.Point(11, 46);
            this._labelNomeSettoreSelezionato.Name = "_labelNomeSettoreSelezionato";
            this._labelNomeSettoreSelezionato.Size = new System.Drawing.Size(70, 13);
            this._labelNomeSettoreSelezionato.TabIndex = 27;
            this._labelNomeSettoreSelezionato.Text = "Nome settore";
            // 
            // _labelCapienzaSettoreSelezionato
            // 
            this._labelCapienzaSettoreSelezionato.AutoSize = true;
            this._labelCapienzaSettoreSelezionato.Location = new System.Drawing.Point(11, 80);
            this._labelCapienzaSettoreSelezionato.Name = "_labelCapienzaSettoreSelezionato";
            this._labelCapienzaSettoreSelezionato.Size = new System.Drawing.Size(88, 13);
            this._labelCapienzaSettoreSelezionato.TabIndex = 28;
            this._labelCapienzaSettoreSelezionato.Text = "Capienza Settore";
            // 
            // _textBoxModificaNome
            // 
            this._textBoxModificaNome.Enabled = false;
            this._textBoxModificaNome.Location = new System.Drawing.Point(105, 46);
            this._textBoxModificaNome.Name = "_textBoxModificaNome";
            this._textBoxModificaNome.Size = new System.Drawing.Size(100, 20);
            this._textBoxModificaNome.TabIndex = 29;
            // 
            // _textBoxModificaCapienza
            // 
            this._textBoxModificaCapienza.Enabled = false;
            this._textBoxModificaCapienza.Location = new System.Drawing.Point(105, 77);
            this._textBoxModificaCapienza.Name = "_textBoxModificaCapienza";
            this._textBoxModificaCapienza.Size = new System.Drawing.Size(100, 20);
            this._textBoxModificaCapienza.TabIndex = 30;
            // 
            // _buttonModificaNome
            // 
            this._buttonModificaNome.Location = new System.Drawing.Point(222, 46);
            this._buttonModificaNome.Name = "_buttonModificaNome";
            this._buttonModificaNome.Size = new System.Drawing.Size(125, 23);
            this._buttonModificaNome.TabIndex = 31;
            this._buttonModificaNome.Text = "Modifica Nome";
            this._buttonModificaNome.UseVisualStyleBackColor = true;
            this._buttonModificaNome.Click += new System.EventHandler(this.buttonAbilitaModificaNome_Click);
            // 
            // _buttonModificaCapienza
            // 
            this._buttonModificaCapienza.Location = new System.Drawing.Point(222, 77);
            this._buttonModificaCapienza.Name = "_buttonModificaCapienza";
            this._buttonModificaCapienza.Size = new System.Drawing.Size(125, 23);
            this._buttonModificaCapienza.TabIndex = 32;
            this._buttonModificaCapienza.Text = "Modifica Capienza";
            this._buttonModificaCapienza.UseVisualStyleBackColor = true;
            this._buttonModificaCapienza.Click += new System.EventHandler(this.buttonAbilitaModificaCapienza_Click);
            // 
            // panelModificaSettore
            // 
            this.panelModificaSettore.Controls.Add(this._buttonModificaCapienza);
            this.panelModificaSettore.Controls.Add(this._buttonModificaNome);
            this.panelModificaSettore.Controls.Add(this._textBoxModificaCapienza);
            this.panelModificaSettore.Controls.Add(this._textBoxModificaNome);
            this.panelModificaSettore.Controls.Add(this._labelCapienzaSettoreSelezionato);
            this.panelModificaSettore.Controls.Add(this._labelNomeSettoreSelezionato);
            this.panelModificaSettore.Controls.Add(this._labelSettoreSelezionato);
            this.panelModificaSettore.Location = new System.Drawing.Point(21, 74);
            this.panelModificaSettore.Name = "panelModificaSettore";
            this.panelModificaSettore.Size = new System.Drawing.Size(362, 128);
            this.panelModificaSettore.TabIndex = 35;
            this.panelModificaSettore.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._buttonAnnulla);
            this.panel1.Controls.Add(this._buttonSalva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 49);
            this.panel1.TabIndex = 36;
            // 
            // ModificaSettore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 312);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelModificaSettore);
            this.Controls.Add(this._comboBoxModificaSettore);
            this.Controls.Add(this._labelSelezioneSettore);
            this.Name = "ModificaSettore";
            this.Text = "Modifica Settore";
            this.Load += new System.EventHandler(this.ModificaSettore_Load);
            this.panelModificaSettore.ResumeLayout(false);
            this.panelModificaSettore.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelSelezioneSettore;
        private System.Windows.Forms.ComboBox _comboBoxModificaSettore;
        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.Label _labelSettoreSelezionato;
        private System.Windows.Forms.Label _labelNomeSettoreSelezionato;
        private System.Windows.Forms.Label _labelCapienzaSettoreSelezionato;
        private System.Windows.Forms.TextBox _textBoxModificaNome;
        private System.Windows.Forms.TextBox _textBoxModificaCapienza;
        private System.Windows.Forms.Button _buttonModificaNome;
        private System.Windows.Forms.Button _buttonModificaCapienza;
        private System.Windows.Forms.Panel panelModificaSettore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}