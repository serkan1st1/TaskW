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
    public class WorkerManager : IWorkerService
    {
        IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public Worker GetById(int id)
        {
            return _workerDal.Get(x => x.WorkerID == id);
        }

        public List<Worker> GetList()
        {
            return _workerDal.List();
        }

        public void WorkerAdd(Worker worker)
        {
            _workerDal.Insert(worker);
        }

        public void WorkerDelete(Worker worker)
        {
            _workerDal.Delete(worker);
        }

        public void WorkerUpdate(Worker worker)
        {
            _workerDal.Update(worker);
        }
    }
}
