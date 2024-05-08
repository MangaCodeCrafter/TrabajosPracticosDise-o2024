namespace CirculoApp
{
    partial class fCirculo
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
            this.mtRadio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lbCirculos = new System.Windows.Forms.ListBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.mtCambiarRadio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCambiarRadio = new System.Windows.Forms.Button();
            this.bCambiarDiametro = new System.Windows.Forms.Button();
            this.mtCambiarDiametro = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.lCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lMayorDiametro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lMenorDiametro = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio:";
            // 
            // mtRadio
            // 
            this.mtRadio.Location = new System.Drawing.Point(68, 18);
            this.mtRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtRadio.Mask = "990";
            this.mtRadio.Name = "mtRadio";
            this.mtRadio.Size = new System.Drawing.Size(25, 20);
            this.mtRadio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cm";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(125, 16);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 21);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lbCirculos
            // 
            this.lbCirculos.FormattingEnabled = true;
            this.lbCirculos.Location = new System.Drawing.Point(19, 47);
            this.lbCirculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCirculos.Name = "lbCirculos";
            this.lbCirculos.Size = new System.Drawing.Size(182, 225);
            this.lbCirculos.TabIndex = 3;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(212, 47);
            this.bArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.bPerimetro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(107, 25);
            this.bPerimetro.TabIndex = 5;
            this.bPerimetro.Text = "Calcular Perímetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // mtCambiarRadio
            // 
            this.mtCambiarRadio.Location = new System.Drawing.Point(272, 113);
            this.mtCambiarRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtCambiarRadio.Mask = "990";
            this.mtCambiarRadio.Name = "mtCambiarRadio";
            this.mtCambiarRadio.Size = new System.Drawing.Size(25, 20);
            this.mtCambiarRadio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radio:";
            // 
            // bCambiarRadio
            // 
            this.bCambiarRadio.Location = new System.Drawing.Point(212, 134);
            this.bCambiarRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCambiarRadio.Name = "bCambiarRadio";
            this.bCambiarRadio.Size = new System.Drawing.Size(107, 25);
            this.bCambiarRadio.TabIndex = 7;
            this.bCambiarRadio.Text = "Cambiar Radio";
            this.bCambiarRadio.UseVisualStyleBackColor = true;
            this.bCambiarRadio.Click += new System.EventHandler(this.bCambiarRadio_Click);
            // 
            // bCambiarDiametro
            // 
            this.bCambiarDiametro.Location = new System.Drawing.Point(212, 195);
            this.bCambiarDiametro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCambiarDiametro.Name = "bCambiarDiametro";
            this.bCambiarDiametro.Size = new System.Drawing.Size(107, 25);
            this.bCambiarDiametro.TabIndex = 9;
            this.bCambiarDiametro.Text = "Cambiar Diámetro";
            this.bCambiarDiametro.UseVisualStyleBackColor = true;
            this.bCambiarDiametro.Click += new System.EventHandler(this.bCambiarDiametro_Click);
            // 
            // mtCambiarDiametro
            // 
            this.mtCambiarDiametro.Location = new System.Drawing.Point(272, 174);
            this.mtCambiarDiametro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtCambiarDiametro.Mask = "990";
            this.mtCambiarDiametro.Name = "mtCambiarDiametro";
            this.mtCambiarDiametro.Size = new System.Drawing.Size(25, 20);
            this.mtCambiarDiametro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diámetro:";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(212, 246);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lCantidad.Location = new System.Drawing.Point(72, 285);
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
            this.label5.Location = new System.Drawing.Point(23, 285);
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
            this.label6.Location = new System.Drawing.Point(98, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mayor diámetro:";
            // 
            // lMayorDiametro
            // 
            this.lMayorDiametro.AutoSize = true;
            this.lMayorDiametro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lMayorDiametro.Location = new System.Drawing.Point(183, 285);
            this.lMayorDiametro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMayorDiametro.Name = "lMayorDiametro";
            this.lMayorDiametro.Size = new System.Drawing.Size(10, 13);
            this.lMayorDiametro.TabIndex = 17;
            this.lMayorDiametro.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(217, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Menor diámetro:";
            // 
            // lMenorDiametro
            // 
            this.lMenorDiametro.AutoSize = true;
            this.lMenorDiametro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lMenorDiametro.Location = new System.Drawing.Point(303, 285);
            this.lMenorDiametro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMenorDiametro.Name = "lMenorDiametro";
            this.lMenorDiametro.Size = new System.Drawing.Size(10, 13);
            this.lMenorDiametro.TabIndex = 19;
            this.lMenorDiametro.Text = "-";
            // 
            // bCerrar
            // 
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 302);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(331, 21);
            this.bCerrar.TabIndex = 11;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 323);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lMenorDiametro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lMayorDiametro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bCambiarDiametro);
            this.Controls.Add(this.mtCambiarDiametro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCambiarRadio);
            this.Controls.Add(this.mtCambiarRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbCirculos);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtRadio);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCirculo";
            this.Text = "Circulos";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox lbCirculos;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.MaskedTextBox mtCambiarRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCambiarRadio;
        private System.Windows.Forms.Button bCambiarDiametro;
        private System.Windows.Forms.MaskedTextBox mtCambiarDiametro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lMayorDiametro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lMenorDiametro;
        private System.Windows.Forms.Button bCerrar;
    }
}

