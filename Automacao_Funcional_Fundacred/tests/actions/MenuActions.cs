using AutomacaoFuncional.tests.steps;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomacaoFuncional.tests.actions
{
    class MenuActions : MenuMap
    {
        ClassUtilities util = new ClassUtilities();

        public void Menu()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ClicarBtMenu()
        {
            bool _result = false;

            try
            {
                Thread.Sleep(2000);
                IWebElement BtMenu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-component-viewer/div/div/component-overview/doc-viewer/div/div[1]/example-viewer/div/div[2]/menu-overview-example/button"));
                util.WaitForElementVisible(BtMenu, 30);
                
                if (BtMenu.Displayed && BtMenu.Enabled)
                {
                    util.ScrollElementoPage(BtMenu);
                    util.ClickJS(BtMenu);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ValidarOpcoesMenu(string opt1, string opt2)
        {
            bool _result = false;

            try
            {
                IWebElement Item1 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/button[1]"));
                IWebElement Item2 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/button[2]"));

                Thread.Sleep(500);
                if (Item1.Text.Contains(opt1) && Item2.Text.Contains(opt2))
                {
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
