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
            //throw new NotImplementedException();
        }
    }
}
