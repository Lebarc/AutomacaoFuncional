using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace AutomacaoFuncional.tests.steps
{
    class AcessPageActions : AccessElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public void AccessPage()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AcessarAplicacao(string url)
        {
            bool _result = false;
            try
            {
                ClassDriver.GetInstance().Driver.Navigate().GoToUrl(url);
                _result = true;
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Erro ao validar!";
            }
            return _result;
        }

        public bool ValidarCarregamento()
        {
            bool _result = false;
            try
            {
                IWebElement LogoHome = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/component-page-header/div/h1"));
                util.WaitForElementVisible(LogoHome, 60);
                if (LogoHome.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Erro ao acessar a aplicação!";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Erro ao validar!";
            }
            return _result;
        }
    }
}
