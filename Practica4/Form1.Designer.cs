namespace Practica4
{
    partial class frmPractica4
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
            this.rtxtbTexto = new System.Windows.Forms.RichTextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnMuestra = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtbTexto
            // 
            this.rtxtbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbTexto.Location = new System.Drawing.Point(230, 62);
            this.rtxtbTexto.Name = "rtxtbTexto";
            this.rtxtbTexto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtbTexto.Size = new System.Drawing.Size(345, 135);
            this.rtxtbTexto.TabIndex = 0;
            this.rtxtbTexto.Text = "";
            this.rtxtbTexto.TextChanged += new System.EventHandler(this.rtxtbTexto_TextChanged);
            this.rtxtbTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtbTexto_KeyPress);
            this.rtxtbTexto.Leave += new System.EventHandler(this.rtxtbTexto_Leave);
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(52, 115);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(136, 21);
            this.lblIngreso.TabIndex = 1;
            this.lblIngreso.Text = "Texto a ingresar:";
            // 
            // btnMuestra
            // 
            this.btnMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuestra.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMuestra.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuestra.Location = new System.Drawing.Point(321, 272);
            this.btnMuestra.Name = "btnMuestra";
            this.btnMuestra.Size = new System.Drawing.Size(152, 23);
            this.btnMuestra.TabIndex = 2;
            this.btnMuestra.Text = "Mostrar texto ingresado";
            this.btnMuestra.UseVisualStyleBackColor = true;
            this.btnMuestra.Click += new System.EventHandler(this.btnMuestra_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(230, 203);
            this.textBox1.MaxLength = 8;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 23);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Formulario de práctica";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPractica4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMuestra);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.rtxtbTexto);
            this.MinimumSize = new System.Drawing.Size(816, 450);
            this.Name = "frmPractica4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica 4";
            this.Load += new System.EventHandler(this.frmPractica4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbTexto;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnMuestra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitulo;
    }
}

