using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IEntity
    {
        //Brand
        public string BrandName { get; set; } 

        //Car
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public decimal DealyPrice { get; set; }

        //Customer
        public string CompanyName { get; set; }

        //Rental
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        //User
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
