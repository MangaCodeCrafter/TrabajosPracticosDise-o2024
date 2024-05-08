using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectanguloApp
{
    public partial class fRectangulo : Form
    {        
        int cantidad;
        Rectangulo[] aRectangulos;
        int cantidadMaxima;
        public fRectangulo()
        {
            InitializeComponent();
            cantidad = 0;
            cantidadMaxima = 10;
            aRectangulos = new Rectangulo[cantidadMaxima];
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (!mtBase.MaskCompleted)
            {
                MessageBox.Show("Completar campo base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtBase.Focus();
            }
            else if (!mtAltura.MaskCompleted)
            {
                MessageBox.Show("Completar campo altura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtAltura.Focus();
            }
            else
            {
                double bace = Convert.ToDouble(mtBase.Text);
                double altura = Convert.ToDouble(mtAltura.Text);
                Rectangulo rectangulo = new Rectangulo(bace, altura);

                if (cantidad > 0 && seRepite(rectangulo))
                {
                    DialogResult result = MessageBox.Show("El rectangulo ya existe, querés agregarlo igual?", "Información", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    
                    if (result == DialogResult.Yes)
                    {
                        agregarOrdenado(rectangulo);
                    }
                }
                else agregarOrdenado(rectangulo);
            }
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex > -1)
            {
                int indexElemento = lbRectangulos.SelectedIndex;
                MessageBox.Show($"El area es de {aRectangulos[indexElemento].getArea()} cm^2", "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tenes que seleccionar un rectángulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex > -1)
            {
                int indexElemento = lbRectangulos.SelectedIndex;
                MessageBox.Show($"El area es de {aRectangulos[indexElemento].getPerimetro()} cm", "Perímetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tenes que seleccionar un rectángulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bActualizarBase_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rectangulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mtCambiarBase.MaskCompleted)
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indexElemento = lbRectangulos.SelectedIndex;
                Rectangulo rectangulo = new Rectangulo(Convert.ToDouble(mtCambiarBase.Text), aRectangulos[indexElemento].getAltura());

                if (cantidad > 0 && seRepite(rectangulo))
                {
                    DialogResult result = MessageBox.Show("El rectangulo ya existe, querés cambiarlo igual?", "Información", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        eliminar(lbRectangulos.SelectedIndex);
                        agregarOrdenado(rectangulo);
                    }

                }
                else
                {
                    eliminar(lbRectangulos.SelectedIndex);
                    agregarOrdenado(rectangulo);
                }
            }
        }

        private void bActualizarAltura_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rectangulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mtCambiarAltura.MaskCompleted)
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indexElemento = lbRectangulos.SelectedIndex;
                Rectangulo rectangulo = new Rectangulo(aRectangulos[indexElemento].getBase(), Convert.ToDouble(mtCambiarAltura.Text));

                if (cantidad > 0 && seRepite(rectangulo))
                {
                    DialogResult result = MessageBox.Show("El rectangulo ya existe, querés cambiarlo igual?", "Información", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        eliminar(lbRectangulos.SelectedIndex);
                        agregarOrdenado(rectangulo);
                    }

                }
                else
                {
                    eliminar(lbRectangulos.SelectedIndex);
                    agregarOrdenado(rectangulo);
                }
            }

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex < 0)
            {
                MessageBox.Show("Tienes que seleccionar un rectangulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminar(lbRectangulos.SelectedIndex);
                lMayorRectangulo.Text = (cantidad == 0) ? "-" : $"{aRectangulos[cantidad - 1].getPerimetro()}";
            }
        }

        private void bListarCuad_Click(object sender, EventArgs e)
        {
            string listaCuadrados = "";

            for (int i = 0; i < cantidad; i++)
            {
                if (aRectangulos[i].esCuadrado())
                {
                    listaCuadrados += $"Base:{aRectangulos[i].getBase()} cm – Altura: {aRectangulos[i].getAltura()} cm \n";
                }
            }
            if (listaCuadrados != "")
            {
                MessageBox.Show(listaCuadrados, "Listado de cuadrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existe ningun cuadrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void limpiarCampos()
        {
            mtAltura.Clear();
            mtBase.Clear();
            mtCambiarAltura.Clear();
            mtCambiarBase.Clear();
        }
        private void agregarOrdenado(Rectangulo rectangulo)
        {
            if (cantidad == cantidadMaxima)
            {
                redimensionar();
            }
            if(cantidad < cantidadMaxima)
            {
            int i = cantidad - 1;

            while ((i >= 0) && (rectangulo.getPerimetro() < aRectangulos[i].getPerimetro()))
            {
                aRectangulos[i + 1] = aRectangulos[i];
                i--;
            }
            aRectangulos[i + 1] = rectangulo;
            cantidad++;

            agregarAlList();

            limpiarCampos();
            mostrarMaximo();
            }
        }
        private void agregarAlList()
        {
            lbRectangulos.Items.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                lbRectangulos.Items.Add(aRectangulos[i].mostrar());
            }
        }

        private bool seRepite(Rectangulo rectangulo)
        {
            bool existe = false;

            for (int i = 0; cantidad > i; i++)
            {
                if (aRectangulos[i].esIgualA(rectangulo)) existe = true;
            }

            return existe;
        }

        private void mostrarMaximo()
        {
            lMayorRectangulo.Text = $"{aRectangulos[cantidad - 1].getPerimetro()}";
        }

        private void eliminar( int indexElemento) 
        {
            // Eliminar del ListBox
            lbRectangulos.Items.RemoveAt(indexElemento);

            // Eliminar del arreglo
            for (int i = indexElemento; i < cantidad - 1; i++)
            {
                aRectangulos[i] = aRectangulos[i + 1];
            }
            cantidad--;
            lCantidad.Text = cantidad.ToString();

        }

        private void redimensionar()
        {
            cantidadMaxima += 20;
            Rectangulo[] auxiliar = new Rectangulo[cantidadMaxima];

            for (int i = 0; i < cantidad; i++)
            {
                auxiliar[i] = aRectangulos[i];
            }

            aRectangulos = auxiliar;
        }
    }
}