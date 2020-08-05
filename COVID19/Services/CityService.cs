using COVID19.Data.Entities;
using COVID19.Repositories.Repository.Interfaces;
using COVID19.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public void Add(Cities cities)
        {
            _cityRepository.Add(cities);
        }

        public void Edit(Cities cities)
        {
            _cityRepository.Add(cities);
        }

        public IEnumerable<Cities> GetAllCities()
        {
            var result = _cityRepository.GetAllCities();
            return result;
        }

        public Cities GetCitiesById(int id)
        {
            var result = _cityRepository.GetCitiesById(id);
            return result;
        }
    }
}
