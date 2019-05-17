namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncapital = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btninteres = new System.Windows.Forms.Button();
            this.btntiempo = new System.Windows.Forms.Button();
            this.btnmonto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncapital
            // 
            this.btncapital.Location = new System.Drawing.Point(107, 47);
            this.btncapital.Name = "btncapital";
            this.btncapital.Size = new System.Drawing.Size(128, 23);
            this.btncapital.TabIndex = 11;
            this.btncapital.Text = "Capital";
            this.btncapital.UseVisualStyleBackColor = true;
            this.btncapital.Click += new System.EventHandler(this.btncapital_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tasa de Interes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninteres
            // 
            this.btninteres.Location = new System.Drawing.Point(107, 150);
            this.btninteres.Name = "btninteres";
            this.btninteres.Size = new System.Drawing.Size(128, 23);
            this.btninteres.TabIndex = 14;
            this.btninteres.Text = "Interes";
            this.btninteres.UseVisualStyleBackColor = true;
            this.btninteres.Click += new System.EventHandler(this.btninteres_Click);
            // 
            // btntiempo
            // 
            this.btntiempo.Location = new System.Drawing.Point(107, 112);
            this.btntiempo.Name = "btntiempo";
            this.btntiempo.Size = new System.Drawing.Size(128, 23);
            this.btntiempo.TabIndex = 15;
            this.btntiempo.Text = "Tiempo";
            this.btntiempo.UseVisualStyleBackColor = true;
            this.btntiempo.Click += new System.EventHandler(this.btntiempo_Click);
            // 
            // btnmonto
            // 
            this.btnmonto.Location = new System.Drawing.Point(107, 80);
            this.btnmonto.Name = "btnmonto";
            this.btnmonto.Size = new System.Drawing.Size(128, 23);
            this.btnmonto.TabIndex = 16;
            this.btnmonto.Text = "Monto";
            this.btnmonto.UseVisualStyleBackColor = true;
            this.btnmonto.Click += new System.EventHandler(this.btnmonto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu de Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(352, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmonto);
            this.Controls.Add(this.btntiempo);
            this.Controls.Add(this.btninteres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncapital);
            this.Name = "Form1";
            this.Text = "Interes Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncapital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btninteres;
        private System.Windows.Forms.Button btntiempo;
        private System.Windows.Forms.Button btnmonto;
        private System.Windows.Forms.Label label1;
    }
}

