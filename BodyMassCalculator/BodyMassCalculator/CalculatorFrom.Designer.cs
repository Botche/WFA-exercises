
namespace BodyMassCalculator
{
	partial class CalculatorFrom
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
			this.KilogramsTextBox = new System.Windows.Forms.TextBox();
			this.HeightTextBox = new System.Windows.Forms.TextBox();
			this.KilogramsLabel = new System.Windows.Forms.Label();
			this.HeightLabel = new System.Windows.Forms.Label();
			this.StatisticsListView = new System.Windows.Forms.ListView();
			this.AddUpdateButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LogoutLinkLabel
			// 
			this.LogoutLinkLabel.AutoSize = true;
			this.LogoutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LogoutLinkLabel.Location = new System.Drawing.Point(13, 13);
			this.LogoutLinkLabel.Name = "LogoutLinkLabel";
			this.LogoutLinkLabel.Size = new System.Drawing.Size(53, 19);
			this.LogoutLinkLabel.TabIndex = 0;
			this.LogoutLinkLabel.TabStop = true;
			this.LogoutLinkLabel.Text = "Logout";
			this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
			// 
			// KilogramsTextBox
			// 
			this.KilogramsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.KilogramsTextBox.Location = new System.Drawing.Point(116, 100);
			this.KilogramsTextBox.Name = "KilogramsTextBox";
			this.KilogramsTextBox.Size = new System.Drawing.Size(100, 33);
			this.KilogramsTextBox.TabIndex = 1;
			// 
			// HeightTextBox
			// 
			this.HeightTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.HeightTextBox.Location = new System.Drawing.Point(116, 206);
			this.HeightTextBox.Name = "HeightTextBox";
			this.HeightTextBox.Size = new System.Drawing.Size(100, 33);
			this.HeightTextBox.TabIndex = 2;
			// 
			// KilogramsLabel
			// 
			this.KilogramsLabel.AutoSize = true;
			this.KilogramsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.KilogramsLabel.Location = new System.Drawing.Point(14, 103);
			this.KilogramsLabel.Name = "KilogramsLabel";
			this.KilogramsLabel.Size = new System.Drawing.Size(100, 25);
			this.KilogramsLabel.TabIndex = 3;
			this.KilogramsLabel.Text = "Kilograms:";
			// 
			// HeightLabel
			// 
			this.HeightLabel.AutoSize = true;
			this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.HeightLabel.Location = new System.Drawing.Point(42, 209);
			this.HeightLabel.Name = "HeightLabel";
			this.HeightLabel.Size = new System.Drawing.Size(72, 25);
			this.HeightLabel.TabIndex = 4;
			this.HeightLabel.Text = "Height:";
			// 
			// StatisticsListView
			// 
			this.StatisticsListView.HideSelection = false;
			this.StatisticsListView.Location = new System.Drawing.Point(276, 58);
			this.StatisticsListView.Name = "StatisticsListView";
			this.StatisticsListView.Size = new System.Drawing.Size(512, 302);
			this.StatisticsListView.TabIndex = 6;
			this.StatisticsListView.UseCompatibleStateImageBehavior = false;
			this.StatisticsListView.SelectedIndexChanged += new System.EventHandler(this.StatisticsListView_SelectedIndexChanged);
			// 
			// AddUpdateButton
			// 
			this.AddUpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddUpdateButton.Location = new System.Drawing.Point(14, 289);
			this.AddUpdateButton.Name = "AddUpdateButton";
			this.AddUpdateButton.Size = new System.Drawing.Size(85, 30);
			this.AddUpdateButton.TabIndex = 7;
			this.AddUpdateButton.Text = "Add";
			this.AddUpdateButton.UseVisualStyleBackColor = true;
			this.AddUpdateButton.Click += new System.EventHandler(this.AddUpdateButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteButton.Location = new System.Drawing.Point(126, 289);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(90, 30);
			this.DeleteButton.TabIndex = 8;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// CalculatorFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddUpdateButton);
			this.Controls.Add(this.StatisticsListView);
			this.Controls.Add(this.HeightLabel);
			this.Controls.Add(this.KilogramsLabel);
			this.Controls.Add(this.HeightTextBox);
			this.Controls.Add(this.KilogramsTextBox);
			this.Controls.Add(this.LogoutLinkLabel);
			this.Name = "CalculatorFrom";
			this.Text = "CalculatorFrom";
			this.Load += new System.EventHandler(this.CalculatorFrom_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel LogoutLinkLabel;
		private System.Windows.Forms.TextBox KilogramsTextBox;
		private System.Windows.Forms.TextBox HeightTextBox;
		private System.Windows.Forms.Label KilogramsLabel;
		private System.Windows.Forms.Label HeightLabel;
		private System.Windows.Forms.ListView StatisticsListView;
		private System.Windows.Forms.Button AddUpdateButton;
		private System.Windows.Forms.Button DeleteButton;
	}
}