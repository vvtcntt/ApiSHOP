﻿using SHOP.Data.Infratructure;
using SHOP.Data.Repositories;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
            void Save();
    }
    class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository,IUnitOfWork initOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = initOfWork;
        }
        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();        }
    }
}