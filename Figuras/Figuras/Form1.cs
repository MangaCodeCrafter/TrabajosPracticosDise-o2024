using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class fFiguras : Form
    {
        List<Figura> lFiguras;
        public fFiguras()
        {
            InitializeComponent();
            lFiguras = new List<Figura>();
        }
        #region radioButtons
        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirculo.Checked) gbCirculo.Visible = true;
            else gbCirculo.Visible = false;
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuadrado.Checked) gbCuadrado.Visible = true;
            else gbCuadrado.Visible = false;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked) gbTriangulo.Visible = true;
            else gbTriangulo.Visible = false;
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangulo.Checked) gbRectangulo.Visible = true;
            else gbRectangulo.Visible = false;
        }
        #endregion
        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (rbCirculo.Checked && tRadio.Text.Trim() == "") mensajeError(tRadio);
            else if (rbCirculo.Checked && !tRadio.Text.All(char.IsDigit)) mensajeError(tRadio);

            else if (rbCuadrado.Checked && tLadoCuadrado.Text.Trim() == "") mensajeError(tLadoCuadrado);
            else if (rbCuadrado.Checked && !tLadoCuadrado.Text.All(char.IsDigit)) mensajeError(tLadoCuadrado);

            else if (rbTriangulo.Checked && tLado1Triangulo.Text.Trim() == "") mensajeError(tLado1Triangulo);
            else if (rbTriangulo.Checked && !tLado1Triangulo.Text.All(char.IsDigit)) mensajeError(tLado1Triangulo);

            else if (rbTriangulo.Checked && tLado2Triangulo.Text.Trim() == "") mensajeError(tLado2Triangulo);
            else if (rbTriangulo.Checked && !tLado2Triangulo.Text.All(char.IsDigit)) mensajeError(tLado2Triangulo);

            else if (rbTriangulo.Checked && tBaseTriangulo.Text.Trim() == "") mensajeError(tBaseTriangulo);
            else if (rbTriangulo.Checked && !tBaseTriangulo.Text.All(char.IsDigit)) mensajeError(tBaseTriangulo);

            else if (rbTriangulo.Checked && tAlturaTriangulo.Text.Trim() == "") mensajeError(tAlturaTriangulo);
            else if (rbTriangulo.Checked && !tAlturaTriangulo.Text.All(char.IsDigit)) mensajeError(tAlturaTriangulo);

            else if (rbRectangulo.Checked && tBaseRectangulo.Text.Trim() == "") mensajeError(tBaseRectangulo);
            else if (rbRectangulo.Checked && !tBaseRectangulo.Text.All(char.IsDigit)) mensajeError(tBaseRectangulo);

            else if (rbRectangulo.Checked && tAlturaRectangulo.Text.Trim() == "") mensajeError(tAlturaRectangulo);
            else if (rbRectangulo.Checked && !tAlturaRectangulo.Text.All(char.IsDigit)) mensajeError(tAlturaRectangulo);

            else if (rbCirculo.Checked)
            {
                Circulo circulo = new Circulo(Convert.ToDouble(tRadio.Text));
                lFiguras.Add(circulo);
                actualizarPantalla(rbCirculo, circulo);
            }
            else if (rbCuadrado.Checked)
            {
                Cuadrado cuadrado = new Cuadrado(Convert.ToDouble(tLadoCuadrado.Text));
                lFiguras.Add(cuadrado);
                actualizarPantalla(rbCuadrado, cuadrado);
            }
            else if (rbRectangulo.Checked)
            {
                Rectangulo rectangulo = new Rectangulo(Convert.ToDouble(tBaseRectangulo.Text), Convert.ToDouble(tAlturaRectangulo.Text));
                lFiguras.Add(rectangulo);
                actualizarPantalla(rbRectangulo, rectangulo);
            }
            else if (rbTriangulo.Checked)
            {

            }

        }

        private void mensajeError(TextBox t)
        {
            if(t.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Focus();
            }
            else
            {
                MessageBox.Show("Solo ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Focus();
            }
        }

        private void actualizarPantalla(RadioButton rb, Figura figura)
        {
            lbFiguras.Items.Clear();

            for(int i = 0; i < lFiguras.Count; i++)
            {
                if(rbCirculo.Checked && lFiguras[i].GetType() == figura.GetType()) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbCuadrado.Checked && lFiguras[i].GetType() == figura.GetType()) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbTriangulo.Checked && lFiguras[i].GetType() == figura.GetType()) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbRectangulo.Checked && lFiguras[i].GetType() == figura.GetType()) lbFiguras.Items.Add(lFiguras[i].mostrar());
            }
        }
    }
}
