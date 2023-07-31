using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    
    public partial class Form1 : Form
    {
        controlCalculadora modelo;
        public Form1()
        {
            InitializeComponent();
            this.modelo = new controlCalculadora();
        }

       
        //Conectando a Control com a Modelo
        public Form1()
        {
            InitializeComponent();
            this.modelo = new controlCalculadora();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }//campo calculadora

       

       


        private void Form1_Load(object sender, EventArgs e)
        {


        }//codigo

       

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }//botao soma

        private void label2_Click(object sender, EventArgs e)
        {

        }//campo digite numero

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// campo para digitar um numero
    }//fim da classe
}
