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
    public partial class SalesPrintReport : FormBase
    {
        int? _salesId = null;
        public SalesPrintReport(int saledId)
        {
            _salesId = saledId;
            InitializeComponent();
        }

        private void SalesPrintReport_Load(object sender, EventArgs e)
        {
            var result = ReportsRepository.getSalesReportResult(
                    null, _salesId, null, null, null
                    );
            ReportDataSource datasource = new ReportDataSource("SalesDataSet", result);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
