using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class UcConsignacionesProveedorListado : UserControlBase
    {
        public UcConsignacionesProveedorListado()
        {
            InitializeComponent();
        }

        public event EventHandler<Guid> AbrirDetalle;

        public List<ProveedorConsignacionDto> Consignaciones
        {
            set
            {
                this.GridConsignaciones.DataSource = value;
            }
        }

        private void GridConsignaciones_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var consignacion = commandCell.RowElement.RowInfo.DataBoundItem as ProveedorConsignacionDto;

            if (consignacion == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(consignacion.Id);
                    break;
            }
        }

        private void Detalle(Guid id)
        {
            OnAbrirDetalle(id);
        }

        private void OnAbrirDetalle(Guid id)
        {
            if (AbrirDetalle != null)
            {
                AbrirDetalle(this, id);
            }
        }

        private void UcConsignacionesProveedorListado_Load(object sender, EventArgs e)
        {

            this.GridConsignaciones.Columns["FechaConsignacion"].DataType = typeof(DateTime);
            this.GridConsignaciones.Columns["FechaConsignacion"].FormatString = "{0: dd/M/yyyy}";
            this.GridConsignaciones.Columns["UltimaFechaPago"].DataType = typeof(DateTime);
            this.GridConsignaciones.Columns["UltimaFechaPago"].FormatString = "{0: dd/M/yyyy}";
            this.GridConsignaciones.Columns["Importe"].DataType = typeof(decimal);
            this.GridConsignaciones.Columns["Importe"].FormatString = "{0:N2}";
            this.GridConsignaciones.Columns["Pagado"].DataType = typeof(decimal);
            this.GridConsignaciones.Columns["Pagado"].FormatString = "{0:N2}";
        }
    }
}
