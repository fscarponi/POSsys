namespace POSsys.View
{
    partial class AnnullaEvento
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
            this._labelSelezionaEvento = new System.Windows.Forms.Label();
            this._comboBoxEventoDaAnnullare = new System.Windows.Forms.ComboBox();
            this._buttonSalva = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelSelezionaEvento
            // 
            this._labelSelezionaEvento.AutoSize = true;
            this._labelSelezionaEvento.Location = new System.Drawing.Point(109, 38);
            this._labelSelezionaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelSelezionaEvento.Name = "_labelSelezionaEvento";
            this._labelSelezionaEvento.Size = new System.Drawing.Size(206, 17);
            this._labelSelezionaEvento.TabIndex = 0;
            this._labelSelezionaEvento.Text = "Seleziona l\'evento da annullare";
            // 
            // _comboBoxEventoDaAnnullare
            // 
            this._comboBoxEventoDaAnnullare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxEventoDaAnnullare.FormattingEnabled = true;
            this._comboBoxEventoDaAnnullare.Location = new System.Drawing.Point(113, 71);
            this._comboBoxEventoDaAnnullare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxEventoDaAnnullare.Name = "_comboBoxEventoDaAnnullare";
            this._comboBoxEventoDaAnnullare.Size = new System.Drawing.Size(200, 24);
            this._comboBoxEventoDaAnnullare.TabIndex = 1;
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(288, 12);
            this._buttonSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(100, 28);
            this._buttonSalva.TabIndex = 24;
            this._buttonSalva.Text = "Conferma";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAnnulla.Location = new System.Drawing.Point(396, 12);
            this._buttonAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this._buttonAnnulla.TabIndex = 23;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // _panelBottom
            // 
            this._panelBottom.Controls.Add(this._buttonSalva);
            this._panelBottom.Controls.Add(this._buttonAnnulla);
            this._panelBottom.Location = new System.Drawing.Point(0, 172);
            this._panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(512, 57);
            this._panelBottom.TabIndex = 26;
            // 
            // AnnullaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 229);
            this.ControlBox = false;
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._comboBoxEventoDaAnnullare);
            this.Controls.Add(this._labelSelezionaEvento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnnullaEvento";
            this.Text = "Annulla Evento";
            this.Load += new System.EventHandler(this.AnnullaEvento_Load);
            this._panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelSelezionaEvento;
        private System.Windows.Forms.ComboBox _comboBoxEventoDaAnnullare;
        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.Panel _panelBottom;
    }
}