namespace POSsys.View
{
    partial class CalcolaCompensi
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.dateTimePickerDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(246, 12);
            this.buttonSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(100, 28);
            this.buttonSalva.TabIndex = 24;
            this.buttonSalva.Text = "Calcola";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(354, 12);
            this.buttonAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this.buttonAnnulla.TabIndex = 23;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // dateTimePickerDataPagamento
            // 
            this.dateTimePickerDataPagamento.Location = new System.Drawing.Point(173, 33);
            this.dateTimePickerDataPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDataPagamento.Name = "dateTimePickerDataPagamento";
            this.dateTimePickerDataPagamento.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDataPagamento.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "Inserisci una data\r\ndi termine conteggio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalva);
            this.panel1.Controls.Add(this.buttonAnnulla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 53);
            this.panel1.TabIndex = 28;
            // 
            // CalcolaCompensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 145);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDataPagamento);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalcolaCompensi";
            this.Text = "Inserisci Data di termine conteggio";
            this.Load += new System.EventHandler(this.CalcolaCompensi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}