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
    public class CheckBoxTestCases
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
           // Thread.Sleep(2000);
            _store.Quit();
        }

        [Test]
        public void LabelTextShouldBeChecked13WhenCheckingBox1And3()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox1();
            _store.ClickCheckbox3();
            _store.ClickUpdateCheckboxButton();
           
            Assert.AreEqual("Checked 13", _store.CheckboxesText);
        }
        [Test]
        public void LabelTextShouldBeChecked12WhenCheckingBox1And2()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox1();
            _store.ClickCheckbox2();
            _store.ClickUpdateCheckboxButton();

            Assert.AreEqual("Checked 12", _store.CheckboxesText);
        }
        [Test]
        public void LabelTextShouldBeChecked23WhenCheckingBox2And3()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox2();
            _store.ClickCheckbox3();
            _store.ClickUpdateCheckboxButton();

            Assert.AreEqual("Checked 23", _store.CheckboxesText);
        }
        [Test]
        public void LabelTextShouldBeChecked1WhenCheckingBox1()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox1();
            _store.ClickUpdateCheckboxButton();
            Assert.AreEqual("Checked 1", _store.CheckboxesText);
        }
        [Test]
        public void LabelTextShouldBeChecked2WhenCheckingBox2()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox2();
            _store.ClickUpdateCheckboxButton();
            Assert.AreEqual("Checked 2", _store.CheckboxesText);
        }
        [Test]
        public void LabelTextShouldBeChecked3WhenCheckingBox3()
        {
            _store.ClickShowCheckboxButton();
            _store.ClickCheckbox3();
            _store.ClickUpdateCheckboxButton();
            Assert.AreEqual("Checked 3", _store.CheckboxesText);
        }
    }
}
