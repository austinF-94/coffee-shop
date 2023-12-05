using coffee_shop.Models;

namespace coffee_shop.Repositories;

public interface ICoffeeRepository
{
    IEnumerable<Coffee> GetAllCoffee();
    Coffee GetCoffeeById(int coffeeId);
    Coffee CreateCoffee(Coffee newCoffee);
    Coffee UpdateCoffee(Coffee newCoffee);
    void DeleteCoffeeById(int coffeeId);
}