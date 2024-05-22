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
            actualizarPantalla();
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuadrado.Checked) gbCuadrado.Visible = true;
            else gbCuadrado.Visible = false;
            actualizarPantalla();
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked) gbTriangulo.Visible = true;
            else gbTriangulo.Visible = false;
            actualizarPantalla();
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangulo.Checked) gbRectangulo.Visible = true;
            else gbRectangulo.Visible = false;
            actualizarPantalla();
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

            else if (rbTriangulo.Checked && Triangulo.esValido(Convert.ToDouble(tBaseTriangulo.Text), Convert.ToDouble(tAlturaTriangulo.Text), Convert.ToDouble(tLado1Triangulo.Text), Convert.ToDouble(tLado2Triangulo.Text))) 
                MessageBox.Show("El triángulo no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (rbRectangulo.Checked && tBaseRectangulo.Text.Trim() == "") mensajeError(tBaseRectangulo);
            else if (rbRectangulo.Checked && !tBaseRectangulo.Text.All(char.IsDigit)) mensajeError(tBaseRectangulo);

            else if (rbRectangulo.Checked && tAlturaRectangulo.Text.Trim() == "") mensajeError(tAlturaRectangulo);
            else if (rbRectangulo.Checked && !tAlturaRectangulo.Text.All(char.IsDigit)) mensajeError(tAlturaRectangulo);

            else if (rbCirculo.Checked)
            {
                Circulo circulo = new Circulo(Convert.ToDouble(tRadio.Text));
                lFiguras.Add(circulo);
                actualizarPantalla();
                tRadio.Clear(); tLadoCuadrado.Clear(); tAlturaRectangulo.Clear(); tBaseRectangulo.Clear(); tBaseTriangulo.Clear(); tAlturaTriangulo.Clear(); tLado1Triangulo.Clear(); tLado2Triangulo.Clear();
            }
            else if (rbCuadrado.Checked)
            {
                Cuadrado cuadrado = new Cuadrado(Convert.ToDouble(tLadoCuadrado.Text));
                lFiguras.Add(cuadrado);
                actualizarPantalla();
                tRadio.Clear(); tLadoCuadrado.Clear(); tAlturaRectangulo.Clear(); tBaseRectangulo.Clear(); tBaseTriangulo.Clear(); tAlturaTriangulo.Clear(); tLado1Triangulo.Clear(); tLado2Triangulo.Clear();
            }
            else if (rbRectangulo.Checked)
            {
                Rectangulo rectangulo = new Rectangulo(Convert.ToDouble(tBaseRectangulo.Text), Convert.ToDouble(tAlturaRectangulo.Text));
                lFiguras.Add(rectangulo);
                actualizarPantalla();
                tRadio.Clear(); tLadoCuadrado.Clear(); tAlturaRectangulo.Clear(); tBaseRectangulo.Clear(); tBaseTriangulo.Clear(); tAlturaTriangulo.Clear(); tLado1Triangulo.Clear(); tLado2Triangulo.Clear();
            }
            else if (rbTriangulo.Checked)
            {
                Triangulo triangulo = new Triangulo(Convert.ToDouble(tBaseTriangulo.Text), Convert.ToDouble(tAlturaTriangulo.Text), Convert.ToDouble(tLado1Triangulo.Text), Convert.ToDouble(tLado2Triangulo.Text));
                lFiguras.Add(triangulo);
                actualizarPantalla();
                tRadio.Clear(); tLadoCuadrado.Clear(); tAlturaRectangulo.Clear(); tBaseRectangulo.Clear(); tBaseTriangulo.Clear(); tAlturaTriangulo.Clear(); tLado1Triangulo.Clear(); tLado2Triangulo.Clear();
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

        private void actualizarPantalla()
        {
            lbFiguras.Items.Clear();
            string figura = "rectangulos";

            for(int i = 0; i < lFiguras.Count; i++)
            {
                if(rbCirculo.Checked && lFiguras[i].GetType() == typeof(Circulo)) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbCuadrado.Checked && lFiguras[i].GetType() == typeof(Cuadrado)) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbTriangulo.Checked && lFiguras[i].GetType() == typeof(Triangulo)) lbFiguras.Items.Add(lFiguras[i].mostrar());                
                if(rbRectangulo.Checked && lFiguras[i].GetType() == typeof(Rectangulo)) lbFiguras.Items.Add(lFiguras[i].mostrar());
            }

            if (rbCirculo.Checked) figura = "circulos";
            if (rbCuadrado.Checked) figura = "cuadrados";
            if (rbTriangulo.Checked) figura = "triangulos";

            lCantidadFiguras.Text = $"Cantidad de figuras: {lFiguras.Count}.";
            lCantidadEspecifico.Text = $"Cantidad de {figura}: {lbFiguras.Items.Count}.";
        }

        private Type obtenerTipo()
        {
            Type type = typeof(Circulo);

            if (rbCuadrado.Checked) type = typeof(Cuadrado);
            if (rbTriangulo.Checked) type = typeof(Triangulo);
            if (rbRectangulo.Checked) type = typeof (Rectangulo);

            return type;
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            if (lbFiguras.SelectedIndex < 0) MessageBox.Show("Seleccione una figura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Type tipoSeleccionado = obtenerTipo();
                List<Figura> aux = lFiguras.FindAll(f => f.GetType() == tipoSeleccionado);
                MessageBox.Show($"El área es: {aux[lbFiguras.SelectedIndex].area()}cm²", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            Type tipoSeleccionado = obtenerTipo();
            List<Figura> aux = lFiguras.FindAll(f => f.GetType() == tipoSeleccionado);
            MessageBox.Show($"El perímetro es: {aux[lbFiguras.SelectedIndex].perimetro()}cm", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
