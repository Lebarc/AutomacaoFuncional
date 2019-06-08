Feature: AutomacaoFuncional

@mytag
Scenario: 01 Acessar A Aplicação
	Given Acesso o endereço "https://material.angular.io/components/categories"
	Then Aplicação e carregada com sucesso

# Validar funções na opção Form Controls

Scenario: 02 Validar A Visualização Do Calendário
	Given Acesso a opção Form Controls
	And Acesso o submenu "Datepicker"
	When Clico no ícone do calendário
	Then Deve apresentar o calendário


Scenario: 03 Validar Informação De Email inválido
	Given Acesso a opção Form Controls
	And Acesso o submenu "Input"
	When Informo o email "error@"
	Then Deve apresentar a mensagem informando email incorreto


Scenario: 04 Validar A Função Select
	Given Acesso a opção Form Controls
	And Acesso o submenu "Select"
	When Clico em Select An Option
	And Seleciono a opção "Option 3"
	Then Deve apresentar a mensagem informando a seleção de "option3"

# Validar funções na opção Navigation

Scenario: 05 Validar As Opções Apresentadas Ao Clicar No Botão Menu
	Given Acesso a opção Navigation
	And Acesso o submenu "Menu"
	When Clico em menu
	Then Deve apresentar as opções "Item 1" e "Item 2"
