using System;
using Microsoft.UI.Xaml;

namespace BindRadioButtonsToEnumsPart4.Wasm
{
	public class Program
	{
		private static App _app;

		static int Main(string[] args)
		{
			Microsoft.UI.Xaml.Application.Start(_ => _app = new App());

			return 0;
		}
	}
}
