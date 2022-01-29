using System.Collections.Generic;
using System.Linq;
using DAL.Context;
using DAL.Models;

namespace DAL.Repositories
{
    public class ExpressionRepository : IRepository<Expression>
    {
        private readonly CalculatorContext _context;
        public ExpressionRepository(CalculatorContext context)
        {
            _context = context;
        }
        public IEnumerable<Expression> GetAll()
        {
            return _context.Expressions;
        }

        public Expression GetById(int id)
        {
            return _context.Expressions.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Expression item)
        {
            _context.Expressions.Add(item);
            _context.SaveChanges();
        }

        public void Update(Expression item)
        {
            _context.Expressions.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Expression item)
        {
            _context.Expressions.Remove(item);
            _context.SaveChanges();
        }
    }
}