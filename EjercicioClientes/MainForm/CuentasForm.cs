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
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CargarClientes()
        {
            try
            {
                cmbClientes.Items.Clear();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = ClienteServicio.TraerClientes();
                cmbClientes.DataSource = bindingSource1.DataSource;
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "Id";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CrearCuenta()
        {
            if (
                !string.IsNullOrEmpty(txtNumeroCuenta.Text) &&
                !string.IsNullOrEmpty(txtDescripcion.Text)
            )
            {
                try
                {
                    int resultado = CuentasServicio.InsertarCuenta(
                        txtNumeroCuenta.Text,
                        txtDescripcion.Text,
                        cmbClientes.SelectedValue.ToString());
                    CargarListadoCuentas();
                    txtNumeroCuenta.Clear();
                    txtDescripcion.Clear();
                    cmbClientes.SelectedIndex = 0;
                    MessageBox.Show("La cuenta se ha insertado correctamente, el número de operación es: " + resultado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor revise los campos ingresados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCuenta();
        }
    }
}
