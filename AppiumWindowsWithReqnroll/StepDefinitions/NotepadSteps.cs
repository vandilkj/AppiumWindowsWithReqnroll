using System;
using AppiumWindowsWithReqnroll.Drivers;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using Reqnroll;

namespace AppiumWindowsWithReqnroll.StepDefinitions
{
	[Binding]
	public class NotepadSteps : IDisposable
	{
		private WindowsDriver<WindowsElement>? _session;

		[Given("que o Bloco de Notas está aberto \\(Appium)")]
		public void DadoQueOBlocoDeNotasEstaAberto()
		{
			_session = WindowsSessionFactory.CreateNotepadSession();
			_session.Should().NotBeNull();
		}

		[When("eu digito o texto {string}")]
		public void QuandoEuDigitoOTexto(string texto)
		{
			_session.Should().NotBeNull();

			// Geralmente a área de edição é o elemento com ClassName "Edit"
			var editor = _session!.FindElementByClassName("Edit");
			editor.Should().NotBeNull();

			editor.Clear();
			editor.SendKeys(texto);
		}

		[Then("o conteúdo deve conter {string}")]
		public void EntaoOConteudoDeveConter(string textoEsperado)
		{
			var editor = _session!.FindElementByClassName("Edit");
			var textoAtual = editor.Text ?? string.Empty;

			textoAtual.Should().Contain(textoEsperado);
		}

		public void Dispose()
		{
			_session?.Quit();
			_session?.Dispose();
		}
	}
}
