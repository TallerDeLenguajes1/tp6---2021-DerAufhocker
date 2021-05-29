using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        clases.ClaseSuma objetoSuma = new clases.ClaseSuma();
        clases.ClaseResta objetoResta = new clases.ClaseResta();
        clases.ClaseProducto objetoProduto = new clases.ClaseProducto();
        clases.ClaseDivision objetoDivision = new clases.ClaseDivision();
        private void btn_1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(pantalla.Text);
            double resultado;

            switch (operador)
            {
                case "+":
                    resultado = objetoSuma.Sumar(num1, num2);
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = objetoResta.Restar(num1, num2);
                    pantalla.Text = resultado.ToString();
                    break;
                case "x":
                    resultado = objetoProduto.Producto(num1, num2);
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        pantalla.Text = "indefinido";
                        pantalla.Clear();
                    }
                    else
                    {
                        resultado = objetoDivision.Division(num1, num2);
                        pantalla.Text = resultado.ToString();
                    }
                    break;
            }

        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }



    }
}
