using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;

namespace COVID19.Services.Service.Interfaces
{
    public interface ICaseService
    {
        IEnumerable<Cases> GetAllCases();
        void Add(Cases cases);
        void Edit(Cases cases);
        Cases GetCasesById(int id);
    }
}
