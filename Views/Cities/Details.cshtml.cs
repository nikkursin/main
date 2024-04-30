using Countries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Countries.Details
{
    public class DetailsModel : PageModel
    {
        public CityModel? City { get; set; }
        public CountryModel? Country { get; set; }

        public void OnGet()
        {
        }
    }
}
