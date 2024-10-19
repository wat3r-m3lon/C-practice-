
Product laptop = new Product("Laptop") { Price = 100 };
Product desktop = new Product("desktop") { Price = 500 };

Shopping car = new Shopping();

car.AddProduct(laptop);
car.AddProduct(desktop);
Console.WriteLine($"Total price is {car.TotalPrice}");

class Product
{
    public string Name { get; set; }

    private decimal _price;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                throw new Exception("Price can not be negative");
            }
            _price = value;
        }
    }

    public readonly decimal TaxRate;
    public const decimal Discount = 0.1m;
    public decimal DiscountPrice
    {
        get {
            decimal discount = Price * Discount;
            decimal discountedPrice = Price - discount;
            return discountedPrice;

        }
    }
    public Product(string name)
    {
        TaxRate = 0.2m;
        Name = name;
    }
}

class Shopping
{
    public decimal TotalPrice { get; private set; }
    public readonly DateTime CreateDateTime;
    public List<Product> Products = new List<Product>();
    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalPrice += product.DiscountPrice;
    }
    public Shopping()
    {
        CreateDateTime = DateTime.Now;
    }
}

