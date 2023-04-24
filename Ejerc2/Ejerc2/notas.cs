using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc2
{
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task<decimal> NotaFinalAsync(decimal num1, decimal num2, decimal num3, decimal num4)
        {
            decimal suma = await Task.Run(() =>
            {
                return (num1 + num2 + num3 + num4) / 4;

            });
            return suma;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            decimal Resultado = await NotaFinalAsync(Convert.ToDecimal(Nota1TextBox.Text), Convert.ToDecimal(Nota2TextBox.Text),
                                                     Convert.ToDecimal(Nota3TextBox.Text), Convert.ToDecimal(Nota4TextBox.Text));
            NotaFinalTextBox.Text = Resultado.ToString();
            if (Resultado >= 60)
            {
                MessageBox.Show("El Alumno Aprobo con: " + Resultado);
            }
            else
            {
                MessageBox.Show("El Alumno Reprobo con: " + Resultado);
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Nota1TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
  
