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
                TxtQuantity.Text = "";
                LblScaleName.Text = Utility.ScaleNameNotApplicable;
                TxtSalesAmount.Text = "";
                TxtCgstPercentage.Text = "5";
                TxtSgstPercentage.Text = "5";
                TxtDiscount.Text = "0";
                TxtNetAmount.Text = "";
                BtnSaveLineItem.Text = Utility.SaveLineItemButton;
                LoadProductItemsToDropDown(DropDownProductName, "");
                LoadPaymentTypeToDropDown(DropDownPaymentType, "");
                _resetLineItemsFromDatabase();
                //Don't reset other's when line items called. 
                if (isResetOnlyLineItems == false)
                {
                    salesId = 0;
                    TxtSalesCode.Text = BaseRepository.GetNextSalesCode();
                    TxtCustomerName.Text = "";
                    TxtCustomerMobileNumber.Text = "";
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
            decimal a;
            if (!decimal.TryParse(TxtQuantity.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtQuantity.Clear();
            }
            else
            {
                _calculateValuesToLineItem();
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

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtDiscount.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtDiscount.Clear();
            }
        }

        private void TxtCgstPercentage_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtCgstPercentage.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtCgstPercentage.Clear();
            }
        }

        private void TxtSgstPercentage_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            if (!decimal.TryParse(TxtSgstPercentage.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtSgstPercentage.Clear();
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
            int a;
            if (!int.TryParse(TxtCustomerMobileNumber.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtCustomerMobileNumber.Clear();
            }
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
                    salesHeader.TotalDiscount = salesHeader.TotalDiscount - deleteLineItem.Discount ?? 0;
                    salesHeader.TotalTaxAmount = salesHeader.TotalTaxAmount - deleteLineItem.TotalTax;
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
                existingLineItemDiscountAmount = lineItemDetail.Discount ?? 0;
                existingLineItemTaxAmount = lineItemDetail.TotalTax ?? 0;
                existingLineItemGrossAmount = lineItemDetail.GrossAmount;
                existingLineItemQuantity = lineItemDetail.Quantity;
                existingLineItemProductId = lineItemDetail.ProductId;

                DropDownProductName.SelectedValue = lineItemDetail.ProductId;
                TxtQuantity.Text = lineItemDetail.Quantity.ToString();
                TxtSalesAmount.Text = lineItemDetail.SalesAmount.ToString();
                TxtCgstPercentage.Text = lineItemDetail.CGST.ToString();
                TxtSgstPercentage.Text = lineItemDetail.SGST.ToString();
                TxtDiscount.Text = lineItemDetail.Discount.ToString();
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
                TxtCustomerMobileNumber.Text = salesHeaderDetail.CustomerMobileNumber.ToString();
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
            try
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
            }
        }

        private void BtnResetLineItem_Click(object sender, EventArgs e)
        {
            _resetAllControls(true);
        }
        private decimal _getLineItemTaxAmount()
        {
            var cgstTax = StringToDecimal(TxtCgstPercentage.Text);
            var sgstTax = StringToDecimal(TxtSgstPercentage.Text);
            var lineItemGrossAmount = _getLineItemGrossAmount();
            var lineItemDiscount = StringToDecimal(TxtDiscount.Text);
            var lineItemTaxAmount = ((lineItemGrossAmount - lineItemDiscount) * (cgstTax + sgstTax) / 100);
            return lineItemTaxAmount;
        }

        private decimal _getLineItemGrossAmount()
        {
            return (StringToDecimal(TxtSalesAmount.Text) * StringToDecimal(TxtQuantity.Text)) - StringToDecimal(TxtDiscount.Text);
        }

        private void _calculateValuesToHeader()
        {
            //First time product id is not inserted then consider first line item values as header values.
            if (salesId == 0)
            {
                TxtTotalSalesAmount.Text = TxtSalesAmount.Text;
                TxtTotalDiscount.Text = TxtDiscount.Text;
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
                var totalDiscountAmount = StringToDecimal(TxtTotalDiscount.Text) + StringToDecimal(TxtDiscount.Text);
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
                if (existingLineItemProductId > 0 && (existingLineItemProductId != (int)DropDownProductName.SelectedValue))
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
                var stockDetailUpdate = new StockViewModel((int)DropDownProductName.SelectedValue);
                stockViewModel.TotalPurchaseQuantity = stockDetailUpdate.TotalPurchaseQuantity;
                stockViewModel.TotalSalesQuantity = stockDetailUpdate.TotalSalesQuantity + (StringToDecimal(TxtQuantity.Text) - existingLineItemQuantity);
                stockViewModel.AvilableQuantity = (stockViewModel.TotalPurchaseQuantity - stockViewModel.TotalSalesQuantity);
                stockViewModel.ProductId = (int)DropDownProductName.SelectedValue;
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
            Int64? _clientMobileNumber = null;
            if (string.IsNullOrEmpty(TxtCustomerMobileNumber.Text) == false)
            {
                _clientMobileNumber = Convert.ToInt64(TxtCustomerMobileNumber.Text);
            }
            int? paymentTypeId = null;
            if ((int)DropDownPaymentType.SelectedIndex > 0)
            {
                paymentTypeId = (int)DropDownPaymentType.SelectedValue;
            }
            salesHeader.SalesCode = TxtSalesCode.Text.ToString();
            salesHeader.CustomerName = TxtCustomerName.Text.ToString();
            salesHeader.CustomerMobileNumber = _clientMobileNumber;
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
            salesLineItem.ProductId = (int)DropDownProductName.SelectedValue;
            salesLineItem.Quantity = StringToDecimal(TxtQuantity.Text);
            salesLineItem.SalesAmount = StringToDecimal(TxtSalesAmount.Text);
            salesLineItem.Discount = StringToDecimal(TxtDiscount.Text);
            salesLineItem.GrossAmount = _getLineItemGrossAmount();
            salesLineItem.CGST = StringToDecimal(TxtCgstPercentage.Text);
            salesLineItem.SGST = StringToDecimal(TxtSgstPercentage.Text);
            salesLineItem.IGST = null;
            salesLineItem.TotalTax = _getLineItemTaxAmount();
            salesLineItem.NetAmount = StringToDecimal(TxtNetAmount.Text);
            salesLineItem.ConfigSellingPrice = configSellingPrice;
            herbalContext.SaveChanges();
        }

        private string _validateLineItemInputs()
        {
            string message = "";
            List<string> requiredFields = new List<string>();
            if ((int)DropDownProductName.SelectedIndex <= 0)
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
            if ((int)DropDownProductName.SelectedIndex > 0 && string.IsNullOrEmpty(TxtQuantity.Text) == false)
            {
                var avilableQuantity = new StockViewModel((int)DropDownProductName.SelectedValue).AvilableQuantity;
                if(Convert.ToDecimal(TxtQuantity.Text) > avilableQuantity)
                {
                    requiredFields.Add(string.Concat("Stock is not avilable for given Quantity, Available stock is, ", avilableQuantity , " ", LblScaleName.Text.ToString()));
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
    }
}
