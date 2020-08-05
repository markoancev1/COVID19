using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data;
using COVID19.Data.Entities;
using COVID19.Repositories.Repository.Interfaces;

namespace COVID19.Repositories
{
    public class CaseRepository : ICaseRepository
    {
        private readonly DataContext _context;

        public CaseRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Cases cases)
        {
            _context.Cases.Add(cases);
            _context.SaveChanges();
        }

        public void Edit(Cases cases)
        {
            _context.Cases.Update(cases);
            _context.SaveChanges();
        }

        public IEnumerable<Cases> GetAllCases()
        {
            var result = _context.Cases.AsEnumerable();
            return result;
        }

        public Cases GetCasesById(int id)
        {
            var result = _context.Cases.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
