﻿namespace PlayStationSharp.TestApp
{
	partial class TestForm
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblOnlineId = new System.Windows.Forms.Label();
			this.lstFriends = new System.Windows.Forms.ListBox();
			this.lblFriends = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(165, 106);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(130, 37);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login with PlayStation";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblOnlineId
			// 
			this.lblOnlineId.AutoSize = true;
			this.lblOnlineId.Location = new System.Drawing.Point(12, 9);
			this.lblOnlineId.Name = "lblOnlineId";
			this.lblOnlineId.Size = new System.Drawing.Size(35, 13);
			this.lblOnlineId.TabIndex = 1;
			this.lblOnlineId.Text = "label1";
			this.lblOnlineId.Visible = false;
			// 
			// lstFriends
			// 
			this.lstFriends.FormattingEnabled = true;
			this.lstFriends.Location = new System.Drawing.Point(361, 28);
			this.lstFriends.Name = "lstFriends";
			this.lstFriends.Size = new System.Drawing.Size(138, 238);
			this.lstFriends.TabIndex = 2;
			this.lstFriends.Visible = false;
			// 
			// lblFriends
			// 
			this.lblFriends.AutoSize = true;
			this.lblFriends.Location = new System.Drawing.Point(358, 12);
			this.lblFriends.Name = "lblFriends";
			this.lblFriends.Size = new System.Drawing.Size(41, 13);
			this.lblFriends.TabIndex = 3;
			this.lblFriends.Text = "Friends";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 278);
			this.Controls.Add(this.lblFriends);
			this.Controls.Add(this.lstFriends);
			this.Controls.Add(this.lblOnlineId);
			this.Controls.Add(this.btnLogin);
			this.Name = "TestForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblOnlineId;
		private System.Windows.Forms.ListBox lstFriends;
		private System.Windows.Forms.Label lblFriends;
	}
}

