﻿using System;
using BA.MultiMVC.Framework.Core.MultiMVC.Sample.Controllers;

using BA.MultiMVC.Framework.Core.MultiMVC.Test.Util.Stubs;
using BA.MultiMVC.Framework.Core;
using BA.MultiMVC.Sample.Extensions.Contoso.Controllers;
using NUnit.Framework;

namespace BA.MultiTenantMVC.Framework.UnitTests.Core
{
    /// <summary>
    /// Summary description for SaasMVCFactory
    /// </summary>
    [TestFixture]
    public class ExtensionControllerFactoryTest
    {
        [TestFixtureSetUp]
        public void Initialize()
        {
            BootstrapperForTest.ConfigureStructureMap(Configuration.ExtensionPath);
        }

        [Test]
        public void GetControllerInstance_ForHomeControllerAndDefaultTenant_ControllerIsInstanceOfTypeHomeController()
        {
            var result = ExtensionControllerFactoryCreateInstance(typeof(HomeController), "Default");
            
            //Assert
            Assert.IsInstanceOfType(typeof(HomeController),result);

        }

        [Test]
        public void GetControllerInstance_ForHomeControllerAndContosoTenant_ControllerIsInstanceOfTypeContosoHomeController()
        {
            var result = ExtensionControllerFactoryCreateInstance(typeof(HomeController), "Contoso");
            
            //Assert
            Assert.AreEqual(typeof(ContosoHomeController).FullName, result.GetType().FullName);
        }

        [Test]
        public void GetControllerInstance_ForHomeControllerAndContosoTenant_TenantKeyIsContoso()
        {
            var result = ExtensionControllerFactoryCreateInstance(typeof(HomeController), "contoso");

            //Assert
            Assert.AreEqual("Contoso", ((BaseController)result).TenantContext.TenantKey);
        }

        [Test]
        public void GetControllerInstance_ForHomeControllerAndDefaultTenant_TenantContextIsNotNull()
        {
            var result = ExtensionControllerFactoryCreateInstance(typeof(HomeController), "Default");

            //Assert
            Assert.IsNotNull(((BaseController)result).TenantContext);

        }

        [Test]
        public void GetControllerInstance_ForHomeControllerAndDefaultTenant_RessourcesIsNotNull()
        {
            var result = ExtensionControllerFactoryCreateInstance(typeof(HomeController), "Default");

            //Assert
            Assert.IsNotNull(((BaseController)result).Ressources);

        }

        private static System.Web.Mvc.IController ExtensionControllerFactoryCreateInstance(Type controllerType, string tenantKey)
        {
            //Arrange
            var subject = new ExtensionControllerFactoryForTest();
            subject.TenantKey = tenantKey;

            //Act
            var result = subject.GetControllerInstanceInvoker(controllerType);
            return result;
        }
        
    }
}