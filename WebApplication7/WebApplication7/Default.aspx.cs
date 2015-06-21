using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication7.ServiceReference;

namespace WebApplication7
{




    internal class Brand
    {
        public string Name { get; set; }
        public List<string> Types { get; set; }

    }

    public partial class Default : System.Web.UI.Page
    {

        Dictionary<string, Brand> brands = new Dictionary<string, Brand>();

        public Default()
        {
            brands = new Dictionary<string, Brand>();
            brands.Add("BMW", new Brand()
            {
                Name = "BMW",
                Types = new List<string>() { "X1", "X2" }
            });
            brands.Add("Ford", new Brand()
            {
                Name = "Ford",
                Types = new List<string>() { "Focus", "S-MAX" }
            });
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
            FillDropdownListWithValues(Brand, brands.Keys.ToArray());
            FillDropdownListWithValues(Relayability, 1, 10);
            FillDropdownListWithValues(RunningCosts, 1, 10);
            FillDropdownListWithValues(Performance, 1, 10);
            FillDropdownListWithValues(Comfort, 1, 10);
            FillDropdownListWithValues(Garage, 1, 10);
            AddSelectableYearsToDropdownListValues(ManufactureYear);
            AddSelectableYearsToDropdownListValues(BoughtYear);
            AddSelectableKms(DrivenKms);
            AddSelectableKms(KmsWhenBought);
            UpdateTypeValues(Brand.SelectedValue);
        }

        private void UpdateTypeValues(string selectedBrand)
        {
            Type.Items.Clear();
            FillDropdownListWithValues(Type, brands[selectedBrand].Types.ToArray());
        }

        private void AddSelectableKms(DropDownList kmList)
        {
            var kms = Enumerable.Range(0, 500).Select(i => i*1000 + " km");
            FillDropdownListWithValues(kmList, kms.ToArray());
        }

        private void AddSelectableYearsToDropdownListValues(DropDownList ManufactureYear)
        {
            FillDropdownListWithValues(ManufactureYear, 1950 ,  2015);
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
            for (int i = begin; i < end + 1 ; i++)
            {
                list.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var review = new UserReview()
            {
                Brand = Brand.SelectedValue,
                Type = Type.SelectedValue,
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
    }
}