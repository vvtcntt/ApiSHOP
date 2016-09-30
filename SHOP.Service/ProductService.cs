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
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetALL();
        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totallRow);
        Product GetById(int id);

        IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository,IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetALL()
        {
            return _productRepository.GetAll(new string[] { "GroupProduct" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x=>x.Active,out totalRow,page,pageSize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Active, out totalRow, page, pageSize);
        }

        public Product GetById(int id)
        {
          return  _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
