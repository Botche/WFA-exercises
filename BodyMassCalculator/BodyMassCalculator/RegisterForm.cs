using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BodyMassCalculator.Database;
using BodyMassCalculator.Database.Models;
using BodyMassCalculator.Helpers;

using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BodyMassCalculator
{
	public partial class RegisterForm : Form
	{
		private readonly BodyMassCalculatorDbContext dbContext;

		public RegisterForm(BodyMassCalculatorDbContext dbContext)
		{
			InitializeComponent();
			this.dbContext = dbContext;
		}

		protected async override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			await this.dbContext.DisposeAsync();
			this.Close();
		}

		private async void RegisterButton_Click(object sender, EventArgs e)
		{
			string username = this.UsernameTextBox.Text;
			string password = this.PasswordTextBox.Text;
			string repeatPassword = this.RepeatPasswordTextBox.Text;

			if (string.IsNullOrWhiteSpace(username)
				|| string.IsNullOrWhiteSpace(password)
				|| string.IsNullOrWhiteSpace(repeatPassword))
			{
				MessageBox.Show("Please, fill all inputs!");

				return;
			}

			if (password != repeatPassword)
			{
				MessageBox.Show("Passwords must match!");

				return;
			}

			bool isUserExist = dbContext.Users
				.Any(u => u.Username == username);

			if (isUserExist)
			{
				MessageBox.Show("Username is already taken!");

				return;
			}

			string salt = PasswordManager.GenerateSalt();
			string hashedPassword = PasswordManager.HashPassword(password, salt);

			User user = new User()
			{
				Username = username,
				PasswordHash = hashedPassword,
				Salt = salt,
				GenderId = 3,
			};

			await this.dbContext.Users.AddAsync(user);
			await this.dbContext.SaveChangesAsync();

			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			Hide();
		}

		private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			Hide();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{
			this.PasswordTextBox.PasswordChar = '*';
			this.RepeatPasswordTextBox.PasswordChar = '*';
		}
	}
}
