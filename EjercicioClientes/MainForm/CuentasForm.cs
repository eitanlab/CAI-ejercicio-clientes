using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace MainForm
{
    public partial class CuentasForm : Form
    {
        public CuentasForm()
        {
            InitializeComponent();
        }

        private void CuentasForm_Load(object sender, EventArgs e)
        {
            listCuentas.View = View.Details;
            CargarListadoCuentas();
            CargarClientes();
        }
        private void CargarListadoCuentas()
        {
            try
            {
                listCuentas.Items.Clear();
                List<Cuenta> lst = CuentasServicio.TraerTodos();
                lst.ForEach(cuenta =>
                {
                    string activo = cuenta.Activo ? "Si" : "No";
                    ListViewItem item = new ListViewItem(new string[]
                    {
                           cuenta.Id.ToString(),
                           cuenta.NroCuenta,
                           cuenta.Descripcion,
                           cuenta.FechaApertura,
                           cuenta.FechaModificacion,
                           activo
                    });
                    listCuentas.Items.Add(item);
                });
                
                
                // listCuentas.
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CargarClientes()
        {
            try
            {
                cmbCientes.Items.Clear();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = ClienteServicio.TraerClientes();
                cmbCientes.DataSource = bindingSource1.DataSource;
                cmbCientes.DisplayMember = "Nombre";
                cmbCientes.ValueMember = "Id";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
