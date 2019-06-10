using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;
using AutomacaoFuncional.tests.utils;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class NavegarSteps
    {
        NavegarActions pageAction = new NavegarActions();

        [Given(@"Acesso a opção Navigation")]
        public void GivenAcessoAOpcao()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.AcessarNavigation();
        }

        [Given(@"Acesso a opção Menu")]
        public void GivenAcessoAOpcaoMenu()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.AcessarOpcaoMenu();
        }

        [Given(@"Acesso a opção Form Controls")]
        public void GivenAcessoAOpcaoFormControls()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.AcessarOpcaoFormControls();
        }

        [Given(@"Acesso o submenu ""(.*)""")]
        public void GivenAcessoOSubmenu(string p0)
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.AcessarSubmenu(p0);
        }
    }
}
