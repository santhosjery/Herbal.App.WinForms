using Herbal.yah_varmalayam.Models;
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
    public partial class Products : FormBase
    {
        int productId = 0;
        public Products(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            GenerateProductCode();
            GetGridList();
            panelPosition(PanelProductMaster);
        }

        private void GenerateProductCode()
        {
            TxtProductCode.Text = "Test";
        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtProductName.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Product Name"));
                    TxtProductName.Focus();
                    return;
                }
                if (_isProductNameAlreadyExists(TxtProductName.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.AlreadyExists, "Product Name"));
                    TxtProductName.Focus();
                    return;
                }
                Product products = new Product();
                if (productId == 0)
                {
                    herbalContext.Products.Add(products);
                    products.CreatedBy = userViewModel.UserId;
                    products.CreatedOn = DateTime.Now;
                }
                else
                {
                    products = herbalContext.Products.Where(_ => _.Id == productId).Single();
                    products.ModifiedBy = userViewModel.UserId;
                    products.ModifiedOn = DateTime.Now;
                }
                products.CategoryId = (int)Utility.CategoryTypes.Herbal;
                products.ProductCode = TxtProductCode.Text.ToString();
                products.ProductName = TxtProductName.Text.ToString();
                products.IsActive = ChkIsActive.Checked;
                herbalContext.SaveChanges();
                showMessageBox.ShowMessage(string.Format((productId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "product"));
                _resetControls();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private bool _isProductNameAlreadyExists(string productName)
        {
            return herbalContext.Products.Where(_ => _.ProductName == productName
                                        && (productId == 0 || _.Id != productId)).Any();
        }

        private void _resetControls()
        {
            productId = 0;
            TxtProductCode.Text = "test2";
            TxtProductName.Text = "";
            ChkIsActive.Checked = true;
            GetGridList();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _resetControls();
        }
        private void GetGridList()
        {
            try
            {
                DataGridProductMaster.Refresh();
                DataGridProductMaster.AutoGenerateColumns = false;
                var productList = new ProductViewModel(TxtSearchItem.text ?? "");
                dataGridViewStyle(DataGridProductMaster);
                DataGridProductMaster.DataSource = productList.productViewList;
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetGridList();
        }

        private void DataGridProductMaster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataGridProductMaster_Click(object sender, EventArgs e)
        {

        }

        private void DataGridProductMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if(DataGridProductMaster.Rows.Count > 0)
            {
                int columnIndex = DataGridProductMaster.CurrentCell.ColumnIndex;
                string text = DataGridProductMaster.Columns[columnIndex].HeaderText;
                if(text.Equals("Delete"))
                {
                    _deleteProduct();
                }
                if(text.Equals("Edit"))
                {
                    _editProduct();
                }
            }
        }
        private void _deleteProduct()
        {
            try
            {
                int RowIndex = DataGridProductMaster.CurrentCell.RowIndex;
                productId = Convert.ToInt32(DataGridProductMaster.Rows[RowIndex].Cells["Id"].Value);
                var productName = DataGridProductMaster.Rows[RowIndex].Cells["ProductName"].Value.ToString();
                if (BaseRepository.IsProductHasPurchaseOrSales(productId))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.UnableToDeleteMessage, productName));
                    return;
                }
                int result = showMessageBox.ShowMessage(Utility.DeleteTitle, string.Format(Utility.DeleteMessage, productName));
                if (result == 1)
                {
                    var deleteProduct = herbalContext.Products.Where(_ => _.Id == productId).First();
                    herbalContext.Products.Remove(deleteProduct);
                    herbalContext.SaveChanges();
                    showMessageBox.ShowMessage(string.Format(Utility.DeleteSuccessMessage, productName));
                    _resetControls();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _editProduct()
        {
            try
            {
                int RowIndex = DataGridProductMaster.CurrentCell.RowIndex;
                productId = Convert.ToInt32(DataGridProductMaster.Rows[RowIndex].Cells["Id"].Value);
                var productDetail = new ProductViewModel(productId);
                TxtProductCode.Text = productDetail.ProductCode;
                TxtProductName.Text = productDetail.ProductName;
                ChkIsActive.Checked = productDetail.IsActive;
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
