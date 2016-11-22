using SimpleAspNetMvcArchProject.Data.Domain;

namespace SimpleAspNetMvcArchProject.Service
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int Id);
    }
}
