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


                    MessageBox.Show(textNomb.Text + " fue registrado!!!");


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
    }

}
