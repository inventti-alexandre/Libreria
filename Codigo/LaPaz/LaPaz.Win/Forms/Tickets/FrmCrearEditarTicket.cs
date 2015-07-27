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
using LaPaz.Win.PragmaService;

namespace LaPaz.Win.Forms.Tickets
{
    public partial class FrmCrearEditarTicket : EditFormBase
    {
        public FrmCrearEditarTicket()
        {
            InitializeComponent();
        }

        private void FrmCrearEditarTicket_Load(object sender, EventArgs e)
        {
            CbxTipo.SelectedIndex = 0;
            CbxTipo.Focus();
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
                try
                {
                    PragmaService.webserv ticket = new webserv();
                    ticket.GenerarTicket(TxtConsulta.Text, CbxTipo.SelectedIndex + 1);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "No se pudo enviar el ticket por un inconveniente con Internet. Por favor intente en unos minutos");
                    throw;
                }

                
            }
        }
        
        protected override object ObtenerEntidad()
        {
            return new TicketConsulta
                       {
                           Mensaje = TxtConsulta.Text
                       };
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtConsulta, "Mensaje");
        }
    }
}
