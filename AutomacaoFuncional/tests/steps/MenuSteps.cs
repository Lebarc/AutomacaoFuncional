using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class MenuSteps
    {
        MenuActions pageAction = new MenuActions();

        [When(@"Clico em menu")]
        public void WhenClicoEmMenu()
        {
            bool result = pageAction.ClicarBtMenu();

            Assert.True(result, "Erro ao clicar no botão menu");
        }

        [Then(@"Deve apresentar as opções ""(.*)"" e ""(.*)""")]
        public void ThenDeveApresentarAsOpcoesE(string p0, string p1)
        {
            bool result = pageAction.ValidarOpcoesMenu(p0, p1);

            Assert.True(result, "Erro ao Apresentar as opções do menu");
        }

    }
}
