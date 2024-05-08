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
            int dia = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(0, 2)) : 30;
            int mes = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(3, 2)) : 2;
            int año = (mtFechaAgregar.MaskCompleted) ? Convert.ToInt32(mtFechaAgregar.Text.Substring(6, 4)): 2000;
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
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 30;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 2;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 2000;
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
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 30;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 2;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 2000;
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
            int dia = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(0, 2)) : 30;
            int mes = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(3, 2)) : 2;
            int año = (mtFechaComparar.MaskCompleted) ? Convert.ToInt32(mtFechaComparar.Text.Substring(6, 4)) : 2000;
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
            int index = lbFechas.SelectedIndex;

            if (index >= 0)
            {
                if (mtDiasEntreFechas.MaskCompleted)
                {
                    int dia = Convert.ToInt32(mtDiasEntreFechas.Text.Substring(0, 2));
                    int mes = Convert.ToInt32(mtDiasEntreFechas.Text.Substring(3, 2));
                    int año = Convert.ToInt32(mtDiasEntreFechas.Text.Substring(6, 4));

                    if(Fecha.esFechaValida(dia, mes, año))
                    {
                        Fecha fechaComparar = new Fecha(dia, mes, año);
                        int cantidadDias;

                        cantidadDias = fechaComparar.mayorQue(aFechas[index]) ? fechaComparar.contarDiasEntre(aFechas[index]) : aFechas[index].contarDiasEntre(fechaComparar);
                        MessageBox.Show($"Entre la fecha {aFechas[index].mostrar()} y la fecha {fechaComparar.mostrar()} hay {cantidadDias}.", "Comparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtDiasEntreFechas.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtDiasEntreFechas.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDia_Click(object sender, EventArgs e)
        {
            if (mtModificarEspecifico.MaskCompleted)
            {
                int index = lbFechas.SelectedIndex;

                if(index >= 0)
                {
                    int dia = Convert.ToInt32(mtModificarEspecifico.Text);
                    int mes = aFechas[index].getMes();
                    int año = aFechas[index].getAño();

                    if (dia > 0 && dia <= Fecha.ultimoDiaMes(aFechas[index].getMes(), aFechas[index].getAño()))
                    {
                        Fecha fecha = new Fecha(dia, mes, año);

                        if (!Existe(fecha))
                        {
                            eliminar();
                            agregarAlArray(fecha);
                        }
                        else
                        {
                            MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mtModificarEspecifico.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El día no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtModificarEspecifico.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
        }

        private void bMes_Click(object sender, EventArgs e)
        {
            if (mtModificarEspecifico.MaskCompleted)
            {
                int index = lbFechas.SelectedIndex;

                if (index >= 0)
                {
                    int dia = aFechas[index].getDia();
                    int mes = Convert.ToInt32(mtModificarEspecifico.Text);
                    int año = aFechas[index].getAño();

                    if (Fecha.esFechaValida(dia, mes, año))
                    {
                        Fecha fecha = new Fecha(dia, mes, año);

                        if (!Existe(fecha))
                        {
                            eliminar();
                            agregarAlArray(fecha);
                        }
                        else
                        {
                            MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mtModificarEspecifico.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El mes no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtModificarEspecifico.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
        }

        private void bAno_Click(object sender, EventArgs e)
        {
            if (mtModificarEspecifico.MaskCompleted)
            {
                int index = lbFechas.SelectedIndex;

                if (index >= 0)
                {
                    int dia = aFechas[index].getDia();
                    int mes = aFechas[index].getMes();
                    int año = Convert.ToInt32(mtModificarEspecifico.Text);

                    if (Fecha.esFechaValida(dia, mes, año))
                    {
                        Fecha fecha = new Fecha(dia, mes, año);

                        if (!Existe(fecha))
                        {
                            eliminar();
                            agregarAlArray(fecha);
                        }
                        else
                        {
                            MessageBox.Show("La fecha ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Fecha.esAñoBiciesto(año))
                    {
                        MessageBox.Show("El año es biciesto, no valido con la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El año es biciesto, no valido con la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtModificarEspecifico.Focus();
            }
        }
    

        private void bIncrementar_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;

            if (index >= 0)
            {
                Fecha fechaMod = aFechas[index].Incrementar();

                if (cantidad == 1 || !Existe(fechaMod))
                {
                    aFechas[index] = aFechas[index].Incrementar();
                    listarFecha();
                }
                else
                {
                    MessageBox.Show("Las fechas no se pueden repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bDecrementar_Click(object sender, EventArgs e)
        {
            int index = lbFechas.SelectedIndex;

            if (index >= 0)
            {
                Fecha fechaMod = aFechas[index].Decrementar();

                if (cantidad == 1 || !Existe(fechaMod))
                {
                    aFechas[index] = aFechas[index].Decrementar();
                    listarFecha();
                }
                else
                {
                    MessageBox.Show("Las fechas no se pueden repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bEntre_Click(object sender, EventArgs e)
        {
            if (mtFechasEntre1.MaskCompleted && mtFechasEntre2.MaskCompleted)
            {
                int dia1 = Convert.ToInt32(mtFechasEntre1.Text.Substring(0, 2));
                int mes1 = Convert.ToInt32(mtFechasEntre1.Text.Substring(3, 2));
                int año1 = Convert.ToInt32(mtFechasEntre1.Text.Substring(6, 4));

                int dia2 = Convert.ToInt32(mtFechasEntre2.Text.Substring(0, 2));
                int mes2 = Convert.ToInt32(mtFechasEntre2.Text.Substring(3, 2));
                int año2 = Convert.ToInt32(mtFechasEntre2.Text.Substring(6, 4));

                if (Fecha.esFechaValida(dia1, mes1, año1) && Fecha.esFechaValida(dia2, mes2, año2))
                {
                    Fecha fechaEntre1 = new Fecha(dia1, mes1, año1);
                    Fecha fechaEntre2 = new Fecha(dia2, mes2, año2);

                    mostarFechasEntre(fechaEntre1 , fechaEntre2);
                }
                else
                {
                    MessageBox.Show("Las fechas deben ser validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void eliminar()
        {
            int indexElemento = lbFechas.SelectedIndex;

            lbFechas.Items.RemoveAt(indexElemento);

            for (int i = indexElemento; i < cantidad - 1; i++)
            {
                aFechas[i] = aFechas[i + 1];
            }
            cantidad--;
        } //Le quité el if que comprueba selección (Se supone que ya lo estamos comprobando antes)

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
        } //Pa que el arreglo crezca 
        #endregion
    }
}
