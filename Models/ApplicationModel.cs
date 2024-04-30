namespace Countries.Models;

public class ContinentModel
{
    public int ID { get; set; }
    public string? Name { get; set; }
}

public class CountryModel
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int ContinentID { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }
    public string? Description { get; set; }

    // Navigation property for Continent
    public ContinentModel? Continent { get; set; }
}

public class CityModel
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int CountryID { get; set; }
    public bool IsCapital { get; set; }
    public string? Description { get; set; }

    // Navigation property for Country
    public CountryModel? Country { get; set; }
}
