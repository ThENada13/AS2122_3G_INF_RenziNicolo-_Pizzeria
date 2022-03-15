
namespace AS2122_3G_INF_RenziNicolo__Pizzeria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarica = new System.Windows.Forms.Button();
            this.cmbTipoPizze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNMarghe = new System.Windows.Forms.Label();
            this.lblVege = new System.Windows.Forms.Label();
            this.lbl4Stag = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstOrdini = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(251, 57);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(63, 23);
            this.btnCarica.TabIndex = 0;
            this.btnCarica.Text = "carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // cmbTipoPizze
            // 
            this.cmbTipoPizze.FormattingEnabled = true;
            this.cmbTipoPizze.Items.AddRange(new object[] {
            "Margherita",
            "Vegetariana",
            "4 Stagioni"});
            this.cmbTipoPizze.Location = new System.Drawing.Point(33, 57);
            this.cmbTipoPizze.Name = "cmbTipoPizze";
            this.cmbTipoPizze.Size = new System.Drawing.Size(196, 23);
            this.cmbTipoPizze.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Margherite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vegetariane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "4 Stagioni";
            // 
            // lblNMarghe
            // 
            this.lblNMarghe.AutoSize = true;
            this.lblNMarghe.Location = new System.Drawing.Point(618, 264);
            this.lblNMarghe.Name = "lblNMarghe";
            this.lblNMarghe.Size = new System.Drawing.Size(0, 15);
            this.lblNMarghe.TabIndex = 5;
            // 
            // lblVege
            // 
            this.lblVege.AutoSize = true;
            this.lblVege.Location = new System.Drawing.Point(618, 308);
            this.lblVege.Name = "lblVege";
            this.lblVege.Size = new System.Drawing.Size(0, 15);
            this.lblVege.TabIndex = 6;
            // 
            // lbl4Stag
            // 
            this.lbl4Stag.AutoSize = true;
            this.lbl4Stag.Location = new System.Drawing.Point(618, 364);
            this.lbl4Stag.Name = "lbl4Stag";
            this.lbl4Stag.Size = new System.Drawing.Size(0, 15);
            this.lbl4Stag.TabIndex = 7;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(141, 109);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(88, 23);
            this.txtQuantita.TabIndex = 8;
            this.txtQuantita.TextChanged += new System.EventHandler(this.txtQuantita_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantità";
            // 
            // lstOrdini
            // 
            this.lstOrdini.FormattingEnabled = true;
            this.lstOrdini.ItemHeight = 15;
            this.lstOrdini.Location = new System.Drawing.Point(398, 57);
            this.lstOrdini.Name = "lstOrdini";
            this.lstOrdini.Size = new System.Drawing.Size(258, 154);
            this.lstOrdini.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOrdini);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.lbl4Stag);
            this.Controls.Add(this.lblVege);
            this.Controls.Add(this.lblNMarghe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoPizze);
            this.Controls.Add(this.btnCarica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.ComboBox cmbTipoPizze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNMarghe;
        private System.Windows.Forms.Label lblVege;
        private System.Windows.Forms.Label lbl4Stag;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstOrdini;
    }
}

