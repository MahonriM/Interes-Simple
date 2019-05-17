namespace WindowsFormsApp2
{
    partial class tasa
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.cmbtiempo = new System.Windows.Forms.ComboBox();
            this.cmbtasa = new System.Windows.Forms.ComboBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(109, 162);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(118, 23);
            this.btncalcular.TabIndex = 30;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cmbtiempo
            // 
            this.cmbtiempo.AutoCompleteCustomSource.AddRange(new string[] {
            "Anual",
            "Mensual",
            "Quincenal",
            "Semestral",
            "Trimestral",
            "Semanal",
            "Bimestral",
            "Trimestral"});
            this.cmbtiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtiempo.FormattingEnabled = true;
            this.cmbtiempo.Items.AddRange(new object[] {
            "Anual",
            "Quincenal",
            "Semestral",
            "Diario",
            "Mensual",
            "Trimestral",
            "Bimestral",
            "Semanal"});
            this.cmbtiempo.Location = new System.Drawing.Point(242, 105);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(121, 21);
            this.cmbtiempo.TabIndex = 29;
            // 
            // cmbtasa
            // 
            this.cmbtasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtasa.FormattingEnabled = true;
            this.cmbtasa.Items.AddRange(new object[] {
            "Anual",
            "Semestral",
            "Quincenal",
            "Diario",
            "Trimestral",
            "Semestral",
            "Bimestral",
            "Mensual"});
            this.cmbtasa.Location = new System.Drawing.Point(242, 140);
            this.cmbtasa.Name = "cmbtasa";
            this.cmbtasa.Size = new System.Drawing.Size(121, 21);
            this.cmbtasa.TabIndex = 28;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(127, 105);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tiempo";
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(127, 39);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(100, 20);
            this.txtinteres.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Interes";
            // 
            // txtcapital
            // 
            this.txtcapital.Location = new System.Drawing.Point(127, 72);
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.Size = new System.Drawing.Size(100, 20);
            this.txtcapital.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "tasa de interes";
            // 
            // tasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtinteres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.cmbtasa);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.label5);
            this.Name = "tasa";
            this.Text = "tasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cmbtiempo;
        private System.Windows.Forms.ComboBox cmbtasa;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}