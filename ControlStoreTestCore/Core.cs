using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ControlStoreTestCore
{
    public class Core
    {
        private ChromeDriver _driver;
        private string _controlStorePath = "file:///c:/controlstore/controlstore.html";
        #region CheckBoxes 
        private By _CheckboxesButton = By.XPath("/html/body/nav/ul/li[1]/button");
        private By _checkbox1 = By.Id("checkbox1");
        private By _checkbox2 = By.Id("checkbox2");
        private By _checkbox3 = By.Id("checkbox3");
        private By _checkboxUpdateButton = By.XPath("//*[@id=\"checkboxesArticle\"]/section/ul/li[4]/button");
        private By _checkboxLabel = By.Id("checkboxLabel");

        public void ClickShowCheckboxButton()
        {
            _driver.FindElement(_CheckboxesButton).Click();
            
        }
        public void ClickCheckbox1()
        {
            _driver.FindElement(_checkbox1).Click();
        }
        public void ClickCheckbox2()
        {
            _driver.FindElement(_checkbox2).Click();
        }
        public void ClickCheckbox3()
        {
            _driver.FindElement(_checkbox3).Click();
        }
        public void ClickUpdateCheckboxButton()
        {
            _driver.FindElement(_checkboxUpdateButton).Click();
        }
        public string CheckboxesText
        {
            get
            {
                return _driver.FindElement(_checkboxLabel).Text;
            }
        }
        #endregion
        #region RadioButtons
        private By _RadioButtonsButton = By.XPath("/html/body/nav/ul/li[2]/button");
        private By _Radio1InRadioButtons = By.Id("radio1");
        private By _Radio2InRadioButtons = By.Id("radio2");
        private By _Radio3InRadioButtons = By.Id("radio3");
        private By _UpdateButtonInRadioButtons = By.XPath("//*[@id=\"radioButtonsArticle\"]/section/ul/li[4]/button");
        private By _LabelOfRadioButtons = By.Id("radio123Label");
        public void ClickRadioButtonsButton()
        {
            _driver.FindElement(_RadioButtonsButton).Click();
        }
        public void SelectRadio1Button()
        {
            _driver.FindElement(_Radio1InRadioButtons).Click();
        }
        public void SelectRadio2Button()
        {
            _driver.FindElement(_Radio2InRadioButtons).Click();
        }
        public void SelectRadio3Button()
        {
            _driver.FindElement(_Radio3InRadioButtons).Click();
        }
        public void ClickTheUpdateButtonInRadioButtons()
        {
            _driver.FindElement(_UpdateButtonInRadioButtons).Click();
        }
        public string GetLabelTextOfRadioButtons
        {
            get { return _driver.FindElement(_LabelOfRadioButtons).Text; }
        }

        #endregion
        #region DropDown
        private By _DropDownsCombosButton = By.XPath("/html/body/nav/ul/li[3]/button");
        private By _Option1FromDropDownsCombos = By.XPath("//*[@id=\"combo1\"]/option[2]");
        private By _Option2FromDropDownsCombos = By.XPath("//*[@id=\"combo1\"]/option[3]");
        private By _Option3FromDropDownsCombos = By.XPath("//*[@id=\"combo1\"]/option[4]");
        private By _UpdateButtonInDropDownsCombos = By.XPath("//*[@id=\"dropdownArticle\"]/section/ul/li[2]/button");
        private By _LabelOfDropDownsCombos = By.Id("comboLabel");
        private By _DDLFromDropDownsCombos = By.Id("combo1");
        
        public void ClickDropDownListFromCombo()
        {
            _driver.FindElement(_DDLFromDropDownsCombos).Click();
        }
        public void ClickDropDownsCombosButton()
        {
            _driver.FindElement(_DropDownsCombosButton).Click();
        }
        public void SelectOption1FromDropDownListInDropDownsCombos()
        {
            _driver.FindElement(_Option1FromDropDownsCombos).Click();
        }
        public void SelectOption2FromDropDownListInDropDownsCombos()
        {
            _driver.FindElement(_Option2FromDropDownsCombos).Click();
        }
        public void SelectOption3FromDropDownListInDropDownsCombos()
        {
            _driver.FindElement(_Option3FromDropDownsCombos).Click();
        }
        public void ClickUpdateButtonInDropDownsCombos()
        {
            _driver.FindElement(_UpdateButtonInDropDownsCombos).Click();
        }
        
        public string GetTextOfLabelOfDropDownsCombos
        {
            get
            {
                return _driver.FindElement(_LabelOfDropDownsCombos).Text;
            }
        }

        #endregion
        #region OpenAndClose
        public void Open()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(_controlStorePath);
        }
        public void Quit()
        {
            _driver.Quit();
        }
        #endregion
    }
}
