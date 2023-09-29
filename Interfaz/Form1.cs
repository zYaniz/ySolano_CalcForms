using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ysolano_CalcForms
{
    public partial class Form1 : Form
    {
        int primero;
        int segundo;
        string ope;
        public Form1()
        {
            InitializeComponent();
        }
        Operacion.Operacion dato = new Operacion.Operacion();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = int.Parse(btnPantalla.Text);
            int S;
            int R;
            int M;
            int D;

            switch (ope)
            {
                case "+":
                    S = dato.Sumar((primero),(segundo));
                    btnPantalla.Text = S.ToString();
                    break;
                case "-":
                    R = dato.Restar((primero), (segundo));
                    btnPantalla.Text = R.ToString();
                    break;
                case "*":
                    M = dato.Multiplicar((primero), (segundo));
                    btnPantalla.Text = M.ToString();
                    break;
                case "/":
                    D = dato.Division((primero), (segundo));
                    btnPantalla.Text = D.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "9";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            ope = "+";
            primero = int.Parse(btnPantalla.Text);
            btnPantalla.Clear();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            ope = "-";
            primero = int.Parse(btnPantalla.Text);
            btnPantalla.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            ope = "*";
            primero = int.Parse(btnPantalla.Text);
            btnPantalla.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            ope = "/";
            primero = int.Parse(btnPantalla.Text);
            btnPantalla.Clear();
        }
    }
}
