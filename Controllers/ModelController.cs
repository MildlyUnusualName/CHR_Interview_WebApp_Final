using CHR_Interview_WebApp_Final.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHR_Interview_WebApp_Final.Controllers
{
    public class ModelController : Controller
    {
        // GET: ModelController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessCode(string stateCode)
        {
            StateCodes input = new StateCodes() { InputCode = stateCode, Results = new List<string>()};
            BinarySearchTree countryTree = BinarySearchTree.BuildTree();

            switch (input.InputCode)
            {
                case "USA":
                case "usa":
                    countryTree.FindPath(99, input.Results);
                    return View(input);
                case "CAN":
                case "can":
                    countryTree.FindPath(100, input.Results);
                    return View(input);
                case "MEX":
                case "mex":
                    countryTree.FindPath(80, input.Results);
                    return View(input);
                case "BEL":
                case "bel":
                    countryTree.FindPath(85, input.Results);
                    return View(input);
                case "GTM":
                case "gtm":
                    countryTree.FindPath(40, input.Results);
                    return View(input);
                case "HND":
                case "hnd":
                    countryTree.FindPath(41, input.Results);
                    return View(input);
                case "SLV":
                case "slv":
                    countryTree.FindPath(1, input.Results);
                    return View(input);
                case "NIC":
                case "nic":
                    countryTree.FindPath(42, input.Results);
                    return View(input);
                case "CRI":
                case "cri":
                    countryTree.FindPath(43, input.Results);
                    return View(input);
                case "PAN":
                case "pan":
                    countryTree.FindPath(44, input.Results);
                    return View(input);
                default:
                    break;
            }
            return View(input);
        }
        // GET: ModelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ModelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
