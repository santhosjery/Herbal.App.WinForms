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
    public partial class Sales : FormBase
    {
        int salesId = 0;
        int salesLineItemId = 0;
        decimal existingLineItemSalesAmount = 0;
        decimal existingLineItemDiscountAmount = 0;
        decimal existingLineItemTaxAmount = 0;
        decimal existingLineItemGrossAmount = 0;
        decimal existingLineItemQuantity = 0;
        decimal configSellingPrice = 0;
        int existingLineItemProductId = 0;
        int? selectedProductID = 0;
        public Sales(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
            dataGridViewStyle(DataGridSalesMaster);
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            panelPosition(PanelSales);
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
                configSellingPrice = 0;
                existingLineItemSalesAmount = 0;
                existingLineItemDiscountAmount = 0;
                existingLineItemTaxAmount = 0;
                existingLineItemGrossAmount = 0;
                existingLineItemQuantity = 0;
                existingLineItemProductId = 0;
                salesLineItemId = 0;
                selectedProductID = 0;
                TxtQuantity.Text = "";
                TxtAutoCompleteProduct.Text = "";
                TxtSalesAmount.Text = "";
                TxtGST.Text = "5";
                TxtNetAmount.Text = "";
                BtnSaveLineItem.Text = Utility.SaveLineItemButton;
                LoadProductItemsToAutoSuggestTextBox(TxtAutoCompleteProduct, "");
                LoadPaymentTypeToDropDown(DropDownPaymentType, "");
                _resetLineItemsFromDatabase();
                //Don't reset other's when line items called. 
                if (isResetOnlyLineItems == false)
                {
                    salesId = 0;
                    TxtSalesCode.Text = BaseRepository.GetNextSalesCode();
                    TxtCustomerName.Text = "";
                    TxtCustomerMobileNumbers.Text = "";
                    TxtCustomerGSTIN.Text = "";
                    TxtAreaCustomerAddress.Text = "";
                    DtPickerInvoiceDate.Value = DateTime.Now;
                    TxtTotalGrossAmount.Text = "";
                    TxtTotalDiscount.Text = "";
                    TxtTotalTax.Text = "";
                    TxtPaidAmount.Text = "";
                    TxtDuesAmount.Text = "";
                    TxtTotalNetAmount.Text = "";
                    TxtTotalSalesAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _resetLineItemsFromDatabase()
        {
            try
            {
                dataTable.Clear();
                DataGridSalesMaster.Refresh();
                DataGridSalesMaster.AutoGenerateColumns = false;
                var salesList = new SalesLineItemViewModel(salesId).salesLineItemViewList;
                for (int i = 0; i < salesList.Count; i++)
                {
                    //To add the sr.no into the grid list.
                    salesList[i].SrNo = i + 1;
                }
                dataTable = ConvertListToDataTable.ToDataTable(salesList);
                bindingSource.DataSource = dataTable;
                DataGridSalesMaster.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
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

        private void TxtPurchaseAmount_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtSalesAmount.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtSalesAmount.Clear();
            }
            else
            {
                _calculateValuesToLineItem();
            }
        }

        private void TxtSgstPercentage_TextChanged(object sender, EventArgs e)
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
        }

        private void TxtCustomerMobileNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void _deleteLineItem()
        {
            try
            {
                int RowIndex = DataGridSalesMaster.CurrentCell.RowIndex;
                salesLineItemId = Convert.ToInt32(DataGridSalesMaster.Rows[RowIndex].Cells["Id"].Value);
                var productName = "Line Item";

                int result = showMessageBox.ShowMessage(Utility.DeleteTitle, string.Format(Utility.DeleteMessage, productName));
                if (result == 1)
                {
                    var deleteLineItem = herbalContext.SalesLineItems.Where(_ => _.Id == salesLineItemId).First();
                    deleteLineItem.IsActive = false;

                    var salesHeader = herbalContext.SalesHeaders.Where(_ => _.Id == salesId).First();
                    salesHeader.TotalSalesAmount = salesHeader.TotalSalesAmount - deleteLineItem.SalesAmount;
                    salesHeader.TotalGrossAmount = salesHeader.TotalGrossAmount - deleteLineItem.GrossAmount;
                    salesHeader.TotalTaxAmount = salesHeader.TotalTaxAmount - deleteLineItem.GST;
                    salesHeader.TotalNetAmount = salesHeader.TotalNetAmount - deleteLineItem.NetAmount;
                    salesHeader.AmountPaid = salesHeader.AmountPaid - deleteLineItem.NetAmount;
                    salesHeader.DueAmount = salesHeader.TotalNetAmount - salesHeader.AmountPaid;

                    var stockDetail = herbalContext.StockDetails.Where(_ => _.ProductId == deleteLineItem.ProductId && _.IsActive == true).FirstOrDefault();
                    if(stockDetail != null)
                    {
                        stockDetail.TotalPurchaseQuantity = (stockDetail.TotalPurchaseQuantity + deleteLineItem.Quantity);
                        stockDetail.TotalSalesQuantity = (stockDetail.TotalSalesQuantity - deleteLineItem.Quantity);
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
                int RowIndex = DataGridSalesMaster.CurrentCell.RowIndex;
                salesLineItemId = Convert.ToInt32(DataGridSalesMaster.Rows[RowIndex].Cells["Id"].Value);
                var lineItemDetail = new SalesLineItemViewModel(false, salesLineItemId);

                existingLineItemSalesAmount = lineItemDetail.SalesAmount;
                existingLineItemGrossAmount = lineItemDetail.GrossAmount;
                existingLineItemQuantity = lineItemDetail.Quantity;
                existingLineItemProductId = lineItemDetail.ProductId;
                selectedProductID = lineItemDetail.ProductId;
                TxtAutoCompleteProduct.Text = getProductCodeAndNameById(lineItemDetail.ProductId);
                TxtQuantity.Text = ((int)lineItemDetail.Quantity).ToString();
                TxtSalesAmount.Text = lineItemDetail.SalesAmount.ToString();
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
            salesLineItemId = 0;
        }

        private void _resetHeaderFromDatabase()
        {
            try
            {
                var salesHeaderDetail = new SalesHeaderViewModel(salesId);
                TxtSalesCode.Text = salesHeaderDetail.SalesCode;
                DtPickerInvoiceDate.Value = salesHeaderDetail.SalesDate;
                TxtCustomerName.Text = salesHeaderDetail.CustomerName;
                TxtCustomerMobileNumbers.Text = salesHeaderDetail.CustomerMobileNumbers.ToString();
                TxtCustomerGSTIN.Text = salesHeaderDetail.CustomerGSTIN.ToString();
                TxtAreaCustomerAddress.Text = salesHeaderDetail.CustomerAddress.ToString();
                TxtTotalSalesAmount.Text = salesHeaderDetail.TotalSalesAmount.ToString();
                TxtTotalDiscount.Text = salesHeaderDetail.TotalDiscount.ToString();
                TxtTotalGrossAmount.Text = salesHeaderDetail.TotalGrossAmount.ToString();
                TxtTotalTax.Text = salesHeaderDetail.TotalTaxAmount.ToString();
                DropDownPaymentType.SelectedValue = salesHeaderDetail.PaymentTypeId ?? 0;
                TxtPaidAmount.Text = salesHeaderDetail.AmountPaid.ToString();
                TxtDuesAmount.Text = salesHeaderDetail.DueAmount.ToString();
                TxtTotalNetAmount.Text = salesHeaderDetail.TotalNetAmount.ToString();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void DataGridSalesMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridSalesMaster.Rows.Count > 0)
            {
                int columnIndex = DataGridSalesMaster.CurrentCell.ColumnIndex;
                string text = DataGridSalesMaster.Columns[columnIndex].HeaderText;
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

        private void DropDownProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (DropDownProductName.SelectedIndex > 0)
                {
                    var _scaleName = new ProductViewModel((int)DropDownProductName.SelectedValue);
                    LblScaleName.Text = string.Format(Utility.ScaleNameConcat, _scaleName.ScaleName);
                    configSellingPrice = _scaleName.SellingPrice;
                    TxtSalesAmount.Text = configSellingPrice.ToString();
                }
                else
                {
                    LblScaleName.Text = Utility.ScaleNameNotApplicable;
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }*/
        }

        private void BtnResetLineItem_Click(object sender, EventArgs e)
        {
            _resetAllControls(true);
        }
        private decimal _getLineItemTaxAmount()
        {
            var gstTax = StringToDecimal(TxtGST.Text);
            var lineItemGrossAmount = _getLineItemGrossAmount();
            var lineItemTaxAmount = ((lineItemGrossAmount) * (gstTax) / 100);
            return lineItemTaxAmount;
        }

        private decimal _getLineItemGrossAmount()
        {
            return (StringToDecimal(TxtSalesAmount.Text) * StringToDecimal(TxtQuantity.Text));
        }

        private void _calculateValuesToHeader()
        {
            //First time product id is not inserted then consider first line item values as header values.
            if (salesId == 0)
            {
                TxtTotalSalesAmount.Text = TxtSalesAmount.Text;
                TxtTotalDiscount.Text = TxtTotalDiscount.Text;
                TxtTotalTax.Text = _getLineItemTaxAmount().ToString();
                TxtTotalGrossAmount.Text = (_getLineItemGrossAmount()).ToString();
                TxtTotalNetAmount.Text = (StringToDecimal(TxtTotalGrossAmount.Text) + StringToDecimal(TxtTotalTax.Text)).ToString();
                TxtPaidAmount.Text = TxtTotalNetAmount.Text;
                TxtDuesAmount.Text = (StringToDecimal(TxtTotalNetAmount.Text) - StringToDecimal(TxtPaidAmount.Text)).ToString();
            }
            else
            {
                if (salesLineItemId > 0)
                {
                    TxtTotalGrossAmount.Text = (StringToDecimal(TxtTotalGrossAmount.Text) - existingLineItemGrossAmount).ToString();
                    TxtTotalSalesAmount.Text = (StringToDecimal(TxtTotalSalesAmount.Text) - existingLineItemSalesAmount).ToString();
                    TxtTotalDiscount.Text = (StringToDecimal(TxtTotalDiscount.Text) - existingLineItemDiscountAmount).ToString();
                    TxtTotalTax.Text = (StringToDecimal(TxtTotalTax.Text) - existingLineItemTaxAmount).ToString();
                }
                var totalSalesAmount = StringToDecimal(TxtTotalSalesAmount.Text) + StringToDecimal(TxtSalesAmount.Text);
                var totalDiscountAmount = StringToDecimal(TxtTotalDiscount.Text);
                TxtTotalSalesAmount.Text = totalSalesAmount.ToString();
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
                        stockViewModel.TotalPurchaseQuantity = stockDetail.TotalPurchaseQuantity;
                        stockViewModel.TotalSalesQuantity = (stockDetail.TotalSalesQuantity - existingLineItemQuantity);
                        stockViewModel.AvilableQuantity = (stockViewModel.TotalPurchaseQuantity - stockViewModel.TotalSalesQuantity);
                        stockViewModel.ProductId = existingLineItemProductId;
                        stockViewModel.UpdateStockDetail(stockViewModel);
                        existingLineItemQuantity = 0;
                    }
                }
                var stockDetailUpdate = new StockViewModel(selectedProductID.Value);
                stockViewModel.TotalPurchaseQuantity = stockDetailUpdate.TotalPurchaseQuantity;
                stockViewModel.TotalSalesQuantity = stockDetailUpdate.TotalSalesQuantity + (StringToDecimal(TxtQuantity.Text) - existingLineItemQuantity);
                stockViewModel.AvilableQuantity = (stockViewModel.TotalPurchaseQuantity - stockViewModel.TotalSalesQuantity);
                stockViewModel.ProductId = selectedProductID.Value;
                stockViewModel.UpdateStockDetail(stockViewModel);
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void _updateSalesHeader()
        {
            SalesHeader salesHeader = new SalesHeader();
            if (salesId == 0)
            {
                herbalContext.SalesHeaders.Add(salesHeader);
                salesHeader.CreatedBy = userViewModel.UserId;
                salesHeader.CreatedOn = DateTime.Now;
                salesHeader.IsActive = true;
            }
            else
            {
                salesHeader = herbalContext.SalesHeaders.Where(_ => _.Id == salesId).Single();
                salesHeader.ModifiedBy = userViewModel.UserId;
                salesHeader.ModifiedOn = DateTime.Now;
            }
            int? paymentTypeId = null;
            if ((int)DropDownPaymentType.SelectedIndex > 0)
            {
                paymentTypeId = (int)DropDownPaymentType.SelectedValue;
            }
            salesHeader.SalesCode = TxtSalesCode.Text.ToString();
            salesHeader.CustomerName = TxtCustomerName.Text.ToString();
            salesHeader.CustomerMobileNumbers = TxtCustomerMobileNumbers.Text;
            salesHeader.CustomerGSTIN = TxtGST.Text.ToString();
            salesHeader.CustomerAddress = TxtAreaCustomerAddress.Text.ToString();
            salesHeader.PaymentTypeId = paymentTypeId;
            salesHeader.SalesDate = DtPickerInvoiceDate.Value;
            salesHeader.TotalSalesAmount = StringToDecimal(TxtTotalSalesAmount.Text);
            salesHeader.TotalDiscount = StringToDecimal(TxtTotalDiscount.Text);
            salesHeader.TotalGrossAmount = StringToDecimal(TxtTotalGrossAmount.Text);
            salesHeader.TotalTaxAmount = StringToDecimal(TxtTotalTax.Text);
            salesHeader.TotalNetAmount = StringToDecimal(TxtTotalNetAmount.Text);
            salesHeader.AmountPaid = StringToDecimal(TxtPaidAmount.Text);
            salesHeader.DueAmount = StringToDecimal(TxtDuesAmount.Text);
            herbalContext.SaveChanges();
            salesId = salesHeader.Id;

        }

        private void _updateSalesLineItem()
        {
            SalesLineItem salesLineItem = new SalesLineItem();
            if (salesLineItemId == 0)
            {
                herbalContext.SalesLineItems.Add(salesLineItem);
                salesLineItem.CreatedBy = userViewModel.UserId;
                salesLineItem.CreatedOn = DateTime.Now;
                salesLineItem.IsActive = true;
            }
            else
            {
                salesLineItem = herbalContext.SalesLineItems.Where(_ => _.Id == salesLineItemId).Single();
                salesLineItem.ModifiedBy = userViewModel.UserId;
                salesLineItem.ModifiedOn = DateTime.Now;
            }
            salesLineItem.SalesLineItemCode = null;
            salesLineItem.SalesId = salesId;
            salesLineItem.ProductId = selectedProductID.Value;
            salesLineItem.Quantity = StringToDecimal(TxtQuantity.Text);
            salesLineItem.SalesAmount = StringToDecimal(TxtSalesAmount.Text);
            salesLineItem.GrossAmount = _getLineItemGrossAmount();
            salesLineItem.GST = StringToDecimal(TxtGST.Text);
            salesLineItem.NetAmount = StringToDecimal(TxtNetAmount.Text);
            salesLineItem.ConfigSellingPrice = configSellingPrice;
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
            if (string.IsNullOrEmpty(TxtQuantity.Text))
            {
                requiredFields.Add("Quantity");
            }
            if (string.IsNullOrEmpty(TxtSalesAmount.Text))
            {
                requiredFields.Add("Sales Amount");
            }
            if (selectedProductID > 0 && string.IsNullOrEmpty(TxtQuantity.Text) == false)
            {
                var avilableQuantity = new StockViewModel(selectedProductID.Value).AvilableQuantity;
                if(Convert.ToDecimal(TxtQuantity.Text) > avilableQuantity)
                {
                    requiredFields.Add(string.Concat("Stock is not avilable for given pack, Total available pack is, ", avilableQuantity));
                }
            }

            if (requiredFields.Any())
            {
                message = String.Join(", ", requiredFields);
            }
            return message;
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
                _updateSalesHeader();
                _updateSalesLineItem();
                _updateStockDetail();
                _resetAllControls(true);
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnSaveSummary_Click(object sender, EventArgs e)
        {
            _updateSalesHeader();
            showMessageBox.ShowMessage(string.Format((salesId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "Sales"));
            salesId = 0;
            salesLineItemId = 0;
            _resetAllControls(false);
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
                if (string.IsNullOrEmpty(selectedProduct))
                {
                    return;
                }
                selectedProductID = getProductIdByCodeAndName(selectedProduct);
                if (selectedProductID > 0)
                {
                    var _productDetail = new ProductViewModel(selectedProductID.Value);
                    TxtQuantity.Text = "1";
                    TxtGST.Text = _productDetail.GST.ToString();
                    TxtSalesAmount.Text = _productDetail.SellingPrice.ToString();
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnPrintSummary_Click(object sender, EventArgs e)
        {
            var form = new SalesPrintReport(26);
            form.Show();
            /*if (salesId <= 0)
            {
                showMessageBox.ShowMessage("Invalid sales ID");
            }
            _updateSalesHeader();
            var form = new SalesPrintReport(salesId);
            //Use this as common method to view appropriate view model.
            /*form.TopLevel = false;
                this.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.BringToFront();
            form.Show();
            _resetAllControls(false);
            salesId = 0;
            salesLineItemId = 0;*/
        }
    }
}
