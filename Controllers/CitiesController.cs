using System.Diagnostics;
using Countries.Details;
using Countries.Index;
using Countries.Models;
using Microsoft.AspNetCore.Mvc;
using temp.Database;

namespace Countries.Controllers;

public class CitiesController : Controller
{
    private ApplicationContext _context = new ApplicationContext();

    public IActionResult Index(string searchTerm, int selectedCountryId, string sortBy)
    {
        var cities = _context.Cities?.ToList() ?? new List<CityModel>();
        cities.ForEach(city => city.Country = _context.Countries?.FirstOrDefault(c => c.ID == city.CountryID));

        // Filter by input value
        if (!string.IsNullOrEmpty(searchTerm))
        {
            cities = cities.Where(c => c.Name!.Contains(searchTerm)).ToList();
        }

        // Filter by selected country
        if (selectedCountryId != 0)
        {
            cities = cities.Where(c => c.Country!.ID == selectedCountryId).ToList();
        }

        // Sort cities
        switch (sortBy)
        {
            // case "population":
            //     cities = cities.OrderByDescending(c => c.Population).ToList();
            //     break;
            // case "area":
            //     cities = cities.OrderByDescending(c => c.Area).ToList();
            //     break;
            default:
                // Default sorting
                // cities = cities.OrderBy(c => c.Name).ToList();
                break;
        }

        var model = new IndexModel
        {
            Cities = cities,
            Countries = _context.Countries?.ToList() ?? new List<CountryModel>(),
            SearchTerm = searchTerm,
            SelectedCountryId = selectedCountryId,
            SortBy = sortBy
        };

        return View(model);
    }

    public IActionResult Details(int id)
    {
        var city = _context.Cities?.FirstOrDefault(c => c.ID == id);
        if (city == null)
        {
            return NotFound();
        }

        var model = new DetailsModel
        {
            City = city,
            Country = _context.Countries?.FirstOrDefault(c => c.ID == city.CountryID)
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
