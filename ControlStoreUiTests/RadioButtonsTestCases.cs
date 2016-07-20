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
    class RadioButtonsTestCases
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
            //Thread.Sleep(2000);
            _store.Quit();
        }
        [Test]
        public void RB_LabelTextShouldBeSeleced1When_Radio1Selected()
        {
            _store.ClickRadioButtonsButton();
            _store.SelectRadio1Button();
            _store.ClickTheUpdateButtonInRadioButtons();
            string actual = _store.GetLabelTextOfRadioButtons;
            Assert.AreEqual("Selected 1", actual);
        }
        [Test]
        public void RB_LabelTextShouldBeSeleced2When_Radio2Selected()
        {
            _store.ClickRadioButtonsButton();
            _store.SelectRadio2Button();
            _store.ClickTheUpdateButtonInRadioButtons();
            string actual = _store.GetLabelTextOfRadioButtons;
            Assert.AreEqual("Selected 2", actual);
        }
        [Test]
        public void RB_LabelTextShouldBeSeleced3When_Radio3Selected()
        {
            _store.ClickRadioButtonsButton();
            _store.SelectRadio3Button();
            _store.ClickTheUpdateButtonInRadioButtons();
            string actual = _store.GetLabelTextOfRadioButtons;
            Assert.AreEqual("Selected 3", actual);
        }
    }
}
