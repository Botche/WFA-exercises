using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BodyMassCalculator.Database;
using BodyMassCalculator.Database.Models;
using BodyMassCalculator.Helpers;

using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BodyMassCalculator
{
	public partial class LoginForm : Form
	{
		private readonly BodyMassCalculatorDbContext dbContext;

		public LoginForm(BodyMassCalculatorDbContext dbContext)
		{
			InitializeComponent();
			this.dbContext = dbContext;
		}

		protected async override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			await this.dbContext.DisposeAsync();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			string username = this.UsernameTextBox.Text;
			string password = this.PasswordTextBox.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Please, fill all inputs!");

				return;
			}

			User user = dbContext.Users
				.SingleOrDefault(u => u.Username == username);
			string hashedPassword = PasswordManager.HashPassword(password, user.Salt);

			if (hashedPassword != user.PasswordHash)
			{
				MessageBox.Show("Incorrect credentials!");

				return;
			}

			CalculatorFrom calculatorForm = new CalculatorFrom(dbContext);
			calculatorForm.Show();
			Hide();
		}

		private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegisterForm registerForm = new RegisterForm(dbContext);
			registerForm.Show();
			Hide();
		}
	}
}
