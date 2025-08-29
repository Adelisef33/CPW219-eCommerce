using eCommerce.Data;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce.Controllers;

    

public class ProductController : Controller
{
    private readonly ProductDBContext _context;

    public ProductController(ProductDBContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Create(Product p)
    {
        if (ModelState.IsValid)
        {
            //Add to database
            _context.Products.Add(p);          // Add the product to the context
            await _context.SaveChangesAsync(); // Save changes to database

            return RedirectToAction(nameof(Index)); //Redirect to the Index action
        }
        return View(p); // If model state is invalid, return the view with the product data and validation errors
    }
}

