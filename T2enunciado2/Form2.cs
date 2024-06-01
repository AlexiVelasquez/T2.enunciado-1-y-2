using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2enunciado2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeroResultado = OrdenamientoAsc(numeroLista);

            txtAsc.Text = "";
            for (int i = 0; i < numeroResultado.Count(); i = i + 1)
            {
                txtAsc.Text = txtAsc.Text + ", " + numeroResultado[i].ToString();
            }

        }

        //Ordenamiento Ascendente

        public int[] OrdenamientoAsc(int[] numero)
        {
            int aux;
            for (int i = 0; i < numero.Length; i++)
            {
                for (int x = 0; x < numero.Length; x = x + 1) 

                for (int j = 0; j < numero.Length - i - 1; j++)
                {
                     if (numero[j] > numero[j + 1])
                     {
                            aux = numero[j + 1];
                            numero[j + 1] = numero[j];
                            numero[j] = aux;
                     }
                }    
            }

            return numero;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        //Ordenamiento Descendente

        public int[] OrdenamientoDesc(int[] numero)
        {
            int aux;
            for (int i = 0; i < numero.Length; i++)
            {
                for (int x = 0; x < numero.Length; x = x + 1)

                    for (int j = 0; j < numero.Length - i - 1; j++)
                    {
                        if (numero[j] < numero[j + 1])
                        {
                            aux = numero[j + 1];
                            numero[j + 1] = numero[j];
                            numero[j] = aux;
                        }
                    }
            }

            return numero;
        }



        //declaracion del numero
        int[] numeroLista;

        private void button3_Click(object sender, EventArgs e)
        {
            numeroLista = new int[dataGridView1.RowCount -1];

            for (int i = 0; i < dataGridView1.RowCount - 1; i = i + 1)
            {
                numeroLista[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            txtArray.Text = "";
            for (int i = 0; i < numeroLista.Count() ; i = i + 1)
            {
                txtArray.Text = txtArray.Text + ", " + numeroLista[i].ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
