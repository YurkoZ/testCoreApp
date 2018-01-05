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
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home1.jpg", CurrentPrice = 345000, PriceChanges = 6.5, Address = "472 Ponderosa Dr, Alpine",
                    Photos = 12, Beds = 4, Bath = 3, SQFT = 2785 });
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home8.jpg", CurrentPrice = 345000, PriceChanges = -10, Address = "472 Ponderosa Dr, Alpine",
                    Photos = 8, Beds = 5, Bath = 3, SQFT = 6000, Favorite = true });
                this.ActiveListing.Add(new PropertyModel() { ImgUrl = "images/property/home11.jpg", CurrentPrice = 345000, PriceChanges = 0, Address = "472 Ponderosa Dr, Alpine",
                    Photos = 10, Beds = 4, Bath = 2, SQFT = 1689 });

                this.PastSales = new List<PropertyModel>();
                this.PastSales.Add(new PropertyModel() { ImgUrl = "images/property/home5.jpg", CurrentPrice = 900000, Location = "CA 91935", Address = "3247 Greystone Dr • Jamul",
                    Beds = 7, Bath = 4, SQFT = 6150, SoldDate = new DateTime(2017, 9, 12), Represented = "Seller" });
                this.PastSales.Add(new PropertyModel() { ImgUrl = "images/property/home4.jpg", CurrentPrice = 490000, Location = "CA 92071", Address = "9951 Watergum Trl • Santee",
                    Beds = 6, Bath = 5.5, SQFT = 5505, SoldDate = new DateTime(2017, 7, 21), Represented = "Buyer" });
                this.PastSales.Add(new PropertyModel() { ImgUrl = "images/property/home12.jpg", CurrentPrice = 529000, Location = "CA 92020", Address = "627 Hawthorne Ave • El Cajon",
                    Beds = 6, Bath = 5.5, SQFT = 4605, SoldDate = new DateTime(2017, 9, 11), Represented = "Buyer" });
                this.PastSales.Add(new PropertyModel() { ImgUrl = "images/property/home6.jpg", CurrentPrice = 555000, Location = "CA 91942", Address = "9565 Janfred Way • La Mesa",
                    Beds = 4, Bath = 4, SQFT = 3350, SoldDate = new DateTime(2017, 7, 11), Represented = "Buyer" });
                this.PastSales.Add(new PropertyModel() { ImgUrl = "images/property/home7.jpg", CurrentPrice = 1256000, Location = "CA 91941", Address = "5160 Alzeda Dr • La Mesa",
                    Beds = 8, Bath = 4.5, SQFT = 5505, SoldDate = new DateTime(2017, 7, 7), Represented = "Seller" });

            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SkillsModel Skills { get; set; }
        public List<PropertyModel> ActiveListing { get; set; }
        public List<PropertyModel> PastSales { get; set; }
    }
}