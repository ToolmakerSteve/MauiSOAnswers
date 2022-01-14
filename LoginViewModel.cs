using Microsoft.Maui.Controls;
using System.Diagnostics;
using System.Windows.Input;

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
		public ICommand LoginCommand { get; set; }
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotPassword { get; set; }

		public LoginViewModel()
		{
			Debug.WriteLine("\n--- LoginViewModel ---\n");

			LoginCommand = new Command(UserLogin);
			RegisterCommand = new Command(NewUser);
			ForgotPassword = new Command(ResetPassword);
		}

		public async void UserLogin()
		{
			Debug.WriteLine("\n--- UserLogin ---\n");
		}

		private void ResetPassword()
		{
			Debug.WriteLine("\n--- ResetPassword ---\n");
		}

		private void NewUser()
		{
			Debug.WriteLine("\n--- NewUser ---\n");
		}
	}
}
