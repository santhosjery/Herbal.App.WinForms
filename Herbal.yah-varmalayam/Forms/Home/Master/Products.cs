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
            dataGridViewStyle(DataGridProductMaster);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            AcceptButton = BtnSaveProduct;
            panelPosition(PanelProductMaster);
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            _resetControls();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.IconDownloadAll, Utility.ExportToolTip);
        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtProductCode.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Product Code"));
                    TxtProductCode.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtProductName.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Product Name"));
                    TxtProductName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtSellingPrice.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Selling Price"));
                    TxtSellingPrice.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtPackQuantity.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Pack Quantity"));
                    TxtPackQuantity.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtGST.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "GST"));
                    TxtGST.Focus();
                    return;
                }
                //Check product name already exists or not
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
                products.PackQuantity = TxtPackQuantity.Text.ToString();
                products.GST = Convert.ToDecimal(TxtGST.Text);
                products.SellingPrice = Convert.ToDecimal(TxtSellingPrice.Text);
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

        private void _resetControls()
        {
            try
            {
                BtnSaveProduct.Text = Utility.SaveButton;
                BtnReset.Text = Utility.ControlResetButton;
                productId = 0;
                TxtProductName.Text = "";
                TxtSellingPrice.Text = "";
                TxtProductCode.Text = "";
                TxtPackQuantity.Text = "";
                TxtGST.Text = "";
                ChkIsActive.Checked = true;
                GetGridList();
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
        private void BtnReset_Click(object sender, EventArgs e)
        {
            _resetControls();
        }
        private void GetGridList()
        {
            try
            {
                dataTable.Clear();
                DataGridProductMaster.Refresh();
                DataGridProductMaster.AutoGenerateColumns = false;
                var productList = new ProductViewModel(TxtSearchItem.text ?? "", false);
                dataTable = ConvertListToDataTable.ToDataTable(productList.productViewList);
                bindingSource.DataSource = dataTable;
                DataGridProductMaster.DataSource = bindingSource;
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
                    BtnSaveProduct.Text = Utility.UpdateButton;
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
                TxtSellingPrice.Text = productDetail.SellingPrice.ToString();
                TxtPackQuantity.Text = productDetail.PackQuantity.ToString();
                TxtGST.Text = productDetail.GST.ToString();
                ChkIsActive.Checked = productDetail.IsActive;
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void DataGridProductMaster_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void _exportData()
        {
            try
            {
                var productList = new ProductViewModel(TxtSearchItem.text ?? "", true);
                dataTable = ConvertListToDataTable.ToDataTable(productList.productViewList);
                string fileLocation = Utility.Prodcut;
                Utility.ExportDataToCsV(dataTable, ref fileLocation);
                showMessageBox.ShowMessage(string.Format(Utility.ExportSuccessMessage, Utility.Prodcut, fileLocation));
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void TxtSellingPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _exportData();
        }
    }
}
