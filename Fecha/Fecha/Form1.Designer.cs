namespace Fecha
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
            this.lbFechas = new System.Windows.Forms.ListBox();
            this.lFechas = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.mtFechaAgregar = new System.Windows.Forms.MaskedTextBox();
            this.mtFechaComparar = new System.Windows.Forms.MaskedTextBox();
            this.mtDiasEntreFechas = new System.Windows.Forms.MaskedTextBox();
            this.mtModificarEspecifico = new System.Windows.Forms.MaskedTextBox();
            this.mtFechasEntre2 = new System.Windows.Forms.MaskedTextBox();
            this.mtFechasEntre1 = new System.Windows.Forms.MaskedTextBox();
            this.bMayor = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.bMenor = new System.Windows.Forms.Button();
            this.bDiasEntre = new System.Windows.Forms.Button();
            this.bDia = new System.Windows.Forms.Button();
            this.bMes = new System.Windows.Forms.Button();
            this.bAno = new System.Windows.Forms.Button();
            this.bIncrementar = new System.Windows.Forms.Button();
            this.bDecrementar = new System.Windows.Forms.Button();
            this.bEntre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lY = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFechas
            // 
            this.lbFechas.FormattingEnabled = true;
            this.lbFechas.Location = new System.Drawing.Point(12, 25);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(168, 290);
            this.lbFechas.TabIndex = 0;
            // 
            // lFechas
            // 
            this.lFechas.AutoSize = true;
            this.lFechas.Location = new System.Drawing.Point(12, 9);
            this.lFechas.Name = "lFechas";
            this.lFechas.Size = new System.Drawing.Size(45, 13);
            this.lFechas.TabIndex = 1;
            this.lFechas.Text = "Fechas:";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(186, 28);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(40, 13);
            this.lFecha.TabIndex = 2;
            this.lFecha.Text = "Fecha:";
            // 
            // mtFechaAgregar
            // 
            this.mtFechaAgregar.Location = new System.Drawing.Point(234, 25);
            this.mtFechaAgregar.Mask = "00/00/0000";
            this.mtFechaAgregar.Name = "mtFechaAgregar";
            this.mtFechaAgregar.Size = new System.Drawing.Size(100, 20);
            this.mtFechaAgregar.TabIndex = 3;
            this.mtFechaAgregar.ValidatingType = typeof(System.DateTime);
            // 
            // mtFechaComparar
            // 
            this.mtFechaComparar.Location = new System.Drawing.Point(115, 21);
            this.mtFechaComparar.Mask = "00/00/0000";
            this.mtFechaComparar.Name = "mtFechaComparar";
            this.mtFechaComparar.Size = new System.Drawing.Size(100, 20);
            this.mtFechaComparar.TabIndex = 4;
            this.mtFechaComparar.ValidatingType = typeof(System.DateTime);
            // 
            // mtDiasEntreFechas
            // 
            this.mtDiasEntreFechas.Location = new System.Drawing.Point(115, 22);
            this.mtDiasEntreFechas.Mask = "00/00/0000";
            this.mtDiasEntreFechas.Name = "mtDiasEntreFechas";
            this.mtDiasEntreFechas.Size = new System.Drawing.Size(100, 20);
            this.mtDiasEntreFechas.TabIndex = 5;
            this.mtDiasEntreFechas.ValidatingType = typeof(System.DateTime);
            // 
            // mtModificarEspecifico
            // 
            this.mtModificarEspecifico.Location = new System.Drawing.Point(15, 19);
            this.mtModificarEspecifico.Mask = "0000";
            this.mtModificarEspecifico.Name = "mtModificarEspecifico";
            this.mtModificarEspecifico.Size = new System.Drawing.Size(53, 20);
            this.mtModificarEspecifico.TabIndex = 6;
            // 
            // mtFechasEntre2
            // 
            this.mtFechasEntre2.Location = new System.Drawing.Point(251, 25);
            this.mtFechasEntre2.Mask = "00/00/0000";
            this.mtFechasEntre2.Name = "mtFechasEntre2";
            this.mtFechasEntre2.Size = new System.Drawing.Size(100, 20);
            this.mtFechasEntre2.TabIndex = 7;
            this.mtFechasEntre2.ValidatingType = typeof(System.DateTime);
            // 
            // mtFechasEntre1
            // 
            this.mtFechasEntre1.Location = new System.Drawing.Point(109, 25);
            this.mtFechasEntre1.Mask = "00/00/0000";
            this.mtFechasEntre1.Name = "mtFechasEntre1";
            this.mtFechasEntre1.Size = new System.Drawing.Size(89, 20);
            this.mtFechasEntre1.TabIndex = 8;
            this.mtFechasEntre1.ValidatingType = typeof(System.DateTime);
            // 
            // bMayor
            // 
            this.bMayor.Location = new System.Drawing.Point(39, 14);
            this.bMayor.Name = "bMayor";
            this.bMayor.Size = new System.Drawing.Size(32, 33);
            this.bMayor.TabIndex = 9;
            this.bMayor.Text = ">=";
            this.bMayor.UseVisualStyleBackColor = true;
            this.bMayor.Click += new System.EventHandler(this.bMayor_Click);
            // 
            // bIgual
            // 
            this.bIgual.Location = new System.Drawing.Point(3, 14);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(32, 33);
            this.bIgual.TabIndex = 10;
            this.bIgual.Text = "==";
            this.bIgual.UseVisualStyleBackColor = true;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // bMenor
            // 
            this.bMenor.Location = new System.Drawing.Point(77, 14);
            this.bMenor.Name = "bMenor";
            this.bMenor.Size = new System.Drawing.Size(32, 33);
            this.bMenor.TabIndex = 11;
            this.bMenor.Text = "<=";
            this.bMenor.UseVisualStyleBackColor = true;
            this.bMenor.Click += new System.EventHandler(this.bMenor_Click);
            // 
            // bDiasEntre
            // 
            this.bDiasEntre.Location = new System.Drawing.Point(3, 11);
            this.bDiasEntre.Name = "bDiasEntre";
            this.bDiasEntre.Size = new System.Drawing.Size(106, 40);
            this.bDiasEntre.TabIndex = 12;
            this.bDiasEntre.Text = "Dias entre fechas";
            this.bDiasEntre.UseVisualStyleBackColor = true;
            this.bDiasEntre.Click += new System.EventHandler(this.bDiasEntre_Click);
            // 
            // bDia
            // 
            this.bDia.Location = new System.Drawing.Point(74, 16);
            this.bDia.Name = "bDia";
            this.bDia.Size = new System.Drawing.Size(43, 23);
            this.bDia.TabIndex = 13;
            this.bDia.Text = "Dia";
            this.bDia.UseVisualStyleBackColor = true;
            this.bDia.Click += new System.EventHandler(this.bDia_Click);
            // 
            // bMes
            // 
            this.bMes.Location = new System.Drawing.Point(123, 16);
            this.bMes.Name = "bMes";
            this.bMes.Size = new System.Drawing.Size(43, 23);
            this.bMes.TabIndex = 14;
            this.bMes.Text = "Mes";
            this.bMes.UseVisualStyleBackColor = true;
            this.bMes.Click += new System.EventHandler(this.bMes_Click);
            // 
            // bAno
            // 
            this.bAno.Location = new System.Drawing.Point(172, 16);
            this.bAno.Name = "bAno";
            this.bAno.Size = new System.Drawing.Size(43, 23);
            this.bAno.TabIndex = 15;
            this.bAno.Text = "Año";
            this.bAno.UseVisualStyleBackColor = true;
            this.bAno.Click += new System.EventHandler(this.bAno_Click);
            // 
            // bIncrementar
            // 
            this.bIncrementar.Location = new System.Drawing.Point(204, 278);
            this.bIncrementar.Name = "bIncrementar";
            this.bIncrementar.Size = new System.Drawing.Size(75, 40);
            this.bIncrementar.TabIndex = 16;
            this.bIncrementar.Text = "Incrementar";
            this.bIncrementar.UseVisualStyleBackColor = true;
            this.bIncrementar.Click += new System.EventHandler(this.bIncrementar_Click);
            // 
            // bDecrementar
            // 
            this.bDecrementar.Location = new System.Drawing.Point(304, 278);
            this.bDecrementar.Name = "bDecrementar";
            this.bDecrementar.Size = new System.Drawing.Size(79, 40);
            this.bDecrementar.TabIndex = 17;
            this.bDecrementar.Text = "Decrementar";
            this.bDecrementar.UseVisualStyleBackColor = true;
            this.bDecrementar.Click += new System.EventHandler(this.bDecrementar_Click);
            // 
            // bEntre
            // 
            this.bEntre.Location = new System.Drawing.Point(12, 14);
            this.bEntre.Name = "bEntre";
            this.bEntre.Size = new System.Drawing.Size(75, 40);
            this.bEntre.TabIndex = 18;
            this.bEntre.Text = "Está entre";
            this.bEntre.UseVisualStyleBackColor = true;
            this.bEntre.Click += new System.EventHandler(this.bEntre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bMenor);
            this.panel1.Controls.Add(this.bIgual);
            this.panel1.Controls.Add(this.bMayor);
            this.panel1.Controls.Add(this.mtFechaComparar);
            this.panel1.Location = new System.Drawing.Point(189, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 61);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bDiasEntre);
            this.panel2.Controls.Add(this.mtDiasEntreFechas);
            this.panel2.Location = new System.Drawing.Point(189, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bAno);
            this.panel3.Controls.Add(this.bMes);
            this.panel3.Controls.Add(this.bDia);
            this.panel3.Controls.Add(this.mtModificarEspecifico);
            this.panel3.Location = new System.Drawing.Point(189, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 56);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lY);
            this.panel4.Controls.Add(this.bEntre);
            this.panel4.Controls.Add(this.mtFechasEntre1);
            this.panel4.Controls.Add(this.mtFechasEntre2);
            this.panel4.Location = new System.Drawing.Point(12, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 72);
            this.panel4.TabIndex = 0;
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(219, 28);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(12, 13);
            this.lY.TabIndex = 19;
            this.lY.Text = "y";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(338, 14);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 40);
            this.bAgregar.TabIndex = 20;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(12, 411);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(401, 23);
            this.bCerrar.TabIndex = 21;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 440);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bDecrementar);
            this.Controls.Add(this.bIncrementar);
            this.Controls.Add(this.mtFechaAgregar);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lFechas);
            this.Controls.Add(this.lbFechas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFechas;
        private System.Windows.Forms.Label lFechas;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.MaskedTextBox mtFechaAgregar;
        private System.Windows.Forms.MaskedTextBox mtFechaComparar;
        private System.Windows.Forms.MaskedTextBox mtDiasEntreFechas;
        private System.Windows.Forms.MaskedTextBox mtModificarEspecifico;
        private System.Windows.Forms.MaskedTextBox mtFechasEntre2;
        private System.Windows.Forms.MaskedTextBox mtFechasEntre1;
        private System.Windows.Forms.Button bMayor;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button bMenor;
        private System.Windows.Forms.Button bDiasEntre;
        private System.Windows.Forms.Button bDia;
        private System.Windows.Forms.Button bMes;
        private System.Windows.Forms.Button bAno;
        private System.Windows.Forms.Button bIncrementar;
        private System.Windows.Forms.Button bDecrementar;
        private System.Windows.Forms.Button bEntre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bCerrar;
    }
}

