using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWorkerService
    {
        List<Worker> GetList();
        void WorkerAdd(Worker worker);
        void WorkerDelete(Worker worker);
        void WorkerUpdate(Worker worker);
        Worker GetById(int id);
    }
}
