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
        List<TipoPrestamo> tiposPrestamo;
        List<Prestamo> prestamos;
        public PrestamosForm()
        {
            InitializeComponent();
            tiposPrestamo = new List<TipoPrestamo>();
            prestamos = new List<Prestamo>();
        }

        private void PrestamosForm_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            CargarTiposPrestamo();
            lstTipoPrestamos.SelectedIndex = 0;
        }
        private void CargarPrestamos()
        {
            try
            {
                lstPrestamos.Items.Clear();
                prestamos = PrestamoServicio.TraerTodos();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = prestamos;
                lstPrestamos.DataSource = bindingSource1.DataSource;
                lstPrestamos.DisplayMember = "Info";
                lstPrestamos.ValueMember = "Id";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CargarTiposPrestamo()
        {
            try
            {
                lstTipoPrestamos.Items.Clear();
                tiposPrestamo = PrestamoServicio.TraerTiposPrestamo();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = tiposPrestamo;
                lstTipoPrestamos.SelectedIndexChanged -= lstTipoPrestamos_SelectedIndexChanged;
                lstTipoPrestamos.DataSource = bindingSource1.DataSource;
                lstTipoPrestamos.DisplayMember = "Linea";
                lstTipoPrestamos.ValueMember = "Id";
                lstTipoPrestamos.SelectedIndexChanged += lstTipoPrestamos_SelectedIndexChanged;
                lstTipoPrestamos.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void LlenarCamposTiposPrestamo(int id)
        {
            if(id >= 0)
            {
                tiposPrestamo.ForEach(tipoItem =>
                {
                    if(tipoItem.Id == id)
                    {
                        txtLinea.Text = tipoItem.Linea;
                        txtTNA.Text = tipoItem.TNA.ToString();
                    }
                });
                numPlazo.Value = 1;
                numMonto.Value = 1;
            }
        }
        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoPrestamos.SelectedIndex == -1) return;
            LlenarCamposTiposPrestamo(int.Parse(lstTipoPrestamos.SelectedValue.ToString()));
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTNA.Text) || string.IsNullOrEmpty(txtLinea.Text)) {
                MessageBox.Show("Para simular un préstamo debe seleccionar un Tipo de Prestamo");
                return;
            }
            Prestamo prestamoSimulado = new Prestamo(double.Parse(txtTNA.Text), (int)numPlazo.Value, (double)numMonto.Value);
            txtCuotaCapital.Text = prestamoSimulado.CuotaCapital.ToString();
            txtCuotaInteres.Text = prestamoSimulado.CuotaInteres.ToString();
            txtCuotaTotal.Text = prestamoSimulado.Cuota.ToString();

        }
    }
}
