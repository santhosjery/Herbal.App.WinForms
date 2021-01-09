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
using WindowsFormsControlLibrary1;

namespace Herbal.yah_varmalayam.Forms
{
    public partial class Purchase : FormBase
    {
        int purchaseId = 0;
        int purchaseLineItemId = 0;
        decimal existingLineItemPurchaseAmount = 0;
        decimal existingLineItemDiscountAmount = 0;
        decimal existingLineItemTaxAmount = 0;
        decimal existingLineItemGrossAmount = 0;
        decimal existingLineItemQuantity = 0;
        int existingLineItemProductId = 0;
        int? selectedProductID = 0;
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
            _resetAllControls(false);
        }

        private void _resetAllControls(bool isResetOnlyLineItems)
        {
            try
            {
                existingLineItemPurchaseAmount = 0;
                existingLineItemDiscountAmount = 0;
                existingLineItemTaxAmount = 0;
                existingLineItemGrossAmount = 0;
                existingLineItemQuantity = 0;
                existingLineItemProductId = 0;
                purchaseLineItemId = 0;
                selectedProductID = 0;
                TxtQuantity.Text = "";
                TxtPurchaseAmount.Text = "";
                TxtGST.Text = "5";
                TxtNetAmount.Text = "";
                BtnSaveLineItem.Text = Utility.SaveLineItemButton;
                TxtAutoCompleteProduct.Text = "";
                LoadPaymentTypeToDropDown(DropDownPaymentType, "");
                LoadProductItemsToAutoSuggestTextBox(TxtAutoCompleteProduct, "");
                _resetLineItemsFromDatabase();
                //Don't reset other's when line items called. 
                if (isResetOnlyLineItems == false)
                {
                    purchaseId = 0;
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
                    TxtTotalPurchaseAmount.Text = "";
                }
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _resetLineItemsFromDatabase()
        {
            try
            {
                dataTable.Clear();
                DataGridPurchaseMaster.Refresh();
                DataGridPurchaseMaster.AutoGenerateColumns = false;
                var purchaseList = new PurchaseLineItemViewModel(purchaseId).purchaseLineItemViewList;
                for(int i = 0; i < purchaseList.Count; i ++)
                {
                    //To add the sr.no into the grid list.
                    purchaseList[i].SrNo = i + 1;
                }
                dataTable = ConvertListToDataTable.ToDataTable(purchaseList);
                bindingSource.DataSource = dataTable;
                DataGridPurchaseMaster.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnSaveLineItem_Click(object sender, EventArgs e)
        {
            try
            {
                string validationMessage = _validateLineItemInputs();
                if (string.IsNullOrEmpty(validationMessage) == false)
                {
                    showMessageBox.ShowMessage(string.Format(Utility.MulripleRequiredMessage, validationMessage));
                    return;
                }
                _calculateValuesToHeader();
                _calculateValuesToLineItem();
                _updatePurchaseHeader();
                _updatePurchaseLineItem();
                _updateStockDetail();
                _resetAllControls(true);
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
        private void _updateStockDetail()
        {
            try
            {
                stockViewModel.CreatedBy = userViewModel.UserId;
                stockViewModel.ModifiedBy = userViewModel.UserId;
                if (existingLineItemProductId > 0 && (existingLineItemProductId != selectedProductID))
                {
                    var stockDetail = new StockViewModel(existingLineItemProductId);
                    if (stockDetail != null)
                    {
                        stockViewModel.TotalPurchaseQuantity = (stockDetail.TotalPurchaseQuantity - existingLineItemQuantity);
                        stockViewModel.TotalSalesQuantity = stockDetail.TotalSalesQuantity;
                        stockViewModel.AvilableQuantity = (stockViewModel.TotalPurchaseQuantity - stockViewModel.TotalSalesQuantity);
                        stockViewModel.ProductId = existingLineItemProductId;
                        stockViewModel.UpdateStockDetail(stockViewModel);
                        existingLineItemQuantity = 0;
                    }
                }
                var stockDetailUpdate = new StockViewModel(selectedProductID.Value);
                stockViewModel.TotalPurchaseQuantity = stockDetailUpdate.TotalPurchaseQuantity + (StringToDecimal(TxtQuantity.Text) - existingLineItemQuantity);
                stockViewModel.TotalSalesQuantity = stockDetailUpdate.TotalSalesQuantity;
                stockViewModel.AvilableQuantity = (stockViewModel.TotalPurchaseQuantity - stockViewModel.TotalSalesQuantity);
                stockViewModel.ProductId = selectedProductID.Value;
                stockViewModel.UpdateStockDetail(stockViewModel);
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
        private void _updatePurchaseHeader()
        {
            PurchaseHeader purchaseHeader = new PurchaseHeader();
            if(purchaseId == 0)
            {
                herbalContext.PurchaseHeaders.Add(purchaseHeader);
                purchaseHeader.CreatedBy = userViewModel.UserId;
                purchaseHeader.CreatedOn = DateTime.Now;
                purchaseHeader.IsActive = true;
            }
            else
            {
                purchaseHeader = herbalContext.PurchaseHeaders.Where(_ => _.Id == purchaseId).Single();
                purchaseHeader.ModifiedBy = userViewModel.UserId;
                purchaseHeader.ModifiedOn = DateTime.Now;
            }
            Int64? _clientMobileNumber = null;
            if(string.IsNullOrEmpty(TxtClientMobileNumber.Text) == false)
            {
                _clientMobileNumber = Convert.ToInt64(TxtClientMobileNumber.Text);
            }
            int? paymentTypeId = null;
            if((int)DropDownPaymentType.SelectedIndex > 0)
            {
                paymentTypeId = (int)DropDownPaymentType.SelectedValue;
            }
            purchaseHeader.PurchaseCode = TxtPurchaseCode.Text.ToString();
            purchaseHeader.ClientName = TxtClientName.Text.ToString();
            purchaseHeader.ClientMobileNumber = _clientMobileNumber;
            purchaseHeader.ClientInvoiceNumber = TxtClientInvoiceNo.Text.ToString();
            purchaseHeader.PaymentTypeId = paymentTypeId;
            purchaseHeader.PurchaseDate = DtPickerInvoiceDate.Value;
            purchaseHeader.TotalPurchaseAmount = StringToDecimal(TxtTotalPurchaseAmount.Text);
            purchaseHeader.TotalDiscount = StringToDecimal(TxtTotalDiscount.Text);
            purchaseHeader.TotalGrossAmount = StringToDecimal(TxtTotalGrossAmount.Text);
            purchaseHeader.TotalTaxAmount = StringToDecimal(TxtTotalTax.Text);
            purchaseHeader.TotalNetAmount = StringToDecimal(TxtTotalNetAmount.Text);
            purchaseHeader.AmountPaid = StringToDecimal(TxtPaidAmount.Text);
            purchaseHeader.DueAmount = StringToDecimal(TxtDuesAmount.Text);
            herbalContext.SaveChanges();
            purchaseId = purchaseHeader.Id;
            
        }
        private void _updatePurchaseLineItem()
        {
            PurchaseLineItem purchaseLineItem = new PurchaseLineItem();
            if(purchaseLineItemId == 0)
            {
                herbalContext.PurchaseLineItems.Add(purchaseLineItem);
                purchaseLineItem.CreatedBy = userViewModel.UserId;
                purchaseLineItem.CreatedOn = DateTime.Now;
                purchaseLineItem.IsActive = true;
            }
            else
            {
                purchaseLineItem = herbalContext.PurchaseLineItems.Where(_ => _.Id == purchaseLineItemId).Single();
                purchaseLineItem.ModifiedBy = userViewModel.UserId;
                purchaseLineItem.ModifiedOn = DateTime.Now;
            }
            purchaseLineItem.PurchaseLineItemCode = null;
            purchaseLineItem.PurchaseId = purchaseId;
            purchaseLineItem.ProductId = selectedProductID.Value;
            purchaseLineItem.Quantity = StringToDecimal(TxtQuantity.Text);
            purchaseLineItem.GST = _getLineItemTaxAmount();
            purchaseLineItem.PurchaseAmount = StringToDecimal(TxtPurchaseAmount.Text);
            purchaseLineItem.GrossAmount = _getLineItemGrossAmount();
            purchaseLineItem.NetAmount = StringToDecimal(TxtNetAmount.Text);
            purchaseLineItem.SellingPrice = null;
            herbalContext.SaveChanges();
        }
        private string _validateLineItemInputs()
        {
            string message = "";
            List<string> requiredFields = new List<string>();
            if (string.IsNullOrEmpty(TxtAutoCompleteProduct.Text) || selectedProductID <= 0)
            {
                requiredFields.Add("Product Name");
            }
            if(string.IsNullOrEmpty(TxtQuantity.Text))
            {
                requiredFields.Add("Quantity");
            }
            if (string.IsNullOrEmpty(TxtPurchaseAmount.Text))
            {
                requiredFields.Add("Purchase Amount");
            }
            if (requiredFields.Any())
            {
                message = String.Join(", ", requiredFields);
            }
            return message;
        }

        private void _calculateValuesToHeader()
        {
            //First time product id is not inserted then consider first line item values as header values.
            if(purchaseId == 0)
            {
                TxtTotalPurchaseAmount.Text = TxtPurchaseAmount.Text;
                TxtTotalTax.Text = _getLineItemTaxAmount().ToString();
                TxtTotalGrossAmount.Text = (_getLineItemGrossAmount()).ToString();
                TxtTotalNetAmount.Text = (StringToDecimal(TxtTotalGrossAmount.Text) + StringToDecimal(TxtTotalTax.Text)).ToString();
                TxtPaidAmount.Text = TxtTotalNetAmount.Text;
                TxtDuesAmount.Text = (StringToDecimal(TxtTotalNetAmount.Text) - StringToDecimal(TxtPaidAmount.Text)).ToString();
            }
            else
            {
                if(purchaseLineItemId > 0)
                {
                    TxtTotalGrossAmount.Text = (StringToDecimal(TxtTotalGrossAmount.Text) - existingLineItemGrossAmount).ToString();
                    TxtTotalPurchaseAmount.Text = (StringToDecimal(TxtTotalPurchaseAmount.Text) - existingLineItemPurchaseAmount).ToString();
                    TxtTotalTax.Text = (StringToDecimal(TxtTotalTax.Text) - existingLineItemTaxAmount).ToString();
                }
                var totalPurchaseAmount = StringToDecimal(TxtTotalPurchaseAmount.Text) + StringToDecimal(TxtPurchaseAmount.Text);
                var totalDiscountAmount = StringToDecimal(TxtTotalDiscount.Text);
                TxtTotalPurchaseAmount.Text = totalPurchaseAmount.ToString();
                TxtTotalDiscount.Text = totalDiscountAmount.ToString();

                TxtTotalTax.Text = (StringToDecimal(TxtTotalTax.Text) + _getLineItemTaxAmount()).ToString();

                var totalGrossAmount = (StringToDecimal(TxtTotalGrossAmount.Text) + _getLineItemGrossAmount()) - totalDiscountAmount;
                TxtTotalGrossAmount.Text = totalGrossAmount.ToString();

                TxtTotalNetAmount.Text = (StringToDecimal(TxtTotalGrossAmount.Text) + StringToDecimal(TxtTotalTax.Text)).ToString();

                TxtPaidAmount.Text = TxtTotalNetAmount.Text;
                TxtDuesAmount.Text = (StringToDecimal(TxtTotalNetAmount.Text) - StringToDecimal(TxtPaidAmount.Text)).ToString();
            }
        }

        private void _calculateValuesToLineItem()
        {
            var grossAmount = _getLineItemGrossAmount();
            var taxAmount = _getLineItemTaxAmount();
            TxtNetAmount.Text = (grossAmount + taxAmount).ToString();
        }
        private decimal _getLineItemTaxAmount()
        {
            var gstAmount = StringToDecimal(TxtGST.Text) * StringToDecimal(TxtQuantity.Text);
            return gstAmount;
        }

        private decimal _getLineItemGrossAmount()
        {
            return (StringToDecimal(TxtPurchaseAmount.Text) * StringToDecimal(TxtQuantity.Text));
        }

        private void BtnResetLineItem_Click(object sender, EventArgs e)
        {
            _resetAllControls(true);
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(TxtQuantity.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtQuantity.Clear();
            }
            else
            {

            }
        }

        private void TxtGrossAmount_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtPurchaseAmount.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtPurchaseAmount.Clear();
            }
            else
            {
                _calculateValuesToLineItem();
            }
        }

        private void TxtCgstPercentage_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtGST.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtGST.Clear();
            }
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtPaidAmount.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtPaidAmount.Clear();
            }
        }

        private void TxtTotalDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtTotalDiscount.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtTotalDiscount.Clear();
            }
            else
            {
                _calculateValuesToHeader();
            }
        }

        private void TxtClientMobileNumber_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtClientMobileNumber.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtClientMobileNumber.Clear();
            }
        }

        private void DataGridPurchaseMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if(DataGridPurchaseMaster.Rows.Count > 0)
            {
                int columnIndex = DataGridPurchaseMaster.CurrentCell.ColumnIndex;
                string text = DataGridPurchaseMaster.Columns[columnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    _deleteLineItem();
                }
                if (text.Equals("Edit"))
                {
                    BtnSaveLineItem.Text = Utility.UpdateLineItemButton;
                    _editProduct();
                }
            }
        }
        private void _deleteLineItem()
        {
            try
            {
                int RowIndex = DataGridPurchaseMaster.CurrentCell.RowIndex;
                purchaseLineItemId = Convert.ToInt32(DataGridPurchaseMaster.Rows[RowIndex].Cells["Id"].Value);
                var productName = "Line Item";
                
                int result = showMessageBox.ShowMessage(Utility.DeleteTitle, string.Format(Utility.DeleteMessage, productName));
                if (result == 1)
                {
                    var deleteLineItem = herbalContext.PurchaseLineItems.Where(_ => _.Id == purchaseLineItemId).First();
                    deleteLineItem.IsActive = false;

                    var purchaseHeader = herbalContext.PurchaseHeaders.Where(_ => _.Id == purchaseId).First();
                    purchaseHeader.TotalPurchaseAmount = purchaseHeader.TotalPurchaseAmount - deleteLineItem.PurchaseAmount;
                    purchaseHeader.TotalGrossAmount = purchaseHeader.TotalGrossAmount - deleteLineItem.GrossAmount;
                    purchaseHeader.TotalTaxAmount = purchaseHeader.TotalTaxAmount - deleteLineItem.GST;
                    purchaseHeader.TotalNetAmount = purchaseHeader.TotalNetAmount - deleteLineItem.NetAmount;
                    purchaseHeader.AmountPaid = purchaseHeader.AmountPaid - deleteLineItem.NetAmount;
                    purchaseHeader.DueAmount = purchaseHeader.TotalNetAmount - purchaseHeader.AmountPaid;

                    var stockDetail = herbalContext.StockDetails.Where(_ => _.ProductId == deleteLineItem.ProductId && _.IsActive == true).FirstOrDefault();
                    if (stockDetail != null)
                    {
                        stockDetail.TotalPurchaseQuantity = (stockDetail.TotalPurchaseQuantity - deleteLineItem.Quantity);
                        stockDetail.TotalSalesQuantity = stockDetail.TotalSalesQuantity;
                        stockDetail.AvilableQuantity = (stockDetail.TotalPurchaseQuantity - stockDetail.TotalSalesQuantity);
                    }

                    herbalContext.SaveChanges();
                    showMessageBox.ShowMessage(string.Format(Utility.DeleteSuccessMessage, productName));
                    _resetDetailsFromDatabase();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _editProduct()
        {
            try
            {
                int RowIndex = DataGridPurchaseMaster.CurrentCell.RowIndex;
                purchaseLineItemId = Convert.ToInt32(DataGridPurchaseMaster.Rows[RowIndex].Cells["Id"].Value);
                var lineItemDetail = new PurchaseLineItemViewModel(false, purchaseLineItemId);

                existingLineItemPurchaseAmount = lineItemDetail.PurchaseAmount;
                existingLineItemGrossAmount = lineItemDetail.GrossAmount;
                existingLineItemQuantity = lineItemDetail.Quantity;
                existingLineItemProductId = lineItemDetail.ProductId;
                selectedProductID = lineItemDetail.ProductId;
                TxtAutoCompleteProduct.Text = getProductCodeAndNameById(lineItemDetail.ProductId);
                TxtQuantity.Text = ((int)lineItemDetail.Quantity).ToString();
                TxtPurchaseAmount.Text = lineItemDetail.PurchaseAmount.ToString();
                TxtGST.Text = lineItemDetail.GST.ToString();
                TxtNetAmount.Text = lineItemDetail.NetAmount.ToString();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _resetDetailsFromDatabase()
        {
            _resetHeaderFromDatabase();
            _resetLineItemsFromDatabase();
            purchaseLineItemId = 0;
        }
        private void _resetHeaderFromDatabase()
        {
            try
            {
                var purchaseHeaderList = new PurchaseHeaderViewModel(purchaseId);
                TxtPurchaseCode.Text = purchaseHeaderList.PurchaseCode;
                TxtClientInvoiceNo.Text = purchaseHeaderList.ClientInvoiceNumber;
                DtPickerInvoiceDate.Value = purchaseHeaderList.PurchaseDate;
                TxtClientName.Text = purchaseHeaderList.ClientName;
                TxtClientMobileNumber.Text = purchaseHeaderList.ClientMobileNumber.ToString();
                TxtTotalPurchaseAmount.Text = purchaseHeaderList.TotalPurchaseAmount.ToString();
                TxtTotalDiscount.Text = purchaseHeaderList.TotalDiscount.ToString();
                TxtTotalGrossAmount.Text = purchaseHeaderList.TotalGrossAmount.ToString();
                TxtTotalTax.Text = purchaseHeaderList.TotalTaxAmount.ToString();
                DropDownPaymentType.SelectedValue = purchaseHeaderList.PaymentTypeId ?? 0;
                TxtPaidAmount.Text = purchaseHeaderList.AmountPaid.ToString();
                TxtDuesAmount.Text = purchaseHeaderList.DueAmount.ToString();
                TxtTotalNetAmount.Text = purchaseHeaderList.TotalNetAmount.ToString();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnSaveSummary_Click(object sender, EventArgs e)
        {
            _updatePurchaseHeader();
            showMessageBox.ShowMessage(string.Format((purchaseId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "Purchase"));
            purchaseId = 0;
            purchaseLineItemId = 0;
            _resetAllControls(false);
        }

        private void BtnPrintSummary_Click(object sender, EventArgs e)
        {
            _updatePurchaseHeader();
            showMessageBox.ShowMessage(string.Format((purchaseId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "Purchase"));
            purchaseId = 0;
            purchaseLineItemId = 0;
            _resetAllControls(false);
            showMessageBox.ShowMessage("Currently reporting feature is not avilable for Purchase!");
        }

        private void TxtQuantity_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPurchaseAmount_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtGST_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtQuantity_Leave(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(TxtQuantity.Text, out a))
            {
                _calculateValuesToLineItem();
            }
        }

        private void TxtPurchaseAmount_Leave(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(TxtPurchaseAmount.Text, out a))
            {
                _calculateValuesToLineItem();
            }
        }

        private void TxtGST_Leave(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(TxtGST.Text, out a))
            {
                _calculateValuesToLineItem();
            }
        }

        private void TxtAutoCompleteProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                getProductDetail(this.TxtAutoCompleteProduct.Text);
            }
        }

        private void getProductDetail(string selectedProduct)
        {
            try
            {
                if(string.IsNullOrEmpty(selectedProduct))
                {
                    return;
                }
                selectedProductID = getProductIdByCodeAndName(selectedProduct);
                if (selectedProductID > 0)
                {
                    var _productDetail = new ProductViewModel(selectedProductID.Value);
                    TxtQuantity.Text = "1";
                    TxtGST.Text = _productDetail.GST.ToString();
                    TxtPurchaseAmount.Text = _productDetail.SellingPrice.ToString();// (_productDetail.SellingPrice - (_productDetail.SellingPrice / 100 * Utility.SellingPricePercentage)).ToString();
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
