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
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Persona persona;
            Estudiante estudiante;

            if (!mtDNI.MaskCompleted)
            {
                MessageBox.Show("Falta completar DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDNI.Focus();
            }
            else
            {
                string documento = mtDNI.Text.Replace(".", "");
                persona = new Persona(documento);

                if (!seRepite(persona, null)) MessageBox.Show("No se encontró a la persona", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int i = 0;
                    while (i < cantidadPersonas && !aPersonas[i].Existe(persona)) i++;

                    tNombre.Text = aPersonas[i].Nombre;
                    tApellido.Text = aPersonas[i].Apellido;
                    dtNacimiento.Value = aPersonas[i].Nacimiento;
                }
            }
            else if (rbEstudiante.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");
                estudiante = new Estudiante(documento, mtLegajo.Text);

                if (!seRepite(null, estudiante)) MessageBox.Show("No se encontró el estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int i = 0;
                    while (i < cantidadEstudiantes && !aEstudiantes[i].Existe(estudiante)) i++;

                    tNombre.Text = aEstudiantes[i].Nombre;
                    tApellido.Text = aEstudiantes[i].Apellido;
                    mtDNI.Text = aEstudiantes[i].Dni;
                    dtNacimiento.Value = aEstudiantes[i].Nacimiento;

                    mtLegajo.Text = aEstudiantes[i].Legajo;
                    tCarrera.Text = aEstudiantes[i].Carrera;
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

        private void tApellido_Validating(object sender, CancelEventArgs e)
        {
            epApellido.Clear();
            if (tApellido.Text.Trim() == "") epApellido.SetError(tApellido, "El campo debe estár completo");
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
        //private void actualizarPantallaTodos()
        //{
        //    lbPersonas.Items.Clear();

        //    for (int i = 0; i < cantidadPersonas; i++)
        //    {
        //        lbPersonas.Items.Add(aPersonas[i].Dni);
        //    }

        //    for (int i = 0; i < cantidadEstudiantes; i++)
        //    {
        //        lbPersonas.Items.Add(aEstudiantes[i].Legajo);
        //    }
        //}
        private void Modificar(Persona p)
        {
            lPersonas.Remove(p);
            lPersonas.Add(p);
        }
        #endregion
    }
}
