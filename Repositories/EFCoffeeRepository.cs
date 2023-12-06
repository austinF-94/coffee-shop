using coffee_shop.Migrations;
using coffee_shop.Models;

namespace coffee_shop.Repositories;

public class EFCoffeeRepository : ICoffeeRepository
{
    private readonly CoffeeDbContext _context;

    public EFCoffeeRepository(CoffeeDbContext context)
    {
        _context = context;
    }

    public Coffee CreateCoffee(Coffee newCoffee)
    {
        _context.Coffee.Add(newCoffee);
        _context.SaveChanges();
        return newCoffee;
    }

    public void DeleteCoffeeById(int coffeeId)
    {
        var coffee = _context.Coffee.Find(coffeeId);
        if (coffee != null)
        {
            _context.Coffee.Remove(coffee);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Coffee> GetAllCoffee()
    {
        return _context.Coffee.ToList();
    }

    public Coffee GetCoffeeById(int coffeeId)
    {
        return _context.Coffee.SingleOrDefault(c => c.CoffeeId == coffeeId);
    }

    public Coffee UpdateCoffee(Coffee newCoffee)
    {
        var originalCoffee = _context.Coffee.Find(newCoffee.CoffeeId);
        if (originalCoffee != null)
        {
            originalCoffee.Name = newCoffee.Name;
            originalCoffee.Description = newCoffee.Description;
            originalCoffee.Price = newCoffee.Price;
            _context.SaveChanges();
        }
        return originalCoffee;
    }
}