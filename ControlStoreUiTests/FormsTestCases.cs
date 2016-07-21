using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using ControlStoreTestCore;

namespace ControlStoreUiTests
{
    [TestFixture]
    public class FormsTestCases
    {
        Core _store;
        [SetUp]
        public void Setup()
        {
            _store = new Core();
            _store.Open();
        }
        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(2000);
            _store.Quit();
        }
        [Test]
        public void SimulateFillingTheForm()
        {
            _store.ClickFormsButton();
            _store.FillFirstName();
            _store.FillLastName();
            _store.FillEmail();
            _store.FillPassword();
            _store.FillPhone();
            _store.ClickSubmitButtonOnForms();
            Assert.IsNotEmpty(_store.GetLabelTextOfForms);
        }
    }
}
