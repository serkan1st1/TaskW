using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using TaskNacres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskNacres.Controllers
{
    public class WorkerController : Controller
    {
        TaskNacresDbEntities wm2 = new TaskNacresDbEntities();
        WorkerManager wm = new WorkerManager(new EFWorkerDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetWorkerList()
        {
            var workerValues = wm.GetList();
            return View(workerValues);
        }
        [HttpGet]
        public ActionResult AddWorker()
        {
            ViewBag.list = wm2.Companies.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddWorker(Worker p)
        {
           
            WorkerValidatior workerValidator = new WorkerValidatior();
            ValidationResult results = workerValidator.Validate(p);
            if (results.IsValid)
            {
                wm.WorkerAdd(p);

                return RedirectToAction("GetWorkerList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View();


        }

        public ActionResult DeleteWorker(int id)
        {
            var workerValue = wm.GetById(id);
            wm.WorkerDelete(workerValue);
            return RedirectToAction("GetWorkerList");
        }

        [HttpGet]
        public ActionResult EditWorker(int id )
        {
         
            var workerValue = wm.GetById(id);
            ViewBag.list = wm2.Companies.ToList();
            return View(workerValue);
        }

        [HttpPost]
        public ActionResult EditWorker(Worker p)
        {
           
            wm.WorkerUpdate(p);
            return RedirectToAction("GetWorkerList");
        }
    }
}