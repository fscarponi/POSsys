namespace POSsys.View
{
    partial class SelezionaAddetti
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
            this.buttonAssegnaAddeto = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.listBoxAddettidisponibili = new System.Windows.Forms.ListBox();
            this.comboBoxIncarico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAssegnaAddeto
            // 
            this.buttonAssegnaAddeto.Location = new System.Drawing.Point(468, 4);
            this.buttonAssegnaAddeto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAssegnaAddeto.Name = "buttonAssegnaAddeto";
            this.buttonAssegnaAddeto.Size = new System.Drawing.Size(100, 28);
            this.buttonAssegnaAddeto.TabIndex = 24;
            this.buttonAssegnaAddeto.Text = "Aggiungi";
            this.buttonAssegnaAddeto.UseVisualStyleBackColor = true;
            this.buttonAssegnaAddeto.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(576, 4);
            this.buttonAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this.buttonAnnulla.TabIndex = 23;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // listBoxAddettidisponibili
            // 
            this.listBoxAddettidisponibili.FormattingEnabled = true;
            this.listBoxAddettidisponibili.ItemHeight = 16;
            this.listBoxAddettidisponibili.Location = new System.Drawing.Point(273, 39);
            this.listBoxAddettidisponibili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAddettidisponibili.Name = "listBoxAddettidisponibili";
            this.listBoxAddettidisponibili.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAddettidisponibili.Size = new System.Drawing.Size(368, 244);
            this.listBoxAddettidisponibili.TabIndex = 26;
            // 
            // comboBoxIncarico
            // 
            this.comboBoxIncarico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncarico.FormattingEnabled = true;
            this.comboBoxIncarico.Location = new System.Drawing.Point(19, 60);
            this.comboBoxIncarico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIncarico.Name = "comboBoxIncarico";
            this.comboBoxIncarico.Size = new System.Drawing.Size(205, 24);
            this.comboBoxIncarico.TabIndex = 28;
            this.comboBoxIncarico.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncarico_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Specifica incarico";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAssegnaAddeto);
            this.panel1.Controls.Add(this.buttonAnnulla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 42);
            this.panel1.TabIndex = 30;
            // 
            // SelezionaAddetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 337);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIncarico);
            this.Controls.Add(this.listBoxAddettidisponibili);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelezionaAddetti";
            this.Text = "Seleziona Addetti Da Impiegare Alla Mansione";
            this.Load += new System.EventHandler(this.SelezionaAddetti_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAssegnaAddeto;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.ListBox listBoxAddettidisponibili;
        private System.Windows.Forms.ComboBox comboBoxIncarico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}