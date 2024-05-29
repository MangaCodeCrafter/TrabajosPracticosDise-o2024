using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Fecha
{
    public partial class Form1 : Form
    {
        private int cantidadMaxima;
        private int cantidad;
        Fecha[] aFechas;
        public Form1()
        {
            InitializeComponent();
            cantidadMaxima = 10;
            cantidad = 0;
            aFechas = new Fecha[cantidadMaxima];
        }
        //Cambié el arreglo.

        #region "Botones"
        private void bAgregar_Click(object sender, EventArgs e)
        {
            int dia = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(0, 2)) : 0;
            int mes = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(3, 2)) : 0;
            int año = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(6, 4)): 0;
            Fecha fecha = new Fecha(dia, mes, año);

            if (!mtFechaAgregar.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaAgregar.Focus();
            }

            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("No es una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaAgregar.Focus();
            }
            else if (Existe(fecha))
            {
                MessageBox.Show("Las fechas no se pueden repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaAgregar.Focus();
            }
            else
            {
                agregarAlArray(fecha);
                mtFechaAgregar.Clear();
            }
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 0;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 0;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 0;
            Fecha fecha = new Fecha(dia, mes, año);

            int index = lbFechas.SelectedIndex;

            if (!mtFechaComparar.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("No es una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }
            else
            {
                if (aFechas[index].esIgual(fecha)) MessageBox.Show("Las fechas coinciden", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Las fechas NO coinciden", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bMayor_Click(object sender, EventArgs e)
        {
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 0;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 0;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 0;
            Fecha fecha = new Fecha(dia, mes, año);

            int index = lbFechas.SelectedIndex;

            if (!mtFechaComparar.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("No es una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }
            else
            {
                if (fecha.mayorQue(aFechas[index])) MessageBox.Show($"La fecha {aFechas[index].mostrar()} es mayor que {fecha.mostrar()}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"La fecha {aFechas[index].mostrar()} NO es mayor que {fecha.mostrar()}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bMenor_Click(object sender, EventArgs e)
        {
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 0;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 0;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 0;
            Fecha fecha = new Fecha(dia, mes, año);

            int index = lbFechas.SelectedIndex;

            if (!mtFechaComparar.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("No es una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }

            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtFechaComparar.Focus();
            }
            else
            {
                if (fecha.menorQue(aFechas[index])) MessageBox.Show($"La fecha {aFechas[index].mostrar()} es menor que {fecha.mostrar()}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"La fecha {aFechas[index].mostrar()} NO es menor que {fecha.mostrar()}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bDiasEntre_Click(object sender, EventArgs e)
        {
            int dia = (mtDiasEntreFechas.MaskCompleted) ? Convert.ToInt32(mtDiasEntreFechas.Text.Substring(0, 2)) : 0;
            int mes = (mtDiasEntreFechas.MaskCompleted) ? Convert.ToInt32(mtDiasEntreFechas.Text.Substring(3, 2)) : 0;
            int año = (mtDiasEntreFechas.MaskCompleted) ? Convert.ToInt32(mtDiasEntreFechas.Text.Substring(6, 4)) : 0;
            Fecha fecha = new Fecha(dia, mes, año);

            int index = lbFechas.SelectedIndex;

            if(index < 0)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mtDiasEntreFechas.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDiasEntreFechas.Focus();
            }
            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("Ingrese una fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDiasEntreFechas.Focus();
            }
            else
            {
                int cantidadDias;

                cantidadDias = fecha.mayorQue(aFechas[index]) ? fecha.contarDiasEntre(aFechas[index]) : aFechas[index].contarDiasEntre(fecha);
                MessageBox.Show($"Entre la fecha {aFechas[index].mostrar()} y la fecha {fecha.mostrar()} hay {cantidadDias}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bDia_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;

            int dia = (mtModificarEspecifico.MaskCompleted) ? Convert.ToInt32(mtModificarEspecifico.Text) : 0;
            int mes = (index >= 0) ? aFechas[index].Mes : 0;
            int año = (index >= 0) ? aFechas[index].Año : 2000;

            Fecha fecha = new Fecha(dia, mes, año);

            if (!mtModificarEspecifico.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("El día no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else if (Existe(fecha))
            {
                MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else
            {
                eliminar(index);
                agregarAlArray(fecha);
            }
        }

        private void bMes_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;

            int dia = (index >= 0) ? aFechas[index].Dia : 0;
            int mes = (mtModificarEspecifico.MaskCompleted) ? Convert.ToInt32(mtModificarEspecifico.Text) : 0;
            int año = (index >= 0) ? aFechas[index].Año : 2000;

            Fecha fecha = new Fecha(dia, mes, año);

            if (!mtModificarEspecifico.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("El mes no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else if (Existe(fecha))
            {
                MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
            else
            {
                eliminar(index);
                agregarAlArray(fecha);
            }
        }

        private void bAno_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;

            int dia = (index >= 0) ? aFechas[index].Dia : 0;
            int mes = (index >= 0) ? aFechas[index].Mes : 0;
            int año = (index >= 0) ? Convert.ToInt32(mtModificarEspecifico.Text) : 0;

            Fecha fecha = new Fecha(dia, mes, año);

            if (!mtModificarEspecifico.MaskCompleted)
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }

            else if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!Fecha.esFechaValida(dia, mes, año))
            {
                MessageBox.Show("El año no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Existe(fecha))
            {
                MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminar(index);
                agregarAlArray(fecha);
            }
        }
    

        private void bIncrementar_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;
            Fecha fechaMod = (index > 0) ? aFechas[index].Incrementar() : null;

            if (index < 0) MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(cantidad == 1 || !Existe(fechaMod))) MessageBox.Show("Las fechas no se pueden repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                aFechas[index] = aFechas[index].Incrementar();
                listarFecha();
            }
        }

        private void bDecrementar_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;
            Fecha fechaMod = (index > 0) ? aFechas[index].Decrementar() : null;

            if (index < 0) MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(cantidad == 1 || !Existe(fechaMod))) MessageBox.Show("Las fechas no se pueden repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                aFechas[index] = aFechas[index].Decrementar();
                listarFecha();
            }
        }

        private void bEntre_Click(object sender, EventArgs e)
        {
            int dia1 = (mtFechasEntre1.MaskCompleted) ? Convert.ToInt32(mtFechasEntre1.Text.Substring(0, 2)) : 0;
            int mes1 = (mtFechasEntre1.MaskCompleted) ? Convert.ToInt32(mtFechasEntre1.Text.Substring(3, 2)) : 0;
            int año1 = (mtFechasEntre1.MaskCompleted) ? Convert.ToInt32(mtFechasEntre1.Text.Substring(6, 4)) : 0;            
            
            int dia2 = (mtFechasEntre2.MaskCompleted) ? Convert.ToInt32(mtFechasEntre2.Text.Substring(0, 2)) : 0;
            int mes2 = (mtFechasEntre2.MaskCompleted) ? Convert.ToInt32(mtFechasEntre2.Text.Substring(3, 2)) : 0;
            int año2 = (mtFechasEntre2.MaskCompleted) ? Convert.ToInt32(mtFechasEntre2.Text.Substring(6, 4)) : 0;

            if (!(mtFechasEntre1.MaskCompleted && mtFechasEntre2.MaskCompleted))
            {
                MessageBox.Show("Debe completar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Fecha.esFechaValida(dia1, mes1, año1) && Fecha.esFechaValida(dia2, mes2, año2)))
            {
                MessageBox.Show("Las fechas deben ser validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fecha fechaEntre1 = new Fecha(dia1, mes1, año1);
                Fecha fechaEntre2 = new Fecha(dia2, mes2, año2);

                mostarFechasEntre(fechaEntre1, fechaEntre2);
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Metodos"
        private void agregarAlArray(Fecha fecha)
        {
            if(cantidad == cantidadMaxima)
            {
                redimensionar();
            }

            int i = cantidad - 1;
            int j = cantidad;

            while((i >= 0) && (fecha.mayorQue(aFechas[i])))
            {
                aFechas[j] = aFechas[i];
                i--;
                j--;
            }
            aFechas[j] = fecha;
            cantidad++;

            listarFecha();
        }        
        private void listarFecha()
        {
            lbFechas.Items.Clear();

            for(int i = 0; i < cantidad; i++)
            {
                lbFechas.Items.Add(aFechas[i].mostrar());
            }
        }
        private bool Existe(Fecha fecha)
        {
            int i = 0;
            while (i < cantidad && !fecha.esIgual(aFechas[i]))
            {
                i++;
            }
            return (i < cantidad);
        }
        private void eliminar(int indexElemento)
        {
            lbFechas.Items.RemoveAt(indexElemento);

            for (int i = indexElemento; i < cantidad - 1; i++)
            {
                aFechas[i] = aFechas[i + 1];
            }
            cantidad--;
        }

        private void mostarFechasEntre(Fecha fecha1, Fecha fecha2)
        {
            string lista = $"Entre {fecha1.mostrar()} y {fecha2.mostrar()} estan las fechas:\n";

            for (int i = 0; i < cantidad; i++)
            {
                if ((aFechas[i].mayorQue(fecha1) && aFechas[i].menorQue(fecha2)) || (aFechas[i].mayorQue(fecha2) && aFechas[i].menorQue(fecha1)))
                {
                    lista += $"{aFechas[i].mostrar()} \n";
                }
            }
            if (lista != $"Entre {fecha1.mostrar()} y {fecha2.mostrar()} estan las fechas:\n")
            {
                MessageBox.Show(lista, "Lista fechas: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay fechas entre esas fechas", "Lista fechas: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void redimensionar()
        {
            cantidadMaxima += 20;
            Fecha[] auxiliar = new Fecha[cantidadMaxima];

            for (int i = 0; i < cantidad; i++)
            {
                auxiliar[i] = aFechas[i];
            }

            aFechas = auxiliar;
        }
        #endregion
    }
}
