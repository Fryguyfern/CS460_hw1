namespace FinalProject.Models;

public class GroceryItem
{
    public string? Name { get; set; }

    public string? Category { get; set; }

    public int Quantity { get; set; }

    public string? Store { get; set; }

    public bool Coupon { get; set; }

    public string? CouponDesc { get; set; }
}
