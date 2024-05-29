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

        //int cantMaxima;
        //int cantidadPersonas;
        //int cantidadEstudiantes;
        public Personas()
        {
            InitializeComponent();
            lPersonas = new List<Persona>();
        }

        private void chEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstudiante.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }

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
            Persona persona;
            Estudiante estudiante;
            Empleado empleado;

            if (!mtDNI.MaskCompleted)
            {
                MessageBox.Show("Falta completar DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDNI.Focus();
            }
            else if (mtDNI.MaskCompleted && rbPersona.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");
                persona = new Persona(documento);

                int i = 0;
                while (i < lPersonas.Count && !lPersonas[i].Equals(persona)) i++;

                if (!lPersonas.Contains(persona)) MessageBox.Show("No se encontró a la persona", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (lPersonas.Contains(persona))
                {
                    tNombre.Text = lPersonas[i].Nombre;
                    dtNacimiento.Value = lPersonas[i].Nacimiento;
                }

                if (lPersonas[i].GetType() == typeof(Estudiante))
                {
                    Estudiante p = (Estudiante)lPersonas[i];
                    mtLegajo.Text = p.Legajo;
                    tCarrera.Text = p.Carrera;
                }
                else if (lPersonas[i].GetType() == typeof(Empleado))
                {
                    Empleado p = (Empleado)lPersonas[i];
                    mtLegajoEmpleado.Text = p.Legajo;
                    tCargo.Text =  p.Cargo;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            epNombre.Clear();
            if(tNombre.Text.Trim() == "") epNombre.SetError(tNombre, "El campo debe estár completo");
        }

        private void tCarrera_Validating(object sender, CancelEventArgs e)
        {
            epCarrera.Clear();
            if (tCarrera.Text.Trim() == "") epCarrera.SetError(tCarrera, "El campo debe estár completo");
        }

        private void mtDNI_Validating(object sender, CancelEventArgs e)
        {
            epDni.Clear();
            if(mtDNI.Text == "  .   .") epDni.SetError(mtDNI, "El campo debe estár completo");
        }

        private void mtLegajo_Validating(object sender, CancelEventArgs e)
        {
            epLegajo.Clear();
            if(mtLegajo.Text.Trim() == "") epLegajo.SetError(mtLegajo, "El campo debe estár completo");
        }

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


        #endregion

        private void rbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstudiante.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEmpleado.Checked) pEmpleado.Visible = true;
            else pEmpleado.Visible = false;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPantallaTodos();
        }
    }
}
