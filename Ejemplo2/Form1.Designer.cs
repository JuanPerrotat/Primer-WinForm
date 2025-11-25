namespace Ejemplo2
{
    partial class PerfilPersona
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
            this.components = new System.ComponentModel.Container();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtnWizard = new System.Windows.Forms.RadioButton();
            this.rbtnElf = new System.Windows.Forms.RadioButton();
            this.rbtnDworf = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.numBichos = new System.Windows.Forms.NumericUpDown();
            this.lblBichos = new System.Windows.Forms.Label();
            this.gbClase = new System.Windows.Forms.GroupBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBichos)).BeginInit();
            this.gbClase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(62, 340);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(422, 178);
            this.lwElementos.TabIndex = 0;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(63, 528);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(234, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(59, 108);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(234, 108);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(250, 23);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // checkChocolate
            // 
            this.checkChocolate.AutoSize = true;
            this.checkChocolate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChocolate.Location = new System.Drawing.Point(234, 147);
            this.checkChocolate.Name = "checkChocolate";
            this.checkChocolate.Size = new System.Drawing.Size(148, 20);
            this.checkChocolate.TabIndex = 3;
            this.checkChocolate.Text = "¿Te gusta el chocolate?";
            this.checkChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(59, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(116, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbtnWizard
            // 
            this.rbtnWizard.AutoSize = true;
            this.rbtnWizard.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWizard.Location = new System.Drawing.Point(6, 29);
            this.rbtnWizard.Name = "rbtnWizard";
            this.rbtnWizard.Size = new System.Drawing.Size(61, 20);
            this.rbtnWizard.TabIndex = 0;
            this.rbtnWizard.TabStop = true;
            this.rbtnWizard.Text = "Wizard";
            this.rbtnWizard.UseVisualStyleBackColor = true;
            // 
            // rbtnElf
            // 
            this.rbtnElf.AutoSize = true;
            this.rbtnElf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnElf.Location = new System.Drawing.Point(348, 29);
            this.rbtnElf.Name = "rbtnElf";
            this.rbtnElf.Size = new System.Drawing.Size(38, 20);
            this.rbtnElf.TabIndex = 1;
            this.rbtnElf.TabStop = true;
            this.rbtnElf.Text = "Elf";
            this.rbtnElf.UseVisualStyleBackColor = true;
            // 
            // rbtnDworf
            // 
            this.rbtnDworf.AutoSize = true;
            this.rbtnDworf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDworf.Location = new System.Drawing.Point(177, 29);
            this.rbtnDworf.Name = "rbtnDworf";
            this.rbtnDworf.Size = new System.Drawing.Size(57, 20);
            this.rbtnDworf.TabIndex = 2;
            this.rbtnDworf.TabStop = true;
            this.rbtnDworf.Text = "Dworf";
            this.rbtnDworf.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            this.cmbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Verde",
            "Azul",
            "Rojo",
            "Violeta",
            "Negro",
            "Blanco"});
            this.cmbColor.Location = new System.Drawing.Point(160, 250);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(324, 21);
            this.cmbColor.TabIndex = 5;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.SystemColors.Control;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(60, 252);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(83, 16);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color favorito:";
            // 
            // numBichos
            // 
            this.numBichos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBichos.Location = new System.Drawing.Point(160, 294);
            this.numBichos.Name = "numBichos";
            this.numBichos.Size = new System.Drawing.Size(324, 20);
            this.numBichos.TabIndex = 6;
            // 
            // lblBichos
            // 
            this.lblBichos.AutoSize = true;
            this.lblBichos.BackColor = System.Drawing.SystemColors.Control;
            this.lblBichos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBichos.Location = new System.Drawing.Point(60, 295);
            this.lblBichos.Name = "lblBichos";
            this.lblBichos.Size = new System.Drawing.Size(94, 16);
            this.lblBichos.TabIndex = 14;
            this.lblBichos.Text = "Bichos matados:";
            // 
            // gbClase
            // 
            this.gbClase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbClase.Controls.Add(this.rbtnDworf);
            this.gbClase.Controls.Add(this.rbtnElf);
            this.gbClase.Controls.Add(this.rbtnWizard);
            this.gbClase.Location = new System.Drawing.Point(42, 172);
            this.gbClase.Name = "gbClase";
            this.gbClase.Size = new System.Drawing.Size(452, 64);
            this.gbClase.TabIndex = 4;
            this.gbClase.TabStop = false;
            this.gbClase.Text = "Clase";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(409, 528);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 7;
            this.btnPerfil.Text = "Ver &perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // PerfilPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.gbClase);
            this.Controls.Add(this.lblBichos);
            this.Controls.Add(this.numBichos);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.checkChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lwElementos);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 602);
            this.Name = "PerfilPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil de la Persona";
            ((System.ComponentModel.ISupportInitialize)(this.numBichos)).EndInit();
            this.gbClase.ResumeLayout(false);
            this.gbClase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox checkChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtnWizard;
        private System.Windows.Forms.RadioButton rbtnElf;
        private System.Windows.Forms.RadioButton rbtnDworf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numBichos;
        private System.Windows.Forms.Label lblBichos;
        private System.Windows.Forms.GroupBox gbClase;
        private System.Windows.Forms.Button btnPerfil;
    }
}

