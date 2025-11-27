# language: pt-BR
Funcionalidade: Bloco de Notas com Appium.Windows
  Cenario: Digitar texto com sucesso
	Dado que o Bloco de Notas está aberto (Appium)
	Quando eu digito o texto "Olá Appium Windows"
	Então o conteúdo deve conter "Olá Appium Windows"