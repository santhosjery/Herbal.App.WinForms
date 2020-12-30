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
    public partial class Scale : FormBase
    {
        int scaleId = 0;
        public Scale(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
            dataGridViewStyle(DataGridScaleMaster);
        }

        private void Scale_Load(object sender, EventArgs e)
        {
            AcceptButton = BtnSaveScale;
            panelPosition(PanelScaleMaster);
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
            _resetControls();
        }

        private void _resetControls()
        {
            try
            {
                BtnSaveScale.Text = Utility.SaveButton;
                BtnReset.Text = Utility.ControlResetButton;
                scaleId = 0;
                TxtScaleName.Text = "";
                ChkIsActive.Checked = true;
                GetGridList();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void GetGridList()
        {
            try
            {
                dataTable.Clear();
                DataGridScaleMaster.Refresh();
                DataGridScaleMaster.AutoGenerateColumns = false;
                /*var scaleList = new ScaleViewModel(TxtSearchItem.text ?? "");
                    dataTable = ConvertListToDataTable.ToDataTable(scaleList.scaleViewModel);*/
                bindingSource.DataSource = dataTable;
                DataGridScaleMaster.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _resetControls();
        }

        private void BtnSaveScale_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (string.IsNullOrEmpty(TxtScaleName.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.RequiredMessage, "Scale Name"));
                    TxtScaleName.Focus();
                    return;
                }
                //Check scale name already exists or not
                if (_isScaleNameAlreadyExists(TxtScaleName.Text))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.AlreadyExists, "Scale Name"));
                    TxtScaleName.Focus();
                    return;
                }
                Models.Scale scale = new Models.Scale();
                if (scaleId == 0)
                {
                    herbalContext.Scales.Add(scale);
                    scale.CreatedBy = userViewModel.UserId;
                    scale.CreatedOn = DateTime.Now;
                }
                else
                {
                    scale = herbalContext.Scales.Where(_ => _.Id == scaleId).Single();
                    scale.ModifiedBy = userViewModel.UserId;
                    scale.ModifiedOn = DateTime.Now;
                }
                scale.ScaleName = TxtScaleName.Text.ToString();
                scale.IsActive = ChkIsActive.Checked;
                herbalContext.SaveChanges();
                showMessageBox.ShowMessage(string.Format((scaleId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "scale"));
                _resetControls();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }*/
        }

        private bool _isScaleNameAlreadyExists(string name)
        {
            /*return herbalContext.Scales.Where(_ => _.ScaleName == name
                                        && (scaleId == 0 || _.Id != scaleId)).Any();*/
            return true;
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetGridList();
        }

        private void DataGridScaleMaster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataGridScaleMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridScaleMaster.Rows.Count > 0)
            {
                int columnIndex = DataGridScaleMaster.CurrentCell.ColumnIndex;
                string text = DataGridScaleMaster.Columns[columnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    _deleteScale();
                }
                if (text.Equals("Edit"))
                {
                    BtnSaveScale.Text = Utility.UpdateButton;
                    _editScale();
                }
            }
        }

        private void _deleteScale()
        {
            /*try
            {
                int RowIndex = DataGridScaleMaster.CurrentCell.RowIndex;
                scaleId = Convert.ToInt32(DataGridScaleMaster.Rows[RowIndex].Cells["Id"].Value);
                var scaleName = DataGridScaleMaster.Rows[RowIndex].Cells["ScaleName"].Value.ToString();
                if (BaseRepository.IsScaleHasPurchaseOrSales(scaleId))
                {
                    showMessageBox.ShowMessage(string.Format(Utility.UnableToDeleteMessage, scaleName));
                    return;
                }
                int result = showMessageBox.ShowMessage(Utility.DeleteTitle, string.Format(Utility.DeleteMessage, scaleName));
                if (result == 1)
                {
                    var deleteScale = herbalContext.Scales.Where(_ => _.Id == scaleId).First();
                    herbalContext.Scales.Remove(deleteScale);
                    herbalContext.SaveChanges();
                    showMessageBox.ShowMessage(string.Format(Utility.DeleteSuccessMessage, scaleName));
                    _resetControls();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }*/
        }

        private void _editScale()
        {
            try
            {
                int RowIndex = DataGridScaleMaster.CurrentCell.RowIndex;
                scaleId = Convert.ToInt32(DataGridScaleMaster.Rows[RowIndex].Cells["Id"].Value);
                var scaleDetail = new ScaleViewModel(scaleId);
                TxtScaleName.Text = scaleDetail.ScaleName;
                ChkIsActive.Checked = scaleDetail.IsActive;
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
    }
}
