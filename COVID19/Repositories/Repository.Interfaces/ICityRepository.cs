using COVID19.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19.Repositories.Repository.Interfaces
{
    public interface ICityRepository
    {
        IEnumerable<Cities> GetAllCities();
        void Add(Cities cities);
        void Edit(Cities cities);
        Cities GetCitiesById(int id);
    }
}
