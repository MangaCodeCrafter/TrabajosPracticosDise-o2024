namespace RectanguloApp
{
    partial class fRectangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtBase = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lbRectangulos = new System.Windows.Forms.ListBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.mtCambiarBase = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bActualizarBase = new System.Windows.Forms.Button();
            this.bActualizarAltura = new System.Windows.Forms.Button();
            this.mtCambiarAltura = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.lCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lMayorRectangulo = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.mtAltura = new System.Windows.Forms.MaskedTextBox();
            this.bListarCuad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base:";
            // 
            // mtBase
            // 
            this.mtBase.Location = new System.Drawing.Point(68, 18);
            this.mtBase.Margin = new System.Windows.Forms.Padding(2);
            this.mtBase.Mask = "990";
            this.mtBase.Name = "mtBase";
            this.mtBase.Size = new System.Drawing.Size(25, 20);
            this.mtBase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura:";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(212, 10);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 29);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lbRectangulos
            // 
            this.lbRectangulos.FormattingEnabled = true;
            this.lbRectangulos.Location = new System.Drawing.Point(19, 47);
            this.lbRectangulos.Margin = new System.Windows.Forms.Padding(2);
            this.lbRectangulos.Name = "lbRectangulos";
            this.lbRectangulos.Size = new System.Drawing.Size(182, 225);
            this.lbRectangulos.TabIndex = 3;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(212, 47);
            this.bArea.Margin = new System.Windows.Forms.Padding(2);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(107, 25);
            this.bArea.TabIndex = 4;
            this.bArea.Text = "Calcular Área";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(212, 76);
            this.bPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(107, 25);
            this.bPerimetro.TabIndex = 5;
            this.bPerimetro.Text = "Calcular Perímetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // mtCambiarBase
            // 
            this.mtCambiarBase.Location = new System.Drawing.Point(272, 113);
            this.mtCambiarBase.Margin = new System.Windows.Forms.Padding(2);
            this.mtCambiarBase.Mask = "000";
            this.mtCambiarBase.Name = "mtCambiarBase";
            this.mtCambiarBase.Size = new System.Drawing.Size(25, 20);
            this.mtCambiarBase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Base:";
            // 
            // bActualizarBase
            // 
            this.bActualizarBase.Location = new System.Drawing.Point(212, 134);
            this.bActualizarBase.Margin = new System.Windows.Forms.Padding(2);
            this.bActualizarBase.Name = "bActualizarBase";
            this.bActualizarBase.Size = new System.Drawing.Size(107, 25);
            this.bActualizarBase.TabIndex = 7;
            this.bActualizarBase.Text = "Actualizar Base";
            this.bActualizarBase.UseVisualStyleBackColor = true;
            this.bActualizarBase.Click += new System.EventHandler(this.bActualizarBase_Click);
            // 
            // bActualizarAltura
            // 
            this.bActualizarAltura.Location = new System.Drawing.Point(212, 195);
            this.bActualizarAltura.Margin = new System.Windows.Forms.Padding(2);
            this.bActualizarAltura.Name = "bActualizarAltura";
            this.bActualizarAltura.Size = new System.Drawing.Size(107, 25);
            this.bActualizarAltura.TabIndex = 9;
            this.bActualizarAltura.Text = "Actualizar Altura";
            this.bActualizarAltura.UseVisualStyleBackColor = true;
            this.bActualizarAltura.Click += new System.EventHandler(this.bActualizarAltura_Click);
            // 
            // mtCambiarAltura
            // 
            this.mtCambiarAltura.Location = new System.Drawing.Point(272, 174);
            this.mtCambiarAltura.Margin = new System.Windows.Forms.Padding(2);
            this.mtCambiarAltura.Mask = "000";
            this.mtCambiarAltura.Name = "mtCambiarAltura";
            this.mtCambiarAltura.Size = new System.Drawing.Size(25, 20);
            this.mtCambiarAltura.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Altura:";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(212, 246);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(107, 25);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lCantidad.Location = new System.Drawing.Point(66, 281);
            this.lCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(13, 13);
            this.lCantidad.TabIndex = 14;
            this.lCantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(17, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(17, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mayor rectángulo";
            // 
            // lMayorRectangulo
            // 
            this.lMayorRectangulo.AutoSize = true;
            this.lMayorRectangulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lMayorRectangulo.Location = new System.Drawing.Point(102, 296);
            this.lMayorRectangulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMayorRectangulo.Name = "lMayorRectangulo";
            this.lMayorRectangulo.Size = new System.Drawing.Size(10, 13);
            this.lMayorRectangulo.TabIndex = 17;
            this.lMayorRectangulo.Text = "-";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(1, 313);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(327, 21);
            this.bCerrar.TabIndex = 11;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // mtAltura
            // 
            this.mtAltura.Location = new System.Drawing.Point(137, 18);
            this.mtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.mtAltura.Mask = "990";
            this.mtAltura.Name = "mtAltura";
            this.mtAltura.Size = new System.Drawing.Size(25, 20);
            this.mtAltura.TabIndex = 20;
            // 
            // bListarCuad
            // 
            this.bListarCuad.Location = new System.Drawing.Point(212, 285);
            this.bListarCuad.Margin = new System.Windows.Forms.Padding(2);
            this.bListarCuad.Name = "bListarCuad";
            this.bListarCuad.Size = new System.Drawing.Size(107, 25);
            this.bListarCuad.TabIndex = 21;
            this.bListarCuad.Text = "Listar Cuadrados";
            this.bListarCuad.UseVisualStyleBackColor = true;
            this.bListarCuad.Click += new System.EventHandler(this.bListarCuad_Click);
            // 
            // fRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 335);
            this.Controls.Add(this.bListarCuad);
            this.Controls.Add(this.mtAltura);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lMayorRectangulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bActualizarAltura);
            this.Controls.Add(this.mtCambiarAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bActualizarBase);
            this.Controls.Add(this.mtCambiarBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbRectangulos);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtBase);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fRectangulo";
            this.Text = "Rectangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox lbRectangulos;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.MaskedTextBox mtCambiarBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bActualizarBase;
        private System.Windows.Forms.Button bActualizarAltura;
        private System.Windows.Forms.MaskedTextBox mtCambiarAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lMayorRectangulo;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.MaskedTextBox mtAltura;
        private System.Windows.Forms.Button bListarCuad;
    }
}

