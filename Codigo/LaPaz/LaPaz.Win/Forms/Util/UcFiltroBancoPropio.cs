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
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroBancoPropio : UserControlBase
    {
        public event EventHandler<BancoPropio> SeleccionarFinished;

        private BancoPropio _bancoPropio;
        public BancoPropio BancoPropio
        {
            get { return _bancoPropio; }
        }

        public int? Id
        {
            get
            {
                var bancoId = Combo.SelectedValue as int?;
                return bancoId == 0 ? null : bancoId;
            }
            set
            {
                Combo.SelectedValue = value ?? 0;
            }
        }

        public string Texto
        {
            get { return Combo.Text; }
        }

        public UcFiltroBancoPropio()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrBancosPropios_Load(object sender, EventArgs e)
        {
            CargarBancosPropios();
        }

        public void CargarBancosPropios()
        {
            if (Ioc.Container == null)
                return;
            
            var bancos = Uow.BancosPropios.Listado().OrderBy(s => s.Nombre).ToList();
            bancos.Insert(0, new BancoPropio() { Nombre= "SELECCIONE BANCO", Id = 0 });
            DefinirCombo();
            Combo.DataSource = bancos;
            DefinirCombo();
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
                SeleccionarBancoPropio();
        }

        private void SeleccionarBancoPropio()
        {
            _bancoPropio = (Id.HasValue)
                            ? Uow.BancosPropios.Obtener(p => p.Id == Id)
                            : null;
            OnSeleccionarSucursalFinished(_bancoPropio);
        }

        private void OnSeleccionarSucursalFinished(BancoPropio bancoPropio)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, bancoPropio);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = null;
        }
    }
}
