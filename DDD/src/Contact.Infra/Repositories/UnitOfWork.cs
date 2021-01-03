using System.Threading.Tasks;
using Contact.Domain.Interfaces;
using Contact.Infra.Context;

namespace Contact.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context){
            _context = context;
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}