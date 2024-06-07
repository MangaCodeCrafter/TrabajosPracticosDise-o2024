using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recupetorio_Gutierrez_Manuel
{
    public partial class Form1 : Form
    {
        Coleccion coleccion;
        List<Mazo> coleccionFiltrada;

        public Form1()
        {
            InitializeComponent();
            coleccion = new Coleccion();
            coleccionFiltrada = new List<Mazo>();
            test();
        }
        #region botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            fAgregar fAgregar = new fAgregar(coleccion);
            fAgregar.ShowDialog();

            if (fAgregar.DialogResult == DialogResult.OK)
            {
                filtrarLista(cbFiltro);
                MessageBox.Show("Se agregó correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No se agregó.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (lbMazos.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Mazo modificar = coleccionFiltrada[lbMazos.SelectedIndex];
                int codigo = modificar.Codigo;

                fAgregar fAgregar = new fAgregar(coleccion, codigo);
                fAgregar.ShowDialog();

                if (fAgregar.DialogResult == DialogResult.OK)
                {
                    //coleccion.Eliminar(modificar);
                    filtrarLista(cbFiltro);
                    MessageBox.Show("Se modificó correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se agregó.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if(lbMazos.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coleccion.Eliminar(coleccionFiltrada[lbMazos.SelectedIndex].Codigo);
                filtrarLista(cbFiltro);
            }
        }
        private void bAcercaDe_Click(object sender, EventArgs e)
        {
            SobreMi sobreMi = new SobreMi();
            sobreMi.ShowDialog();
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void filtrarLista(ComboBox cb)
        {
            lbMazos.Items.Clear();
            string acabado;

            int cantidad = (rb40.Checked) ? 40 : 50;

            if (rbAirCushion.Checked) acabado = "Air Cushion";
            else if (rbSmooth.Checked) acabado = "Smooth";
            else acabado = "Plastic";

            if (cb.SelectedIndex == 0 && !chPersonalizado.Checked) coleccionFiltrada = coleccion.Bucar();
            else if (cb.SelectedIndex == 1 && !chPersonalizado.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Frances));
            else if (cb.SelectedIndex == 2 && !chPersonalizado.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Español));

            else if (cb.SelectedIndex == 0 && chPersonalizado.Checked && rbTodas.Checked) coleccionFiltrada = coleccion.Buscar(chCartasEspeciales.Checked);
            else if (cb.SelectedIndex == 1 && chPersonalizado.Checked && rbTodas.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Frances), chCartasEspeciales.Checked);
            else if (cb.SelectedIndex == 2 && chPersonalizado.Checked && rbTodas.Checked && rbTodasCantidad.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Español), chCartasEspeciales.Checked);

            else if (cb.SelectedIndex == 0 && chPersonalizado.Checked) coleccionFiltrada = coleccion.Buscar(acabado, chCartasEspeciales.Checked);
            else if (cb.SelectedIndex == 1 && chPersonalizado.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Frances), acabado, chCartasEspeciales.Checked);
            else if (cb.SelectedIndex == 2 && chPersonalizado.Checked && rbTodasCantidad.Checked) coleccionFiltrada = coleccion.Buscar(typeof(Español), acabado, chCartasEspeciales.Checked);

            else if (cb.SelectedIndex == 2 && rbTodas.Checked) coleccionFiltrada = coleccion.Buscar(cantidad, chCartasEspeciales.Checked);
            else if (cb.SelectedIndex == 2) coleccionFiltrada = coleccion.Buscar(cantidad, acabado, chCartasEspeciales.Checked);

            mostrarLista();
        }

        private void mostrarLista()
        {
            foreach (Mazo m in coleccionFiltrada) lbMazos.Items.Add(m);
        }

        private void chPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (chPersonalizado.Checked) pEspecífico.Enabled = true;
            else pEspecífico.Enabled = false;
            filtrarLista(cbFiltro);
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
            gbCantidad.Visible = (cbFiltro.SelectedIndex == 2) ? true : false;
        }

        private void test()
        {
        //    coleccion.Agregar(new Frances(5, "Bycicle", false, DateTime.Now, new Estructura("Papel", "Air Cushion"), "rojo"));            
        //    coleccion.Agregar(new Frances(2, "Bycicle", true, DateTime.Now, new Estructura("Papel", "Air Cushion"), "blanco"));            
        //    coleccion.Agregar(new Frances("Bycicle", false, DateTime.Now, new Estructura("Papel", "Air Cushion"), "azul"));            
        //    coleccion.Agregar(new Frances("Aviator", false, DateTime.Now, new Estructura("Papel", "Smooth"), "rojo"));            
        //    coleccion.Agregar(new Frances("Aviator", true, DateTime.Now, new Estructura("Papel", "Smooth"), "blanco"));            
        //    coleccion.Agregar(new Frances("Aviator", false, DateTime.Now, new Estructura("Papel", "Smooth"), "azul"));            
        //    coleccion.Agregar(new Frances("Bycicle p", false, DateTime.Now, new Estructura("Papel", "Plastic"), "rojo"));            
        //    coleccion.Agregar(new Frances("Bycicle p", true, DateTime.Now, new Estructura("Papel", "Plastic"), "blanco"));            
        //    coleccion.Agregar(new Frances("Bycicle p", false, DateTime.Now, new Estructura("Papel", "Plastic"), "azul"));
        //    coleccion.Agregar(new Español(34, "Casino", false, DateTime.Now, new Estructura("Papel", "Air Cushion"), 40));            
        //    coleccion.Agregar(new Español("Casino", true, DateTime.Now, new Estructura("Papel", "Air Cushion"), 50));            
        //    coleccion.Agregar(new Español("Casino second", true, DateTime.Now, new Estructura("Papel", "Smooth"), 40));

            filtrarLista(cbFiltro);
        }

        private void chCartasEspeciales_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rbAirCushion_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rbSmooth_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rbPlastic_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rb40_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rb50_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }

        private void rbTodasCantidad_CheckedChanged(object sender, EventArgs e)
        {
            filtrarLista(cbFiltro);
        }
    }
}
