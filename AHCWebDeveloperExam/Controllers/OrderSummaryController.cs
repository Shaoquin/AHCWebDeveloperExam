using AHCWebDeveloperExam.Helper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHCWebDeveloperExam.Controllers
{
    public class OrderSummaryController : Controller
    {

        // GET: OrderSummary
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderSummary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderSummary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderSummary/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderSummary/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderSummary/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderSummary/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderSummary/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
