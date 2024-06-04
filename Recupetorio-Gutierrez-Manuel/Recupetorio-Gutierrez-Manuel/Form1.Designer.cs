namespace Recupetorio_Gutierrez_Manuel
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAcercaDe = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.pBotones = new System.Windows.Forms.Panel();
            this.lbMazos = new System.Windows.Forms.ListBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.chCartasEspeciales = new System.Windows.Forms.CheckBox();
            this.gbAcabado = new System.Windows.Forms.GroupBox();
            this.rbPlastic = new System.Windows.Forms.RadioButton();
            this.rbSmooth = new System.Windows.Forms.RadioButton();
            this.rbAirCushion = new System.Windows.Forms.RadioButton();
            this.gbCantidad = new System.Windows.Forms.GroupBox();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.pEspecífico = new System.Windows.Forms.Panel();
            this.chPersonalizado = new System.Windows.Forms.CheckBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.lMazos = new System.Windows.Forms.Label();
            this.pBotones.SuspendLayout();
            this.gbAcabado.SuspendLayout();
            this.gbCantidad.SuspendLayout();
            this.pFiltro.SuspendLayout();
            this.pEspecífico.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(12, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(92, 61);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(12, 79);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(92, 61);
            this.bModificar.TabIndex = 1;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(12, 146);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(92, 61);
            this.bEliminar.TabIndex = 2;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bAcercaDe
            // 
            this.bAcercaDe.Location = new System.Drawing.Point(12, 213);
            this.bAcercaDe.Name = "bAcercaDe";
            this.bAcercaDe.Size = new System.Drawing.Size(92, 61);
            this.bAcercaDe.TabIndex = 3;
            this.bAcercaDe.Text = "Sobre Nosotros";
            this.bAcercaDe.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(12, 280);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(92, 61);
            this.bSalir.TabIndex = 4;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pBotones.Controls.Add(this.bAgregar);
            this.pBotones.Controls.Add(this.bSalir);
            this.pBotones.Controls.Add(this.bModificar);
            this.pBotones.Controls.Add(this.bAcercaDe);
            this.pBotones.Controls.Add(this.bEliminar);
            this.pBotones.Location = new System.Drawing.Point(475, 30);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(116, 356);
            this.pBotones.TabIndex = 5;
            // 
            // lbMazos
            // 
            this.lbMazos.FormattingEnabled = true;
            this.lbMazos.ItemHeight = 16;
            this.lbMazos.Location = new System.Drawing.Point(259, 30);
            this.lbMazos.Name = "lbMazos";
            this.lbMazos.Size = new System.Drawing.Size(191, 356);
            this.lbMazos.TabIndex = 6;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "TODOS",
            "Franceses",
            "Españoles"});
            this.cbFiltro.Location = new System.Drawing.Point(18, 12);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(191, 24);
            this.cbFiltro.TabIndex = 7;
            this.cbFiltro.Text = "TODOS";
            // 
            // chCartasEspeciales
            // 
            this.chCartasEspeciales.AutoSize = true;
            this.chCartasEspeciales.Location = new System.Drawing.Point(9, 16);
            this.chCartasEspeciales.Name = "chCartasEspeciales";
            this.chCartasEspeciales.Size = new System.Drawing.Size(138, 20);
            this.chCartasEspeciales.TabIndex = 8;
            this.chCartasEspeciales.Text = "Cartas especiales";
            this.chCartasEspeciales.UseVisualStyleBackColor = true;
            // 
            // gbAcabado
            // 
            this.gbAcabado.Controls.Add(this.rbPlastic);
            this.gbAcabado.Controls.Add(this.rbSmooth);
            this.gbAcabado.Controls.Add(this.rbAirCushion);
            this.gbAcabado.Location = new System.Drawing.Point(9, 42);
            this.gbAcabado.Name = "gbAcabado";
            this.gbAcabado.Size = new System.Drawing.Size(191, 110);
            this.gbAcabado.TabIndex = 9;
            this.gbAcabado.TabStop = false;
            this.gbAcabado.Text = "Acabado";
            // 
            // rbPlastic
            // 
            this.rbPlastic.AutoSize = true;
            this.rbPlastic.Location = new System.Drawing.Point(6, 75);
            this.rbPlastic.Name = "rbPlastic";
            this.rbPlastic.Size = new System.Drawing.Size(117, 20);
            this.rbPlastic.TabIndex = 2;
            this.rbPlastic.TabStop = true;
            this.rbPlastic.Text = "Plastic Coating";
            this.rbPlastic.UseVisualStyleBackColor = true;
            // 
            // rbSmooth
            // 
            this.rbSmooth.AutoSize = true;
            this.rbSmooth.Location = new System.Drawing.Point(6, 49);
            this.rbSmooth.Name = "rbSmooth";
            this.rbSmooth.Size = new System.Drawing.Size(112, 20);
            this.rbSmooth.TabIndex = 1;
            this.rbSmooth.TabStop = true;
            this.rbSmooth.Text = "Smooth Finish";
            this.rbSmooth.UseVisualStyleBackColor = true;
            // 
            // rbAirCushion
            // 
            this.rbAirCushion.AutoSize = true;
            this.rbAirCushion.Checked = true;
            this.rbAirCushion.Location = new System.Drawing.Point(6, 23);
            this.rbAirCushion.Name = "rbAirCushion";
            this.rbAirCushion.Size = new System.Drawing.Size(134, 20);
            this.rbAirCushion.TabIndex = 0;
            this.rbAirCushion.TabStop = true;
            this.rbAirCushion.Text = "Air-Cushion Finish";
            this.rbAirCushion.UseVisualStyleBackColor = true;
            // 
            // gbCantidad
            // 
            this.gbCantidad.Controls.Add(this.rb50);
            this.gbCantidad.Controls.Add(this.rb40);
            this.gbCantidad.Location = new System.Drawing.Point(9, 158);
            this.gbCantidad.Name = "gbCantidad";
            this.gbCantidad.Size = new System.Drawing.Size(191, 79);
            this.gbCantidad.TabIndex = 10;
            this.gbCantidad.TabStop = false;
            this.gbCantidad.Text = "Cantidad";
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(6, 47);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(84, 20);
            this.rb50.TabIndex = 1;
            this.rb50.TabStop = true;
            this.rb50.Text = "50 Cartas";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Checked = true;
            this.rb40.Location = new System.Drawing.Point(6, 21);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(84, 20);
            this.rb40.TabIndex = 0;
            this.rb40.TabStop = true;
            this.rb40.Text = "40 Cartas";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // pFiltro
            // 
            this.pFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pFiltro.Controls.Add(this.pEspecífico);
            this.pFiltro.Controls.Add(this.chPersonalizado);
            this.pFiltro.Controls.Add(this.cbFiltro);
            this.pFiltro.Location = new System.Drawing.Point(12, 30);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(226, 356);
            this.pFiltro.TabIndex = 11;
            // 
            // pEspecífico
            // 
            this.pEspecífico.Controls.Add(this.gbAcabado);
            this.pEspecífico.Controls.Add(this.chCartasEspeciales);
            this.pEspecífico.Controls.Add(this.gbCantidad);
            this.pEspecífico.Enabled = false;
            this.pEspecífico.Location = new System.Drawing.Point(3, 89);
            this.pEspecífico.Name = "pEspecífico";
            this.pEspecífico.Size = new System.Drawing.Size(220, 252);
            this.pEspecífico.TabIndex = 12;
            // 
            // chPersonalizado
            // 
            this.chPersonalizado.AutoSize = true;
            this.chPersonalizado.Location = new System.Drawing.Point(40, 53);
            this.chPersonalizado.Name = "chPersonalizado";
            this.chPersonalizado.Size = new System.Drawing.Size(139, 20);
            this.chPersonalizado.TabIndex = 11;
            this.chPersonalizado.Text = "Filtrado específico";
            this.chPersonalizado.UseVisualStyleBackColor = true;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(12, 9);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(39, 16);
            this.lFiltro.TabIndex = 12;
            this.lFiltro.Text = "Filtro:";
            // 
            // lMazos
            // 
            this.lMazos.AutoSize = true;
            this.lMazos.Location = new System.Drawing.Point(256, 9);
            this.lMazos.Name = "lMazos";
            this.lMazos.Size = new System.Drawing.Size(50, 16);
            this.lMazos.TabIndex = 13;
            this.lMazos.Text = "Mazos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.lMazos);
            this.Controls.Add(this.lFiltro);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.lbMazos);
            this.Controls.Add(this.pBotones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pBotones.ResumeLayout(false);
            this.gbAcabado.ResumeLayout(false);
            this.gbAcabado.PerformLayout();
            this.gbCantidad.ResumeLayout(false);
            this.gbCantidad.PerformLayout();
            this.pFiltro.ResumeLayout(false);
            this.pFiltro.PerformLayout();
            this.pEspecífico.ResumeLayout(false);
            this.pEspecífico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAcercaDe;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.ListBox lbMazos;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.CheckBox chCartasEspeciales;
        private System.Windows.Forms.GroupBox gbAcabado;
        private System.Windows.Forms.RadioButton rbPlastic;
        private System.Windows.Forms.RadioButton rbSmooth;
        private System.Windows.Forms.RadioButton rbAirCushion;
        private System.Windows.Forms.GroupBox gbCantidad;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Label lMazos;
        private System.Windows.Forms.Panel pEspecífico;
        private System.Windows.Forms.CheckBox chPersonalizado;
    }
}

