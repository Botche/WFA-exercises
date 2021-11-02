using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleWFAProject
{
	public partial class CustomersName : Form
	{
		private const string ERROR_MESSAGE_BOX_TITLE = "Close window";
		private const string ERROR_MESSAGE_BOX_INVALID_NAME = "Invalid name!";
		private const string ERROR_MESSAGE_BOX_DUPLICATE_NAME = "The name is already given!";

		private const string CUSTOMERS_NAME_FILE_PATH = @"./../../../CustomersName.txt";

		public CustomersName()
		{
			InitializeComponent();
		}

		private void CustomersName_Load(object sender, EventArgs e)
		{
			this.ReadAllCustomersNameFromFile();
			this.txtName.Select();
		}

		private void btnAddName_Click(object sender, EventArgs e)
		{
			this.AddNameToList();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.lstNames.Items.Clear();
			this.ClearCustomersNameFromFile();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				this.AddNameToList();
			}
		}

		private void lstNames_DoubleClick(object sender, EventArgs e)
		{
			this.txtName.Text = this.lstNames.SelectedItem.ToString();
		}

		private void btnEditName_Click(object sender, EventArgs e)
		{
			// string customerNameToEdit = this.lstName.SelectedItem.ToString(); -- same as the if block
			string customerNameToEdit = "";
			if (this.lstNames.SelectedItem != null)
			{
				customerNameToEdit = this.lstNames.SelectedItem.ToString();
			}

			bool result = this.AddNameToList();
			if (result == true)
			{
				this.lstNames.Items.Remove(customerNameToEdit);
				this.RemoveCustomerNameFromFile(customerNameToEdit);
			}
		}

		private bool AddNameToList()
		{
			string customerName = this.txtName.Text;
			this.txtName.Clear();

			if (String.IsNullOrWhiteSpace(customerName)
				|| customerName.All(char.IsLetter) == false)
			{
				MessageBox.Show(ERROR_MESSAGE_BOX_INVALID_NAME, ERROR_MESSAGE_BOX_TITLE);

				return false;
			}

			if (this.lstNames.Items.Contains(customerName) == true)
			{
				MessageBox.Show(ERROR_MESSAGE_BOX_DUPLICATE_NAME, ERROR_MESSAGE_BOX_TITLE);

				return false;
			}

			this.lstNames.Items.Add(customerName);
			this.AddCustomerNameToFile(customerName);

			return true;
		}

		private async void ReadAllCustomersNameFromFile()
		{
			using (StreamReader streamReader = new StreamReader(CUSTOMERS_NAME_FILE_PATH))
			{
				string customerName = String.Empty;
				while ((customerName = await streamReader.ReadLineAsync()) != null)
				{
					this.lstNames.Items.Add(customerName);
				}
			}
		}

		private async void AddCustomerNameToFile(string customerName)
		{
			List<string> customersName = (await File.ReadAllLinesAsync(CUSTOMERS_NAME_FILE_PATH)).ToList();
			customersName.Add(customerName);

			using (StreamWriter streamWriter = new StreamWriter(CUSTOMERS_NAME_FILE_PATH))
			{
				string result = string.Join('\n', customersName);

				await streamWriter.WriteLineAsync(result);
			}
		}

		private void ClearCustomersNameFromFile()
		{
			File.WriteAllText(CUSTOMERS_NAME_FILE_PATH, String.Empty);
		}
		 
		private async void RemoveCustomerNameFromFile(string customerName)
		{
			List<string> customersName = new List<string>();

			using (StreamReader streamReader = new StreamReader(CUSTOMERS_NAME_FILE_PATH))
			{
				string customerNameFromFile = String.Empty;
				while ((customerNameFromFile = await streamReader.ReadLineAsync()) != null)
				{
					if (customerNameFromFile == customerName)
					{
						continue;
					}

					customersName.Add(customerNameFromFile);
				}
			}

			File.WriteAllLines(CUSTOMERS_NAME_FILE_PATH, customersName);
		}
	}
}
