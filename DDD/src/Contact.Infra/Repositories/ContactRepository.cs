using System.Collections.Generic;
using System.Linq;
using Contact.Domain.Models;
using Contact.Infra.Context;

namespace Contact.Infra.Repositories
{
    public class ContactRepository : Repository<Conttact>
    {
        public ContactRepository(AppDbContext context) : base(context){}

        public override Conttact GetById(int id)
        {
            var query = _context.Set<Conttact>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<Conttact> GetAll(){
            var query = _context.Set<Conttact>();

            return query.Any() ? query.ToList() : new List<Conttact>();
        }
    }
}