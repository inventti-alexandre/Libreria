using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Framework.Comun.Validation;
using LaPaz.Datos;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;
using LaPaz.Win.Factory;
using Telerik.WinControls;

namespace LaPaz.Win.Forms.Senias
{
    public partial class FrmAnularSenia : EditFormBase
    {
        private readonly ICajaMovientoFactory _cajaMovientoFactory;
        public ProveedorSenia Senia { get; set; }
        public decimal Maximo { get; set; }

        public FrmAnularSenia(ILaPazUow uow, Guid id, ICajaMovientoFactory cajaMovientoFactory)
        {
            _cajaMovientoFactory = cajaMovientoFactory;
            Uow = uow;
            Senia = Uow.ProveedoresSenias.Obtener(s => s.Id == id);
            InitializeComponent();
        }

        private void FrmAnularSenia_Load(object sender, EventArgs e)
        {
            Maximo = Senia.Importe.GetValueOrDefault() - Senia.ImporteUsado.GetValueOrDefault();
            TxtImporte.Text = Maximo.ToString("N2");
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var anular = Convert.ToDecimal(TxtImporte.Text);
                if (Maximo == anular)
                    Senia.FechaAnulacion = DateTime.Now;

                Senia.ImporteUsado += anular;

                Uow.ProveedoresSenias.Modificar(Senia);

                var cajaMovimiento = _cajaMovientoFactory.Create(TipoComprobanteEnum.SeñaProveedor,
                    TipoMovimientoCajaEnum.AnulacionSeniaProveedor, Senia.Id, anular);

                Uow.CajaMovimientos.Agregar(cajaMovimiento);

                Uow.Commit();
            }
        }

        protected virtual bool ValidarForm()
        {
            //Validate
            if (string.IsNullOrEmpty(TxtImporte.Text))
            {
                this.FormErrorProvider.SetError(TxtImporte, "Debe ingresar un importe");
                return false;
            }

            decimal valor = -1;
            var converted = decimal.TryParse(TxtImporte.Text, out valor);
            if (valor <= 0 || valor > Senia.Importe - Senia.ImporteUsado.GetValueOrDefault())
            {
                this.FormErrorProvider.SetError(TxtImporte, "El importe ingresado no es válido");
                return false;
            }
            return true;
        }
    }
}
