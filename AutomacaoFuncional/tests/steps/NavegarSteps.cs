using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class NavegarSteps
    {
        NavegarActions pageAction = new NavegarActions();

        [Given(@"Acesso a opção Navigation")]
        public void GivenAcessoAOpcao()
        {
            bool result = pageAction.AcessarNavigation();

            Assert.True(result, "Erro ao acessar a opção Navigation");
        }

        [Given(@"Acesso a opção Menu")]
        public void GivenAcessoAOpcaoMenu()
        {
            bool result = pageAction.AcessarOpcaoMenu();

            Assert.True(result, "Erro ao acessar opção Menu");
        }

        [Given(@"Acesso a opção Form Controls")]
        public void GivenAcessoAOpcaoFormControls()
        {
            bool result = pageAction.AcessarOpcaoFormControls();

            Assert.True(result, "Erro ao acessar opção Form Controls");
        }

        [Given(@"Acesso o submenu ""(.*)""")]
        public void GivenAcessoOSubmenu(string p0)
        {
            bool result = pageAction.AcessarSubmenu(p0);

            Assert.True(result, "Erro ao acessar o SubMenu "+ p0);
        }
    }
}
