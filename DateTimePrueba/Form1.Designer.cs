namespace DateTimePrueba
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnDtp = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(45, 113);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(248, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnDtp
            // 
            this.btnDtp.Location = new System.Drawing.Point(315, 110);
            this.btnDtp.Name = "btnDtp";
            this.btnDtp.Size = new System.Drawing.Size(75, 23);
            this.btnDtp.TabIndex = 2;
            this.btnDtp.Text = "Prueba 1";
            this.btnDtp.UseVisualStyleBackColor = true;
            this.btnDtp.Click += new System.EventHandler(this.btnDtp_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(315, 178);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Prueba 2";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(45, 178);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnDtp);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.calFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnDtp;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.MonthCalendar calFecha;
    }
}

