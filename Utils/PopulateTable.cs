namespace MyApp.Utils;

using MyApp.Models;
using MyApp.Data;

public class PopulateTable 
{
    public static void ItemsFromCsv(MyAppDbContext context, String csvPath) 
    {
        List<Item> items = File.ReadAllLines(csvPath)
                                           .Skip(1)
                                           .Select(v => new Item(v))
                                           .ToList();
        
        context.Items.AddRange(items);

        context.SaveChanges();
    }
}