namespace BodyMassCalculator
{
	using System;
	using System.Windows.Forms;

	using BodyMassCalculator.Database;

	public partial class Form1 : Form
	{
		private readonly BodyMassCalculatorDbContext dbContext;

		public Form1(BodyMassCalculatorDbContext dbContext)
		{
			InitializeComponent();
			this.dbContext = dbContext;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// This code is only for once to populate Genders table

			// var male = new Gender()
			// {
			// 	Name = "Male",
			// };
			// var female = new Gender()
			// {
			// 	Name = "Female",
			// };
			// var unknown = new Gender()
			// {
			// 	Name = "Unknown",
			// };
				 
			// this.dbContext.Genders.AddRange(male, female, unknown);
			// this.dbContext.SaveChanges();
		}
	}
}
