using Countries.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Countries.Index
{
    public class IndexModel : PageModel
    {
        public List<CityModel> Cities { get; set; }
        public List<CountryModel> Countries { get; set; }
        public string? SearchTerm { get; set; }
        public int? SelectedCountryId { get; set; }
        public string? SortBy { get; set; }

        public IndexModel()
        {
            Cities = new List<CityModel>();
            Countries = new List<CountryModel>();
            SelectedCountryId = 0;
            SortBy = "default";
        }

        public void OnGet()
        {
        }

    }
}
