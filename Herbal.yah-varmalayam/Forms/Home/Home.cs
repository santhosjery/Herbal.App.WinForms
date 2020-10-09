using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.Forms.Home
{
    public partial class Home : FormBase
    {
        public Home(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemProduct_Click(object sender, EventArgs e)
        {
            this.Text = Utility.ProductFormName;
            ShowAppropriateForm(new Products(this.userViewModel));
        }
        private void ShowAppropriateForm(Form form)
        {
            //Use this as common method to view appropriate view model.
            form.TopLevel = false;
            this.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        private void MenuItemTaxes_Click(object sender, EventArgs e)
        {
            this.Text = Utility.TaxMasterFormName;
            ShowAppropriateForm(new Taxes(this.userViewModel));
        }

        private void MenuItemCompanyDetail_Click(object sender, EventArgs e)
        {
            this.Text = Utility.CompanyDetailFormName;
            ShowAppropriateForm(new CompanyDetails(this.userViewModel));
        }

        private void MenuItemPurchase_Click(object sender, EventArgs e)
        {
            this.Text = Utility.PurchaseFormName;
            ShowAppropriateForm(new Purchase(this.userViewModel));
        }

        private void MenuItemSales_Click(object sender, EventArgs e)
        {
            this.Text = Utility.SalesFormName;
            ShowAppropriateForm(new Sales(this.userViewModel));
        }

        private void MenuItemPurchaseReport_Click(object sender, EventArgs e)
        {
            this.Text = Utility.PurchaseReportFormName;
            ShowAppropriateForm(new PurchaseReport(this.userViewModel));
        }

        private void MenuItemSalesReport_Click(object sender, EventArgs e)
        {
            this.Text = Utility.SalesReportFormName;
            ShowAppropriateForm(new SalesReport(this.userViewModel));
        }

        private void MenuItemStockReport_Click(object sender, EventArgs e)
        {
            this.Text = Utility.StockReportFormName;
            ShowAppropriateForm(new StockReport(this.userViewModel));
        }

        private void MenuItemManageUsers_Click(object sender, EventArgs e)
        {
            this.Text = Utility.ManageUserFormName;
            ShowAppropriateForm(new ManageUsers(this.userViewModel));
        }

        private void MenuItemHone_Click(object sender, EventArgs e)
        {
            //this.Text = Utility.HomeFormName;
            //ShowAppropriateForm(new Home(this.userViewModel));
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            showMessageBox.ShowMessage("Developed by Santhosh. \r\r\tContact no : 9095349906 \r\r\tVersion : 1.0");
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            int result = showMessageBox.ShowMessage(Utility.ExitTitle, Utility.ExitTitleMessage);
            if (result == 1)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void MenuItemLogOut_Click(object sender, EventArgs e)
        {
            Forms.Login.Login LoginHome = new Forms.Login.Login();
            LoginHome.Show();
            this.Close();
        }
    }
}
