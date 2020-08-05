
using COVID19.Data;
using COVID19.Data.Entities;
using COVID19.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Cities cities)
        {
            _context.Cities.Add(cities);
            _context.SaveChanges();
        }

        public void Edit(Cities cities)
        {
            _context.Cities.Update(cities);
            _context.SaveChanges();
        }

        public IEnumerable<Cities> GetAllCities()
        {
            var result = _context.Cities.AsEnumerable();
            return result;
        }

        public Cities GetCitiesById(int id)
        {
            var result = _context.Cities.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}

