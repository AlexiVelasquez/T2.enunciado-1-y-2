using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T2.enunciado1
{
    public partial class Form1 : Form
    {
        //Variables públicas con valores máximos para dueños y mascotas
        public static int G18_totaldueño = 100; //max = 100
        public static int G18_totalmascotas = 100; //max = 100
        //Contadores para llevar el registro de dueños y mascotas registradas
        private int contadorDueños = 0;
        private int contadormascotas = 0;

        //Arreglos para almacenar los datos del dueño
        public static string[] G18_nombredueño = new string[G18_totaldueño];
        public string[] G18_direcciondueño = new string[G18_totaldueño];
        public int[] G18_telefonodueño = new int[G18_totaldueño];

        //Arreglos para almacenar los datos de la mascota
        public string[] G18_nombremascota = new string[G18_totalmascotas];
        public int[] G18_edadmascota = new int[G18_totalmascotas];
        public string[] G18_razamascota = new string[G18_totalmascotas];
        public string[] G18_dueñomascota = new string[G18_totalmascotas];





        public Form1()
        {
            InitializeComponent();
            

        }

        private void Listadueños_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (contadormascotas < G18_totalmascotas) //Se usa el if para verificar si hay espacio para registrar otra mascota
                {
                    //Se almacena los datos de la mascota
                    G18_nombremascota[contadormascotas] = txtnmasc.Text;
                    G18_edadmascota[contadormascotas] = int.Parse(txtedMas.Text);
                    G18_razamascota[contadormascotas] = txtrazMasc.Text;

                    //Se incrementa el contador de mascotas registradas
                    contadormascotas++;

                    //Mensaje de confirmacion del registro
                    MessageBox.Show("Estimad@ "+ textNomb.Text+" su mascota fue registrada!!!");

                    //Se limpian los espacios utilizados
                    txtnmasc.Clear();
                    txtedMas.Clear();
                    txtrazMasc.Clear();
                }
                else
                {
                    MessageBox.Show("Se ha alcanzado el número máximo de Mascotas registradas.");
                }
            }
            catch (Exception)
            {
                //Mensaje de error por si se ingresan datos inválidos
                MessageBox.Show("Error: Debes ingresar datos válidos. ");
            }
         
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (contadorDueños < G18_totaldueño)
                {
                    //
                    //Usamos los arrays e inicializamos en la posicion 0 = contadorDueños
                    G18_nombredueño[contadorDueños] = textNomb.Text;
                    G18_direcciondueño[contadorDueños] = textDirec.Text;
                    G18_telefonodueño[contadorDueños] = int.Parse(textTelef.Text);

                    //Actualización del combobox con el nombre del nuevo dueño
                    comboboxdueños.Items.Add(textNomb.Text);

                    //Se le agrega un espacio mas para que pase a la siguiente posición
                    contadorDueños++;


                   //Se presenta un messagebox indicando que el registro fue exitoso
                    MessageBox.Show("Estimad@ "+textNomb.Text + " usted acaba de registrarse");


                    //Limpiamos los espacios utilizados
                    //para que despues del registro, se pueda seguir utilizando
                    textNomb.Clear();
                    textDirec.Clear();
                    textTelef.Clear();
                }
                else
                {
                    //Gracias al If, en caso que el número ingresado pase la cantidad de espacios
                    //establecidos en los arreglos, se presentara el siguiente mensaje
                    MessageBox.Show("Se ha alcanzado el número máximo de dueños registrados.");
                }
            }
            catch (Exception)
            {
                //Manejo de excepciones en caso de datos inválidos
                MessageBox.Show("Error: Debes ingresar datos válidos. ");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void botonbuscarmascota_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de la mascota ingresado por el usuario
            string nombreMascota = txtBuscarMascota.Text;

            // Variable para almacenar el índice de la mascota encontrada
            int indiceMascota = -1;

            // Recorrer el arreglo de nombres de mascotas para buscar la coincidencia
            for (int i = 0; i < contadormascotas; i++)
            {
                if (G18_nombremascota[i] == nombreMascota)
                {
                    // Si se encuentra la mascota, guardar el índice y salir del ciclo
                    indiceMascota = i;
                    break;
                }
            }

            // Verificar si se encontró la mascota
            if (indiceMascota != -1)
            {
                // Obtener el nombre del dueño de la mascota utilizando el índice encontrado
                string nombreDueño = G18_nombredueño[indiceMascota];

                // Mostrar la información de la mascota en el label
                labelInfoMascota.Text = "Nombre de la Mascota: " + G18_nombremascota[indiceMascota] + "\n" +
                                        "Edad: " + G18_edadmascota[indiceMascota] + "\n" +
                                        "Raza: " + G18_razamascota[indiceMascota] + "\n" +
                                        "Dueño: " + nombreDueño + "\n" +
                                        "Dirección del Dueño: " + G18_direcciondueño[indiceMascota] + "\n" +
                                        "Teléfono del Dueño: " + G18_telefonodueño[indiceMascota];
            }
            else
            {
                // Si no se encontró la mascota, mostrar un mensaje indicando que no se encontró
                labelInfoMascota.Text = "Mascota no encontrada.";
            }

        }
    }

}
