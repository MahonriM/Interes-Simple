namespace WindowsFormsApp2
{
    partial class tiempo
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
            this.txttasainteres = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cmbtasa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txttasainteres
            // 
            this.txttasainteres.Location = new System.Drawing.Point(122, 82);
            this.txttasainteres.Name = "txttasainteres";
            this.txttasainteres.Size = new System.Drawing.Size(100, 20);
            this.txttasainteres.TabIndex = 16;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(122, 49);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 14;
            // 
            // txtcapital
            // 
            this.txtcapital.Location = new System.Drawing.Point(122, 20);
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.Size = new System.Drawing.Size(100, 20);
            this.txtcapital.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "tasa de interes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Capital";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(147, 144);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 17;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cmbtasa
            // 
            this.cmbtasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtasa.FormattingEnabled = true;
            this.cmbtasa.Location = new System.Drawing.Point(228, 82);
            this.cmbtasa.Name = "cmbtasa";
            this.cmbtasa.Size = new System.Drawing.Size(121, 21);
            this.cmbtasa.TabIndex = 18;
            // 
            // tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 254);
            this.Controls.Add(this.cmbtasa);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttasainteres);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtcapital);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tiempo";
            this.Text = "tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttasainteres;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cmbtasa;
    }
}