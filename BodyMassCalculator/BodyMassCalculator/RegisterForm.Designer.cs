
namespace BodyMassCalculator
{
	partial class RegisterForm
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
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.RegisterLabel = new System.Windows.Forms.Label();
			this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
			this.RepeatPasswordLabel = new System.Windows.Forms.Label();
			this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(284, 231);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(308, 23);
			this.PasswordTextBox.TabIndex = 11;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(284, 168);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(308, 23);
			this.UsernameTextBox.TabIndex = 10;
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(358, 354);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(115, 29);
			this.RegisterButton.TabIndex = 9;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(187, 229);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(91, 25);
			this.PasswordLabel.TabIndex = 8;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(181, 166);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(97, 25);
			this.UsernameLabel.TabIndex = 7;
			this.UsernameLabel.Text = "Username";
			// 
			// RegisterLabel
			// 
			this.RegisterLabel.AutoSize = true;
			this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterLabel.Location = new System.Drawing.Point(358, 96);
			this.RegisterLabel.Name = "RegisterLabel";
			this.RegisterLabel.Size = new System.Drawing.Size(99, 32);
			this.RegisterLabel.TabIndex = 6;
			this.RegisterLabel.Text = "Register";
			// 
			// RepeatPasswordTextBox
			// 
			this.RepeatPasswordTextBox.Location = new System.Drawing.Point(284, 286);
			this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
			this.RepeatPasswordTextBox.Size = new System.Drawing.Size(308, 23);
			this.RepeatPasswordTextBox.TabIndex = 13;
			// 
			// RepeatPasswordLabel
			// 
			this.RepeatPasswordLabel.AutoSize = true;
			this.RepeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RepeatPasswordLabel.Location = new System.Drawing.Point(124, 284);
			this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
			this.RepeatPasswordLabel.Size = new System.Drawing.Size(154, 25);
			this.RepeatPasswordLabel.TabIndex = 12;
			this.RepeatPasswordLabel.Text = "Repeat password";
			// 
			// LoginLinkLabel
			// 
			this.LoginLinkLabel.AutoSize = true;
			this.LoginLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LoginLinkLabel.Location = new System.Drawing.Point(284, 400);
			this.LoginLinkLabel.Name = "LoginLinkLabel";
			this.LoginLinkLabel.Size = new System.Drawing.Size(250, 19);
			this.LoginLinkLabel.TabIndex = 14;
			this.LoginLinkLabel.TabStop = true;
			this.LoginLinkLabel.Text = "If you are already registered then log in";
			this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLabel_LinkClicked);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LoginLinkLabel);
			this.Controls.Add(this.RepeatPasswordTextBox);
			this.Controls.Add(this.RepeatPasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.RegisterLabel);
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label RegisterLabel;
		private System.Windows.Forms.TextBox RepeatPasswordTextBox;
		private System.Windows.Forms.Label RepeatPasswordLabel;
		private System.Windows.Forms.LinkLabel LoginLinkLabel;
	}
}