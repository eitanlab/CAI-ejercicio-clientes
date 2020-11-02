using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClienteServicio servicio = new ClienteServicio();
            List<Cliente> listadoClientes = new List<Cliente>();
            listadoClientes = servicio.TraerClientes();
            listBox1.DataSource = listadoClientes;
            //listadoClientes.ForEach(cliente => listBox1.DataSource = cliente.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormHelpers.ValidarDni(textBox1.Text))
            {
                if (FormHelpers.ValidarNull(textBox2.Text))
                {
                    if (FormHelpers.ValidarNull(textBox3.Text))
                    {
                        if (FormHelpers.ValidarNull(textBox4.Text))
                        {
                            ClienteServicio servicio = new ClienteServicio();
                            int resultado = servicio.InsertarCliente(
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text);
                            MessageBox.Show("El cliente se ha insertado correctamente, el número de operación es: " + resultado);
                        }
                    }
                }
            }    
        }
    }
}
