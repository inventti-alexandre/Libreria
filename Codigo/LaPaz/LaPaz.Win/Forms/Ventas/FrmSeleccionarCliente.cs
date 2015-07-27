using LaPaz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmSeleccionarCliente : FormBase
    {
        private readonly IList<Cliente> _clientes; 

        public FrmSeleccionarCliente(List<Cliente> clientes)
        {
            _clientes = clientes;
            InitializeComponent();
        }

        public event EventHandler<Cliente> ClienteSelected; 

        private void FrmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            this.GrillaSeleccionarCliente.DataSource = _clientes;
        }

        private void GrillaSeleccionarCliente_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GrillaSeleccionarCliente.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var cliente = selectedRow.DataBoundItem as Cliente;

            if (cliente == null)
                return;

            OnClienteSelected(cliente);
        }

        private void OnClienteSelected(Cliente cliente)
        {
            if (ClienteSelected != null)
            {
                ClienteSelected(this, cliente);
            }
        }

        private void GrillaSeleccionarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedRow = GrillaSeleccionarCliente.SelectedRows[0];

                var selectedCliente = selectedRow.DataBoundItem as Cliente;

                if (selectedCliente != null)
                {
                    OnClienteSelected(selectedCliente);
                }

                e.Handled = true;
            }
        }
    }
}
