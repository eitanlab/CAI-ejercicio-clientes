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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            CargarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCliente();
        }
        private void CrearCliente()
        {
            if (
                !string.IsNullOrEmpty(maskedTextBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text)
            ) { 
             try
                {
                    int resultado = ClienteServicio.InsertarCliente(
                        maskedTextBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        textBox4.Text);
                    CargarClientes();
                    maskedTextBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    MessageBox.Show("El cliente se ha insertado correctamente, el número de operación es: " + resultado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            } else
            {
                MessageBox.Show("Por favor revise los campos ingresados");
            }
        }
        private void CargarClientes()
        {
            try
            {
                listView1.Items.Clear();
                List<Cliente> listadoClientes = new List<Cliente>();
                listadoClientes = ClienteServicio.TraerClientes();
                listadoClientes.ForEach(cliente =>
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        cliente.Id.ToString(),
                        cliente.Dni.ToString(),
                        cliente.Nombre,
                        cliente.Apellido
                    });
                    listView1.Items.Add(item);
                });
                
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
