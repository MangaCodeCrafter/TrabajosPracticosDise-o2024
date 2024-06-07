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
    public partial class fAgregar : Form
    {
        private Coleccion coleccion;
        private int codigoObj = 0;

        public fAgregar(Coleccion c)
        {
            InitializeComponent();
            coleccion = c;
        }        
        public fAgregar(Coleccion c, int codigo)
        {
            InitializeComponent();
            coleccion = c;
            codigoObj = codigo;
            llenarCampos();
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if(rbFrances.Checked && tModelo.Text.Trim() == "")
            {                
                errorProvider.SetError(tModelo, "Complete modelo.");
                tModelo.Focus();        
            }
            if (tMarca.Text.Trim() == "")
            {
                errorProvider.SetError(tMarca, "Complete la marca.");
                tMarca.Focus();
            }
            else
            {
                Estructura estructura;

                if (rbAirCushion.Checked) estructura = new Estructura("Papel", "Air Cushion");
                else if (rbSmooth.Checked) estructura = new Estructura("Papel", "Smooth");
                else estructura = new Estructura("Plastico", "Plastic");

                int cantidad = (rb40.Checked) ? 40 : 50;
                Type tipo = (rbFrances.Checked) ? typeof(Frances) : typeof(Español);

                coleccion.insertarDatos(codigoObj, tipo, tMarca.Text, tModelo.Text, estructura, dtLote.Value, chEspeciales.Checked, cantidad);
                
                DialogResult = DialogResult.OK;

                this.Close();
            }
        }
        private void rbFrances_CheckedChanged(object sender, EventArgs e)
        {
            gbCantidad.Visible = false;

            tModelo.Visible = true;
            lModelo.Visible = true;
        }

        private void rbEspañol_CheckedChanged(object sender, EventArgs e)
        {
            gbCantidad.Visible = true;

            tModelo.Visible = false;
            lModelo.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarCampos()
        {
            obtenerDatos(out string marca, out string modelo, out string acabado, out DateTime fechaLote, out bool especiales, out int cantidad);

            tMarca.Text = marca;
            dtLote.Value = fechaLote;

            if (especiales) chEspeciales.Checked = true;

            if (acabado == "Air Cushion") rbAirCushion.Checked = true;
            else if (acabado == "Smooth") rbSmooth.Checked = true;
            else rbPlastic.Checked = true;

            tModelo.Text = modelo;

            if(cantidad == 40) rb40.Checked = true;
            else rb50.Checked = true;

            if (cantidad == 0) rbFrances.Checked = true;
            else rbEspañol.Checked = true;
        }

        private void obtenerDatos(out string marca, out string modelo, out string acabado, out DateTime fechaLote, out bool especiales, out int cantidad )
        {
            Mazo mazo = coleccion.Buscar(codigoObj);

            marca = mazo.Marca;
            fechaLote = mazo.FechaLote;
            especiales = mazo.Especial;
            acabado = mazo.Acabado;
            modelo = (mazo is Frances f) ? f.Modelo : "";
            cantidad = (mazo is Español e) ? e.Cantidad : 0;
        }


    }
}
