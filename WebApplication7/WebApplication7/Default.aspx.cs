using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication7.ServiceReference;

namespace WebApplication7
{

    class BrandsAndTypes : Dictionary<string, List<string>>
    {
        public void AddBrandAndType(string brand, string type)
        {
            if (!this.ContainsKey(brand))
            {
                this.Add(brand, new List<string>());
            }
            var typeList = this[brand];
            if (!typeList.Contains(type))
            {
                typeList.Add(type);
            }
        }
    }

    
    public partial class Default : System.Web.UI.Page
    {

        BrandsAndTypes brandsAndTypesDictionary = GetBrandsAndTpyes();

        public string I18N_BrandLabel {
            get { return Resource.ResourceManager.GetString("Brand", CultureInfo.CurrentCulture); }
        }

        public string I18N_TypeLabel
        {
            get { return Resource.ResourceManager.GetString("Type", CultureInfo.CurrentCulture); }
        }

        public string I18N_OtherLabel
        {
            get { return Resource.ResourceManager.GetString("Other", CultureInfo.CurrentCulture); }
        }

        public string I18N_YearOfManufacture
        {
            get { return Resource.ResourceManager.GetString("YearOfManufacture", CultureInfo.CurrentCulture); }
        }

        public string I18N_YearOfPurchase
        {
            get { return Resource.ResourceManager.GetString("YearOfPurchase", CultureInfo.CurrentCulture); }
        }

        public string I18N_DrivenDistance
        {
            get { return Resource.ResourceManager.GetString("DrivenDistance", CultureInfo.CurrentCulture); }
        }

        public string I18N_DistanceWhenBought
        {
            get { return Resource.ResourceManager.GetString("DistanceWhenBought", CultureInfo.CurrentCulture); }
        }

        public string I18N_RelyabilityDefinition
        {
            get { return Resource.ResourceManager.GetString("RelyabilityDefinition", CultureInfo.CurrentCulture); }
        }

        public string I18N_Reliability
        {
            get { return Resource.ResourceManager.GetString("Reliability", CultureInfo.CurrentCulture); }
        }

        public string I18N_PerformanceDefinition
        {
            get { return Resource.ResourceManager.GetString("PerformanceDefinition", CultureInfo.CurrentCulture); }
        }

        public string I18N_Performance
        {
            get { return Resource.ResourceManager.GetString("Performance", CultureInfo.CurrentCulture); }
        }

        public string I18N_ComfortDefinition
        {
            get { return Resource.ResourceManager.GetString("ComfortDefinition", CultureInfo.CurrentCulture); }
        }

        public string I18N_Comfort
        {
            get { return Resource.ResourceManager.GetString("Comfort", CultureInfo.CurrentCulture); }
        }

        public string I18N_GarageDefinition
        {
            get { return Resource.ResourceManager.GetString("GarageDefinition", CultureInfo.CurrentCulture); }
        }

        public string I18N_Garage
        {
            get { return Resource.ResourceManager.GetString("Garage", CultureInfo.CurrentCulture); }
        }

        public string I18N_SubmitRating
        {
            get { return Resource.ResourceManager.GetString("SubmitRating", CultureInfo.CurrentCulture); }
        }

        public string I18N_ReviewForm_Welcome
        {
            get { return Resource.ResourceManager.GetString("ReviewForm_Welcome", CultureInfo.CurrentCulture); }
        }

        public string I18N_DescriptionOfTheDecimalRatingValues
        {
            get { return Resource.ResourceManager.GetString("DescriptionOfTheDecimalRatingValues", CultureInfo.CurrentCulture); }
        }

        public string I18N_CostsDefinition
        {
            get { return Resource.ResourceManager.GetString("CostsDefinition", CultureInfo.CurrentCulture); }
        }

        public string I18N_Costs
        {
            get { return Resource.ResourceManager.GetString("Costs", CultureInfo.CurrentCulture); }
        }

        private static BrandsAndTypes GetBrandsAndTpyes()
        {
            var json = File.ReadAllText(Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "Content", "BrandAndTypeDicitonary.json"));
            var result = JsonHelper.FromJsonString<BrandsAndTypes>(json);
            return result;
        }

        public Default()
        {
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializeFormFirstTime();
            }
            
        }

        private void InitializeFormFirstTime()
        {
            FillDropdownListWithValues(Brand, brandsAndTypesDictionary.Keys.ToArray());
            FillDropdownListWithValuesInReverseOrder(Relayability, 1, 10);
            FillDropdownListWithValuesInReverseOrder(RunningCosts, 1, 10);
            FillDropdownListWithValuesInReverseOrder(Performance, 1, 10);
            FillDropdownListWithValuesInReverseOrder(Comfort, 1, 10);
            FillDropdownListWithValuesInReverseOrder(Garage, 1, 10);
            AddSelectableYearsToDropdownListValues(ManufactureYear);
            AddSelectableYearsToDropdownListValues(BoughtYear);
            AddSelectableKms(DrivenKms);
            AddSelectableKms(KmsWhenBought);
            UpdateTypeValues(Brand.SelectedValue);
        }

        private void UpdateTypeValues(string selectedBrand)
        {
            Type.Items.Clear();
            FillDropdownListWithValues(Type, brandsAndTypesDictionary[selectedBrand].ToArray());
        }

        private void AddSelectableKms(DropDownList kmList)
        {
            var kms = Enumerable.Range(0, 500).Select(i => i*1000 + " km");
            FillDropdownListWithValues(kmList, kms.ToArray());
        }

        private void AddSelectableYearsToDropdownListValues(DropDownList list)
        {
            FillDropdownListWithValuesInReverseOrder(list, 1950, 2015);
        }



        private static void FillDropdownListWithValues(DropDownList list, string[] items)
        {
            foreach (var item in items)
            {
                list.Items.Add(item);
            }
        }

        private static void FillDropdownListWithValues(DropDownList list, int begin, int end)
        {
            for (int i = begin; i <= end ; i++)
            {
                list.Items.Add(i.ToString());
            }
        }

        private static void FillDropdownListWithValuesInReverseOrder(DropDownList list, int begin, int end)
        {
            for (int i = end; i >= begin ; i--)
            {
                list.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var review = new UserReview()
            {
                Brand = !IsCustomBrand.Checked ? Brand.SelectedValue : CustomBrand.Text,
                Type = !IsCustomType.Checked ? Type.SelectedValue : CustomType.Text,
                Comfort = Convert.ToInt32(Comfort.SelectedValue),
                DrivenKms = ConvertKmStringToInt(DrivenKms.SelectedValue),
                Garage = Convert.ToInt32(Garage.SelectedValue),
                KmsWhenBought = ConvertKmStringToInt(KmsWhenBought.SelectedValue),
                Performance = Convert.ToInt32(Performance.SelectedValue),
                Relyability = Convert.ToInt32(Relayability.SelectedValue),
                RunningCost = Convert.ToInt32(RunningCosts.SelectedValue),
                YearOfManufacturing = Convert.ToInt32(ManufactureYear.SelectedValue),
                YearOfPurchase = Convert.ToInt32(BoughtYear.SelectedValue)
            };
            var client = new UserReviewSaveServiceClient(new WebHttpBinding(),
                new EndpointAddress("http://appharustestapp1.apphb.com/UserReviewSaveService.svc"));
            client.Endpoint.Behaviors.Add(new WebHttpBehavior());
            client.SaveReview(review);
            Server.Transfer("Thanks.aspx", true);
        }

        private int ConvertKmStringToInt(string kmString)
        {
            kmString = kmString.Split(' ')[0];
            return Convert.ToInt32(kmString);
        }

        protected void BrandChanged(object sender, EventArgs e)
        {
            UpdateTypeValues(Brand.SelectedValue);
        }

        protected void IsCustomBrand_OnCheckedChanged(object sender, EventArgs e)
        {
            Brand.Visible = !IsCustomBrand.Checked;
            CustomBrand.Visible = IsCustomBrand.Checked;
        }

        protected void IsCustomType_OnCheckedChanged(object sender, EventArgs e)
        {
            Type.Visible = !IsCustomType.Checked;
            CustomType.Visible = IsCustomType.Checked;
        }
    }
}