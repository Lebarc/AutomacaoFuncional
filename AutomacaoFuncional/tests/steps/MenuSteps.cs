using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;
using AutomacaoFuncional.tests.utils;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class MenuSteps
    {
        MenuActions pageAction = new MenuActions();

        [When(@"Clico em menu")]
        public void WhenClicoEmMenu()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ClicarBtMenu();
        }

        [Then(@"Deve apresentar as opções ""(.*)"" e ""(.*)""")]
        public void ThenDeveApresentarAsOpcoesE(string p0, string p1)
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ValidarOpcoesMenu(p0, p1);
        }

    }
}
