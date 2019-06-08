using TechTalk.SpecFlow;
using NUnit.Framework;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class AcessarSteps
    {
        AcessPageActions pageActions = new AcessPageActions();

        [Given(@"Acesso o endereço ""(.*)""")]
        public void GivenAcessoOEndereco(string url)
        {
            var result = pageActions.AcessarAplicacao(url);

            Assert.True(result, "Erro ao acessar a URL -> " + url);
        }

        [Then(@"Aplicação e carregada com sucesso")]
        public void ThenAplicacaoECarregadaComSucesso()
        {
            var result = pageActions.ValidarCarregamento();

            Assert.True(result, "Erro ao acessar a endereço solicitado");
        }
    }
}
