using System.Threading.Tasks;
using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class ProductController : Controller
{

    private readonly DataContext _context;
    public ProductController(DataContext context)
    {
        _context = context;
    }
    public ActionResult Index()
    {
        // var products = _context.Products.Include(i => i.Category).ToList();
        var products = _context.Products.Select(i => new ProductGetModel
        {
            Id = i.Id,
            ProductName = i.ProductName,
            Price = i.Price,
            IsActive = i.IsActive,
            IsHome = i.IsHome,
            CategoryName = i.Category.CategoryName,
            Image = i.Image,
        }).ToList();
        // her ürünle birlikte kategoriyide aldık = Include(i => i.Category)
        return View(products);
    }
    public ActionResult List(string url, string q)
    {
        var query = _context.Products.Where(i => i.IsActive);

        if (!string.IsNullOrEmpty(url))
        {
            query = query.Where(i => i.Category.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.ProductName.ToLower().Contains(q.ToLower()));

            ViewData["q"] = q;
        }

        return View(query.ToList());
    }

    public ActionResult Details(int id)
    {
        var product = _context.Products.Find(id);

        if (product == null)
        {
            return RedirectToAction("Index", "Home");
        }

        ViewData["BenzerUrunler"] = _context.Products.Where(i => i.IsActive && i.CategoryId == product.CategoryId && i.Id != id).Take(4).ToList(); // random olacak

        return View(product);
    }

    public ActionResult Create()
    {
        // ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
        return View();
    }
    [HttpPost]
    public async Task<ActionResult> Create(ProductCreateModel model)
    {
        var fileName = Path.GetRandomFileName() + ".jpg";
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await model.Image!.CopyToAsync(stream);
        }

        var entity = new Product()
        {
            ProductName = model.ProductName,
            Description = model.Description,
            Price = model.Price,
            IsActive = model.IsActive,
            IsHome = model.IsHome,
            CategoryId = model.CategoryId,
            Image = fileName,
        };

        _context.Products.Add(entity);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
    public ActionResult Edit(int id)
    {
        var entity = _context.Products.Select(i => new ProductEditModel
        {
            Id = i.Id,
            ProductName = i.ProductName,
            Description = i.Description,
            IsActive = i.IsActive,
            IsHome = i.IsHome,
            Price = i.Price,
            CategoryId = i.CategoryId,
            Image = i.Image,

        }).FirstOrDefault(i => i.Id == id);
        ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
        return View(entity);
    }
    [HttpPost]
    public ActionResult Edit(int id, ProductEditModel model)
    {
        if (id != model.Id)
        {
            return RedirectToAction("Index");
        }

        var entity = _context.Products.FirstOrDefault(i => i.Id == model.Id);

        if (entity != null)
        {
            entity.ProductName = model.ProductName;
            entity.Description = model.Description;
            entity.IsActive = model.IsActive;
            entity.IsHome = model.IsHome;
            entity.Price = model.Price;
            entity.CategoryId = model.CategoryId;
            // entity.Image = model.Image;

            _context.SaveChanges();

            TempData["Message"] = $"{entity.ProductName} ürünü güncellendi";

            return RedirectToAction("Index");

        }
        return View(model);
    }
}