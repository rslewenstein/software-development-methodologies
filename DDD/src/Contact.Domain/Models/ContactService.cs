using Contact.Domain.Interfaces;

namespace Contact.Domain.Models
{
    public class ContactService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactService(IRepository<Contact> contactRepository){
            _contactRepository = contactRepository;
        }

        public void Save(int id, string name, string email){
            var contact = _contactRepository.GetById(id);

            if(contact == null){
                contact = new Contact(name, email);
                _contactRepository.Save(contact);
            }
            else{
                contact.Update(name, email);
            }
        }
    }
}