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

namespace BodyMassCalculator
{
	public partial class CalculatorFrom : Form
	{
		private readonly BodyMassCalculatorDbContext dbContext;
		private readonly int userId;

		public CalculatorFrom(BodyMassCalculatorDbContext dbContext, int userId)
		{
			InitializeComponent();
			this.dbContext = dbContext;
			this.userId = userId;
		}

		protected async override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			await this.dbContext.DisposeAsync();
			this.Close();
		}

		private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			Hide();
		}

		private void CalculatorFrom_Load(object sender, EventArgs e)
		{
			this.DeleteButton.Hide();
			this.CreateStatisticsListView();
			this.UpdateListView();
		}

		private async void AddUpdateButton_Click(object sender, EventArgs e)
		{
			bool isKilogramsValid = double.TryParse(this.KilogramsTextBox.Text, out double kilograms);
			bool isHeightValid = double.TryParse(this.HeightTextBox.Text, out double height);

			if (isHeightValid == false || isKilogramsValid == false)
			{
				return;
			}

			if (this.AddUpdateButton.Text == "Add")
			{
				BodyMassCalculatorStatistic bodyMass = new BodyMassCalculatorStatistic()
				{
					CreatedAt = DateTime.UtcNow,
					Height = height,
					Weight = kilograms,
					UserId = userId,
				};

				await this.dbContext.BodyMassCalculatorStatistics.AddAsync(bodyMass);
				await this.dbContext.SaveChangesAsync();
			}
			else
			{
				ListViewItem item = this.StatisticsListView.SelectedItems[0];
				if (item != null)
				{
					var statistic = this.dbContext.BodyMassCalculatorStatistics
						.Where(bmcs => bmcs.Id == int.Parse(item.SubItems[0].Text))
						.FirstOrDefault();

					statistic.Weight = kilograms;
					statistic.Height = height;

					this.dbContext.BodyMassCalculatorStatistics.Update(statistic);
					await this.dbContext.SaveChangesAsync();

					this.AddUpdateButton.Text = "Add";
					this.DeleteButton.Hide();
				}
			}

			this.KilogramsTextBox.Text = "";
			this.HeightTextBox.Text = "";

			this.UpdateListView();
		}

		private async void DeleteButton_Click(object sender, EventArgs e)
		{
			ListViewItem item = this.StatisticsListView.SelectedItems[0];
			if (item != null)
			{
				var statistic = this.dbContext.BodyMassCalculatorStatistics
					.Where(bmcs => bmcs.Id == int.Parse(item.SubItems[0].Text))
					.FirstOrDefault();

				this.dbContext.BodyMassCalculatorStatistics.Remove(statistic);
				await this.dbContext.SaveChangesAsync();

				this.AddUpdateButton.Text = "Add";
				this.DeleteButton.Hide();

				this.KilogramsTextBox.Text = "";
				this.HeightTextBox.Text = "";

				this.UpdateListView();
			}
		}

		private void UpdateListView()
		{
			this.StatisticsListView.Items.Clear();

			var statistics = this.dbContext.BodyMassCalculatorStatistics
				.Where(bmcs => bmcs.UserId == this.userId)
				.OrderByDescending(bmcs => bmcs.CreatedAt)
				.ToList();

			foreach (var statistic in statistics)
			{
				ListViewItem statisticViewItem = new ListViewItem(statistic.Id.ToString());

				statisticViewItem.SubItems.Add(statistic.CreatedAt.ToString());
				statisticViewItem.SubItems.Add(statistic.Weight.ToString());
				statisticViewItem.SubItems.Add(statistic.Height.ToString());

				double bmi = Math.Round(statistic.Weight / Math.Pow(statistic.Height / 100, 2), 2);
				statisticViewItem.SubItems.Add(bmi.ToString());

				this.StatisticsListView.Items.Add(statisticViewItem);
			}
		}

		private void CreateStatisticsListView()
		{
			// Set the view to show details.
			this.StatisticsListView.View = View.Details;
			// Allow the user to edit item text.
			this.StatisticsListView.LabelEdit = true;
			// Select the item and subitems when selection is made.
			this.StatisticsListView.FullRowSelect = true;
			// Display grid lines.
			this.StatisticsListView.GridLines = true;

			// Create columns for the items and subitems.
			// Width of -2 indicates auto-size.
			this.StatisticsListView.Columns.Add("Id", 100, HorizontalAlignment.Left);
			this.StatisticsListView.Columns.Add("Date Time", -2, HorizontalAlignment.Left);
			this.StatisticsListView.Columns.Add("Weight", -2, HorizontalAlignment.Left);
			this.StatisticsListView.Columns.Add("Heigth", -2, HorizontalAlignment.Left);
			this.StatisticsListView.Columns.Add("BMI", -2, HorizontalAlignment.Left);
		}

		private void StatisticsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			var items = this.StatisticsListView.SelectedItems;
			if (items.Count != 0)
			{
				var item = this.StatisticsListView.SelectedItems[0];

				this.DeleteButton.Show();
				this.AddUpdateButton.Text = "Update";

				this.KilogramsTextBox.Text = item.SubItems[2].Text;
				this.HeightTextBox.Text = item.SubItems[3].Text;

				return;
			}

			this.AddUpdateButton.Text = "Add";
			this.DeleteButton.Hide();

			this.KilogramsTextBox.Text = "";
			this.HeightTextBox.Text = "";
		}
	}
}
