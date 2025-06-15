namespace MyApp.Models;

using MyApp.Data;
using System.IO;

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
    
    public Item(string csvLine)
    {
        string[] values = csvLine.Split(';');
        Category = Convert.ToString(values[0]);
        Name = Convert.ToString(values[1]);
        Mrp = Convert.ToInt32(values[2]);
        DiscountPercent = Convert.ToInt32(values[3]);
        AvailableQuantity = Convert.ToInt32(values[4]);
        DiscountedSellingPrice = Convert.ToInt32(values[5]);
        WeightInGms = Convert.ToInt32(values[6]);
        OutOfStock = Convert.ToBoolean(values[7]);
        Quantity = Convert.ToInt32(values[8]); 
    }
}
