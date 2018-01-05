using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class ProfileViewModel
    {
        public ProfileViewModel() { }
        public ProfileViewModel(bool test)
        {
            if(test)
            {
                this.FirstName = "Melissa";
                this.LastName = "Crosby";

                this.Skills = new SkillsModel(test);
                this.ActiveListing = new List<PropertyModel>();
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home1.jpg", CurrentPrice = 345000, PriceChanges = 6.5, Address = "472 Ponderosa Dr, Alpine", Photos = 12, Beds = 4, Bath = 3, SQFT = 2785 });
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home8.jpg", CurrentPrice = 345000, PriceChanges = -10, Address = "472 Ponderosa Dr, Alpine", Photos = 12, Beds = 4, Bath = 3, SQFT = 2785, Favorite = true });
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home11.jpg", CurrentPrice = 345000, PriceChanges = 0, Address = "472 Ponderosa Dr, Alpine", Photos = 12, Beds = 4, Bath = 3, SQFT = 2785 });
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SkillsModel Skills { get; set; }
        public List<PropertyModel> ActiveListing { get; set; }
    }
}