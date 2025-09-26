using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1._2
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtDato.Text);
                cola.Encolar(valor);
                MostrarCola();
                txtDato.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                int eliminado = cola.Desencolar();
                MessageBox.Show("Se eliminó: " + eliminado);
                MostrarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                int primero = cola.Peek();
                MessageBox.Show("El primer elemento es: " + primero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (cola.EstaVacia())
                MessageBox.Show("La cola está vacía");
            else
                MessageBox.Show("La cola NO está vacía");
        }
        private void MostrarCola()
        {
            listCola.Items.Clear();
            foreach (var item in cola.ObtenerElementos())
            {
                listCola.Items.Add(item);
            }
        }
    }
}
