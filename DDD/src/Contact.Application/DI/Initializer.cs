using Contact.Domain.Interfaces;
using Contact.Domain.Models;
using Contact.Infra.Context;
using Contact.Infra.Repositories;

namespace Contact.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection){
            services.AddDbContext<AppDbContext>(options => options.UseSqlite(conection));

            services.AddScoped(typeof(IRepository<Conttact>), typeof(ContactRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ContactService));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}