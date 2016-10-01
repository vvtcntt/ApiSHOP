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
        void Add(GroupProduct groupProduct);
        void Update(GroupProduct groupProduct);
        void Delete(int id);
        IEnumerable<GroupProduct> GetAll();
        IEnumerable<GroupProduct> GetAllByParentId(int parentId);
        GroupProduct GetById(int id);


    }
    class GroupProductService : IGroupProductService
    {
        IGroupProductRepository _groupProductRepository;
        IUnitOfWork _unitOfWork;
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
          return  _groupProductRepository.GetAll();
        }

        public IEnumerable<GroupProduct> GetAllByParentId(int parentId)
        {
            return _groupProductRepository.GetMulti(x => x.Active == true && x.ParentID == parentId);
         }

        public GroupProduct GetById(int id)
        {
            return _groupProductRepository.GetSingleById(id);
        }

        public void Update(GroupProduct groupProduct)
        {
            _groupProductRepository.Update(groupProduct);
        }
    }
}
