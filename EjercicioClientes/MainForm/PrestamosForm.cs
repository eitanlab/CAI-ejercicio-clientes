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
                prestamos = PrestamoServicio.TraerTodos();
                Operador operador = new Operador(prestamos);
                txtComisionTotal.Text = operador.PorcentajeComision.ToString();
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
        private void limpiarForm()
        {
            txtComisionTotal.Clear();
            txtCuotaCapital.Clear();
            txtCuotaInteres.Clear();
            txtCuotaTotal.Clear();
            numMonto.Value = 1;
            numPlazo.Value = 1;
        }
        private void SimularPrestamo(string linea, double tna,int plazo,double monto)
        {
            if (string.IsNullOrEmpty(linea) || tna <= 0 || plazo <=0 || monto <= 0)
            {
                MessageBox.Show("Para simular un préstamo debe seleccionar un Tipo de Prestamo e ingresar plazo y monto positivos");
                return;
            }
            Prestamo prestamoSimulado = new Prestamo(linea,tna,plazo,monto);
            txtCuotaCapital.Text = prestamoSimulado.CuotaCapital.ToString();
            txtCuotaInteres.Text = prestamoSimulado.CuotaInteres.ToString();
            txtCuotaTotal.Text = prestamoSimulado.Cuota.ToString();
        }
        private void AltaPrestamo(string linea,double tna, int plazo, double monto)
        {
            if (string.IsNullOrEmpty(linea) || tna <= 0 || plazo <= 0 || monto <= 0)
            {
                MessageBox.Show("Para simular un préstamo debe seleccionar un Tipo de Prestamo e ingresar plazo y monto positivos");
                return;
            }
            try
            {
                Prestamo prestamo = new Prestamo(linea, tna, plazo, monto);
                int resultado = PrestamoServicio.InsertarPrestamo(prestamo);
                MessageBox.Show("Prestamo con ID " + resultado + " creado con éxito");
            } catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }
        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoPrestamos.SelectedIndex == -1) return;
            LlenarCamposTiposPrestamo(int.Parse(lstTipoPrestamos.SelectedValue.ToString()));
            limpiarForm();
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            SimularPrestamo(txtLinea.Text ,double.Parse(txtTNA.Text), (int)numPlazo.Value, (double)numMonto.Value);
        }
        private void btnAltaPrestamo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLinea.Text) || string.IsNullOrEmpty(txtTNA.Text) || string.IsNullOrEmpty(txtCuotaCapital.Text) || 
                string.IsNullOrEmpty(txtCuotaInteres.Text) || string.IsNullOrEmpty(txtCuotaTotal.Text))
            {
                MessageBox.Show("Para ingresar un préstamo debe seleccionar un Tipo de Prestamo e ingresar plazo y monto positivos");
                return;
            }
            AltaPrestamo(txtLinea.Text, double.Parse(txtTNA.Text), (int)numPlazo.Value, (double)numMonto.Value);
            limpiarForm();
            CargarPrestamos();
        }

    }
}
