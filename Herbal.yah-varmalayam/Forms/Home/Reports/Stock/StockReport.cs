﻿using Microsoft.Reporting.WinForms;
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
    public partial class StockReport : FormBase
    {
        public StockReport(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            _resetAllControls();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void _resetAllControls()
        {
            LoadProductItemsToDropDown(DropDownProductName, "");
            LoadSortByListToDropDown(DropDownSortByName, "");
            LoadSortByOrderListToDropDown(DropDownSortByDirection, "");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _resetAllControls();
        }

        private void BtnAllpyFilter_Click(object sender, EventArgs e)
        {
            _loadDataToReport();
        }

        private void _loadDataToReport()
        {
            try
            {
                string sortByName = DropDownSortByName.SelectedValue.ToString();
                string sortByDirection = DropDownSortByDirection.SelectedValue.ToString();
                int? productId = null;
                if (DropDownProductName.SelectedValue != null && (int)DropDownProductName.SelectedValue > 0)
                {
                    productId = (int)DropDownProductName.SelectedValue;
                }
                var result = ReportsRepository.getStockReportResult(
                        productId, sortByName, sortByDirection
                    );
                ReportDataSource datasource = new ReportDataSource("StockDataSet", result);
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
