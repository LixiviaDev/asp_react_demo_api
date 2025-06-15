namespace MyApp.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = "Item";

    public Item() {}

    public Item(string _Name)
    {
        Name = _Name;
    }
}
