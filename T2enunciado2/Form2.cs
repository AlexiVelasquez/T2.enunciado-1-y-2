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
        //declaracion del numero
        int[] numeroLista;


        private void button3_Click(object sender, EventArgs e)
        {
            numeroLista = new int[dataGridView1.RowCount - 1];

            for (int i = 0; i < dataGridView1.RowCount - 1; i = i + 1)
            {
                numeroLista[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            txtArray.Text = "";
            for (int i = 0; i < numeroLista.Count(); i = i + 1)
            {
                txtArray.Text = txtArray.Text + ", " + numeroLista[i].ToString();
            }
        }


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
            int[] numeroResultado = OrdenamientoDesc(numeroLista);

            txtDesc.Text = "";
            for (int i = 0; i < numeroResultado.Count(); i = i + 1)
            {
                txtDesc.Text = txtDesc.Text + ", " + numeroResultado[i].ToString();
            }
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBusq.Text = BusquedaNumero(numeroLista, int.Parse(txtBusq.Text)).ToString();
        }

        //Búsqueda de número ingresado en el array
        public int BusquedaNumero(int[] numeroLista, int ValorBuscado)
        {
            for (int i = 0; i < numeroLista.Length; i++)
            {
                //Si el número ingresado se encuentra en el array, se mostrará una ventana indicando que fue encontrado
                if (numeroLista[i] == ValorBuscado)
                {
                    MessageBox.Show("Número encontrado");
                    return ValorBuscado;
                }

                //Si el número ingresado no se encuentra en el array, se mostrará una ventana indicando que no fue encontrado
            }
            MessageBox.Show("Número no encontrado");
            return ValorBuscado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numeroEliminar;

            if (!int.TryParse(txtBusq.Text, out numeroEliminar))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }
            bool encontrado = false;
            for (int i = 0; i < numeroLista.Length; i++)
            {
                if (numeroLista[i] == numeroEliminar)
                {
                    encontrado = true;

                    for (int j = i; j < numeroLista.Length - 1; j++)
                    {
                        numeroLista[j] = numeroLista[j + 1];
                    }

                    Array.Resize(ref numeroLista, numeroLista.Length - 1);
                    MessageBox.Show($"El número {numeroEliminar} ha sido eliminado de la lista.");

                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show($"El número {numeroEliminar} no se encontró en la lista.");
            }

            MostrarListaActualizada();
        }

        private void MostrarListaActualizada()
        {
            txtArray.Text = string.Join(", ", numeroLista);
        }
    }
 }
    
