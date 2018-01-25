using System;
using System.Collections.Generic;

namespace MotoSaleSite.Models
{
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string FuelType { get; set; }
        public int Mileage { get; set; }
        public int YearOfManufacture { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public string MainPhotoLink { get; set; }
        public string AdvertisementPhotosLink { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
