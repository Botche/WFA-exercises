﻿
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
			// CalculatorFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LogoutLinkLabel);
			this.Name = "CalculatorFrom";
			this.Text = "CalculatorFrom";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel LogoutLinkLabel;
	}
}