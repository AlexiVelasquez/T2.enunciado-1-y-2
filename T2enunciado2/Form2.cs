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
            

        }

        //declaracion del numero
        int[] numeroLista;

        private void button3_Click(object sender, EventArgs e)
        {
            numeroLista = new int[dataGridView1.RowCount];

            for (int i = 0; i < dataGridView1.RowCount - 1; i = i + 1)
            {
                numeroLista[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            for (int i = 0; i < numeroLista.Count() - 1; i = i + 1)
            {
                txtArray.Text = txtArray.Text + ", " + numeroLista[i].ToString();
            }
        }
    }
}
