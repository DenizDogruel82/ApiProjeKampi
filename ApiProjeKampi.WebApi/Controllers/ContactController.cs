using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value=_context.Contacts.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult ContactPost(CreateContactDto createContactDto) { 
        
            Contact contact = new Contact();
            contact.Email = createContactDto.Email;
            contact.Address = createContactDto.Address;
            contact.Phone = createContactDto.Phone;
            contact.MapLocation = createContactDto.MapLocation;
            contact.OpenHours = createContactDto.OpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarili");

        
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id) {

            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            return Ok("Silme işlemi başarılı");
        
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id) { 
        
        var value= _context.Contacts.Find(id);
            return Ok(value);
        
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact();
            contact.ContactId = updateContactDto.ContactId;
            contact.Email = updateContactDto.Email;
            contact.Address= updateContactDto.Address;
            contact.OpenHours= updateContactDto.OpenHours;
            contact.Phone= updateContactDto.Phone;
            contact.MapLocation= updateContactDto.MapLocation;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı");

        }

    }
}
