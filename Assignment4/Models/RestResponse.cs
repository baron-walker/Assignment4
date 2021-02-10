using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class RestResponse
    {
        public string Name { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; }

        // Validate phone numbers to be put in like "111-222-1234"
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string RestPhone { get; set; }

    }
}
