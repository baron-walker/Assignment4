using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    // Process The list of suggested restaurants that are stored in the temp storage
    public static class TempStorage
    {
        private static List<RestResponse> applications = new List<RestResponse>();

        public static IEnumerable<RestResponse> Applications => applications;

        public static void AddApplication(RestResponse application)
        {
            applications.Add(application);
        }
    }
}