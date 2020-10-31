﻿using Herbal.yah_varmalayam.Forms.Home.Reports.Purchase;
using Microsoft.Reporting.WinForms;
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
    public partial class PurchaseReport : FormBase
    {
        public PurchaseReport(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            //panelPositionForReport(PanelPurchaseReport);
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            _resetAllControls();
            this.reportViewer1.RefreshReport();
        }

        private void _resetAllControls()
        {
            TxtPurchaseCode.Text = "";
            DtPickerStartDate.Value = DateTime.Now.AddDays(-30);
            DtPickerEndDate.Value = DateTime.Now;
            LoadProductItemsToDropDown(DropDownProductName, "");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _resetAllControls();
        }

        private void DtPickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAllpyFilter_Click(object sender, EventArgs e)
        {
            _loadDataToReport();
        }

        private void _loadDataToReport()
        {
            try
            {
                string purchaseCode = TxtPurchaseCode.Text.ToString();
                int? purchaseId = null;
                DateTime? startDate = DtPickerStartDate.Value;
                DateTime? endDate = DtPickerEndDate.Value;
                int? productId = null;
                if(DropDownProductName.SelectedValue != null && (int)DropDownProductName.SelectedValue > 0)
                {
                    productId = (int)DropDownProductName.SelectedValue;
                }
                var result = ReportsRepository.getPurchaseReportResult(
                    purchaseCode, purchaseId, startDate, endDate, productId
                    );
                ReportDataSource datasource = new ReportDataSource("PurchaseDataSet", result);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
