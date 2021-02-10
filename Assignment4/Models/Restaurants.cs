using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurants
    {
        // constructor
        public Restaurants(int rank)
        {
            RestRank = rank;
        }

        // declare model attributes
        [Required]
        public int RestRank { get;}
        [Required]
        public string RestName { get; set; }
        #nullable enable
        // If null display value
        public string? FavDish { get; set; } = "It's all tasty";
        #nullable disable
        [Required]
        public string Address { get; set; }
        [Phone]
        public string PhoneNum { get; set; }
        #nullable enable
        // If null display value
        public string? WebLink { get; set; } = "Coming Soon!";
        #nullable disable


        // Create list of top five restaurants
        public static Restaurants[] GetRests()
        {
            Restaurants r1 = new Restaurants(1)
            {
                RestName = "Rancheritos",
                FavDish = "Super Nachos",
                Address = "46 E 1230 N St",
                PhoneNum = "(801) 374-0822",
                WebLink = "https://rancheritosmexicanfood.com/menu/"
            };

            Restaurants r2 = new Restaurants(2)
            {
                RestName = "Taco Bell",
                FavDish = "Cheesy Bean and Rice Burrito",
                Address = "1244 N Freedom Blvd",
                PhoneNum = "(801) 377-7080",
                WebLink = "tacobell.com"
            };

            Restaurants r3 = new Restaurants(3)
            {
                RestName = "Bombay House",
                FavDish = "Tikki Masala",
                Address = "463 N University Ave",
                PhoneNum = "(801) 373-6677",
                WebLink = "bombayhouse.com"
            };

            Restaurants r4 = new Restaurants(4)
            {
                RestName = "Costa Vida",
                FavDish = "Burrito",
                Address = "1200 N University Ave",
                PhoneNum = "(801) 373-1876",
                WebLink = "costavida.com"
            };

            Restaurants r5 = new Restaurants(5)
            {
                RestName = "Communal",
                Address = "102 N University Ave",
                PhoneNum = "(801) 373-8000",
                WebLink = "getbento.com"
            };

            // Return the list
            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
