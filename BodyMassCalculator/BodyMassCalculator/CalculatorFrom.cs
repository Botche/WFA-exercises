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

namespace BodyMassCalculator
{
	public partial class CalculatorFrom : Form
	{
		private readonly BodyMassCalculatorDbContext dbContext;

		public CalculatorFrom(BodyMassCalculatorDbContext dbContext)
		{
			InitializeComponent();
			this.dbContext = dbContext;
		}

		private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			Hide();
		}
	}
}
