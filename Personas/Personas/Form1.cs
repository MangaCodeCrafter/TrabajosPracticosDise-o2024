using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace Personas
{
    public partial class Personas : Form
    {
        List<Persona> lPersonas;
        public Personas()
        {
            InitializeComponent();
            lPersonas = new List<Persona>();
        }

        #region filtro y radioButton
        private void chEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstudiante.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }
        private void rbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstudiante.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }
        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpleado.Checked) pEmpleado.Visible = true;
            else pEmpleado.Visible = false;
        }
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPantallaTodos();
        }
        #endregion

        #region botones
        private void btGuardar_Click(object sender, EventArgs e)
        {
            Persona persona;
            Estudiante estudiante;
            Empleado empleado;
            DialogResult result = DialogResult.None;

            if (!mtDNI.MaskCompleted)
            {
                MessageBox.Show("Falta completar DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDNI.Focus();
            }
            else if (rbEstudiante.Checked & !mtLegajo.MaskCompleted)
            {
                MessageBox.Show("Falta completar Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtLegajo.Focus();
            }
            else if (rbEmpleado.Checked && !mtLegajoEmpleado.MaskCompleted)
            {
                MessageBox.Show("Falta completar Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtLegajoEmpleado.Focus();
            }
            else if (rbPersona.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");

                persona = new Persona(tNombre.Text, documento, dtNacimiento.Value);
                if (lPersonas.Contains(persona)) result = MessageBox.Show("La persona ya existe \n ¿Querés modificar la persona?", "Info.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) Modificar(persona);
                else if (result == DialogResult.None) lPersonas.Add(persona);
            }
            else if(rbEstudiante.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");

                estudiante = new Estudiante(tNombre.Text, documento, dtNacimiento.Value, mtLegajo.Text, tCarrera.Text);
                if (lPersonas.Contains(estudiante)) result = MessageBox.Show("El estudiante ya existe \n ¿Querés modificar el estudiante?", "Info.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if(result == DialogResult.Yes) Modificar(estudiante);
                else if (result == DialogResult.None) lPersonas.Add(estudiante);
            }
            else if (rbEmpleado.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");

                empleado = new Empleado(tNombre.Text, documento, dtNacimiento.Value, mtLegajoEmpleado.Text, tCargo.Text);
                if (lPersonas.Contains(empleado)) result = MessageBox.Show("El empleado ya existe \n ¿Querés modificar el estudiante?", "Info.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) Modificar(empleado);
                else if (result == DialogResult.None) lPersonas.Add(empleado);
            };

            actualizarPantallaTodos();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!mtDNI.MaskCompleted)
            {
                MessageBox.Show("Falta completar DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDNI.Focus();
            }
            else if (ExisteYLugar(new Persona(mtDNI.Text.Replace(".", "")), out int i))
            {
                Persona p = lPersonas[i];
                tNombre.Text = p.Nombre; 
                dtNacimiento.Value = p.Nacimiento; 
                rbPersona.Checked = true;

                if (p.GetType() == typeof(Estudiante))
                {
                    Estudiante estudiante = (Estudiante)p; 
                    rbEstudiante.Checked = true;
                    mtLegajo.Text = estudiante.Legajo; 
                    tCarrera.Text = estudiante.Carrera;
                }
                else if (p.GetType() == typeof(Empleado))
                {
                    Empleado empleado = (Empleado)p; 
                    rbEmpleado.Checked = true;
                    mtLegajoEmpleado.Text = empleado.Legajo; 
                    tCargo.Text = empleado.Cargo;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region validatings        
        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if(tNombre.Text.Trim() == "") errorProvider.SetError(tNombre, "El campo debe estár completo");
        }

        private void tCarrera_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tCarrera.Text.Trim() == "") errorProvider.SetError(tCarrera, "El campo debe estár completo");
        }
        private void mtDNI_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if(mtDNI.Text == "  .   .") errorProvider.SetError(mtDNI, "El campo debe estár completo");
        }

        private void mtLegajo_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if(mtLegajo.Text.Trim() == "") errorProvider.SetError(mtLegajo, "El campo debe estár completo");
        }
        private void mtLegajoEmpleado_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (!mtLegajoEmpleado.MaskCompleted) errorProvider.SetError(mtLegajoEmpleado, "El campo debe estár completo");
        }

        private void tCargo_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tCargo.Text.Trim() == "") errorProvider.SetError(tCargo, "El campo debe estár completo");
        }
        #endregion

        #region Metodos     
        private void actualizarPantallaTodos()
        {
            lbPersonas.Items.Clear();

            lPersonas.Sort((x, y) => x.Dni.CompareTo(y.Dni));

            if (cbFiltro.SelectedIndex == 0) for (int i = 0; i < lPersonas.Count; i++) lbPersonas.Items.Add(lPersonas[i].ToString());
            if (cbFiltro.SelectedIndex == 1) for (int i = 0; i < lPersonas.Count; i++) if (lPersonas[i].GetType() == typeof(Persona)) lbPersonas.Items.Add(lPersonas[i].ToString());
            if (cbFiltro.SelectedIndex == 2) for (int i = 0; i < lPersonas.Count; i++) if (lPersonas[i].GetType() == typeof(Estudiante)) lbPersonas.Items.Add(lPersonas[i].ToString());
            if (cbFiltro.SelectedIndex == 3) for (int i = 0; i < lPersonas.Count; i++) if (lPersonas[i].GetType() == typeof(Empleado)) lbPersonas.Items.Add(lPersonas[i].ToString());
            

            lCantidad.Text = $"Cantidad: {lbPersonas.Items.Count}";
        }
        private void Modificar(Persona p)
        {
            lPersonas.Remove(p);
            lPersonas.Add(p);
        }

        private bool ExisteYLugar (Persona p, out int posicion)
        {
            int i = 0;

            while (i < lPersonas.Count && lPersonas[i].Dni != p.Dni) i++;

            posicion = i;
            return i < lPersonas.Count;
        }
        #endregion

    }
}
