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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuentasForm cuentasForm = new CuentasForm();
            cuentasForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrestamosForm prestamosForm = new PrestamosForm();
            prestamosForm.ShowDialog();
        }
    }
}
