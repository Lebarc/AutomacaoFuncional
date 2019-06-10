using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.utils;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class AcessarSteps
    {
        AcessPageActions pageActions = new AcessPageActions();

        [Given(@"Acesso o endereço ""(.*)""")]
        public void GivenAcessoOEndereco(string url)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.AcessarAplicacao(url);
        }

        [Then(@"Aplicação e carregada com sucesso")]
        public void ThenAplicacaoECarregadaComSucesso()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidarCarregamento();
        }
    }
}
