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
    public class ComboBoxTestCases
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
        public void LabelTextShouldBeSelected1WhenOption1IsSeleced()
        {
            _store.ClickDropDownsCombosButton();
            _store.ClickDropDownListFromCombo();
            _store.SelectOption1FromDropDownListInDropDownsCombos();
            _store.ClickUpdateButtonInDropDownsCombos();
            
            Assert.AreEqual("Selected 1", _store.GetTextOfLabelOfDropDownsCombos);
        }
        [Test]
        public void LabelTextShouldBeSelected2WhenOption2IsSeleced()
        {
            _store.ClickDropDownsCombosButton();
            _store.ClickDropDownListFromCombo();
            _store.SelectOption2FromDropDownListInDropDownsCombos();
            _store.ClickUpdateButtonInDropDownsCombos();

            Assert.AreEqual("Selected 2", _store.GetTextOfLabelOfDropDownsCombos);
        }
        [Test]
        public void LabelTextShouldBeSelected3WhenOption3IsSeleced()
        {
            _store.ClickDropDownsCombosButton();
            _store.ClickDropDownListFromCombo();
            _store.SelectOption3FromDropDownListInDropDownsCombos();
            _store.ClickUpdateButtonInDropDownsCombos();

            Assert.AreEqual("Selected 3", _store.GetTextOfLabelOfDropDownsCombos);
        }
    }
}
