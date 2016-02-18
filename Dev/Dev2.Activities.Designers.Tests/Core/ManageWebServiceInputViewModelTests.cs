﻿using System.Collections.Generic;
using Dev2.Activities.Designers.Tests.WebGetTool;
using Dev2.Activities.Designers2.Core;
using Dev2.Activities.Designers2.Web_Service_Get;
using Dev2.Common.Interfaces;
using Dev2.Common.Interfaces.DB;
using Dev2.Studio.Core.Activities.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warewolf.Core;

namespace Dev2.Activities.Designers.Tests.Core
{
    [TestClass]
    public class ManageWebServiceInputViewModelTests
    {
        [TestMethod]
        [Owner("Leon Rajindrapersadh")]
        [TestCategory("OutputsRegion_Ctor")]
        public void ManageWebServiceInputViewModel_Ctor()
        {
            var mod = new MyWebModel();
            var act = new DsfWebGetActivity()
            {
                SourceId = mod.Sources[0].Id,
                Outputs = new List<IServiceOutputMapping> { new ServiceOutputMapping("a", "b", "c"), new ServiceOutputMapping("d", "e", "f") },
                Headers = new List<INameValue> { new NameValue("a", "x") },
                QueryString = "Bob the builder",
                ServiceName = "dsfBob"
            };

            var webget = new WebServiceGetViewModel(ModelItemUtils.CreateModelItem(act), mod);

            ManageWebServiceInputViewModel vm = new ManageWebServiceInputViewModel(webget, mod);
            Assert.IsNotNull(vm.CloseCommand);
            Assert.IsNotNull(vm.PasteResponseCommand);
            Assert.IsNotNull(vm.CloseCommand);

            //------------Assert Results-------------------------
        }

        [TestMethod]
        [Owner("Leon Rajindrapersadh")]
        [TestCategory("OutputsRegion_Ctor")]
        public void ManageWebServiceInputViewModel_TestAction()
        {
            bool called = false;
            bool calledOk = false;

            var mod = new MyWebModel();
            var act = new DsfWebGetActivity()
            {
                SourceId = mod.Sources[0].Id,
                Outputs = new List<IServiceOutputMapping> { new ServiceOutputMapping("a", "b", "c"), new ServiceOutputMapping("d", "e", "f") },
                Headers = new List<INameValue> { new NameValue("a", "x") },
                QueryString = "Bob the builder",
                ServiceName = "dsfBob"
            };

            var webget = new WebServiceGetViewModel(ModelItemUtils.CreateModelItem(act), mod);

            ManageWebServiceInputViewModel vm = new ManageWebServiceInputViewModel(webget, mod);
            vm.TestAction = () => { called = true; };
            vm.OkAction = () =>
            {
                calledOk = true;
            };
            vm.TestAction();
            vm.OkAction();

            //------------Assert Results-------------------------

            Assert.IsTrue(called);
            Assert.IsTrue(calledOk);
        }

        [TestMethod]
        [Owner("Leon Rajindrapersadh")]
        [TestCategory("OutputsRegion_Ctor")]
        public void ManageWebServiceInputViewModel_Properties()
        {
            var mod = new MyWebModel();
            var act = new DsfWebGetActivity()
            {
                SourceId = mod.Sources[0].Id,
                Outputs = new List<IServiceOutputMapping> { new ServiceOutputMapping("a", "b", "c"), new ServiceOutputMapping("d", "e", "f") },
                Headers = new List<INameValue> { new NameValue("a", "x") },
                QueryString = "Bob the builder",
                ServiceName = "dsfBob"
            };

            var webget = new WebServiceGetViewModel(ModelItemUtils.CreateModelItem(act), mod);

            ManageWebServiceInputViewModel vm = new ManageWebServiceInputViewModel(webget, mod);
            var lst = new List<IServiceInput>();
            vm.InputArea.Inputs = lst;
            Assert.AreEqual(lst, vm.InputArea.Inputs);
            var lsto = new List<IServiceOutputMapping>();
            vm.OutputArea.Outputs = lsto;
            Assert.AreEqual(lsto, vm.OutputArea.Outputs);
            vm.TestResults = "bob";
            Assert.AreEqual("bob", vm.TestResults);
            vm.TestResultsAvailable = true;
            Assert.IsTrue(vm.TestResultsAvailable);
            vm.OkSelected = true;
            Assert.IsTrue(vm.OkSelected);
            vm.IsTestResultsEmptyRows = true;
            Assert.IsTrue(vm.IsTestResultsEmptyRows);
            vm.IsTesting = true;
            Assert.IsTrue(vm.IsTesting);
            vm.PasteResponseVisible = true;
            Assert.IsTrue(vm.PasteResponseVisible);
            vm.PasteResponseAvailable = true;
            Assert.IsTrue(vm.PasteResponseAvailable);
            var b = new WebServiceDefinition() { Headers = new List<NameValue>() { new NameValue("a", "b") } };
            vm.Model = b;
            Assert.IsNotNull(vm.Model);
        }
    }
}