using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
namespace BulkyBookWeb.Controllers;

public class CategoryController: Controller
{

    private readonly ApplicationDBContext _db;

    public CategoryController(ApplicationDBContext db){
        _db = db;
    }
    public IActionResult Index(){
        IEnumerable<Category> objCategoryList = _db.Categories;
return View(objCategoryList);
    }
      public IActionResult Create(){
        
return View();
    }
    [HttpPost]
[ValidateAntiForgeryToken]

    public IActionResult Create(Category obj){
        
        obj.PrecCloseFromOpen = Math.Round(((obj.Open - obj.Close)/obj.Open)*100,4);
        obj.PrecHighOfDay = Math.Round(((obj.HighOfDay - obj.Open) / obj.Open) * 100,4);
        obj.PrecLowOfDay = Math.Round(((obj.LowOfDay - obj.Open) / obj.Open) * 100,4);
        obj.PrecCloseFromOpen = Math.Round(((obj.Close - obj.Open) / obj.Open) * 100,4);
        obj.PrecFromOpen30High = Math.Round(((obj.FromOpen30High - obj.Open) / obj.Open) * 100,4);
        obj.PrecCompleteRange = Math.Round(((obj.HighOfDay - obj.LowOfDay) / obj.HighOfDay) * 100,4);
        obj.PrecDay2Open = Math.Round(((obj.Close - obj.Day2Open) / obj.Close) * 100, 4);
        obj.Day2Volume = obj.DailyVolume * ((obj.HighOfDay + obj.LowOfDay) / 2);
        if (obj.Name == obj.DisplayOrder.ToString()){
            ModelState.AddModelError("Customer","The DisplayOrder cannot exactly match the Name.");
        }
        if(ModelState.IsValid){
        _db.Categories.Add(obj);
        _db.SaveChanges();
               TempData["success"] = "Category created successfully";
     return RedirectToAction("Index");
    }
      return View(obj);
    
    }

 public IActionResult Edit(int? id){
     if(id ==null || id ==0)  {
        return NotFound();
     } 
     //var categoryFromDb = _db.Categories.FirstOrDefault(u => u.Id==id);
    // var categoryFromDbFirst = _db.Categories.SingleOrDefault(u => u.Id==id);
     var categoryFromDbFind = _db.Categories.Find(id);
return View(categoryFromDbFind);
    }
   [HttpPost]
[ValidateAntiForgeryToken]

    public IActionResult Edit(Category obj){
        obj.PrecCloseFromOpen = Math.Round(((obj.Open - obj.Close) / obj.Open) * 100, 4);
        obj.PrecHighOfDay = Math.Round(((obj.HighOfDay - obj.Open) / obj.Open) * 100, 4);
        obj.PrecLowOfDay = Math.Round(((obj.LowOfDay - obj.Open) / obj.Open) * 100, 4);
        obj.PrecCloseFromOpen = Math.Round(((obj.Close - obj.Open) / obj.Open) * 100, 4);
        obj.PrecFromOpen30High = Math.Round(((obj.FromOpen30High - obj.Open) / obj.Open) * 100, 4);
        obj.PrecCompleteRange = Math.Round(((obj.HighOfDay - obj.LowOfDay) / obj.HighOfDay) * 100, 4);
        obj.Day2Volume = obj.DailyVolume * ((obj.HighOfDay + obj.LowOfDay) / 2);
        obj.PrecDay2Open = Math.Round(((obj.Close - obj.Day2Open) / obj.Close) * 100, 4);
       
        if (obj.Name == obj.DisplayOrder.ToString()){
            ModelState.AddModelError("Customer","The DisplayOrder cannot exactly match the Name.");
        }
        if(ModelState.IsValid){
        _db.Categories.Update(obj);
        _db.SaveChanges();
               TempData["success"] = "Category edited successfully";
     return RedirectToAction("Index");
    }
      return View(obj);
    
    }

     public IActionResult Delete(int? id){
     if(id ==null || id ==0)  {
        return NotFound();
     } 
     //var categoryFromDb = _db.Categories.FirstOrDefault(u => u.Id==id);
    // var categoryFromDbFirst = _db.Categories.SingleOrDefault(u => u.Id==id);
     var categoryFromDbFind = _db.Categories.Find(id);
return View(categoryFromDbFind);
    }
    //POST
  [HttpPost]
[ValidateAntiForgeryToken]

    public IActionResult Delete(Category obj){
        obj.PrecCloseFromOpen = Math.Round(((obj.Open - obj.Close) / obj.Open) * 100, 4);
        obj.PrecHighOfDay = Math.Round(((obj.HighOfDay - obj.Open) / obj.Open) * 100, 4);
        obj.PrecLowOfDay = Math.Round(((obj.LowOfDay - obj.Open) / obj.Open) * 100, 4);
        obj.PrecCloseFromOpen = Math.Round(((obj.Close - obj.Open) / obj.Open) * 100, 4);
        obj.PrecFromOpen30High = Math.Round(((obj.FromOpen30High - obj.Open) / obj.Open) * 100, 4);
        obj.PrecCompleteRange = Math.Round(((obj.HighOfDay - obj.LowOfDay) / obj.HighOfDay) * 100, 4);
        
        obj.PrecDay2Open = Math.Round(((obj.Close - obj.Day2Open) / obj.Close) * 100, 4);

        _db.Categories.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Category deleted successfully";
     return RedirectToAction("Index");
    
     
    }
}