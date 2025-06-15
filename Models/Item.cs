namespace MyApp.Models;

public class Item
{
    public int Id { get; set; }

    public string Category { get; set; } = "Default category";
    public string Name { get; set; } = "Default item";

    public int Mrp { get; set; } = 0;
    public int DiscountPercent { get; set; } = 0;
    public int AvailableQuantity { get; set; } = 0;
    public int DiscountedSellingPrice { get; set; } = 0;
    public int WeightInGms { get; set; } = 0;
    public int Quantity { get; set; } = 0;

    public bool OutOfStock { get; set; } = false;

    public Item() {}

    public Item(string _Category, 
                string _Name, 
                int _Mrp, 
                int _DiscountPercent, 
                int _AvailableQuantity, 
                int _DiscountedSellingPrice, 
                int _WeightInGms, 
                int _Quantity,
                bool _OutOfStock)
    {
        Category = _Category;
        Name = _Name;
        Mrp = _Mrp;
        DiscountPercent = _DiscountPercent;
        AvailableQuantity = _AvailableQuantity;
        DiscountedSellingPrice = _DiscountedSellingPrice;
        WeightInGms = _WeightInGms;
        Quantity = _Quantity;
        OutOfStock = _OutOfStock;
    }
}
