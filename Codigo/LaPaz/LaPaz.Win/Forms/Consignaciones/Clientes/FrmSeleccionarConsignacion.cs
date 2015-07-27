using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Entidades.Dto;
namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class FrmSeleccionarConsignacion : FormBase
    {
        private readonly IList<RemitosVentaDto> _consignacion; 

        public FrmSeleccionarConsignacion(List<RemitosVentaDto> consignacion )
        {
            _consignacion = consignacion;
            InitializeComponent();
        }

        public event EventHandler<RemitosVentaDto> ConsignacionSelected; 

        private void FrmSeleccionarConsignacion_Load(object sender, EventArgs e)
        {
            this.GrillaSeleccionarCliente.DataSource = _consignacion;
        }

        private void GrillaSeleccionarCliente_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GrillaSeleccionarCliente.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var consignacion = selectedRow.DataBoundItem as RemitosVentaDto;

            if (consignacion == null)
                return;

            OnConsignacionSelected(consignacion);
        }

        private void OnConsignacionSelected(RemitosVentaDto consignacion)
        {
            if (ConsignacionSelected != null)
            {
                ConsignacionSelected(this, consignacion);
            }
        }

        private void GrillaSeleccionarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedRow = GrillaSeleccionarCliente.SelectedRows[0];

                var selectedConsignacion = selectedRow.DataBoundItem as RemitosVentaDto;

                if (selectedConsignacion != null)
                {
                    OnConsignacionSelected(selectedConsignacion);
                }

                e.Handled = true;
            }
        }
    }
}
