using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.PragmaService;

namespace LaPaz.Win.Forms.Configuracion
{
    public partial class FrmParametrosConfiguracion : EditFormBase
    {
        public FrmParametrosConfiguracion(ILaPazUow uow)
        {
            InitializeComponent();
            Uow = uow;
        }

        private void FrmParametrosConfiguracion_Load(object sender, EventArgs e)
        {
            txtMaximoImporteVenta.Text = Context.SucursalActual.MaximoImporteVenta.ToString("N2");
            txtPorcentajeDescuentoVenta.Text = Context.SucursalActual.MaximoPorcentajeDescuento.ToString("N2");
            txtNroLineasPorVenta.Text = Context.SucursalActual.MaximoNroLineasPorVenta.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var sucursal = ObtenerEntidadDesdeForm();
                Uow.Sucursales.Modificar(sucursal);
                Uow.Commit();
            }
        }

        protected override bool ValidarForm()
        {
            var esValido = true;
            if (string.IsNullOrEmpty(txtMaximoImporteVenta.Text))
            {
                esValido = false;
                this.FormErrorProvider.SetError(txtMaximoImporteVenta, "Debe ingresar un importe");
            }

            if (string.IsNullOrEmpty(txtPorcentajeDescuentoVenta.Text))
            {
                esValido = false;
                this.FormErrorProvider.SetError(txtPorcentajeDescuentoVenta, "Debe ingresar un porcentaje");
            }

            if (string.IsNullOrEmpty(txtNroLineasPorVenta.Text))
            {
                esValido = false;
                this.FormErrorProvider.SetError(txtNroLineasPorVenta, "Debe ingresar un número de líneas");
            }

            if (esValido)
                return base.ValidarForm();

            return false;
        }

        public Sucursal ObtenerEntidadDesdeForm()
        {
            var sucursal = Context.SucursalActual;
            sucursal.MaximoPorcentajeDescuento = Convert.ToDecimal(txtPorcentajeDescuentoVenta.Text);
            sucursal.MaximoImporteVenta = Convert.ToDecimal(txtMaximoImporteVenta.Text);
            sucursal.MaximoNroLineasPorVenta = Convert.ToInt32(txtNroLineasPorVenta.Text);
            return sucursal;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerEntidadDesdeForm();
        }
        
        protected override void ValidarControles()
        {
            this.ValidarControl(txtMaximoImporteVenta, "MaximoImporteVenta");
            this.ValidarControl(txtPorcentajeDescuentoVenta, "MaximoPorcentajeDescuento");
            this.ValidarControl(txtNroLineasPorVenta, "MaximoNroLineasPorVenta");
        }
    }
}
