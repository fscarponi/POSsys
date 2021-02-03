namespace POSsys.View
{
    partial class EliminaSettore
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
            this._buttonSalva = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this._comboBoxEliminaSettore = new System.Windows.Forms.ComboBox();
            this._labelEliminaSettore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSalva.Location = new System.Drawing.Point(225, 11);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(75, 23);
            this._buttonSalva.TabIndex = 28;
            this._buttonSalva.Text = "Salva";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAnnulla.Location = new System.Drawing.Point(306, 11);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this._buttonAnnulla.TabIndex = 27;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // _comboBoxEliminaSettore
            // 
            this._comboBoxEliminaSettore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxEliminaSettore.FormattingEnabled = true;
            this._comboBoxEliminaSettore.Location = new System.Drawing.Point(88, 60);
            this._comboBoxEliminaSettore.Name = "_comboBoxEliminaSettore";
            this._comboBoxEliminaSettore.Size = new System.Drawing.Size(151, 21);
            this._comboBoxEliminaSettore.TabIndex = 26;
            // 
            // _labelEliminaSettore
            // 
            this._labelEliminaSettore.AutoSize = true;
            this._labelEliminaSettore.Location = new System.Drawing.Point(85, 33);
            this._labelEliminaSettore.Name = "_labelEliminaSettore";
            this._labelEliminaSettore.Size = new System.Drawing.Size(157, 13);
            this._labelEliminaSettore.TabIndex = 25;
            this._labelEliminaSettore.Text = "Seleziona il settore da eliminare:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._buttonAnnulla);
            this.panel1.Controls.Add(this._buttonSalva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 46);
            this.panel1.TabIndex = 29;
            // 
            // EliminaSettore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 209);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._comboBoxEliminaSettore);
            this.Controls.Add(this._labelEliminaSettore);
            this.Name = "EliminaSettore";
            this.Text = "Elimina Settore";
            this.Load += new System.EventHandler(this.EliminaSettore_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonSalva;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.ComboBox _comboBoxEliminaSettore;
        private System.Windows.Forms.Label _labelEliminaSettore;
        private System.Windows.Forms.Panel panel1;
    }
}