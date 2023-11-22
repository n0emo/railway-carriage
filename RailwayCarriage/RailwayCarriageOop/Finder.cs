using Domain.Models;

namespace RailwayCarriageOop;

internal class Finder
{
    public class FinderOptions
    {
        public IEnumerable<int> Radiuses { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<CarriageCount> Carriages { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }

        public FinderOptions(
            IEnumerable<int> radiuses,
            IEnumerable<Company> companies,
            IEnumerable<CarriageCount> carriages,
            string type,
            string amount)
        {
            Radiuses = radiuses;
            Companies = companies;
            Carriages = carriages.Where(c => c.Name == type);
            Type = type;
            Amount = amount;
        }
    }

    public class FinderResult
    {
        public (Company company, int amount)[] Companies {get;}

        public FinderResult((Company company, int amount)[] companies)
        {
            Companies = companies;
        }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException() : base()
        {
        }
    }

    private IEnumerable<int> _radiuses;
    private IEnumerable<Company> _companies;
    private IEnumerable<CarriageCount> _carriages;
    private string _type;
    private string _amount;

    public Finder(FinderOptions options)
    {
        _radiuses = options.Radiuses;
        _companies = options.Companies;
        _carriages = options.Carriages;
        _type = options.Type;
        _amount = options.Amount;
    }
    
    public FinderResult Find()
    {
        foreach(int radius in _radiuses)
        {
            FinderResult result;
            try
            {
                result = FindInRadius(radius);
            }
            catch
            {
                continue;
            }

            return result;
        }

        throw new NotFoundException("No carriages was found.");
    }

    private FinderResult FindInRadius(int radius)
    {
        var company_groups = _companies
            .GroupBy(c => c.IsState)
            .ToDictionary(c => c.Key, c => c.ToList());


        throw new NotFoundException();
    }

    
}
