using System.Collections.Generic;
using System.Linq;
using Contact.Domain.Interfaces;
using Contact.Domain.Models;
using Contact.Infra.Context;

namespace Contact.Infra.Repositories
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : BaseEntity
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context){
            _context = context;
        }

        public virtual Tentity GetById(int id){
            var query = _context.Set<Tentity>().Where(e => e.Id == id);

            if(query.Any())
                return query.FirstOrDefault();

            return null;    
        }

        public virtual IEnumerable<Tentity> GetAll()
        {
            var query = _context.Set<Tentity>();

            if(query.Any())
                return query.ToList();

            return new List<Tentity>();

        }

        public void Save(Tentity entity)
        {
            _context.Set<Tentity>().Add(entity);
        }
        
    }
}