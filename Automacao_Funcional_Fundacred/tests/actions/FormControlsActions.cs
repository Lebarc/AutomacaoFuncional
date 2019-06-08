using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace AutomacaoFuncional.tests.steps
{
    class FormControlsActions : FormControlsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public void FormControls()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ClicarCalendario()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(3000);
                IWebElement IconCalendar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-component-viewer/div/div/component-overview/doc-viewer/div/div[1]/example-viewer/div/div[2]/datepicker-overview-example/mat-form-field/div/div[1]/div[2]/mat-datepicker-toggle/button"));
                util.WaitForElementVisible(IconCalendar, 30);

                if (IconCalendar.Displayed && IconCalendar.Enabled)
                {
                    IconCalendar.Click();
                    Thread.Sleep(1000);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ValidarCalendario()
        {
            bool _result = false;

            try
            {
                IWebElement ValidarCalendario = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='mat-datepicker-0']"));
                util.WaitForElementVisible(ValidarCalendario, 30);

                Thread.Sleep(500);
                if (ValidarCalendario.Displayed)
                {
                    _result = true;
                    ValidarCalendario.Click();
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool SelecionarOpcao(string Option)
        {
            bool _result = false;
            try
            {
                Thread.Sleep(500);
                IWebElement SelectOption = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@class='cdk-overlay-pane']//mat-option/span[contains(text(),'"+ Option + "')]"));
                util.WaitForElementVisible(SelectOption, 30);

                if (SelectOption.Displayed && SelectOption.Enabled)
                {
                    Thread.Sleep(500);
                    util.ClickJS(SelectOption);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ValidarOpcaoSelecionada(string Opcao)
        {
            bool _result = false;
            try
            {
                Thread.Sleep(500);
                IWebElement ValidarMansagem = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/material-docs-app/app-component-sidenav/mat-sidenav-container/mat-sidenav-content/div/div/div/app-component-viewer/div/div/component-overview/doc-viewer/div/div[2]/example-viewer/div/div[2]/select-value-binding-example/p"));
                util.WaitForElementVisible(ValidarMansagem, 30);
                string teste = ValidarMansagem.Text;
                if (ValidarMansagem.Displayed && ValidarMansagem.Text.Contains(Opcao))
                {
                    Thread.Sleep(500);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ClicarSelectAnOption()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(500);
                IWebElement SelectAnOption = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='mat-select-1']/div/div[1]/span"));
                util.WaitForElementVisible(SelectAnOption, 30);

                if (SelectAnOption.Displayed && SelectAnOption.Enabled)
                {
                    Thread.Sleep(500);
                    util.ScrollPage(2);
                    util.ClickJS(SelectAnOption);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool InserirEmail(string email)
        {
            bool _result = false;
            try
            {
                Thread.Sleep(1000);
                IWebElement InputEmail = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='mat-form-field-infix']/input[@placeholder='Email']"));
                util.WaitForElementVisible(InputEmail, 30);

                if (InputEmail.Displayed && InputEmail.Enabled)
                {
                    Thread.Sleep(500);
                    util.ScrollPage(2);
                    InputEmail.SendKeys(email);
                    _result = true;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ValidarMsgEmailIncorreto()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(1000);
                IWebElement ValidarMsgError = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='mat-error-1']"));
                util.WaitForElementVisible(ValidarMsgError, 30);

                if (ValidarMsgError.Displayed && ValidarMsgError.Enabled)
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
