using System;

namespace App1.Models
{
    public class Item
    {
        //id not yet added done correctly
        public string Id { get; set; }

        // nameof place
        public string Name { get; set; }
        public double Distance { get; set; }
        public int NumberOfPeople { get; set; }
        public string ImageUrl { get; set; }

        //new stuff thats added for details page

        //NOTE: franchise can be shown on main page as well, discuss

        // I think there is no need for description
        public string Description { get; set; }
        public string Frenchise { get; set; }
        public string PostalCode { get; set; }
        public int OutSideLine { get; set; }
        public int CheckOutLine { get; set; }
        public string Address { get; set; }
        public double Latitutude { get; set; }
        public double Longititude { get; set; }

        // Now need to deal with the manual input from user

    }
}