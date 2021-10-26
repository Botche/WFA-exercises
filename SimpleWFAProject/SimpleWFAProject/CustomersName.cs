using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleWFAProject
{
	public partial class CustomersName : Form
	{
		private const string ERROR_MESSAGE_BOX_TITLE = "Close window";
		private const string ERROR_MESSAGE_BOX_INVALID_NAME = "Invalid name!";
		private const string ERROR_MESSAGE_BOX_DUPLICATE_NAME = "The name is already given!";

		public CustomersName()
		{
			InitializeComponent();
		}

		private void CustomersName_Load(object sender, EventArgs e)
		{
			this.txtName.Select();
		}

		private void btnAddName_Click(object sender, EventArgs e)
		{
			this.AddNameToList();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.lstNames.Items.Clear();
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

			return true;
		}
	}
}
