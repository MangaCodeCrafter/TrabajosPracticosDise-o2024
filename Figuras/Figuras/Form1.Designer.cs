namespace Figuras
{
    partial class fFiguras
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
            this.pFigura = new System.Windows.Forms.Panel();
            this.gbFigura = new System.Windows.Forms.GroupBox();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.bAgregar = new System.Windows.Forms.Button();
            this.gbRectangulo = new System.Windows.Forms.GroupBox();
            this.lAlturaRectangulo = new System.Windows.Forms.Label();
            this.lBaseRectangulo = new System.Windows.Forms.Label();
            this.tAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.tBaseRectangulo = new System.Windows.Forms.TextBox();
            this.gbTriangulo = new System.Windows.Forms.GroupBox();
            this.lAlturaTriangulo = new System.Windows.Forms.Label();
            this.tAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.tBaseTriangulo = new System.Windows.Forms.TextBox();
            this.tLado1Triangulo = new System.Windows.Forms.TextBox();
            this.tLado2Triangulo = new System.Windows.Forms.TextBox();
            this.lBaseTriangulo = new System.Windows.Forms.Label();
            this.lLado1Triangulo = new System.Windows.Forms.Label();
            this.lLado2Triangulo = new System.Windows.Forms.Label();
            this.gbCuadrado = new System.Windows.Forms.GroupBox();
            this.tLadoCuadrado = new System.Windows.Forms.TextBox();
            this.lLadoCuadrado = new System.Windows.Forms.Label();
            this.gbCirculo = new System.Windows.Forms.GroupBox();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.lRadio = new System.Windows.Forms.Label();
            this.lbFiguras = new System.Windows.Forms.ListBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lCantidadEspecifico = new System.Windows.Forms.Label();
            this.lCantidadFiguras = new System.Windows.Forms.Label();
            this.pFigura.SuspendLayout();
            this.gbFigura.SuspendLayout();
            this.gbRectangulo.SuspendLayout();
            this.gbTriangulo.SuspendLayout();
            this.gbCuadrado.SuspendLayout();
            this.gbCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFigura
            // 
            this.pFigura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pFigura.Controls.Add(this.gbFigura);
            this.pFigura.Controls.Add(this.bAgregar);
            this.pFigura.Controls.Add(this.gbRectangulo);
            this.pFigura.Controls.Add(this.gbTriangulo);
            this.pFigura.Controls.Add(this.gbCuadrado);
            this.pFigura.Controls.Add(this.gbCirculo);
            this.pFigura.Location = new System.Drawing.Point(13, 12);
            this.pFigura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pFigura.Name = "pFigura";
            this.pFigura.Size = new System.Drawing.Size(407, 224);
            this.pFigura.TabIndex = 0;
            // 
            // gbFigura
            // 
            this.gbFigura.Controls.Add(this.rbCirculo);
            this.gbFigura.Controls.Add(this.rbCuadrado);
            this.gbFigura.Controls.Add(this.rbTriangulo);
            this.gbFigura.Controls.Add(this.rbRectangulo);
            this.gbFigura.Location = new System.Drawing.Point(13, 16);
            this.gbFigura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFigura.Name = "gbFigura";
            this.gbFigura.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFigura.Size = new System.Drawing.Size(152, 135);
            this.gbFigura.TabIndex = 1;
            this.gbFigura.TabStop = false;
            this.gbFigura.Text = "Figura";
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(5, 21);
            this.rbCirculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(69, 20);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.Text = "Ciruclo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Checked = true;
            this.rbCuadrado.Location = new System.Drawing.Point(5, 47);
            this.rbCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(88, 20);
            this.rbCuadrado.TabIndex = 1;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            this.rbCuadrado.CheckedChanged += new System.EventHandler(this.rbCuadrado_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(5, 73);
            this.rbTriangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(85, 20);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(5, 98);
            this.rbRectangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(97, 20);
            this.rbRectangulo.TabIndex = 3;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbRectangulo_CheckedChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(320, 161);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 50);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // gbRectangulo
            // 
            this.gbRectangulo.Controls.Add(this.lAlturaRectangulo);
            this.gbRectangulo.Controls.Add(this.lBaseRectangulo);
            this.gbRectangulo.Controls.Add(this.tAlturaRectangulo);
            this.gbRectangulo.Controls.Add(this.tBaseRectangulo);
            this.gbRectangulo.Location = new System.Drawing.Point(228, 12);
            this.gbRectangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRectangulo.Name = "gbRectangulo";
            this.gbRectangulo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRectangulo.Size = new System.Drawing.Size(167, 139);
            this.gbRectangulo.TabIndex = 0;
            this.gbRectangulo.TabStop = false;
            this.gbRectangulo.Text = "Rectangulo";
            this.gbRectangulo.Visible = false;
            // 
            // lAlturaRectangulo
            // 
            this.lAlturaRectangulo.AutoSize = true;
            this.lAlturaRectangulo.Location = new System.Drawing.Point(5, 87);
            this.lAlturaRectangulo.Name = "lAlturaRectangulo";
            this.lAlturaRectangulo.Size = new System.Drawing.Size(41, 16);
            this.lAlturaRectangulo.TabIndex = 3;
            this.lAlturaRectangulo.Text = "Altura";
            // 
            // lBaseRectangulo
            // 
            this.lBaseRectangulo.AutoSize = true;
            this.lBaseRectangulo.Location = new System.Drawing.Point(5, 55);
            this.lBaseRectangulo.Name = "lBaseRectangulo";
            this.lBaseRectangulo.Size = new System.Drawing.Size(39, 16);
            this.lBaseRectangulo.TabIndex = 2;
            this.lBaseRectangulo.Text = "Base";
            // 
            // tAlturaRectangulo
            // 
            this.tAlturaRectangulo.Location = new System.Drawing.Point(56, 81);
            this.tAlturaRectangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tAlturaRectangulo.Name = "tAlturaRectangulo";
            this.tAlturaRectangulo.Size = new System.Drawing.Size(100, 22);
            this.tAlturaRectangulo.TabIndex = 1;
            // 
            // tBaseRectangulo
            // 
            this.tBaseRectangulo.Location = new System.Drawing.Point(56, 52);
            this.tBaseRectangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBaseRectangulo.Name = "tBaseRectangulo";
            this.tBaseRectangulo.Size = new System.Drawing.Size(100, 22);
            this.tBaseRectangulo.TabIndex = 0;
            // 
            // gbTriangulo
            // 
            this.gbTriangulo.Controls.Add(this.lAlturaTriangulo);
            this.gbTriangulo.Controls.Add(this.tAlturaTriangulo);
            this.gbTriangulo.Controls.Add(this.tBaseTriangulo);
            this.gbTriangulo.Controls.Add(this.tLado1Triangulo);
            this.gbTriangulo.Controls.Add(this.tLado2Triangulo);
            this.gbTriangulo.Controls.Add(this.lBaseTriangulo);
            this.gbTriangulo.Controls.Add(this.lLado1Triangulo);
            this.gbTriangulo.Controls.Add(this.lLado2Triangulo);
            this.gbTriangulo.Location = new System.Drawing.Point(228, 12);
            this.gbTriangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTriangulo.Name = "gbTriangulo";
            this.gbTriangulo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTriangulo.Size = new System.Drawing.Size(167, 139);
            this.gbTriangulo.TabIndex = 0;
            this.gbTriangulo.TabStop = false;
            this.gbTriangulo.Text = "Triangulo";
            this.gbTriangulo.Visible = false;
            // 
            // lAlturaTriangulo
            // 
            this.lAlturaTriangulo.AutoSize = true;
            this.lAlturaTriangulo.Location = new System.Drawing.Point(5, 108);
            this.lAlturaTriangulo.Name = "lAlturaTriangulo";
            this.lAlturaTriangulo.Size = new System.Drawing.Size(41, 16);
            this.lAlturaTriangulo.TabIndex = 10;
            this.lAlturaTriangulo.Text = "Altura";
            // 
            // tAlturaTriangulo
            // 
            this.tAlturaTriangulo.Location = new System.Drawing.Point(56, 105);
            this.tAlturaTriangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tAlturaTriangulo.Name = "tAlturaTriangulo";
            this.tAlturaTriangulo.Size = new System.Drawing.Size(100, 22);
            this.tAlturaTriangulo.TabIndex = 10;
            // 
            // tBaseTriangulo
            // 
            this.tBaseTriangulo.Location = new System.Drawing.Point(56, 78);
            this.tBaseTriangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBaseTriangulo.Name = "tBaseTriangulo";
            this.tBaseTriangulo.Size = new System.Drawing.Size(100, 22);
            this.tBaseTriangulo.TabIndex = 2;
            // 
            // tLado1Triangulo
            // 
            this.tLado1Triangulo.Location = new System.Drawing.Point(56, 21);
            this.tLado1Triangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLado1Triangulo.Name = "tLado1Triangulo";
            this.tLado1Triangulo.Size = new System.Drawing.Size(100, 22);
            this.tLado1Triangulo.TabIndex = 4;
            // 
            // tLado2Triangulo
            // 
            this.tLado2Triangulo.Location = new System.Drawing.Point(56, 49);
            this.tLado2Triangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLado2Triangulo.Name = "tLado2Triangulo";
            this.tLado2Triangulo.Size = new System.Drawing.Size(100, 22);
            this.tLado2Triangulo.TabIndex = 5;
            // 
            // lBaseTriangulo
            // 
            this.lBaseTriangulo.AutoSize = true;
            this.lBaseTriangulo.Location = new System.Drawing.Point(11, 80);
            this.lBaseTriangulo.Name = "lBaseTriangulo";
            this.lBaseTriangulo.Size = new System.Drawing.Size(39, 16);
            this.lBaseTriangulo.TabIndex = 8;
            this.lBaseTriangulo.Text = "Base";
            // 
            // lLado1Triangulo
            // 
            this.lLado1Triangulo.AutoSize = true;
            this.lLado1Triangulo.Location = new System.Drawing.Point(2, 27);
            this.lLado1Triangulo.Name = "lLado1Triangulo";
            this.lLado1Triangulo.Size = new System.Drawing.Size(48, 16);
            this.lLado1Triangulo.TabIndex = 10;
            this.lLado1Triangulo.Text = "Lado 1";
            // 
            // lLado2Triangulo
            // 
            this.lLado2Triangulo.AutoSize = true;
            this.lLado2Triangulo.Location = new System.Drawing.Point(2, 55);
            this.lLado2Triangulo.Name = "lLado2Triangulo";
            this.lLado2Triangulo.Size = new System.Drawing.Size(48, 16);
            this.lLado2Triangulo.TabIndex = 11;
            this.lLado2Triangulo.Text = "Lado 2";
            // 
            // gbCuadrado
            // 
            this.gbCuadrado.Controls.Add(this.tLadoCuadrado);
            this.gbCuadrado.Controls.Add(this.lLadoCuadrado);
            this.gbCuadrado.Location = new System.Drawing.Point(228, 12);
            this.gbCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCuadrado.Name = "gbCuadrado";
            this.gbCuadrado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCuadrado.Size = new System.Drawing.Size(167, 139);
            this.gbCuadrado.TabIndex = 0;
            this.gbCuadrado.TabStop = false;
            this.gbCuadrado.Text = "Cuadrado";
            // 
            // tLadoCuadrado
            // 
            this.tLadoCuadrado.Location = new System.Drawing.Point(56, 57);
            this.tLadoCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLadoCuadrado.Name = "tLadoCuadrado";
            this.tLadoCuadrado.Size = new System.Drawing.Size(100, 22);
            this.tLadoCuadrado.TabIndex = 2;
            // 
            // lLadoCuadrado
            // 
            this.lLadoCuadrado.AutoSize = true;
            this.lLadoCuadrado.Location = new System.Drawing.Point(5, 63);
            this.lLadoCuadrado.Name = "lLadoCuadrado";
            this.lLadoCuadrado.Size = new System.Drawing.Size(38, 16);
            this.lLadoCuadrado.TabIndex = 3;
            this.lLadoCuadrado.Text = "Lado";
            // 
            // gbCirculo
            // 
            this.gbCirculo.Controls.Add(this.tRadio);
            this.gbCirculo.Controls.Add(this.lRadio);
            this.gbCirculo.Location = new System.Drawing.Point(228, 12);
            this.gbCirculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCirculo.Name = "gbCirculo";
            this.gbCirculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCirculo.Size = new System.Drawing.Size(167, 139);
            this.gbCirculo.TabIndex = 2;
            this.gbCirculo.TabStop = false;
            this.gbCirculo.Text = "Circulo";
            this.gbCirculo.Visible = false;
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(56, 68);
            this.tRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(100, 22);
            this.tRadio.TabIndex = 1;
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Location = new System.Drawing.Point(5, 71);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(44, 16);
            this.lRadio.TabIndex = 0;
            this.lRadio.Text = "Radio";
            // 
            // lbFiguras
            // 
            this.lbFiguras.FormattingEnabled = true;
            this.lbFiguras.ItemHeight = 16;
            this.lbFiguras.Location = new System.Drawing.Point(12, 242);
            this.lbFiguras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFiguras.Name = "lbFiguras";
            this.lbFiguras.Size = new System.Drawing.Size(313, 148);
            this.lbFiguras.TabIndex = 4;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(333, 263);
            this.bArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(87, 50);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(333, 319);
            this.bPerimetro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(87, 50);
            this.bPerimetro.TabIndex = 7;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(333, 415);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 50);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lCantidadEspecifico
            // 
            this.lCantidadEspecifico.AutoSize = true;
            this.lCantidadEspecifico.Location = new System.Drawing.Point(9, 415);
            this.lCantidadEspecifico.Name = "lCantidadEspecifico";
            this.lCantidadEspecifico.Size = new System.Drawing.Size(164, 16);
            this.lCantidadEspecifico.TabIndex = 8;
            this.lCantidadEspecifico.Text = "Cantidad de cuadrados: 0.";
            // 
            // lCantidadFiguras
            // 
            this.lCantidadFiguras.AutoSize = true;
            this.lCantidadFiguras.Location = new System.Drawing.Point(11, 449);
            this.lCantidadFiguras.Name = "lCantidadFiguras";
            this.lCantidadFiguras.Size = new System.Drawing.Size(139, 16);
            this.lCantidadFiguras.TabIndex = 9;
            this.lCantidadFiguras.Text = "Cantidad de figuras: 0.";
            // 
            // fFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 501);
            this.Controls.Add(this.lCantidadFiguras);
            this.Controls.Add(this.lCantidadEspecifico);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbFiguras);
            this.Controls.Add(this.pFigura);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fFiguras";
            this.Text = "Figuras";
            this.pFigura.ResumeLayout(false);
            this.gbFigura.ResumeLayout(false);
            this.gbFigura.PerformLayout();
            this.gbRectangulo.ResumeLayout(false);
            this.gbRectangulo.PerformLayout();
            this.gbTriangulo.ResumeLayout(false);
            this.gbTriangulo.PerformLayout();
            this.gbCuadrado.ResumeLayout(false);
            this.gbCuadrado.PerformLayout();
            this.gbCirculo.ResumeLayout(false);
            this.gbCirculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pFigura;
        private System.Windows.Forms.GroupBox gbFigura;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.GroupBox gbCirculo;
        private System.Windows.Forms.GroupBox gbCuadrado;
        private System.Windows.Forms.GroupBox gbTriangulo;
        private System.Windows.Forms.GroupBox gbRectangulo;
        private System.Windows.Forms.ListBox lbFiguras;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.Label lRadio;
        private System.Windows.Forms.TextBox tLadoCuadrado;
        private System.Windows.Forms.Label lLadoCuadrado;
        private System.Windows.Forms.TextBox tBaseTriangulo;
        private System.Windows.Forms.TextBox tLado1Triangulo;
        private System.Windows.Forms.TextBox tLado2Triangulo;
        private System.Windows.Forms.Label lBaseTriangulo;
        private System.Windows.Forms.Label lLado1Triangulo;
        private System.Windows.Forms.Label lLado2Triangulo;
        private System.Windows.Forms.Label lAlturaRectangulo;
        private System.Windows.Forms.Label lBaseRectangulo;
        private System.Windows.Forms.TextBox tAlturaRectangulo;
        private System.Windows.Forms.TextBox tBaseRectangulo;
        private System.Windows.Forms.Label lCantidadEspecifico;
        private System.Windows.Forms.Label lCantidadFiguras;
        private System.Windows.Forms.Label lAlturaTriangulo;
        private System.Windows.Forms.TextBox tAlturaTriangulo;
    }
}

