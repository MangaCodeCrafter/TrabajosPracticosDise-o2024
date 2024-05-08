namespace Personas
{
    partial class Personas
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
            this.lLegajo = new System.Windows.Forms.Label();
            this.lCarrera = new System.Windows.Forms.Label();
            this.lFechaIngreso = new System.Windows.Forms.Label();
            this.lFiltro = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.tCarrera = new System.Windows.Forms.TextBox();
            this.mtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNombre = new System.Windows.Forms.Label();
            this.chEstudiante = new System.Windows.Forms.CheckBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.lDocumento = new System.Windows.Forms.Label();
            this.lFechaNac = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.mtDNI = new System.Windows.Forms.MaskedTextBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLegajo
            // 
            this.lLegajo.AutoSize = true;
            this.lLegajo.Location = new System.Drawing.Point(29, 15);
            this.lLegajo.Name = "lLegajo";
            this.lLegajo.Size = new System.Drawing.Size(42, 13);
            this.lLegajo.TabIndex = 4;
            this.lLegajo.Text = "Legajo:";
            // 
            // lCarrera
            // 
            this.lCarrera.AutoSize = true;
            this.lCarrera.Location = new System.Drawing.Point(29, 48);
            this.lCarrera.Name = "lCarrera";
            this.lCarrera.Size = new System.Drawing.Size(44, 13);
            this.lCarrera.TabIndex = 5;
            this.lCarrera.Text = "Carrera:";
            // 
            // lFechaIngreso
            // 
            this.lFechaIngreso.AutoSize = true;
            this.lFechaIngreso.Location = new System.Drawing.Point(5, 83);
            this.lFechaIngreso.Name = "lFechaIngreso";
            this.lFechaIngreso.Size = new System.Drawing.Size(78, 13);
            this.lFechaIngreso.TabIndex = 6;
            this.lFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(3, 20);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(32, 13);
            this.lFiltro.TabIndex = 7;
            this.lFiltro.Text = "Filtro:";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(3, 259);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(52, 13);
            this.lCantidad.TabIndex = 8;
            this.lCantidad.Text = "Cantidad:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(3, 43);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 12;
            // 
            // tCarrera
            // 
            this.tCarrera.Location = new System.Drawing.Point(89, 45);
            this.tCarrera.Name = "tCarrera";
            this.tCarrera.Size = new System.Drawing.Size(100, 20);
            this.tCarrera.TabIndex = 13;
            // 
            // mtLegajo
            // 
            this.mtLegajo.Location = new System.Drawing.Point(89, 8);
            this.mtLegajo.Mask = "000000";
            this.mtLegajo.Name = "mtLegajo";
            this.mtLegajo.Size = new System.Drawing.Size(100, 20);
            this.mtLegajo.TabIndex = 15;
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.Location = new System.Drawing.Point(3, 70);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(120, 186);
            this.lbPersonas.TabIndex = 16;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(89, 83);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(99, 20);
            this.dtIngreso.TabIndex = 19;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(96, 308);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(188, 308);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 21;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(291, 308);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 22;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbPersonas);
            this.panel1.Controls.Add(this.cbFiltro);
            this.panel1.Controls.Add(this.lCantidad);
            this.panel1.Controls.Add(this.lFiltro);
            this.panel1.Location = new System.Drawing.Point(285, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 277);
            this.panel1.TabIndex = 23;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(24, 23);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // chEstudiante
            // 
            this.chEstudiante.AutoSize = true;
            this.chEstudiante.Location = new System.Drawing.Point(84, 129);
            this.chEstudiante.Name = "chEstudiante";
            this.chEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chEstudiante.TabIndex = 17;
            this.chEstudiante.Text = "Estudiante";
            this.chEstudiante.UseVisualStyleBackColor = true;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(24, 46);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(47, 13);
            this.lApellido.TabIndex = 1;
            this.lApellido.Text = "Apellido:";
            // 
            // lDocumento
            // 
            this.lDocumento.AutoSize = true;
            this.lDocumento.Location = new System.Drawing.Point(13, 72);
            this.lDocumento.Name = "lDocumento";
            this.lDocumento.Size = new System.Drawing.Size(65, 13);
            this.lDocumento.TabIndex = 2;
            this.lDocumento.Text = "Documento:";
            // 
            // lFechaNac
            // 
            this.lFechaNac.AutoSize = true;
            this.lFechaNac.Location = new System.Drawing.Point(8, 104);
            this.lFechaNac.Name = "lFechaNac";
            this.lFechaNac.Size = new System.Drawing.Size(111, 13);
            this.lFechaNac.TabIndex = 3;
            this.lFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(84, 20);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 9;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(84, 46);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(100, 20);
            this.tApellido.TabIndex = 11;
            // 
            // mtDNI
            // 
            this.mtDNI.Location = new System.Drawing.Point(84, 72);
            this.mtDNI.Mask = "00,000,000";
            this.mtDNI.Name = "mtDNI";
            this.mtDNI.Size = new System.Drawing.Size(100, 20);
            this.mtDNI.TabIndex = 14;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(125, 103);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(99, 20);
            this.dtNacimiento.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lNombre);
            this.panel2.Controls.Add(this.lApellido);
            this.panel2.Controls.Add(this.lDocumento);
            this.panel2.Controls.Add(this.lFechaNac);
            this.panel2.Controls.Add(this.tNombre);
            this.panel2.Controls.Add(this.tApellido);
            this.panel2.Controls.Add(this.dtNacimiento);
            this.panel2.Controls.Add(this.mtDNI);
            this.panel2.Controls.Add(this.chEstudiante);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 160);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lLegajo);
            this.panel3.Controls.Add(this.lCarrera);
            this.panel3.Controls.Add(this.lFechaIngreso);
            this.panel3.Controls.Add(this.tCarrera);
            this.panel3.Controls.Add(this.mtLegajo);
            this.panel3.Controls.Add(this.dtIngreso);
            this.panel3.Location = new System.Drawing.Point(12, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 111);
            this.panel3.TabIndex = 19;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 348);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btBuscar);
            this.Name = "Personas";
            this.Text = "Personas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lLegajo;
        private System.Windows.Forms.Label lCarrera;
        private System.Windows.Forms.Label lFechaIngreso;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox tCarrera;
        private System.Windows.Forms.MaskedTextBox mtLegajo;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.CheckBox chEstudiante;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lDocumento;
        private System.Windows.Forms.Label lFechaNac;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.MaskedTextBox mtDNI;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

