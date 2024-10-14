using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult ADDItem(GroceryItem Item){
        if (Item.Name!=null){
            GroceryList.ADD(Item);
        }
        return View(Item);
    }
    [HttpGet]
    public IActionResult Grocery(){
        return View(GroceryList.Items);
    }
    [HttpPost]
    public IActionResult Grocery(string? namelist, string? category, int? quantity, bool? coupon, string? coupondesc, string? store){
        if(namelist != null){
            string[] items=namelist.Split(",");
            foreach(string name in items){
                GroceryItem Item= new GroceryItem{Name=name, Category=category, Quantity=(int)quantity, Store=store, Coupon=(bool)coupon, CouponDesc=coupondesc};
            GroceryList.ADD(Item);
            }
                   
        }
        return View(GroceryList.Items);
    }
    [HttpGet]
    public IActionResult ADDList(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
