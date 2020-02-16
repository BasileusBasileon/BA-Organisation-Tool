using BA_Organisation_Tool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BA_Organisation_Tool.Controls
{
	public sealed partial class RunGrid : UserControl
	{
		private BARun _run;
		public BARun Run
		{
			get => _run; set
			{
				_run = value;
				OnRunChanged();
			}
		}

		private List<(Person, PersonRunInformation)> _magia1;
		private List<(Person, PersonRunInformation)> _magia2;
		private List<(Person, PersonRunInformation)> _magia3;
		private List<(Person, PersonRunInformation)> _logos1;
		private List<(Person, PersonRunInformation)> _logos2;
		private List<(Person, PersonRunInformation)> _logos3;
		private List<(Person, PersonRunInformation)> _support;

		private void OnRunChanged()
		{
			foreach (KeyValuePair<Person, PersonRunInformation> kvp in _run.People)
			{
				switch (kvp.Value.Group)
				{
					case GroupEnum.Magia1:

						break;
					case GroupEnum.Magia2:

						break;
					case GroupEnum.Magia3:

						break;
					case GroupEnum.Logos1:

						break;
					case GroupEnum.Logos2:

						break;
					case GroupEnum.Logos3:

						break;
					case GroupEnum.Support:

						break;
				}
			}
		}

		public RunGrid()
		{
			this.InitializeComponent();
		}
	}
}
