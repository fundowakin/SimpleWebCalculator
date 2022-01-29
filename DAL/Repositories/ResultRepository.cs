using System.Collections.Generic;
using System.Linq;
using DAL.Context;
using DAL.Models;

namespace DAL.Repositories
{
    public class ResultRepository : IRepository<Result>
    {
        private readonly CalculatorContext _context;
        public ResultRepository(CalculatorContext context)
        {
            _context = context;
        }
        public IEnumerable<Result> GetAll()
        {
            return _context.Results;
        }

        public Result GetById(int id)
        {
            return _context.Results.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Result item)
        {
            _context.Results.Add(item);
            _context.SaveChanges();
        }

        public void Update(Result item)
        {
            _context.Results.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Result item)
        {
            _context.Results.Remove(item);
            _context.SaveChanges();
        }
    }
}