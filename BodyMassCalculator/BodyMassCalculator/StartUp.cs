namespace BodyMassCalculator
{
	using System;
	using System.Windows.Forms;

	using BodyMassCalculator.Database;

	using Microsoft.EntityFrameworkCore;

	static class StartUp
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			BodyMassCalculatorDbContext dbContext = new BodyMassCalculatorDbContext();
			dbContext.Database.Migrate();

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1(dbContext));
		}
	}
}
