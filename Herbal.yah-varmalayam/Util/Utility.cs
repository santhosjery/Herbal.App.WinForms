using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public static class Utility
    {
        private const string _connectionString = "data source=SANTHON-LR0D1A0;initial catalog=Herbal;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";
        public const string Prodcut = "Prodcut";
        public const string ExitTitle = "Exit";
        public const string ExitTitleMessage = "Do you want to Exit?";
        public const string InvalidMessage = "Invalid {0}"; 
        public const string RequiredMessage = "{0} is required";
        public const string MulripleRequiredMessage = "Following fields are {0}";
        public const string SaveMessage = "New {0} added successfully";
        public const string UpdateMessage = "{0} details updated successfully";
        public const string AlreadyExists = "{0} already exists!";
        public const string DeleteTitle = "Delete!";
        public const string DeleteMessage = "Delete the '{0}' permanently?";
        public const string UnableToDeleteMessage = "Unable to delete the {0} since it's assosiated to {1}";
        public const string DeleteSuccessMessage = "'{0}' deleted successfully.";
        public const string NotFoundMessage = "{0} not found.";
        public const string ScaleNameConcat = "({0})";
        public const string ScaleNameNotApplicable = "N/A";
        ///
        ///Button Names
        ///
        public const string SaveButton = "Save";
        public const string UpdateButton = "Update";
        public const string SaveLineItemButton = "Save Line Item";
        public const string UpdateLineItemButton = "Update Line Item";
        public const string ControlResetButton = "Reset";
        public const string DropDownFirstItem = "--Select--";

        /// <summary>
        /// Top form names
        public const string ProductFormName = "Product Master";
        public const string ScaleFormName = "Scale Master";
        public const string TaxMasterFormName = "Tax Master";
        public const string CompanyDetailFormName = "Company Details";
        public const string ManageUserFormName = "Manage User";
        public const string PurchaseReportFormName = "Purchase Report";
        public const string SalesReportFormName = "Sales Report";
        public const string StockReportFormName = "Stock Report";
        public const string PurchaseFormName = "Purchase";
        public const string SalesFormName = "Sales";
        public const string HomeFormName = "Home";
        /// </summary>

        /// <summary>
        /// List page header style
        /// ///
        public const string LblBackColor = "ControlLight";
        public const string LblFontColor = "Blue";
        public const string LblFontStyle = "Segoe UI";
        public const int LblFontSize = 17;

        /// <summary>
        /// Enum for category
        /// ///
        public enum CategoryTypes
        {
            Herbal = 1,
            AuyrVedha = 2
        }

        /// </summary>

        public static string LogException(Exception ex)
        {
            return "Following Error occured while processing your request: " + ex.Message;
        }

        public static string GetEntityConnectionString()
        {
            var entityBuilder = new EntityConnectionStringBuilder();
            // WARNING
            // Check app config and set the appropriate DBModel
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = _connectionString + ";MultipleActiveResultSets=True;App=EntityFramework;";
            entityBuilder.Metadata = @"res://*/Models.HerbalModel.csdl|res://*/Models.HerbalModel.ssdl|res://*/Models.HerbalModel.msl";
            return entityBuilder.ToString();
        }
    }
}
