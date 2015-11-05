using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Clientes
{
    public partial class FrmClientesListadoResumido : FormBase
    {
        public FrmClientesListadoResumido()
        {
            InitializeComponent();
        }

        public void ActualizarClientes(List<Cliente> clientes)
        {
            GrillaClientes.DataSource = clientes;
        }

        public void ActualizarRemitosVenta(List<RemitosVentaDetalle> remitosVentas)
        {
            grillaRemitos.DataSource = remitosVentas;
        }
    }
}
