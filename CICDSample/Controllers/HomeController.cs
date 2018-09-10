using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;

namespace CICDSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOperations _operations;

        public HomeController(IOperations operations)
        {
            _operations = operations;
        }
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Add()
        {
            var request = new OperationRequest();
            request.Number1 = 100;
            request.Number2 = 200;
            var response = _operations.Add(request);
            return View(response);
        }

        public ActionResult Subtraction()
        {
            var request = new OperationRequest();
            request.Number1 = 10;
            request.Number2 = 20;
            var response = _operations.Subtraction(request);
            return View(response);
        }
        public ActionResult Multiplication()
        {
            var request = new OperationRequest();
            request.Number1 = 10;
            request.Number2 = 20;
            var response = _operations.Multiplication(request);
            return View(response);
        }
        public ActionResult Division()
        {
            var request = new OperationRequest();
            request.Number1 = 100;
            request.Number2 = 20;
            var response = _operations.Division(request);
            return View(response);
        }
    }
}