using System.ComponentModel.DataAnnotations;

namespace coffee_shop.Models;

public class Coffee {
    public int CoffeeId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required, Range(0, 20, ErrorMessage = "You must enter a price between 0 and 20.")]
    public double Price { get; set; }


    public string getName()
    {
        return Name;
    }
    public void setName(string name) 
    {
        this.Name = name;
    }


    public string getDescription()
    {
        return Description;
    }
    public void setDescription(string description) 
    {
        this.Description = description;
    }


    public double getPrice()
    {
        return Price;
    }
    public void setPrice(double price) 
    {
        this.Price = price;
    }
}