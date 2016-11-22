using System.Linq;
using SimpleAspNetMvcArchProject.Data;
using SimpleAspNetMvcArchProject.Data.Domain;

namespace SimpleAspNetMvcArchProject.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IContext _context;
        
        public CountryService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<Country>();
        }

        public Country GetById(int Id) {
            return _dbset.FirstOrDefault(x=>x.Id == Id);
        }
    }
}
