using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Controls;
using LaPaz.Datos.Interfaces;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Helpers;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms
{
    public class FormBaseListado : FormBase
    {
        public bool CargarGrillaOnLoad { get; set; }
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public RadGridView MainGrid { get; set; }
        public MetroPager MainPager { get; set; }
        public Dictionary<string, string> SortColumnMappings { get; set; }
        public UcProgressSpinner Spinner { get; set; }

        public FormBaseListado()
        {
            CargarGrillaOnLoad = true;
        }

        public void FormBaseListado_Load(object sender, EventArgs e)
        {
            MainGrid.SortChanged += MainGridOnSortChanged;
            MainGrid.DataBindingComplete += MainGridOnDataBindingComplete;
        }

        private void MainGridOnDataBindingComplete(object sender, GridViewBindingCompleteEventArgs gridViewBindingCompleteEventArgs)
        {
            Spinner.Hide();
        }

        private void MainGridOnSortChanged(object sender, GridViewCollectionChangedEventArgs gridViewCollectionChangedEventArgs)
        {
            var sort = gridViewCollectionChangedEventArgs.GridViewTemplate.Sort;
            var split = sort.Split(' ');
            SortColumn = FinalSortColumn(split[0]);
            SortDirection = split[1];
            MainPager.CurrentPage = 0;
            RefrescarListado();
        }

        public virtual async Task<int> RefrescarListado()
        {
            return 0;
        }

        private string FinalSortColumn(string column)
        {
            if (SortColumnMappings == null || !SortColumnMappings.ContainsKey(column))
                return column;
            return SortColumnMappings[column];
        }
    }
}
