namespace WindowsFormsApp2
{
    partial class Interes
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
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txttasainteres = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbtiempo = new System.Windows.Forms.ComboBox();
            this.cmbtasa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(134, 130);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 22;
            // 
            // txttasainteres
            // 
            this.txttasainteres.Location = new System.Drawing.Point(134, 97);
            this.txttasainteres.Name = "txttasainteres";
            this.txttasainteres.Size = new System.Drawing.Size(100, 20);
            this.txttasainteres.TabIndex = 21;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(134, 60);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 19;
            // 
            // txtcapital
            // 
            this.txtcapital.Location = new System.Drawing.Point(134, 31);
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.Size = new System.Drawing.Size(100, 20);
            this.txtcapital.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "tasa de interes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Capital";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(392, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conozco";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tasa de interes y tiempo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monto";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cmbtiempo.Location = new System.Drawing.Point(240, 134);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(121, 21);
            this.cmbtiempo.TabIndex = 33;
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
            this.cmbtasa.Location = new System.Drawing.Point(240, 100);
            this.cmbtasa.Name = "cmbtasa";
            this.cmbtasa.Size = new System.Drawing.Size(121, 21);
            this.cmbtasa.TabIndex = 32;
            // 
            // Interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 269);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.cmbtasa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txttasainteres);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtcapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Interes";
            this.Text = "Interes";
            this.Load += new System.EventHandler(this.Interes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txttasainteres;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbtiempo;
        private System.Windows.Forms.ComboBox cmbtasa;
    }
}