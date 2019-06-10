using TechTalk.SpecFlow;
using NUnit.Framework;
using AutomacaoFuncional.tests.actions;
using AutomacaoFuncional.tests.utils;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class FormControlsSteps
    {
        FormControlsActions pageAction = new FormControlsActions();

        [When(@"Clico no ícone do calendário")]
        public void WhenClicoNoIconeDoCalendario()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ClicarCalendario();
        }

        [Then(@"Deve apresentar o calendário")]
        public void ThenDeveApresentarOCalendario()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ValidarCalendario();
        }

        [When(@"Informo o email ""(.*)""")]
        public void WhenInformoOEmail(string p0)
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.InserirEmail(p0);
        }

        [Then(@"Deve apresentar a mensagem informando email incorreto")]
        public void ThenDeveApresentarAMensagemInformandoEmailIncorreto()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ValidarMsgEmailIncorreto();
        }

        [When(@"Clico em Select An Option")]
        public void WhenClicoEmSelectAnOption()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ClicarSelectAnOption();
        }

        [When(@"Seleciono a opção ""(.*)""")]
        public void WhenSelecionoAOpcao(string p0)
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.SelecionarOpcao(p0);
        }

        [Then(@"Deve apresentar a mensagem informando a seleção de ""(.*)""")]
        public void ThenDeveApresentarAMensagemInformandoASelecaoDe(string p0)
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ValidarOpcaoSelecionada(p0);
        }


    }
}
