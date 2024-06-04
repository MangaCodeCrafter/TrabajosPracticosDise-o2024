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
        public Form1()
        {
            InitializeComponent();
            coleccion = new Coleccion();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            fAgregar fAgregar = new fAgregar(coleccion);
            fAgregar.ShowDialog();

            if (fAgregar.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se agregó correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No se agregó.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
