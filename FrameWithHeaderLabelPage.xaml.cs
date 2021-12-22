using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiTests
{
	public partial class FrameWithHeaderLabelPage : ContentPage
	{
		public FrameWithHeaderLabelPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		public string LabelText { get; set; } = "Binding Label Text";
	}
}