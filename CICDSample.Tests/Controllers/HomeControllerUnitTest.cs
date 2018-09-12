using System;
using CICDSample.Controllers;
using BAL;
using Moq;
using System.Web.Mvc;
using NUnit.Framework;

namespace CICDSample.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerUnitTest
    {
        private Mock<IOperations> _operations;
        private HomeController _homeController;

        [SetUp]
        public void Setup()
        {
            _operations = new Mock<IOperations>();
            _homeController = new HomeController(_operations.Object);
        }

        [Test]
        public void Test_Index_Controller()
        {
            var result = _homeController.Index() as ViewResult;
            //Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeController_Add_Test()
        {
            var result = _homeController.Add() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
