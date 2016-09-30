using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IContactRepository : IRepository<Contact> { }
   public class ContactRepository:RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository (DbFactory dbFactory):base(dbFactory)
        { }
    }
}
