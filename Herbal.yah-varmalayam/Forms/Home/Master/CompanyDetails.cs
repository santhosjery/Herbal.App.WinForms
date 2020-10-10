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
    public partial class CompanyDetails : FormBase
    {
        int companyId = 0;
        public CompanyDetails(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
            InitializeComponent();
        }

        private void CompanyDetails_Load(object sender, EventArgs e)
        {
            AcceptButton = BtnUpdateCompanyDetail;
            panelPosition(PanelCompanyMaster);
            PanelCompanyMaster.AutoScroll = false;
            PanelCompanyMaster.HorizontalScroll.Enabled = false;
            PanelCompanyMaster.HorizontalScroll.Visible = false;
            PanelCompanyMaster.HorizontalScroll.Maximum = 0;
            PanelCompanyMaster.AutoScroll = true;
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
                BtnUpdateCompanyDetail.Text = Utility.UpdateButton;
                companyId = 0;
                GetCompanyDetails();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void GetCompanyDetails()
        {
            var companyDetail = new CompanyViewModel().companyViewList.First();
            companyId = companyDetail.Id;
            TxtCompanyName.Text = companyDetail.CompanyName;
            TxtDescription.Text = companyDetail.Description;
            TxtAuthorisedDealer.Text = companyDetail.AuthorisedDealer;
            TxtPrimaryContactNumber.Text = companyDetail.PrimaryContactNumber.ToString();
            TxtSecondaryContactNumber.Text = companyDetail.SecondaryContactNumber.ToString();
            TxtPrimaryEmailAddress.Text = companyDetail.PrimaryEmailAddress;
            TxtWebSite.Text = companyDetail.WebSite;
            TxtCompanyAddress.Text = companyDetail.CompanyAddress;
            TxtGSTINNumber.Text = companyDetail.GSTINNumber;
            TxtGSTINCertifiedBy.Text = companyDetail.GSTINCertifiedBy;
            TxtNote.Text = companyDetail.Note;
            TxtRevisedNote.Text = companyDetail.RevisedNote;
        }

        private void BtnUpdateCompanyDetail_Click(object sender, EventArgs e)
        {
            try
            {
                //Considering only one company exists
                if (companyId == 0)
                {
                    showMessageBox.ShowMessage(string.Concat(Utility.NotFoundMessage, "Company Id"));
                    return;
                }
                string validationMessage = _isValidationFailed();
                if (string.IsNullOrEmpty(validationMessage) == false)
                {
                    showMessageBox.ShowMessage(string.Concat(Utility.MulripleRequiredMessage, validationMessage));
                    return;
                }
                var companyDetail = herbalContext.CompanyDetails.Where(_ => _.Id == companyId).Single();

                companyDetail.CompanyName = TxtCompanyName.Text.ToString();
                companyDetail.Description = TxtDescription.Text.ToString();
                companyDetail.AuthorisedDealer = TxtAuthorisedDealer.Text.ToString();
                companyDetail.PrimaryContactNumber = Convert.ToInt64(TxtPrimaryContactNumber.Text.ToString());
                companyDetail.SecondaryContactNumber = Convert.ToInt64(TxtSecondaryContactNumber.Text.ToString());
                companyDetail.PrimaryEmailAddress = TxtPrimaryEmailAddress.Text.ToString();
                companyDetail.WebSite = TxtWebSite.Text.ToString();
                companyDetail.CompanyAddress = TxtCompanyAddress.Text.ToString();
                companyDetail.GSTINNumber = TxtGSTINNumber.Text.ToString();
                companyDetail.GSTINCertifiedBy = TxtGSTINCertifiedBy.Text.ToString();
                companyDetail.Note = TxtNote.Text.ToString();
                companyDetail.RevisedNote = TxtRevisedNote.Text.ToString();
                companyDetail.ModifiedBy = userViewModel.UserId;
                companyDetail.ModifiedOn = DateTime.Now;
                herbalContext.SaveChanges();
                showMessageBox.ShowMessage(string.Format((companyId > 0 ? Utility.UpdateMessage : Utility.SaveMessage), "Company Detail"));
                _resetControls();
            }
            catch (Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }
        private string _isValidationFailed()
        {
            List<string> requiredFields = new List<string>();
            string message = "";
            if(string.IsNullOrEmpty(TxtCompanyName.Text))
                requiredFields.Add("Company Name");

            if (string.IsNullOrEmpty(TxtDescription.Text))
                requiredFields.Add("Description");

            if (string.IsNullOrEmpty(TxtAuthorisedDealer.Text))
                requiredFields.Add("Authorised Dealer");

            if (string.IsNullOrEmpty(TxtPrimaryContactNumber.Text))
                requiredFields.Add("Primary Contact Number");

            if (string.IsNullOrEmpty(TxtPrimaryEmailAddress.Text))
                requiredFields.Add("Primary Email Address");

            if (string.IsNullOrEmpty(TxtCompanyAddress.Text))
                requiredFields.Add("Company Address");

            if (string.IsNullOrEmpty(TxtGSTINNumber.Text))
                requiredFields.Add("GSTIN Number");

            if (string.IsNullOrEmpty(TxtGSTINCertifiedBy.Text))
                requiredFields.Add("GSTIN Certified By");

            if (string.IsNullOrEmpty(TxtNote.Text))
                requiredFields.Add("Note");

            if (string.IsNullOrEmpty(TxtRevisedNote.Text))
                requiredFields.Add("Revised Note");

            if (requiredFields.Any())
            {
                message = String.Join(", ", requiredFields);
            }
            return message;
        }

        private void TxtPrimaryContactNumber_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(TxtPrimaryContactNumber.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtPrimaryContactNumber.Clear();
            }
        }

        private void TxtSecondaryContactNumber_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(TxtSecondaryContactNumber.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                TxtSecondaryContactNumber.Clear();
            }
        }
    }
}
