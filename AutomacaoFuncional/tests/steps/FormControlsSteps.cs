using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class FormControlsSteps
    {
        FormControlsActions pageAction = new FormControlsActions();

        [When(@"Clico no ícone do calendário")]
        public void WhenClicoNoIconeDoCalendario()
        {
            bool result = pageAction.ClicarCalendario();

            Assert.True(result, "Erro ao clicar no calendário");
        }

        [Then(@"Deve apresentar o calendário")]
        public void ThenDeveApresentarOCalendario()
        {
            bool result = pageAction.ValidarCalendario();

            Assert.True(result, "Erro ao apresentar o calendário");
        }

        [When(@"Informo o email ""(.*)""")]
        public void WhenInformoOEmail(string p0)
        {
            bool result = pageAction.InserirEmail(p0);

            Assert.True(result, "Erro ao inserir o email");
        }

        [Then(@"Deve apresentar a mensagem informando email incorreto")]
        public void ThenDeveApresentarAMensagemInformandoEmailIncorreto()
        {
            bool result = pageAction.ValidarMsgEmailIncorreto();

            Assert.True(result, "Erro ao validar e apresentar a ensagem informando email inválido");
        }

        [When(@"Clico em Select An Option")]
        public void WhenClicoEmSelectAnOption()
        {
            bool result = pageAction.ClicarSelectAnOption();

            Assert.True(result, "Erro ao clicar no campo select an option");
        }

        [When(@"Seleciono a opção ""(.*)""")]
        public void WhenSelecionoAOpcao(string p0)
        {
            bool result = pageAction.SelecionarOpcao(p0);

            Assert.True(result, "Erro ao selecionar a opção " +p0);
        }

        [Then(@"Deve apresentar a mensagem informando a seleção de ""(.*)""")]
        public void ThenDeveApresentarAMensagemInformandoASelecaoDe(string p0)
        {
            bool result = pageAction.ValidarOpcaoSelecionada(p0);

            Assert.True(result, "Erro ao apresentar a mensagem informando a opção " + p0 + " Selecionada");
        }


    }
}
