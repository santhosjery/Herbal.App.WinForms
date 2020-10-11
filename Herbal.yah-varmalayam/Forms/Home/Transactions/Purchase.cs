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
    public partial class Purchase : FormBase
    {
        public Purchase(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
            dataGridViewStyle(DataGridPurchaseMaster);
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            panelPosition(PanelPurchase);
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
                TxtPurchaseCode.Text = BaseRepository.GetNextPurchaseCode();
                TxtClientInvoiceNo.Text = "";
                TxtClientName.Text = "";
                TxtClientMobileNumber.Text = "";
                DtPickerInvoiceDate.Value = DateTime.Now;
                TxtTotalGrossAmount.Text = "";
                TxtTotalDiscount.Text = "";
                TxtTotalTax.Text = "";
                TxtPaidAmount.Text = "";
                TxtDuesAmount.Text = "";
                TxtTotalNetAmount.Text = "";
                TxtQuantity.Text = "";
                LblScale.Text = "N/A";
                TxtGrossAmount.Text = "";
                TxtGrossAmount.Text = "";
                TxtCgstPercentage.Text = "";
                TxtSgstPercentage.Text = "";
                TxtNetAmount.Text = "";
                LoadProductItemsToDropDown(DropDownProductName, "");
                LoadPaymentTypeToDropDown(DropDownPaymentType, "");
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
