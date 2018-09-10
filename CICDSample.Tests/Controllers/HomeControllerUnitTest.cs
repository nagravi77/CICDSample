using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CICDSample.Controllers;
using BAL;
using Moq;
using System.Web.Mvc;

namespace CICDSample.Tests.Controllers
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        private Mock<IOperations> _operations;
        private HomeController _homeController;

        [TestInitialize]
        public void Setup()
        {
            _operations = new Mock<IOperations>();
            _homeController = new HomeController(_operations.Object);
        }

        [TestMethod]
        public void Test_Index_Controller()
        {
            var result = _homeController.Index() as ViewResult;
            //Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomeController_Add_Test()
        {
            var result = _homeController.Add() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
