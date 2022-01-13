using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace MauiTests
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
			BindingContext = new LoginViewModel();
		}
	}
}