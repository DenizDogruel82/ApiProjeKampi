using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public CategoriesController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category) { 
          _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Ekleme başarılı");

        
        }
        [HttpGet]
        public IActionResult GetCategories() { 
        
           var value = _context.Categories.ToList();
            return Ok(value);

        }
        [HttpDelete]
        public IActionResult DeleteCategories(int id) {
            var value = _context.Categories.Find(id);
           _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi Başarılı");
            


        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) { 
        
        var value= _context.Categories.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category) { 
        
        _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Guncelleme işlemi başarılı");
        
        }
    }
}
