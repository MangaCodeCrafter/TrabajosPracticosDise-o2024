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
        public fAgregar(Coleccion c)
        {
            InitializeComponent();
            coleccion = c;
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
                if (rbSmooth.Checked) estructura = new Estructura("Papel", "Smooth");
                else estructura = new Estructura("Plastico", "Plastic");

                if (rbFrances.Checked)
                {
                    Frances mazoFrances = new Frances(tMarca.Text, chEspeciales.Checked, dtLote.Value, estructura, tModelo.Text);
                    coleccion.Agregar(mazoFrances);
                }
                else
                {
                    int cantidad = (rb40.Checked) ? 40 : 50;
                    Español mazoEspañol = new Español(tMarca.Text, chEspeciales.Checked, dtLote.Value, estructura, cantidad);
                    coleccion.Agregar(mazoEspañol);
                }

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
    }
}
