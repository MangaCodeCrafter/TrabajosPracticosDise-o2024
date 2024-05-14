using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Personas
{
    public partial class Personas : Form
    {
        Persona[] aPersonas;
        Estudiante[] aEstudiantes;
        int cantMaxima;
        int cantidadPersonas;
        int cantidadEstudiantes;
        public Personas()
        {
            InitializeComponent();
            cantMaxima = 10;
            cantidadPersonas = 0;
            cantidadEstudiantes = 0;
            aPersonas = new Persona[cantMaxima];
            aEstudiantes = new Estudiante[cantMaxima];
        }

        private void chEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstudiante.Checked) panel3.Visible = true;
            else panel3.Visible = false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Persona persona;
            Estudiante estudiante;
            DialogResult result = DialogResult.None;

            if (!mtDNI.MaskCompleted)
            {
                MessageBox.Show("Falta completar DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDNI.Focus();
            }
            else if (chEstudiante.Checked & !mtLegajo.MaskCompleted)
            {
                MessageBox.Show("Falta completar Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtLegajo.Focus();
            }
            else if (!chEstudiante.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");

                persona = new Persona(tNombre.Text, tApellido.Text, documento, dtNacimiento.Value);
                if (seRepite(persona, null)) result = MessageBox.Show("La persona ya existe \n ¿Querés modificar la persona?", "Info.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(result == DialogResult.Yes) Modificar(persona, null);
                else if (result == DialogResult.None) agregarAlArregloPersona(persona);
            }
            else if(chEstudiante.Checked)
            {
                string documento = mtDNI.Text.Replace(".", "");

                estudiante = new Estudiante(tNombre.Text, tApellido.Text, documento, dtNacimiento.Value, mtLegajo.Text, tCarrera.Text, dtIngreso.Value);
                if (seRepite(null, estudiante)) result = MessageBox.Show("El estudiante ya existe \n ¿Querés modificar el estudiante?", "Info.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if(result == DialogResult.Yes) Modificar(null, estudiante);
                else if (result == DialogResult.None) agregarAlArregloEstudiante(estudiante);
            }
            actualizarPantallaTodos();
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
            else if (chEstudiante.Checked & !mtLegajo.MaskCompleted)
            {
                MessageBox.Show("Falta completar Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtLegajo.Focus();
            }
            else if (!chEstudiante.Checked)
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
            else if (chEstudiante.Checked)
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
                    dtIngreso.Value = aEstudiantes[i].Ingreso;
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

        private void agregarAlArregloPersona(Persona persona)
        {
            int i = cantidadPersonas - 1;

            while (i >= 0 && Convert.ToInt32(aPersonas[i].Dni) > Convert.ToInt32(persona.Dni))
            {
                aPersonas[i + 1] = aPersonas[i];
                i--;
            }
            aPersonas[i + 1] = persona;

            cantidadPersonas++;
        }        
        private void agregarAlArregloEstudiante(Estudiante estudiante)
        {
            int i = cantidadEstudiantes - 1;

            while (i >= 0 && Convert.ToInt32(aEstudiantes[i].Legajo) > Convert.ToInt32(estudiante.Legajo))
            {
                aEstudiantes[i + 1] = aEstudiantes[i];
                i--;
            }
            aEstudiantes[i + 1] = estudiante;

            cantidadEstudiantes++;
        }
        private void actualizarPantallaTodos()
        {
            lbPersonas.Items.Clear();

            for (int i = 0; i < cantidadPersonas; i++)
            {
                lbPersonas.Items.Add(aPersonas[i].Dni);
            }

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                lbPersonas.Items.Add(aEstudiantes[i].Legajo);
            }
        }
        private bool seRepite(Persona p, Estudiante e)
        {
            int i = (p != null) ? 0 : cantidadPersonas;
            if(p != null) while(i < cantidadPersonas && !aPersonas[i].Existe(p)) i++;

            int j = (e != null) ? 0 : cantidadEstudiantes;
            if(e != null) while (j < cantidadEstudiantes && !aEstudiantes[j].Existe(e)) j++;

            return (i < cantidadPersonas || j < cantidadEstudiantes);
        }
        private void Modificar(Persona p, Estudiante e)
        {
            int i = 0;

            if(p != null) 
            {
                while (i < cantidadPersonas && !aPersonas[i].Existe(p)) i++;
                if (i < cantidadPersonas) aPersonas[i] = p;
            }

            int j = 0;

            if(e != null)
            {
                while (j < cantidadEstudiantes && !aEstudiantes[i].Existe(e)) j++;
                if (j < cantidadEstudiantes) aEstudiantes[j] = e;
            }
        }
        #endregion
    }
}
