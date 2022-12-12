using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskNacres.Controllers
{
    public class CompanyController : Controller
    {
        CompanyManager cm = new CompanyManager(new EFCompanyDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCompanyList()
        {
            var companyValues = cm.GetList();
            return View(companyValues);
        }

        [HttpGet]
        public ActionResult AddCompany()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCompany(Company p)
        {
            // cm.AddCompanyBL(p);
            CompanyValidatior companyValidator = new CompanyValidatior();
            ValidationResult results = companyValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CompanyAddBL(p);
                return RedirectToAction("GetCompanyList");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


        }

        public ActionResult DeleteCompany(int id)
        {
            var companyValue = cm.GetByID(id);
            cm.CompanyDelete(companyValue);
            return RedirectToAction("GetCompanyList");
        }

        [HttpGet]
        public ActionResult EditCompany(int id)
        {
            var companyvalue = cm.GetByID(id);
            return View(companyvalue);
        }

        [HttpPost]
        public ActionResult EditCompany(Company p)
        {
            cm.CompanyUpdate(p);
            return RedirectToAction("GetCompanyList");
        }
    }
}