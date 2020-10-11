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
            
        internal void LoadScaleItemsToDropDown(ComboBox combobox, string searchText)
        {
            //Call this method to append the Scale list
            try
            {
                Dictionary<int, string> listItemDictionary = new Dictionary<int, string>();
                combobox.Refresh();
                listItemDictionary.Clear();
                var scaleList = new ScaleViewModel(searchText).scaleViewModel;
                var dt = ConvertListToDataTable.ToDataTable(scaleList);
                if(dt.Rows.Count > 0)
                {
                    listItemDictionary.Add(0, Utility.DropDownFirstItem);
                    foreach (DataRow DtCol in dt.Rows)
                    {
                        listItemDictionary.Add(Convert.ToInt32(DtCol["Id"]), DtCol["ScaleName"].ToString());
                    }
                    combobox.DataSource = new BindingSource(listItemDictionary, null);
                    combobox.DisplayMember = "Value";
                    combobox.ValueMember = "Key";
                }
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }


        internal void LoadProductItemsToDropDown(ComboBox combobox, string searchText)
        {
            //Call this method to append the Scale list
            try
            {
                Dictionary<int, string> listItemDictionary = new Dictionary<int, string>();
                combobox.Refresh();
                listItemDictionary.Clear();
                var list = new ProductViewModel(searchText).productViewList;
                var dt = ConvertListToDataTable.ToDataTable(list);
                if (dt.Rows.Count > 0)
                {
                    listItemDictionary.Add(0, Utility.DropDownFirstItem);
                    foreach (DataRow DtCol in dt.Rows)
                    {
                        listItemDictionary.Add(Convert.ToInt32(DtCol["Id"]), DtCol["ProductName"].ToString());
                    }
                    combobox.DataSource = new BindingSource(listItemDictionary, null);
                    combobox.DisplayMember = "Value";
                    combobox.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        internal void LoadPaymentTypeToDropDown(ComboBox combobox, string searchText)
        {
            //Call this method to append the Scale list
            try
            {
                Dictionary<int, string> listItemDictionary = new Dictionary<int, string>();
                combobox.Refresh();
                listItemDictionary.Clear();
                var list = new PaymentTypeViewModel(searchText).paymentTypeViewModel;
                var dt = ConvertListToDataTable.ToDataTable(list);
                if (dt.Rows.Count > 0)
                {
                    listItemDictionary.Add(0, Utility.DropDownFirstItem);
                    foreach (DataRow DtCol in dt.Rows)
                    {
                        listItemDictionary.Add(Convert.ToInt32(DtCol["Id"]), DtCol["PaymentTypeName"].ToString());
                    }
                    combobox.DataSource = new BindingSource(listItemDictionary, null);
                    combobox.DisplayMember = "Value";
                    combobox.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
