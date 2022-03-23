using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDAl;
        public ServiceManager(IServiceDal serviceDAl)
        {
            _serviceDAl = serviceDAl;
        }

        public void TAdd(Service t)
        {
            _serviceDAl.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDAl.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _serviceDAl.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDAl.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDAl.Update(t);
        }
    }
}
