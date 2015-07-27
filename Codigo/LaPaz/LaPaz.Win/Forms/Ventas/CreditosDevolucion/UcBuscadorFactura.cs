using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Win.Forms.Ventas.CreditosDevolucion
{
    public partial class UcBuscadorFactura : UserControlBase
    {
        private readonly IVentaDetalleNegocio _ventaDetalleNegocio;
        private readonly IClock _clock;

        public UcBuscadorFactura()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            _ventaDetalleNegocio = new VentaDetalleNegocio(Uow,_clock);
            InitializeComponent();
        }

        public event EventHandler<List<VentaDetalleDto>> BuscarFinished;

        private void BtnBuscarFactura_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        private void BuscarFactura()
        {
            var textBuscarSucursal = TxtSucursal.Text.PadLeft(4,'0');
            var textBuscarNro = TxtNroFactura.Text.PadLeft(8, '0');
            var lcn = 'C' + textBuscarSucursal + textBuscarNro;

            Expression<Func<Venta, bool>> where =
                x =>
                SqlFunctions.PatIndex(lcn, x.LCN) > 0;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //var venta = Uow.Ventas.Obtener(v => v.LCN == lcn, v => v.Cliente);
                var venta =
                    Uow.Ventas.Listado(v => v.Cliente).Where(v => v.LCN == lcn).OrderByDescending(v => v.FechaAlta).
                        FirstOrDefault();
                
                if (venta ==null)
                    OnBuscarFinished(null); 
                else
                {
                    var detalle = _ventaDetalleNegocio.Listado(venta.Id).ToList();
                    Cursor.Current = Cursors.Default;

                    OnBuscarFinished(detalle);
                }
       
            }
            catch (Exception e)
            {

                //throw e;
            }
        }

        private void OnBuscarFinished(List<VentaDetalleDto> ventaDetalle)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, ventaDetalle);
            }
        }

        private void TxtNroFactura_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarFactura();
            }
        }

    }
}
