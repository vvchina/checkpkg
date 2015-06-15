/*
 * Created by SharpDevelop.
 * User: vv
 * Date: 2015/6/11
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace checkpkg
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label operatorLB;
		private System.Windows.Forms.Label passwdLB;
		private System.Windows.Forms.TextBox operatorTB;
		private System.Windows.Forms.MaskedTextBox passwdMTB;
		private System.Windows.Forms.Button loginBT;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.operatorLB = new System.Windows.Forms.Label();
			this.passwdLB = new System.Windows.Forms.Label();
			this.operatorTB = new System.Windows.Forms.TextBox();
			this.passwdMTB = new System.Windows.Forms.MaskedTextBox();
			this.loginBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.operatorLB.Location = new System.Drawing.Point(209, 147);
			this.operatorLB.Name = "operatorLB";
			this.operatorLB.Size = new System.Drawing.Size(100, 23);
			this.operatorLB.Text = "操作员";
			// 
			// label2
			// 
			this.passwdLB.Location = new System.Drawing.Point(209, 183);
			this.passwdLB.Name = "passwordLB";
			this.passwdLB.Size = new System.Drawing.Size(100, 23);
			this.passwdLB.Text = "密码";
			// 
			// textBox1
			// 
			this.operatorTB.Location = new System.Drawing.Point(302, 147);
			this.operatorTB.Name = "OperatorTB";
			this.operatorTB.Size = new System.Drawing.Size(100, 21);
			this.operatorTB.TabIndex = 0;
			// 
			// maskedTextBox1
			// 
			this.passwdMTB.Location = new System.Drawing.Point(302, 183);
			this.passwdMTB.Name = "PasswordMTB";
			this.passwdMTB.Size = new System.Drawing.Size(100, 21);
			this.passwdMTB.TabIndex = 1;
			// 
			// button1
			// 
			this.loginBT.Location = new System.Drawing.Point(263, 229);
			this.loginBT.Name = "loginBT";
			this.loginBT.Size = new System.Drawing.Size(75, 23);
			this.loginBT.TabIndex = 2;
			this.loginBT.Text = "登录";
			this.loginBT.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 296);
			this.Controls.Add(this.loginBT);
			this.Controls.Add(this.passwdMTB);
			this.Controls.Add(this.operatorTB);
			this.Controls.Add(this.passwdLB);
			this.Controls.Add(this.operatorLB);
			this.Name = "LoginForm";
			this.Text = "登录";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
