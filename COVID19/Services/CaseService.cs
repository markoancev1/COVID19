using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;
using COVID19.Repositories.Repository.Interfaces;
using COVID19.Services.Service.Interfaces;

namespace COVID19.Services
{
    public class CaseService : ICaseService
    {
        private readonly ICaseRepository _caseRepository;

        public CaseService(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }

        public void Add(Cases cases)
        {
            _caseRepository.Add(cases);
        }

        public void Edit(Cases cases)
        {
            _caseRepository.Edit (cases);
        }

        public IEnumerable<Cases> GetAllCases()
        {
            var result = _caseRepository.GetAllCases();
            return result;
        }

        public Cases GetCasesById(int id)
        {
            var result = _caseRepository.GetCasesById(id);
            return result;
        }
    }
}
