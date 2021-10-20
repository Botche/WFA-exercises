using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleWFAProject
{
	public partial class CustomersName : Form
	{
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
			if(e.KeyChar == (char)Keys.Enter)
			{
				this.AddNameToList();
			}
		}

		private void AddNameToList()
		{
			string customerName = this.txtName.Text;
			this.txtName.Clear();

			if (String.IsNullOrWhiteSpace(customerName)
				|| customerName.All(char.IsLetter) == false)
			{
				string message = "Wrong name!";
				string title = "Close Window";

				MessageBox.Show(message, title);

				return;
			}

			this.lstNames.Items.Add(customerName);
		}
	}
}
