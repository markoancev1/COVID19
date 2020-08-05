using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;

namespace COVID19.Repositories.Repository.Interfaces
{
    public interface ICaseRepository
    {

        IEnumerable<Cases> GetAllCases();
        void Add(Cases cases);
        void Edit(Cases cases);
        Cases GetCasesById(int id);
    }
}
