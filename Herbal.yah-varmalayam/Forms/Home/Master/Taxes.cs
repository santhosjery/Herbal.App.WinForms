using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.Forms
{
    public partial class Taxes : FormBase
    {
        int taxId = 0;
        public Taxes(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
            dataGridViewStyle(DataGridTaxMaster);
        }

        private void Taxes_Load(object sender, EventArgs e)
        {
            AcceptButton = BtnSaveTax;
            panelPosition(PanelTaxMaster);
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            _resetControls();
        }

        private void _resetControls()
        {
            try
            {
                BtnSaveTax.Text = Utility.SaveButton;
                BtnReset.Text = Utility.ControlResetButton;
                taxId = 0;
                TxtCGST.Text = "";
                TxtSGST.Text = "";
                TxtIGST.Text = "";
                ChkIsActive.Checked = true;
                GetGridList();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void GetGridList()
        {
            try
            {
                dataTable.Clear();
                DataGridTaxMaster.Refresh();
                DataGridTaxMaster.AutoGenerateColumns = false;
                var taxList = new TaxViewModel();
                dataTable = ConvertListToDataTable.ToDataTable(taxList.taxViewList);
                bindingSource.DataSource = dataTable;
                DataGridTaxMaster.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
