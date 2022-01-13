using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTests
{
	public class LoginViewModel : BindableObject //BaseViewModel
	{
		//private fields
		private string _username;
		private string _password;

		public string Username
		{
			get { return _username; }
			set { _username = value; OnPropertyChanged(); }
		}
		public string Password
		{
			get { return _password; }
			set { _password = value; OnPropertyChanged(); }
		}

		//Commands
		public Command LoginCommand { get; set; }
		public Command RegisterCommand { get; set; }
		public Command ForgotPassword { get; set; }

		public LoginViewModel()
		{
			System.Console.WriteLine("INSIDE LOGIN VIEWMODEL");
			LoginCommand = new Command(UserLogin);
			RegisterCommand = new Command(NewUser);
			ForgotPassword = new Command(ResetPassword);
		}

		private void ResetPassword(object obj)
		{
			throw new NotImplementedException();
		}

		private void NewUser(object obj)
		{
			throw new NotImplementedException();
		}

		public async void UserLogin(object obj)
		{
			throw new NotImplementedException();
		}
	}
}
