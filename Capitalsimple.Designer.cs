namespace WindowsFormsApp2
{
    partial class Capitalsimple
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
            this.cmbtiempo = new System.Windows.Forms.ComboBox();
            this.cmbtasa = new System.Windows.Forms.ComboBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txttasainteres = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cmbtiempo.Location = new System.Drawing.Point(372, 148);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(121, 21);
            this.cmbtiempo.TabIndex = 22;
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
            this.cmbtasa.Location = new System.Drawing.Point(372, 114);
            this.cmbtasa.Name = "cmbtasa";
            this.cmbtasa.Size = new System.Drawing.Size(121, 21);
            this.cmbtasa.TabIndex = 21;
            this.cmbtasa.SelectedIndexChanged += new System.EventHandler(this.cmbtasa_SelectedIndexChanged);
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(257, 148);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 20;
            // 
            // txttasainteres
            // 
            this.txttasainteres.Location = new System.Drawing.Point(257, 115);
            this.txttasainteres.Name = "txttasainteres";
            this.txttasainteres.Size = new System.Drawing.Size(100, 20);
            this.txttasainteres.TabIndex = 19;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(257, 75);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "tasa de interes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monto";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(239, 205);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(118, 23);
            this.btncalcular.TabIndex = 23;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Capitalsimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 376);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.cmbtasa);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txttasainteres);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Capitalsimple";
            this.Text = "Capital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbtiempo;
        private System.Windows.Forms.ComboBox cmbtasa;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txttasainteres;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalcular;
    }
}