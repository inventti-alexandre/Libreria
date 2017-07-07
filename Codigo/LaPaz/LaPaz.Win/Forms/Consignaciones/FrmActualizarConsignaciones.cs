using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class FrmActualizarConsignaciones : FormBaseListado
    {
        List<TitulosMovimiento> _movimientos;
        IVentaNegocio _venta;
        public FrmActualizarConsignaciones(ILaPazUow uow, IVentaNegocio ventaNegocio)
        {
            Uow = uow;
            _venta = ventaNegocio;
            InitializeComponent();
        }

        private void FrmActualizarConsignaciones_Load(object sender, EventArgs e)
        {
            //GridMovimientos.DataSource = _movimientos;
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            _movimientos = Uow.TitulosMovimiento.Listado().Where(tm => tm.Id > 1497489).ToList();
            GridMovimientos.DataSource = _movimientos;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Titulo titulo;
            foreach (var tituloMovimiento in _movimientos)
            {
                titulo = Uow.Titulos.Obtener(t => t.Id == tituloMovimiento.TituloId);
                _venta.ActualizarTitulosConsignaciones(tituloMovimiento.TituloId, titulo.ProveedorId,tituloMovimiento.CntMinCn, Context.SucursalActual.Id);
            }
            
        }
    }
}
