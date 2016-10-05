using SHOP.Data.Infratructure;
using SHOP.Data.Repositories;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Service
{
    public interface IGroupProductService
    {
        GroupProduct Add(GroupProduct groupProduct);
        void Update(GroupProduct groupProduct);
        GroupProduct Delete(int id);
        IEnumerable<GroupProduct> GetAll();
        IEnumerable<GroupProduct> GetAllByParentId(int parentId);
        GroupProduct GetById(int id);

        void Save();
    }
    public class GroupProductService : IGroupProductService
    {
        private IGroupProductRepository _groupProductRepository;
        private IUnitOfWork _unitOfWork;


        public GroupProductService(IGroupProductRepository groupProductRepository, IUnitOfWork unitOfWork)
        {
            this._groupProductRepository = groupProductRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(GroupProduct groupProduct)
        {
            _groupProductRepository.Add(groupProduct);
        }

        public void Delete(int id)
        {
            _groupProductRepository.Delete(id);
        }

        public IEnumerable<GroupProduct> GetAll()
        {
            return _groupProductRepository.GetAll();
        }

        public IEnumerable<GroupProduct> GetAllByParentId(int parentId)
        {
            return _groupProductRepository.GetMulti(x => x.Active == true && x.ParentID == parentId);
        }

        public GroupProduct GetById(int id)
        {
            return _groupProductRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(GroupProduct groupProduct)
        {
            _groupProductRepository.Update(groupProduct);
        }

        GroupProduct IGroupProductService.Add(GroupProduct groupProduct)
        {
            throw new NotImplementedException();
        }

        GroupProduct IGroupProductService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
