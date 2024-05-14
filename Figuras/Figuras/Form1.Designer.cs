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
            this.gbCirculo = new System.Windows.Forms.GroupBox();
            this.gbCuadrado = new System.Windows.Forms.GroupBox();
            this.gbTriangulo = new System.Windows.Forms.GroupBox();
            this.gbRectangulo = new System.Windows.Forms.GroupBox();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.lbFiguras = new System.Windows.Forms.ListBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lRadio = new System.Windows.Forms.Label();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.tLadoCuadrado = new System.Windows.Forms.TextBox();
            this.lLadoCuadrado = new System.Windows.Forms.Label();
            this.lBaseTriangulo = new System.Windows.Forms.Label();
            this.lAlturaTriangulo = new System.Windows.Forms.Label();
            this.lLado1Triangulo = new System.Windows.Forms.Label();
            this.lLado2Triangulo = new System.Windows.Forms.Label();
            this.tBaseTriangulo = new System.Windows.Forms.TextBox();
            this.tAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.tLado1Triangulo = new System.Windows.Forms.TextBox();
            this.tLado2Triangulo = new System.Windows.Forms.TextBox();
            this.tBaseRectangulo = new System.Windows.Forms.TextBox();
            this.tAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.lBaseRectangulo = new System.Windows.Forms.Label();
            this.lAlturaRectangulo = new System.Windows.Forms.Label();
            this.pFigura.SuspendLayout();
            this.gbFigura.SuspendLayout();
            this.gbCirculo.SuspendLayout();
            this.gbCuadrado.SuspendLayout();
            this.gbTriangulo.SuspendLayout();
            this.gbRectangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFigura
            // 
            this.pFigura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pFigura.Controls.Add(this.gbFigura);
            this.pFigura.Controls.Add(this.bAgregar);
            this.pFigura.Location = new System.Drawing.Point(13, 12);
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
            this.gbFigura.Name = "gbFigura";
            this.gbFigura.Size = new System.Drawing.Size(152, 135);
            this.gbFigura.TabIndex = 1;
            this.gbFigura.TabStop = false;
            this.gbFigura.Text = "Figura";
            // 
            // gbCirculo
            // 
            this.gbCirculo.Controls.Add(this.tRadio);
            this.gbCirculo.Controls.Add(this.lRadio);
            this.gbCirculo.Location = new System.Drawing.Point(475, 38);
            this.gbCirculo.Name = "gbCirculo";
            this.gbCirculo.Size = new System.Drawing.Size(167, 139);
            this.gbCirculo.TabIndex = 2;
            this.gbCirculo.TabStop = false;
            this.gbCirculo.Text = "Circulo";
            // 
            // gbCuadrado
            // 
            this.gbCuadrado.Controls.Add(this.tLadoCuadrado);
            this.gbCuadrado.Controls.Add(this.lLadoCuadrado);
            this.gbCuadrado.Location = new System.Drawing.Point(656, 38);
            this.gbCuadrado.Name = "gbCuadrado";
            this.gbCuadrado.Size = new System.Drawing.Size(167, 139);
            this.gbCuadrado.TabIndex = 0;
            this.gbCuadrado.TabStop = false;
            this.gbCuadrado.Text = "Cuadrado";
            // 
            // gbTriangulo
            // 
            this.gbTriangulo.Controls.Add(this.tBaseTriangulo);
            this.gbTriangulo.Controls.Add(this.tAlturaTriangulo);
            this.gbTriangulo.Controls.Add(this.tLado1Triangulo);
            this.gbTriangulo.Controls.Add(this.tLado2Triangulo);
            this.gbTriangulo.Controls.Add(this.lBaseTriangulo);
            this.gbTriangulo.Controls.Add(this.lAlturaTriangulo);
            this.gbTriangulo.Controls.Add(this.lLado1Triangulo);
            this.gbTriangulo.Controls.Add(this.lLado2Triangulo);
            this.gbTriangulo.Location = new System.Drawing.Point(475, 193);
            this.gbTriangulo.Name = "gbTriangulo";
            this.gbTriangulo.Size = new System.Drawing.Size(167, 139);
            this.gbTriangulo.TabIndex = 0;
            this.gbTriangulo.TabStop = false;
            this.gbTriangulo.Text = "Triangulo";
            // 
            // gbRectangulo
            // 
            this.gbRectangulo.Controls.Add(this.lAlturaRectangulo);
            this.gbRectangulo.Controls.Add(this.lBaseRectangulo);
            this.gbRectangulo.Controls.Add(this.tAlturaRectangulo);
            this.gbRectangulo.Controls.Add(this.tBaseRectangulo);
            this.gbRectangulo.Location = new System.Drawing.Point(656, 193);
            this.gbRectangulo.Name = "gbRectangulo";
            this.gbRectangulo.Size = new System.Drawing.Size(167, 139);
            this.gbRectangulo.TabIndex = 0;
            this.gbRectangulo.TabStop = false;
            this.gbRectangulo.Text = "Rectangulo";
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(6, 21);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(69, 20);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Ciruclo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(6, 47);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(88, 20);
            this.rbCuadrado.TabIndex = 1;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(6, 73);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(85, 20);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(6, 99);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(97, 20);
            this.rbRectangulo.TabIndex = 3;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // lbFiguras
            // 
            this.lbFiguras.FormattingEnabled = true;
            this.lbFiguras.ItemHeight = 16;
            this.lbFiguras.Location = new System.Drawing.Point(12, 242);
            this.lbFiguras.Name = "lbFiguras";
            this.lbFiguras.Size = new System.Drawing.Size(314, 148);
            this.lbFiguras.TabIndex = 4;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(320, 161);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 50);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(333, 263);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 50);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Area";
            this.bArea.UseVisualStyleBackColor = true;
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(333, 319);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 50);
            this.bPerimetro.TabIndex = 7;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(333, 415);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 50);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Location = new System.Drawing.Point(6, 71);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(44, 16);
            this.lRadio.TabIndex = 0;
            this.lRadio.Text = "Radio";
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(56, 68);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(100, 22);
            this.tRadio.TabIndex = 1;
            // 
            // tLadoCuadrado
            // 
            this.tLadoCuadrado.Location = new System.Drawing.Point(56, 57);
            this.tLadoCuadrado.Name = "tLadoCuadrado";
            this.tLadoCuadrado.Size = new System.Drawing.Size(100, 22);
            this.tLadoCuadrado.TabIndex = 2;
            // 
            // lLadoCuadrado
            // 
            this.lLadoCuadrado.AutoSize = true;
            this.lLadoCuadrado.Location = new System.Drawing.Point(6, 63);
            this.lLadoCuadrado.Name = "lLadoCuadrado";
            this.lLadoCuadrado.Size = new System.Drawing.Size(38, 16);
            this.lLadoCuadrado.TabIndex = 3;
            this.lLadoCuadrado.Text = "Lado";
            // 
            // lBaseTriangulo
            // 
            this.lBaseTriangulo.AutoSize = true;
            this.lBaseTriangulo.Location = new System.Drawing.Point(9, 27);
            this.lBaseTriangulo.Name = "lBaseTriangulo";
            this.lBaseTriangulo.Size = new System.Drawing.Size(39, 16);
            this.lBaseTriangulo.TabIndex = 8;
            this.lBaseTriangulo.Text = "Base";
            // 
            // lAlturaTriangulo
            // 
            this.lAlturaTriangulo.AutoSize = true;
            this.lAlturaTriangulo.Location = new System.Drawing.Point(9, 55);
            this.lAlturaTriangulo.Name = "lAlturaTriangulo";
            this.lAlturaTriangulo.Size = new System.Drawing.Size(41, 16);
            this.lAlturaTriangulo.TabIndex = 9;
            this.lAlturaTriangulo.Text = "Altura";
            // 
            // lLado1Triangulo
            // 
            this.lLado1Triangulo.AutoSize = true;
            this.lLado1Triangulo.Location = new System.Drawing.Point(9, 83);
            this.lLado1Triangulo.Name = "lLado1Triangulo";
            this.lLado1Triangulo.Size = new System.Drawing.Size(48, 16);
            this.lLado1Triangulo.TabIndex = 10;
            this.lLado1Triangulo.Text = "Lado 1";
            // 
            // lLado2Triangulo
            // 
            this.lLado2Triangulo.AutoSize = true;
            this.lLado2Triangulo.Location = new System.Drawing.Point(9, 112);
            this.lLado2Triangulo.Name = "lLado2Triangulo";
            this.lLado2Triangulo.Size = new System.Drawing.Size(48, 16);
            this.lLado2Triangulo.TabIndex = 11;
            this.lLado2Triangulo.Text = "Lado 2";
            // 
            // tBaseTriangulo
            // 
            this.tBaseTriangulo.Location = new System.Drawing.Point(56, 21);
            this.tBaseTriangulo.Name = "tBaseTriangulo";
            this.tBaseTriangulo.Size = new System.Drawing.Size(100, 22);
            this.tBaseTriangulo.TabIndex = 2;
            // 
            // tAlturaTriangulo
            // 
            this.tAlturaTriangulo.Location = new System.Drawing.Point(56, 49);
            this.tAlturaTriangulo.Name = "tAlturaTriangulo";
            this.tAlturaTriangulo.Size = new System.Drawing.Size(100, 22);
            this.tAlturaTriangulo.TabIndex = 3;
            // 
            // tLado1Triangulo
            // 
            this.tLado1Triangulo.Location = new System.Drawing.Point(56, 77);
            this.tLado1Triangulo.Name = "tLado1Triangulo";
            this.tLado1Triangulo.Size = new System.Drawing.Size(100, 22);
            this.tLado1Triangulo.TabIndex = 4;
            // 
            // tLado2Triangulo
            // 
            this.tLado2Triangulo.Location = new System.Drawing.Point(56, 106);
            this.tLado2Triangulo.Name = "tLado2Triangulo";
            this.tLado2Triangulo.Size = new System.Drawing.Size(100, 22);
            this.tLado2Triangulo.TabIndex = 5;
            // 
            // tBaseRectangulo
            // 
            this.tBaseRectangulo.Location = new System.Drawing.Point(56, 52);
            this.tBaseRectangulo.Name = "tBaseRectangulo";
            this.tBaseRectangulo.Size = new System.Drawing.Size(100, 22);
            this.tBaseRectangulo.TabIndex = 0;
            // 
            // tAlturaRectangulo
            // 
            this.tAlturaRectangulo.Location = new System.Drawing.Point(56, 81);
            this.tAlturaRectangulo.Name = "tAlturaRectangulo";
            this.tAlturaRectangulo.Size = new System.Drawing.Size(100, 22);
            this.tAlturaRectangulo.TabIndex = 1;
            // 
            // lBaseRectangulo
            // 
            this.lBaseRectangulo.AutoSize = true;
            this.lBaseRectangulo.Location = new System.Drawing.Point(6, 55);
            this.lBaseRectangulo.Name = "lBaseRectangulo";
            this.lBaseRectangulo.Size = new System.Drawing.Size(39, 16);
            this.lBaseRectangulo.TabIndex = 2;
            this.lBaseRectangulo.Text = "Base";
            // 
            // lAlturaRectangulo
            // 
            this.lAlturaRectangulo.AutoSize = true;
            this.lAlturaRectangulo.Location = new System.Drawing.Point(6, 87);
            this.lAlturaRectangulo.Name = "lAlturaRectangulo";
            this.lAlturaRectangulo.Size = new System.Drawing.Size(41, 16);
            this.lAlturaRectangulo.TabIndex = 3;
            this.lAlturaRectangulo.Text = "Altura";
            // 
            // fFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 501);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.gbCirculo);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbFiguras);
            this.Controls.Add(this.gbCuadrado);
            this.Controls.Add(this.gbRectangulo);
            this.Controls.Add(this.gbTriangulo);
            this.Controls.Add(this.pFigura);
            this.Name = "fFiguras";
            this.Text = "Figuras";
            this.Load += new System.EventHandler(this.fFiguras_Load);
            this.pFigura.ResumeLayout(false);
            this.gbFigura.ResumeLayout(false);
            this.gbFigura.PerformLayout();
            this.gbCirculo.ResumeLayout(false);
            this.gbCirculo.PerformLayout();
            this.gbCuadrado.ResumeLayout(false);
            this.gbCuadrado.PerformLayout();
            this.gbTriangulo.ResumeLayout(false);
            this.gbTriangulo.PerformLayout();
            this.gbRectangulo.ResumeLayout(false);
            this.gbRectangulo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox tAlturaTriangulo;
        private System.Windows.Forms.TextBox tLado1Triangulo;
        private System.Windows.Forms.TextBox tLado2Triangulo;
        private System.Windows.Forms.Label lBaseTriangulo;
        private System.Windows.Forms.Label lAlturaTriangulo;
        private System.Windows.Forms.Label lLado1Triangulo;
        private System.Windows.Forms.Label lLado2Triangulo;
        private System.Windows.Forms.Label lAlturaRectangulo;
        private System.Windows.Forms.Label lBaseRectangulo;
        private System.Windows.Forms.TextBox tAlturaRectangulo;
        private System.Windows.Forms.TextBox tBaseRectangulo;
    }
}

