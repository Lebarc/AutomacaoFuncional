using AutomacaoFuncional.tests.steps;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomacaoFuncional.tests.actions
{
    class NavegarActions : NavegarMap
    {
        ClassUtilities util = new ClassUtilities();

        public void Navegar()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AcessarOpcaoFormControls()
        {
            bool _result = false;

            try
            {
                IWebElement Home = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-navbar/nav[1]/a[2]"));
                
                Thread.Sleep(500);
                if (Home.Displayed && Home.Enabled)
                {
                    Home.Click();

                    IWebElement OptFormControls = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-component-category-list/div[2]/a[1]/mat-card"));
                    util.WaitForElementVisible(OptFormControls, 30);

                    if (OptFormControls.Displayed && OptFormControls.Enabled)
                    {
                        OptFormControls.Click();
                        _result = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }


        internal bool AcessarDatepicker()
        {
            bool _result = false;

            try
            {
                IWebElement OptDatepicker = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-components/div/a[3]/mat-card/mat-card-header"));
                util.WaitForElementVisible(OptDatepicker, 30);

                Thread.Sleep(500);
                if (OptDatepicker.Displayed && OptDatepicker.Enabled)
                {
                    OptDatepicker.Click();
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }


        internal bool AcessarInput()
        {
            bool _result = false;

            try
            {
                IWebElement OptInput = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-components/div/a[5]/mat-card/mat-card-header"));
                util.WaitForElementVisible(OptInput, 30);

                Thread.Sleep(500);
                if (OptInput.Displayed && OptInput.Enabled)
                {
                    OptInput.Click();
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }


        public bool AcessarNavigation()
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1000);
                IWebElement Home = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-navbar/nav[1]/a[2]"));

                Thread.Sleep(500);
                if (Home.Displayed && Home.Enabled)
                {
                    Home.Click();

                    Thread.Sleep(1000);
                    IWebElement OptNavigation = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-component-category-list/div[2]/a[2]/mat-card"));
                    util.WaitForElementVisible(OptNavigation, 30);

                    Thread.Sleep(500);
                    if (OptNavigation.Displayed && OptNavigation.Enabled)
                    {
                        OptNavigation.Click();
                        _result = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }


        public bool AcessarOpcaoMenu()
        {
            bool _result = false;

            try
            {
                IWebElement OptMenu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-components/div/a[1]/mat-card/mat-card-content"));
                util.WaitForElementVisible(OptMenu, 30);

                Thread.Sleep(500);
                if (OptMenu.Displayed && OptMenu.Enabled)
                {
                    OptMenu.Click();
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }


        public bool AcessarSubmenu(string SubMenu)
        {
            bool _result = false;

            try
            {
                IWebElement OptSelect = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='docs-component-list-category']//a//mat-card//div/mat-card-title[contains(text(),'"+SubMenu+"')]"));
                util.WaitForElementVisible(OptSelect, 30);

                Thread.Sleep(500);
                if (OptSelect.Displayed && OptSelect.Enabled)
                {
                    OptSelect.Click();
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }
    }
}