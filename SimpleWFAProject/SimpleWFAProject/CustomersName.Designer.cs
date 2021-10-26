namespace SimpleWFAProject
{
	partial class CustomersName
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAddName = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lstNames = new System.Windows.Forms.ListBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnEditName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddName
			// 
			this.btnAddName.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAddName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAddName.Location = new System.Drawing.Point(300, 133);
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.Size = new System.Drawing.Size(120, 34);
			this.btnAddName.TabIndex = 0;
			this.btnAddName.Text = "Add Name";
			this.btnAddName.UseVisualStyleBackColor = true;
			this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(300, 104);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(120, 23);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			// 
			// lstNames
			// 
			this.lstNames.FormattingEnabled = true;
			this.lstNames.ItemHeight = 15;
			this.lstNames.Location = new System.Drawing.Point(130, 104);
			this.lstNames.Name = "lstNames";
			this.lstNames.Size = new System.Drawing.Size(120, 124);
			this.lstNames.TabIndex = 2;
			this.lstNames.DoubleClick += new System.EventHandler(this.lstNames_DoubleClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(300, 215);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 36);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(279, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(83, 19);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btnEditName
			// 
			this.btnEditName.Location = new System.Drawing.Point(300, 173);
			this.btnEditName.Name = "btnEditName";
			this.btnEditName.Size = new System.Drawing.Size(120, 36);
			this.btnEditName.TabIndex = 5;
			this.btnEditName.Text = "Edit Name";
			this.btnEditName.UseVisualStyleBackColor = true;
			this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
			// 
			// CustomersName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 361);
			this.Controls.Add(this.btnEditName);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lstNames);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnAddName);
			this.MinimumSize = new System.Drawing.Size(550, 400);
			this.Name = "CustomersName";
			this.Text = "Customers Name";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.CustomersName_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ListBox lstNames;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnEditName;
	}
}

