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
    public partial class PrestamosForm : Form
    {
        public PrestamosForm()
        {
            InitializeComponent();
        }

        private void PrestamosForm_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }
        private void CargarPrestamos()
        {
            try
            {
                lstPrestamos.Items.Clear();
                List<Prestamo> prestamos = new List<Prestamo>();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = PrestamoServicio.TraerTodos();
                lstPrestamos.DataSource = bindingSource1.DataSource;
                lstPrestamos.DisplayMember = "Info";
                lstPrestamos.ValueMember = "Id";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
