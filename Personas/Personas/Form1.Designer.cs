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
            this.components = new System.ComponentModel.Container();
            this.lLegajo = new System.Windows.Forms.Label();
            this.lCarrera = new System.Windows.Forms.Label();
            this.lFiltro = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.tCarrera = new System.Windows.Forms.TextBox();
            this.mtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDocumento = new System.Windows.Forms.Label();
            this.lFechaNac = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.mtDNI = new System.Windows.Forms.MaskedTextBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.rbEstudiante = new System.Windows.Forms.RadioButton();
            this.rbPersona = new System.Windows.Forms.RadioButton();
            this.pEstudiante = new System.Windows.Forms.Panel();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLegajo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCarrera = new System.Windows.Forms.ErrorProvider(this.components);
            this.pEmpleado = new System.Windows.Forms.Panel();
            this.lLegajoEmpleado = new System.Windows.Forms.Label();
            this.lCargo = new System.Windows.Forms.Label();
            this.tCargo = new System.Windows.Forms.TextBox();
            this.mtLegajoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarrera)).BeginInit();
            this.pEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLegajo
            // 
            this.lLegajo.AutoSize = true;
            this.lLegajo.Location = new System.Drawing.Point(44, 41);
            this.lLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLegajo.Name = "lLegajo";
            this.lLegajo.Size = new System.Drawing.Size(52, 16);
            this.lLegajo.TabIndex = 4;
            this.lLegajo.Text = "Legajo:";
            // 
            // lCarrera
            // 
            this.lCarrera.AutoSize = true;
            this.lCarrera.Location = new System.Drawing.Point(44, 82);
            this.lCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCarrera.Name = "lCarrera";
            this.lCarrera.Size = new System.Drawing.Size(55, 16);
            this.lCarrera.TabIndex = 5;
            this.lCarrera.Text = "Carrera:";
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(4, 25);
            this.lFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(39, 16);
            this.lFiltro.TabIndex = 7;
            this.lFiltro.Text = "Filtro:";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(4, 280);
            this.lCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(64, 16);
            this.lCantidad.TabIndex = 8;
            this.lCantidad.Text = "Cantidad:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "TODOS",
            "Personas",
            "Estudiantes"});
            this.cbFiltro.Location = new System.Drawing.Point(8, 47);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(160, 24);
            this.cbFiltro.TabIndex = 12;
            this.cbFiltro.Text = "TODOS";
            // 
            // tCarrera
            // 
            this.tCarrera.Location = new System.Drawing.Point(124, 78);
            this.tCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.tCarrera.Name = "tCarrera";
            this.tCarrera.Size = new System.Drawing.Size(132, 22);
            this.tCarrera.TabIndex = 13;
            this.tCarrera.Validating += new System.ComponentModel.CancelEventHandler(this.tCarrera_Validating);
            // 
            // mtLegajo
            // 
            this.mtLegajo.Location = new System.Drawing.Point(124, 33);
            this.mtLegajo.Margin = new System.Windows.Forms.Padding(4);
            this.mtLegajo.Mask = "000000";
            this.mtLegajo.Name = "mtLegajo";
            this.mtLegajo.Size = new System.Drawing.Size(132, 22);
            this.mtLegajo.TabIndex = 15;
            this.mtLegajo.Validating += new System.ComponentModel.CancelEventHandler(this.mtLegajo_Validating);
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.ItemHeight = 16;
            this.lbPersonas.Location = new System.Drawing.Point(8, 80);
            this.lbPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(159, 196);
            this.lbPersonas.TabIndex = 16;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(133, 353);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 28);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(241, 353);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 28);
            this.btGuardar.TabIndex = 21;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(349, 353);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 22;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbPersonas);
            this.panel1.Controls.Add(this.cbFiltro);
            this.panel1.Controls.Add(this.lCantidad);
            this.panel1.Controls.Add(this.lFiltro);
            this.panel1.Location = new System.Drawing.Point(380, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 314);
            this.panel1.TabIndex = 23;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(74, 34);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(59, 16);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // lDocumento
            // 
            this.lDocumento.AutoSize = true;
            this.lDocumento.Location = new System.Drawing.Point(59, 61);
            this.lDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDocumento.Name = "lDocumento";
            this.lDocumento.Size = new System.Drawing.Size(79, 16);
            this.lDocumento.TabIndex = 2;
            this.lDocumento.Text = "Documento:";
            // 
            // lFechaNac
            // 
            this.lFechaNac.AutoSize = true;
            this.lFechaNac.Location = new System.Drawing.Point(4, 94);
            this.lFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFechaNac.Name = "lFechaNac";
            this.lFechaNac.Size = new System.Drawing.Size(138, 16);
            this.lFechaNac.TabIndex = 3;
            this.lFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(150, 28);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(132, 22);
            this.tNombre.TabIndex = 9;
            this.tNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tNombre_Validating);
            // 
            // mtDNI
            // 
            this.mtDNI.Location = new System.Drawing.Point(150, 58);
            this.mtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.mtDNI.Mask = "00,000,000";
            this.mtDNI.Name = "mtDNI";
            this.mtDNI.Size = new System.Drawing.Size(132, 22);
            this.mtDNI.TabIndex = 14;
            this.mtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.mtDNI_Validating);
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(150, 89);
            this.dtNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(131, 22);
            this.dtNacimiento.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.rbEmpleado);
            this.panel2.Controls.Add(this.rbEstudiante);
            this.panel2.Controls.Add(this.rbPersona);
            this.panel2.Controls.Add(this.lNombre);
            this.panel2.Controls.Add(this.lDocumento);
            this.panel2.Controls.Add(this.lFechaNac);
            this.panel2.Controls.Add(this.tNombre);
            this.panel2.Controls.Add(this.dtNacimiento);
            this.panel2.Controls.Add(this.mtDNI);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 169);
            this.panel2.TabIndex = 17;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(255, 123);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(91, 20);
            this.rbEmpleado.TabIndex = 21;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbEstudiante
            // 
            this.rbEstudiante.AutoSize = true;
            this.rbEstudiante.Location = new System.Drawing.Point(132, 123);
            this.rbEstudiante.Name = "rbEstudiante";
            this.rbEstudiante.Size = new System.Drawing.Size(91, 20);
            this.rbEstudiante.TabIndex = 20;
            this.rbEstudiante.Text = "Estudiante";
            this.rbEstudiante.UseVisualStyleBackColor = true;
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.Checked = true;
            this.rbPersona.Location = new System.Drawing.Point(16, 123);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(79, 20);
            this.rbPersona.TabIndex = 19;
            this.rbPersona.TabStop = true;
            this.rbPersona.Text = "Persona";
            this.rbPersona.UseVisualStyleBackColor = true;
            // 
            // pEstudiante
            // 
            this.pEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pEstudiante.Controls.Add(this.lLegajo);
            this.pEstudiante.Controls.Add(this.lCarrera);
            this.pEstudiante.Controls.Add(this.tCarrera);
            this.pEstudiante.Controls.Add(this.mtLegajo);
            this.pEstudiante.Location = new System.Drawing.Point(16, 192);
            this.pEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.pEstudiante.Name = "pEstudiante";
            this.pEstudiante.Size = new System.Drawing.Size(356, 137);
            this.pEstudiante.TabIndex = 19;
            this.pEstudiante.Visible = false;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApellido
            // 
            this.epApellido.ContainerControl = this;
            // 
            // epDni
            // 
            this.epDni.ContainerControl = this;
            // 
            // epLegajo
            // 
            this.epLegajo.ContainerControl = this;
            // 
            // epCarrera
            // 
            this.epCarrera.ContainerControl = this;
            // 
            // pEmpleado
            // 
            this.pEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pEmpleado.Controls.Add(this.lLegajoEmpleado);
            this.pEmpleado.Controls.Add(this.lCargo);
            this.pEmpleado.Controls.Add(this.tCargo);
            this.pEmpleado.Controls.Add(this.mtLegajoEmpleado);
            this.pEmpleado.Location = new System.Drawing.Point(577, 138);
            this.pEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.pEmpleado.Name = "pEmpleado";
            this.pEmpleado.Size = new System.Drawing.Size(356, 137);
            this.pEmpleado.TabIndex = 20;
            this.pEmpleado.Visible = false;
            // 
            // lLegajoEmpleado
            // 
            this.lLegajoEmpleado.AutoSize = true;
            this.lLegajoEmpleado.Location = new System.Drawing.Point(44, 41);
            this.lLegajoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLegajoEmpleado.Name = "lLegajoEmpleado";
            this.lLegajoEmpleado.Size = new System.Drawing.Size(52, 16);
            this.lLegajoEmpleado.TabIndex = 4;
            this.lLegajoEmpleado.Text = "Legajo:";
            // 
            // lCargo
            // 
            this.lCargo.AutoSize = true;
            this.lCargo.Location = new System.Drawing.Point(44, 82);
            this.lCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCargo.Name = "lCargo";
            this.lCargo.Size = new System.Drawing.Size(47, 16);
            this.lCargo.TabIndex = 5;
            this.lCargo.Text = "Cargo:";
            // 
            // tCargo
            // 
            this.tCargo.Location = new System.Drawing.Point(124, 78);
            this.tCargo.Margin = new System.Windows.Forms.Padding(4);
            this.tCargo.Name = "tCargo";
            this.tCargo.Size = new System.Drawing.Size(132, 22);
            this.tCargo.TabIndex = 13;
            // 
            // mtLegajoEmpleado
            // 
            this.mtLegajoEmpleado.Location = new System.Drawing.Point(124, 33);
            this.mtLegajoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.mtLegajoEmpleado.Mask = "000000";
            this.mtLegajoEmpleado.Name = "mtLegajoEmpleado";
            this.mtLegajoEmpleado.Size = new System.Drawing.Size(132, 22);
            this.mtLegajoEmpleado.TabIndex = 15;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 398);
            this.Controls.Add(this.pEmpleado);
            this.Controls.Add(this.pEstudiante);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btBuscar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personas";
            this.Text = "Personas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pEstudiante.ResumeLayout(false);
            this.pEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarrera)).EndInit();
            this.pEmpleado.ResumeLayout(false);
            this.pEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lLegajo;
        private System.Windows.Forms.Label lCarrera;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox tCarrera;
        private System.Windows.Forms.MaskedTextBox mtLegajo;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDocumento;
        private System.Windows.Forms.Label lFechaNac;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.MaskedTextBox mtDNI;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pEstudiante;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epDni;
        private System.Windows.Forms.ErrorProvider epLegajo;
        private System.Windows.Forms.ErrorProvider epCarrera;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton rbEstudiante;
        private System.Windows.Forms.RadioButton rbPersona;
        private System.Windows.Forms.Panel pEmpleado;
        private System.Windows.Forms.Label lLegajoEmpleado;
        private System.Windows.Forms.Label lCargo;
        private System.Windows.Forms.TextBox tCargo;
        private System.Windows.Forms.MaskedTextBox mtLegajoEmpleado;
    }
}

