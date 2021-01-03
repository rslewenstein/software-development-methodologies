using Contact.Domain.Interfaces;

namespace Contact.Domain.Models
{
    public class ContactService
    {
        private readonly IRepository<Conttact> _contactRepository;

        public ContactService(IRepository<Conttact> contactRepository){
            _contactRepository = contactRepository;
        }

        public void Save(int id, string name, string email){
            var contact = _contactRepository.GetById(id);

            if(contact == null){
                contact = new Conttact(name, email);
                _contactRepository.Save(contact);
            }
            else{
                contact.Update(name, email);
            }
        }
    }
}