namespace POSsys.View
{
    partial class CreaNuovoSettore
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
            this._labelNomeSettore = new System.Windows.Forms.Label();
            this._textBoxNomeSettore = new System.Windows.Forms.TextBox();
            this._textBoxCapienzaSettore = new System.Windows.Forms.TextBox();
            this._labelCapienzaSettore = new System.Windows.Forms.Label();
            this._buttonSalva = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelNomeSettore
            // 
            this._labelNomeSettore.AutoSize = true;
            this._labelNomeSettore.Location = new System.Drawing.Point(26, 22);
            this._labelNomeSettore.Name = "_labelNomeSettore";
            this._labelNomeSettore.Size = new System.Drawing.Size(70, 13);
            this._labelNomeSettore.TabIndex = 0;
            this._labelNomeSettore.Text = "Nome settore";
            // 
            // _textBoxNomeSettore
            // 
            this._textBoxNomeSettore.Location = new System.Drawing.Point(29, 38);
            this._textBoxNomeSettore.Name = "_textBoxNomeSettore";
            this._textBoxNomeSettore.Size = new System.Drawing.Size(100, 20);
            this._textBoxNomeSettore.TabIndex = 1;
            // 
            // _textBoxCapienzaSettore
            // 
            this._textBoxCapienzaSettore.Location = new System.Drawing.Point(29, 93);
            this._textBoxCapienzaSettore.Name = "_textBoxCapienzaSettore";
            this._textBoxCapienzaSettore.Size = new System.Drawing.Size(100, 20);
            this._textBoxCapienzaSettore.TabIndex = 3;
            // 
            // _labelCapienzaSettore
            // 
            this._labelCapienzaSettore.AutoSize = true;
            this._labelCapienzaSettore.Location = new System.Drawing.Point(26, 77);
            this._labelCapienzaSettore.Name = "_labelCapienzaSettore";
            this._labelCapienzaSettore.Size = new System.Drawing.Size(86, 13);
            this._labelCapienzaSettore.TabIndex = 2;
            this._labelCapienzaSettore.Text = "Capienza settore";
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(201, 7);
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
            this._buttonAnnulla.Location = new System.Drawing.Point(282, 7);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this._buttonAnnulla.TabIndex = 23;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this._buttonAnnulla);
            this.panelBottom.Controls.Add(this._buttonSalva);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 150);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(369, 42);
            this.panelBottom.TabIndex = 25;
            // 
            // CreaNuovoSettore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 192);
            this.ControlBox = false;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this._textBoxCapienzaSettore);
            this.Controls.Add(this._labelCapienzaSettore);
            this.Controls.Add(this._textBoxNomeSettore);
            this.Controls.Add(this._labelNomeSettore);
            this.Name = "CreaNuovoSettore";
            this.Text = "Crea Nuovo Settore";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelNomeSettore;
        private System.Windows.Forms.TextBox _textBoxNomeSettore;
        private System.Windows.Forms.TextBox _textBoxCapienzaSettore;
        private System.Windows.Forms.Label _labelCapienzaSettore;
        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelBottom;
    }
}