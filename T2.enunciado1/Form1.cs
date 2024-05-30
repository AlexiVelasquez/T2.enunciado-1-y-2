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
        public static int G18_totaldueño = 100;
        public static int G18_totalmascotas = 100;
        private int contadorDueños = 0;
        private int contadormascotas = 0;

        public static string[] G18_nombredueño = new string[G18_totaldueño];
        public string[] G18_direcciondueño = new string[G18_totaldueño];
        public int[] G18_telefonodueño = new int[G18_totaldueño];

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
                if (contadormascotas < G18_totalmascotas)
                {

                    G18_nombremascota[contadormascotas] = txtnmasc.Text;
                    G18_edadmascota[contadormascotas] = int.Parse(txtedMas.Text);
                    G18_razamascota[contadormascotas] = txtrazMasc.Text;

                    contadormascotas++;


                    MessageBox.Show("Estimad@ " +" su mascota fue registrada!!!");


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

                    G18_nombredueño[contadorDueños] = textNomb.Text;
                    G18_direcciondueño[contadorDueños] = textDirec.Text;
                    G18_telefonodueño[contadorDueños] = int.Parse(textTelef.Text);


                    comboboxdueños.Items.Add(textNomb.Text);


                    contadorDueños++;


                    MessageBox.Show("Estimad@ "+textNomb.Text + " usted acaba de registrarse");


                    textNomb.Clear();
                    textDirec.Clear();
                    textTelef.Clear();
                }
                else
                {
                    MessageBox.Show("Se ha alcanzado el número máximo de dueños registrados.");
                }
            }
            catch (Exception)
            {
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
            string nombreMascota = txtBuscarMascota.Text;
            int indiceMascota = -1;

            for (int i = 0; i < contadormascotas; i++)
            {
                if (G18_nombremascota[i] == nombreMascota)
                {
                    indiceMascota = i;
                    break;
                }
            }

            if (indiceMascota != -1)
            {
                string nombreDueño = G18_nombredueño[indiceMascota];

                labelInfoMascota.Text = "Nombre de la Mascota: " + G18_nombremascota[indiceMascota] + "\n" +
                                         "Edad: " + G18_edadmascota[indiceMascota] + "\n" +
                                         "Raza: " + G18_razamascota[indiceMascota] + "\n" +
                                         "Dueño: " + nombreDueño + "\n" +
                                         "Dirección del Dueño: " + G18_direcciondueño[indiceMascota] + "\n" +
                                         "Teléfono del Dueño: " + G18_telefonodueño[indiceMascota];
            }
            else
            {
                labelInfoMascota.Text = "Mascota no encontrada.";
            }

        }
    }

}
