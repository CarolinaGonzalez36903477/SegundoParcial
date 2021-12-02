using pfentidades;
using pfentidades.Entidades;
using pfentidades.Modeladores;
using pfnegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial.cosola
{
    public partial class Form1 : Form
    {
        private PlazoFijoNegocio _plazoFijoNegocio;
        private TipoPlazoFijo _tipoPlazoFijo;
        private PlazoFijo _plazoFijo;

        private List<PlazoFijo> _plazosFijos;
        public Operadores _operador;

        public Form1()
        {
            _plazoFijoNegocio = new PlazoFijoNegocio();
            _tipoPlazoFijo = new TipoPlazoFijo();
            _plazoFijo = new PlazoFijo();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoPF.DataSource = _tipoPlazoFijo.CargarLista();
        }

        public void ValidacionesEntradas()
        {
            if (cmbTipoPF.SelectedItem == null || tbCapital.Text == "" || txbdias.Text == "")
            {
                throw new Exception("Debe completar y seleccionar todos los campos");
                
            }
            if (!int.TryParse(txbdias.Text, out int salida))
            {
                throw new Exception("El campo dias debe ser numerico"); 
            }
            

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesEntradas();
                TipoPlazoFijo _tipoplazo = new TipoPlazoFijo();
                _tipoplazo= (TipoPlazoFijo)cmbTipoPF.SelectedItem;
                PlazoFijo _plazonuevo = CargarPlazo(_tipoplazo);

                if (_tipoplazo.id == 1)
                {
                    txbTasainteres.Text = _tipoplazo.tasa.ToString("0.00");
                }
                if (_tipoplazo.id == 2)
                {
                    txbTasainteres.Text = _tipoplazo.tasa.ToString("0.00");
                }

                txbMontoFinal.Text = _plazonuevo.MontoFinal.ToString("0.00");
                txbinteres.Text = _plazonuevo.Interes.ToString("0.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Limpiar();
            }

          

        }

        public PlazoFijo CargarPlazo(TipoPlazoFijo _tipoplazo)
        {
            PlazoFijo _nuevoPlazo = new PlazoFijo();
            
            _nuevoPlazo.Tipo = _tipoplazo.id;
            _nuevoPlazo.Tasa = _tipoplazo.tasa;
            _nuevoPlazo.CapitalInicial = Convert.ToDouble(tbCapital.Text);
            _nuevoPlazo.dias = Convert.ToInt32(txbdias.Text);

           return  _nuevoPlazo; 
        
        }

        public PlazoFijo CrearPlazo()
        {

            _plazoFijo.Tipo = ((TipoPlazoFijo)cmbTipoPF.SelectedItem).id;
            _plazoFijo.Tasa = ((TipoPlazoFijo)cmbTipoPF.SelectedItem).tasa;
            _plazoFijo.CapitalInicial = Convert.ToDouble(tbCapital.Text);
            _plazoFijo.dias = Convert.ToInt32(txbdias.Text);
            txbMontoFinal.Text = _plazoFijo.MontoFinal.ToString("0.00");
            txbinteres.Text = _plazoFijo.Interes.ToString("0.00");

            return _plazoFijo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TransactionResult _resultado = new TransactionResult();
            try
            {
                _plazoFijo = CrearPlazo();
                _resultado = _plazoFijoNegocio.Alta(_plazoFijo);
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Limpiar();
            }
           

        }

        public void Refrescar()
        {
            _plazosFijos = _plazoFijoNegocio.TraerPlazosFijos();
            lstboxPlazo.DataSource = _plazosFijos;
            _operador = new Operadores(_plazosFijos);
            txbComisionTotal.Text = _operador.ComisitiontOTAL().ToString("0.00");
            txbtMontototal.Text = _operador.MontoTotal().ToString("0.00");
        
        }

        public void Limpiar()
        {
            txbdias.Clear();
            txbinteres.Clear();
            txbMontoFinal.Clear();
            txbinteres.Clear();
            txbTasainteres.Clear();
            tbCapital.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
