using System.Threading.Tasks;

namespace Contact.Domain.Interfaces
{
    public interface IUnitOfWork
    {
         Task Commit();
    }
}