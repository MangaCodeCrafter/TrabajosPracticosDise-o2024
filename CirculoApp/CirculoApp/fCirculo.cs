using System;
using System.Windows.Forms;

namespace CirculoApp
{
    public partial class fCirculo : Form
    {
        private Circulo[] aCirculos;
        public int cantidad;
        int cantidadMaxima;

        public fCirculo()
        {
            InitializeComponent();
            int cantidadMaxima = 10;
            aCirculos = new Circulo[cantidadMaxima];
            cantidad = 0;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            Circulo circulo = (mtRadio.MaskCompleted) ? new Circulo(Convert.ToDouble(mtRadio.Text)) : new Circulo(7);

            if (!mtRadio.MaskCompleted)
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtRadio.Focus();
            }
            else if(cantidad > 0 && seRepite(circulo))
            {
                MessageBox.Show("El circulo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                agregarOrdenado(circulo);
                limpiarCampos();
            }
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            if (lbCirculos.SelectedIndex < 0)
            {
                MessageBox.Show("Tenes que seleccionar un circulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCirculos.Focus();
            }
            else
            {
                int indexElemento = lbCirculos.SelectedIndex;
                MessageBox.Show($"El area es de {aCirculos[indexElemento].getArea()} cm^2", "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            if (lbCirculos.SelectedIndex < 0)
            {
                MessageBox.Show("Tenes que seleccionar un circulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCirculos.Focus();
            }
            else
            {
                int indexElemento = lbCirculos.SelectedIndex;
                MessageBox.Show($"El perímetro es de {aCirculos[indexElemento].getPerimetro()} cm", "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bCambiarRadio_Click(object sender, EventArgs e)
        {
            Circulo circulo = (mtCambiarRadio.MaskCompleted) ? new Circulo(Convert.ToDouble(mtCambiarRadio.Text)) : new Circulo(7);
            int indexElemento = lbCirculos.SelectedIndex;
            if (indexElemento < 0)
            {
                MessageBox.Show("Tenes que seleccionar un círculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCirculos.Focus();
            }
            else if(!mtCambiarRadio.MaskCompleted)
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCambiarRadio.Focus();
            }
            else if(cantidad > 0 && seRepite(circulo))
            {
                MessageBox.Show("El circulo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminar();
                agregarOrdenado(circulo);
                limpiarCampos();

            }
        }

        private void bCambiarDiametro_Click(object sender, EventArgs e)
        {

            Circulo circulo = (mtCambiarDiametro.MaskCompleted) ? new Circulo(Convert.ToDouble(mtCambiarDiametro.Text)/2) : new Circulo(7);
            int indexElemento = lbCirculos.SelectedIndex;

            if (indexElemento < 0)
            {
                MessageBox.Show("Tenes que seleccionar un círculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCirculos.Focus();
            }
            else if (!mtCambiarDiametro.MaskCompleted)
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCambiarDiametro.Focus();
            }
            else if (cantidad > 0 && seRepite(circulo))
            {
                MessageBox.Show("El circulo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminar();
                agregarOrdenado(circulo);
                limpiarCampos();

            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            int indexElemento = lbCirculos.SelectedIndex;
           
            if (indexElemento < 0)
            {
                MessageBox.Show("Tenes que seleccionar un círculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbCirculos.Focus();
            }
            else
            {
                eliminar();
            }
            
        }

        private void limpiarCampos()
        {
            mtRadio.Text = "";
            mtCambiarRadio.Text = "";
            mtCambiarDiametro.Text = "";
            
        }

        private void agregarOrdenado(Circulo circulo)
        {
            if(cantidad == cantidadMaxima)
            {
                redimensionar();
            }
           
            if(cantidad < cantidadMaxima)
            {
                int i = cantidad - 1;
               
                while (i >= 0 && aCirculos[i].getRadio() > circulo.getRadio())
                {
                    aCirculos[i + 1] = aCirculos[i];
                    i--;
                }
                aCirculos[i + 1] = circulo;
                cantidad++;

                agregarAlList();

                MostrarMaximosYMinimos();
            }
        }

        private void agregarAlList()
        {
            lbCirculos.Items.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                lbCirculos.Items.Add(aCirculos[i].mostrar());
            }
        }

        private bool seRepite(Circulo circulo)
        {
            int i = 0;
            while((i< cantidad) && (!aCirculos[i].esIgualA(circulo)))
            {
                i++;
            }
            return (i < cantidad);
        }
        private void MostrarMaximosYMinimos()
        {
            double minimo = 0, maximo = 0;
            if (cantidad > 0)
            {
                minimo = aCirculos[0].getDiametro();
                maximo = aCirculos[cantidad-1].getDiametro();
            }
            lCantidad.Text = $"{cantidad}";
            lMenorDiametro.Text = $"{minimo}";
            lMayorDiametro.Text = $"{maximo}";
        }

        private void eliminar()
        {
            int indexElemento = lbCirculos.SelectedIndex;       

            // Eliminar del ListBox
            lbCirculos.Items.RemoveAt(indexElemento);

            // Eliminar del arreglo
            for (int i = indexElemento; i < cantidad - 1; i++)
            {
                aCirculos[i] = aCirculos[i + 1];
            }
            cantidad--;
            lCantidad.Text = cantidad.ToString();

            MostrarMaximosYMinimos();
          
        }

        private void redimensionar()
        {
            cantidadMaxima += 20;
            Circulo[] auxiliar = new Circulo[cantidadMaxima];

            for (int i = 0; i < cantidad; i++)
            {
                auxiliar[i] = aCirculos[i];
            }
            aCirculos = auxiliar;

        }
    }
}
