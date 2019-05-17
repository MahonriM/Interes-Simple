namespace WindowsFormsApp2
{
    partial class Monto
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
            this.txttasainteres = new System.Windows.Forms.TextBox();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(81, 171);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(118, 23);
            this.btncalcular.TabIndex = 32;
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
            this.cmbtiempo.Location = new System.Drawing.Point(214, 114);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(121, 21);
            this.cmbtiempo.TabIndex = 31;
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
            this.cmbtasa.Location = new System.Drawing.Point(214, 80);
            this.cmbtasa.Name = "cmbtasa";
            this.cmbtasa.Size = new System.Drawing.Size(121, 21);
            this.cmbtasa.TabIndex = 30;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(99, 114);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 29;
            // 
            // txttasainteres
            // 
            this.txttasainteres.Location = new System.Drawing.Point(99, 81);
            this.txttasainteres.Name = "txttasainteres";
            this.txttasainteres.Size = new System.Drawing.Size(100, 20);
            this.txttasainteres.TabIndex = 28;
            // 
            // txtcapital
            // 
            this.txtcapital.Location = new System.Drawing.Point(99, 41);
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.Size = new System.Drawing.Size(100, 20);
            this.txtcapital.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "tasa de interes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Capital";
            // 
            // Monto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 234);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.cmbtasa);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txttasainteres);
            this.Controls.Add(this.txtcapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Monto";
            this.Text = "Monto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cmbtiempo;
        private System.Windows.Forms.ComboBox cmbtasa;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txttasainteres;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}