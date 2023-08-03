using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{





    public partial class Form1 : Form
    {



        ControlCalculadora modelo;
        public Form1()
        {
            InitializeComponent();
            this.modelo = new ControlCalculadora();
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }//campo calculadora

       

       


        private void Form1_Load(object sender, EventArgs e)
        {


        }//codigo

       
        
       

       

        private void button1_Click(object sender, EventArgs e)
        {
          
                maskedTextBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));
            //fim do botão somar



        }//botao soma

        private void label2_Click(object sender, EventArgs e)
        {
            
        }//campo digite numero

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// campo para digitar um numero

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }//fim do botão subtrair

        private void button3_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = "" + this.modelo.Dividir(Convert.ToDouble(maskedTextBox1.Text));
        }//botao dividir

        private void button4_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = "" + this.modelo.Multiplicar(Convert.ToDouble(maskedTextBox1.Text));
        
        
        }//botao multipicar

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.potencia(Convert.ToDouble(maskedTextBox1.Text));
        }//botao potencia

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.potencia(Convert.ToDouble(maskedTextBox1.Text));   
        }//botao raiz
    }
}//fim da classe

