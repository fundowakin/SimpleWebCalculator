using System.Collections.Generic;
using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL.UOW;

namespace BLL.Services
{
    public class ExpressionService : IService<ExpressionDTO>
    {
        private UnitOfWork _unitOfWork;

        public ExpressionService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ExpressionDTO> GetAll()
        {
            var result = _unitOfWork.ExpressionRepository.GetAll();
            var config = new MapperConfiguration(cfg 
                => cfg.CreateMap<Expression, ExpressionDTO>());
            var mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<ExpressionDTO>>(result);
        }
    }
}