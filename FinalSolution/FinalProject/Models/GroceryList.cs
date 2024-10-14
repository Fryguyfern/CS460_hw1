namespace FinalProject.Models;

public static class GroceryList
{
    public static List<GroceryItem> Items=new List<GroceryItem>(){};
    public static void ADD(GroceryItem Item){
        Items.Add(Item);
    }
}
