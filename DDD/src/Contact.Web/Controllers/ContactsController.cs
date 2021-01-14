using System.Collections.Generic;
using Contact.Domain.Interfaces;
using Contact.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Web.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactService _contactService;
        private readonly IRepository<Conttact> _contactRepository;

        public ContactsController(ContactService contactService, 
            IRepository<Conttact> contactRepository){
                _contactService = contactService;
                _contactRepository = contactRepository;
            }

        [HttpGet]
        public IActionResult GetContacts(){
            var contacts = _contactRepository.GetAll();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public ActionResult<Conttact> GetContact(int id){
            var contact = _contactRepository.GetById(id);

            if (contact == null)
                return NotFound(new {message = $"Contact of ID ={id} not found!"});

            return contact;    
        }
    }
}