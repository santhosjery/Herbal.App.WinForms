using Herbal.yah_varmalayam.MessageBox;
using Herbal.yah_varmalayam.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.Forms
{
    public class FormBase : Form
    {
        protected HerbalEntities herbalContext = new HerbalEntities();
        public MsgBoxMessages showMessageBox = new MsgBoxMessages();
        public UserViewModel userViewModel = new UserViewModel();
        public DataTable dataTable = new DataTable();
        public BindingSource bindingSource = new BindingSource();
        public FormBase()
        {
            
        }
        public void dataGridViewStyle(DataGridView dataGridView)
        {
            /*This Method for Allow datagrid to perform some Operations */
            dataGridView.RowTemplate.Height = 37;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.Font = new Font("Cambria", 14);
        }
        public void panelPosition(Panel panel)
        {
            //Panel to center position
            panel.Location = new Point(
                this.ClientSize.Width / 2 - panel.Size.Width / 2,
                this.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
        }
    }
}
