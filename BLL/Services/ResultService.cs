using System.Collections.Generic;
using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL.UOW;

namespace BLL.Services
{
    public class ResultService : IService<ResultDTO>
    {
        private readonly UnitOfWork _unitOfWork;

        public ResultService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<ResultDTO> GetAll()
        {
            var result = _unitOfWork.ResultRepository.GetAll();
            var config = new MapperConfiguration(cfg 
                => cfg.CreateMap<Result, ResultDTO>());
            var mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<ResultDTO>>(result);
        }
    }
}