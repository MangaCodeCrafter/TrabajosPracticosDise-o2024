namespace Recupetorio_Gutierrez_Manuel
{
    partial class fAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbMazo = new System.Windows.Forms.GroupBox();
            this.rbEspañol = new System.Windows.Forms.RadioButton();
            this.rbFrances = new System.Windows.Forms.RadioButton();
            this.chEspeciales = new System.Windows.Forms.CheckBox();
            this.gbAcabado = new System.Windows.Forms.GroupBox();
            this.rbPlastic = new System.Windows.Forms.RadioButton();
            this.rbSmooth = new System.Windows.Forms.RadioButton();
            this.rbAirCushion = new System.Windows.Forms.RadioButton();
            this.gbCantidad = new System.Windows.Forms.GroupBox();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.tModelo = new System.Windows.Forms.TextBox();
            this.lModelo = new System.Windows.Forms.Label();
            this.dtLote = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMarca = new System.Windows.Forms.Label();
            this.tMarca = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMazo.SuspendLayout();
            this.gbAcabado.SuspendLayout();
            this.gbCantidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMazo
            // 
            this.gbMazo.Controls.Add(this.rbEspañol);
            this.gbMazo.Controls.Add(this.rbFrances);
            this.gbMazo.Location = new System.Drawing.Point(17, 19);
            this.gbMazo.Name = "gbMazo";
            this.gbMazo.Size = new System.Drawing.Size(258, 57);
            this.gbMazo.TabIndex = 0;
            this.gbMazo.TabStop = false;
            this.gbMazo.Text = "Mazo";
            // 
            // rbEspañol
            // 
            this.rbEspañol.AutoSize = true;
            this.rbEspañol.Location = new System.Drawing.Point(144, 21);
            this.rbEspañol.Name = "rbEspañol";
            this.rbEspañol.Size = new System.Drawing.Size(78, 20);
            this.rbEspañol.TabIndex = 1;
            this.rbEspañol.Text = "Español";
            this.rbEspañol.UseVisualStyleBackColor = true;
            this.rbEspañol.CheckedChanged += new System.EventHandler(this.rbEspañol_CheckedChanged);
            // 
            // rbFrances
            // 
            this.rbFrances.AutoSize = true;
            this.rbFrances.Checked = true;
            this.rbFrances.Location = new System.Drawing.Point(27, 21);
            this.rbFrances.Name = "rbFrances";
            this.rbFrances.Size = new System.Drawing.Size(77, 20);
            this.rbFrances.TabIndex = 0;
            this.rbFrances.TabStop = true;
            this.rbFrances.Text = "Frances";
            this.rbFrances.UseVisualStyleBackColor = true;
            this.rbFrances.CheckedChanged += new System.EventHandler(this.rbFrances_CheckedChanged);
            // 
            // chEspeciales
            // 
            this.chEspeciales.AutoSize = true;
            this.chEspeciales.Location = new System.Drawing.Point(76, 220);
            this.chEspeciales.Name = "chEspeciales";
            this.chEspeciales.Size = new System.Drawing.Size(138, 20);
            this.chEspeciales.TabIndex = 1;
            this.chEspeciales.Text = "Cartas especiales";
            this.chEspeciales.UseVisualStyleBackColor = true;
            // 
            // gbAcabado
            // 
            this.gbAcabado.Controls.Add(this.rbPlastic);
            this.gbAcabado.Controls.Add(this.rbSmooth);
            this.gbAcabado.Controls.Add(this.rbAirCushion);
            this.gbAcabado.Location = new System.Drawing.Point(17, 246);
            this.gbAcabado.Name = "gbAcabado";
            this.gbAcabado.Size = new System.Drawing.Size(258, 100);
            this.gbAcabado.TabIndex = 2;
            this.gbAcabado.TabStop = false;
            this.gbAcabado.Text = "Acabado";
            // 
            // rbPlastic
            // 
            this.rbPlastic.AutoSize = true;
            this.rbPlastic.Location = new System.Drawing.Point(80, 74);
            this.rbPlastic.Name = "rbPlastic";
            this.rbPlastic.Size = new System.Drawing.Size(117, 20);
            this.rbPlastic.TabIndex = 2;
            this.rbPlastic.Text = "Plastic Coating";
            this.rbPlastic.UseVisualStyleBackColor = true;
            // 
            // rbSmooth
            // 
            this.rbSmooth.AutoSize = true;
            this.rbSmooth.Location = new System.Drawing.Point(80, 47);
            this.rbSmooth.Name = "rbSmooth";
            this.rbSmooth.Size = new System.Drawing.Size(112, 20);
            this.rbSmooth.TabIndex = 1;
            this.rbSmooth.Text = "Smooth Finish";
            this.rbSmooth.UseVisualStyleBackColor = true;
            // 
            // rbAirCushion
            // 
            this.rbAirCushion.AutoSize = true;
            this.rbAirCushion.Checked = true;
            this.rbAirCushion.Location = new System.Drawing.Point(80, 21);
            this.rbAirCushion.Name = "rbAirCushion";
            this.rbAirCushion.Size = new System.Drawing.Size(134, 20);
            this.rbAirCushion.TabIndex = 0;
            this.rbAirCushion.TabStop = true;
            this.rbAirCushion.Text = "Air-Cushion Finish";
            this.rbAirCushion.UseVisualStyleBackColor = true;
            // 
            // gbCantidad
            // 
            this.gbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbCantidad.Controls.Add(this.rb50);
            this.gbCantidad.Controls.Add(this.rb40);
            this.gbCantidad.Location = new System.Drawing.Point(17, 352);
            this.gbCantidad.Name = "gbCantidad";
            this.gbCantidad.Size = new System.Drawing.Size(258, 78);
            this.gbCantidad.TabIndex = 3;
            this.gbCantidad.TabStop = false;
            this.gbCantidad.Text = "Cantidad";
            this.gbCantidad.Visible = false;
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(144, 34);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(82, 20);
            this.rb50.TabIndex = 1;
            this.rb50.Text = "50 cartas";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Checked = true;
            this.rb40.Location = new System.Drawing.Point(27, 34);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(82, 20);
            this.rb40.TabIndex = 0;
            this.rb40.TabStop = true;
            this.rb40.Text = "40 cartas";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // tModelo
            // 
            this.tModelo.Location = new System.Drawing.Point(17, 151);
            this.tModelo.Name = "tModelo";
            this.tModelo.Size = new System.Drawing.Size(258, 22);
            this.tModelo.TabIndex = 4;
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(14, 132);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(56, 16);
            this.lModelo.TabIndex = 5;
            this.lModelo.Text = "Modelo:";
            // 
            // dtLote
            // 
            this.dtLote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLote.Location = new System.Drawing.Point(121, 187);
            this.dtLote.Name = "dtLote";
            this.dtLote.Size = new System.Drawing.Size(115, 22);
            this.dtLote.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha del lote:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.lMarca);
            this.panel1.Controls.Add(this.tMarca);
            this.panel1.Controls.Add(this.lModelo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gbMazo);
            this.panel1.Controls.Add(this.dtLote);
            this.panel1.Controls.Add(this.chEspeciales);
            this.panel1.Controls.Add(this.gbAcabado);
            this.panel1.Controls.Add(this.tModelo);
            this.panel1.Controls.Add(this.gbCantidad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 444);
            this.panel1.TabIndex = 8;
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(14, 79);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(48, 16);
            this.lMarca.TabIndex = 9;
            this.lMarca.Text = "Marca:";
            // 
            // tMarca
            // 
            this.tMarca.Location = new System.Drawing.Point(17, 98);
            this.tMarca.Name = "tMarca";
            this.tMarca.Size = new System.Drawing.Size(258, 22);
            this.tMarca.TabIndex = 8;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(17, 12);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(87, 49);
            this.bGuardar.TabIndex = 9;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(193, 12);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(82, 49);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.bGuardar);
            this.panel2.Controls.Add(this.bCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 72);
            this.panel2.TabIndex = 11;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(324, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAgregar";
            this.Text = "Agregar / Modificar";
            this.gbMazo.ResumeLayout(false);
            this.gbMazo.PerformLayout();
            this.gbAcabado.ResumeLayout(false);
            this.gbAcabado.PerformLayout();
            this.gbCantidad.ResumeLayout(false);
            this.gbCantidad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMazo;
        private System.Windows.Forms.RadioButton rbEspañol;
        private System.Windows.Forms.RadioButton rbFrances;
        private System.Windows.Forms.CheckBox chEspeciales;
        private System.Windows.Forms.GroupBox gbAcabado;
        private System.Windows.Forms.RadioButton rbPlastic;
        private System.Windows.Forms.RadioButton rbSmooth;
        private System.Windows.Forms.RadioButton rbAirCushion;
        private System.Windows.Forms.GroupBox gbCantidad;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.TextBox tModelo;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.DateTimePicker dtLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.TextBox tMarca;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}