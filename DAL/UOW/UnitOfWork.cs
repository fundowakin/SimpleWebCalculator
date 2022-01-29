using DAL.Context;
using DAL.Models;
using DAL.Repositories;

namespace DAL.UOW
{
    public class UnitOfWork
    {
        private static CalculatorContext _context;
        private IRepository<Result> _resultRepository;
        private IRepository<Expression> _expressionRepository;

        public UnitOfWork()
        {
            _context ??= new CalculatorContext();
        }

        public IRepository<Result> ResultRepository => _resultRepository ??= new ResultRepository(_context);
        public IRepository<Expression> ExpressionRepository => _expressionRepository ??= new ExpressionRepository(_context);
    }
}