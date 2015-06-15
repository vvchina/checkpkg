/*
 * Created by SharpDevelop.
 * User: vv
 * Date: 2015/6/11
 * Time: 22:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace checkpkg
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		
		private System.Windows.Forms.TabPage checkExchangeMgTab;
		private System.Windows.Forms.RichTextBox ceMg_exchangeLogRTB;
		private System.Windows.Forms.RichTextBox ceMg_bankStatusRTB;
		private System.Windows.Forms.Button ceMg_startBT;
		private System.Windows.Forms.Button ceMg_saveBT;
		private System.Windows.Forms.Button ceMg_stopBT;
		private System.Windows.Forms.RadioButton ceMg_morningRB;
		private System.Windows.Forms.RadioButton ceMg_nightRB;
		
		
		private System.Windows.Forms.TabPage keyMgTab;
		private System.Windows.Forms.Label keyMg_bankLB;
		private System.Windows.Forms.ListBox keyMg_bankLBX;
		private System.Windows.Forms.RichTextBox keyMg_logRTB;
		private System.Windows.Forms.Button keyMg_saveBT;
		
		private System.Windows.Forms.TabPage pkgMgTab;		
		private System.Windows.Forms.Button pkgMg_saveBT;
		private System.Windows.Forms.RichTextBox pkgMg_logRTB;
		private System.Windows.Forms.ListBox pkgMg_bankLBX;
		private System.Windows.Forms.Label pkgMg_bankLB;
		
		
		private System.Windows.Forms.TabPage DeliverMgTab;
		private System.Windows.Forms.TextBox deMg_nameTB;
		private System.Windows.Forms.Label deMg_nameLB;
		private System.Windows.Forms.Button deMg_saveBT;
		private System.Windows.Forms.RichTextBox deMg_saveRTB;
		
		private System.Windows.Forms.TabPage bankMgTab;
		private System.Windows.Forms.DataGrid bankMgDG;

		private System.Windows.Forms.TabPage queryTab;
		
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.checkExchangeMgTab = new System.Windows.Forms.TabPage();
			this.ceMg_startBT = new System.Windows.Forms.Button();
			this.ceMg_saveBT = new System.Windows.Forms.Button();
			this.ceMg_stopBT = new System.Windows.Forms.Button();
			this.ceMg_exchangeLogRTB = new System.Windows.Forms.RichTextBox();
			this.ceMg_bankStatusRTB = new System.Windows.Forms.RichTextBox();
			this.ceMg_morningRB = new System.Windows.Forms.RadioButton();
			this.ceMg_nightRB = new System.Windows.Forms.RadioButton();
			
			this.keyMgTab = new System.Windows.Forms.TabPage();
			this.keyMg_saveBT = new System.Windows.Forms.Button();
			this.keyMg_logRTB = new System.Windows.Forms.RichTextBox();
			this.keyMg_bankLB = new System.Windows.Forms.Label();
			this.keyMg_bankLBX = new System.Windows.Forms.ListBox();
			
			this.pkgMgTab = new System.Windows.Forms.TabPage();
			this.pkgMg_saveBT = new System.Windows.Forms.Button();
			this.pkgMg_logRTB = new System.Windows.Forms.RichTextBox();
			this.pkgMg_bankLBX = new System.Windows.Forms.ListBox();
			this.pkgMg_bankLB = new System.Windows.Forms.Label();
			
			this.DeliverMgTab = new System.Windows.Forms.TabPage();
			this.deMg_saveBT = new System.Windows.Forms.Button();
			this.deMg_saveRTB = new System.Windows.Forms.RichTextBox();
			this.deMg_nameTB = new System.Windows.Forms.TextBox();
			this.deMg_nameLB = new System.Windows.Forms.Label();
			
			this.bankMgTab = new System.Windows.Forms.TabPage();
			this.bankMgDG = new System.Windows.Forms.DataGrid();
			
			this.queryTab = new System.Windows.Forms.TabPage();
			
			this.tabControl1.SuspendLayout();
			this.checkExchangeMgTab.SuspendLayout();
			this.keyMgTab.SuspendLayout();
			this.pkgMgTab.SuspendLayout();
			this.DeliverMgTab.SuspendLayout();
			this.bankMgTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bankMgDG)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.checkExchangeMgTab);
			this.tabControl1.Controls.Add(this.keyMgTab);
			this.tabControl1.Controls.Add(this.pkgMgTab);
			this.tabControl1.Controls.Add(this.DeliverMgTab);
			this.tabControl1.Controls.Add(this.bankMgTab);
			this.tabControl1.Controls.Add(this.queryTab);
			this.tabControl1.Location = new System.Drawing.Point(0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(741, 341);
			this.tabControl1.TabIndex = 0;
			// 
			// checkExchangeMgTab
			// 
			this.checkExchangeMgTab.Controls.Add(this.ceMg_startBT);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_saveBT);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_stopBT);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_exchangeLogRTB);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_bankStatusRTB);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_morningRB);
			this.checkExchangeMgTab.Controls.Add(this.ceMg_nightRB);
			this.checkExchangeMgTab.Location = new System.Drawing.Point(4, 22);
			this.checkExchangeMgTab.Name = "checkExchangeMgTab";
			this.checkExchangeMgTab.Padding = new System.Windows.Forms.Padding(3);
			this.checkExchangeMgTab.Size = new System.Drawing.Size(733, 315);
			this.checkExchangeMgTab.TabIndex = 0;
			this.checkExchangeMgTab.Text = "支票交换";
			this.checkExchangeMgTab.UseVisualStyleBackColor = true;
			this.checkExchangeMgTab.Click += new System.EventHandler(this.CheckExchangeMgTabClick);
			// 
			// startBT
			// 
			this.ceMg_startBT.Location = new System.Drawing.Point(163, 80);
			this.ceMg_startBT.Name = "startBT";
			this.ceMg_startBT.Size = new System.Drawing.Size(75, 23);
			this.ceMg_startBT.TabIndex = 3;
			this.ceMg_startBT.Text = "开始";
			this.ceMg_startBT.UseVisualStyleBackColor = true;
			// 
			// saveBT
			// 
			this.ceMg_saveBT.Location = new System.Drawing.Point(295, 80);
			this.ceMg_saveBT.Name = "saveBT";
			this.ceMg_saveBT.Size = new System.Drawing.Size(75, 23);
			this.ceMg_saveBT.TabIndex = 5;
			this.ceMg_saveBT.Text = "保存";
			this.ceMg_saveBT.UseVisualStyleBackColor = true;
			// 
			// stopBT
			// 
			this.ceMg_stopBT.Location = new System.Drawing.Point(415, 79);
			this.ceMg_stopBT.Name = "stopBT";
			this.ceMg_stopBT.Size = new System.Drawing.Size(75, 23);
			this.ceMg_stopBT.TabIndex = 7;
			this.ceMg_stopBT.Text = "停止";
			this.ceMg_stopBT.UseVisualStyleBackColor = true;
			// 
			// exchangeLogRTB
			// 
			this.ceMg_exchangeLogRTB.Location = new System.Drawing.Point(90, 130);
			this.ceMg_exchangeLogRTB.Name = "exchangeLogRTB";
			this.ceMg_exchangeLogRTB.Size = new System.Drawing.Size(232, 83);
			this.ceMg_exchangeLogRTB.TabIndex = 4;
			this.ceMg_exchangeLogRTB.Text = "";
			// 
			// BankStatusRTB
			// 
			this.ceMg_bankStatusRTB.Location = new System.Drawing.Point(398, 130);
			this.ceMg_bankStatusRTB.Name = "BankStatusRTB";
			this.ceMg_bankStatusRTB.Size = new System.Drawing.Size(226, 83);
			this.ceMg_bankStatusRTB.TabIndex = 6;
			this.ceMg_bankStatusRTB.Text = "";
			// 
			// morningRB
			// 
			this.ceMg_morningRB.Location = new System.Drawing.Point(249, 26);
			this.ceMg_morningRB.Name = "morningRB";
			this.ceMg_morningRB.Size = new System.Drawing.Size(104, 24);
			this.ceMg_morningRB.TabIndex = 1;
			this.ceMg_morningRB.Text = "午场";
			this.ceMg_morningRB.UseVisualStyleBackColor = true;
			// 
			// nightRB
			// 
			this.ceMg_nightRB.Checked = true;
			this.ceMg_nightRB.Location = new System.Drawing.Point(65, 27);
			this.ceMg_nightRB.Name = "nightRB";
			this.ceMg_nightRB.Size = new System.Drawing.Size(104, 24);
			this.ceMg_nightRB.TabIndex = 0;
			this.ceMg_nightRB.TabStop = true;
			this.ceMg_nightRB.Text = "晚场";
			this.ceMg_nightRB.UseVisualStyleBackColor = true;
			
			
			
			
			// 
			// keyMgTab
			// 
			this.keyMgTab.Controls.Add(this.keyMg_saveBT);
			this.keyMgTab.Controls.Add(this.keyMg_logRTB);
			this.keyMgTab.Controls.Add(this.keyMg_bankLB);
			this.keyMgTab.Controls.Add(this.keyMg_bankLBX);
			this.keyMgTab.Location = new System.Drawing.Point(4, 22);
			this.keyMgTab.Name = "keyMgTab";
			this.keyMgTab.Padding = new System.Windows.Forms.Padding(3);
			this.keyMgTab.Size = new System.Drawing.Size(733, 315);
			this.keyMgTab.TabIndex = 1;
			this.keyMgTab.Text = "交换锁管理";
			this.keyMgTab.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.keyMg_saveBT.Location = new System.Drawing.Point(156, 224);
			this.keyMg_saveBT.Name = "keyMg_save";
			this.keyMg_saveBT.Size = new System.Drawing.Size(75, 23);
			this.keyMg_saveBT.TabIndex = 3;
			this.keyMg_saveBT.Text = "保存";
			this.keyMg_saveBT.UseVisualStyleBackColor = true;
			// 
			// keyMg_logRTB
			// 
			this.keyMg_logRTB.Location = new System.Drawing.Point(63, 97);
			this.keyMg_logRTB.Name = "keyMg_logRTB";
			this.keyMg_logRTB.Size = new System.Drawing.Size(282, 75);
			this.keyMg_logRTB.TabIndex = 2;
			this.keyMg_logRTB.Text = "";
			// 
			// keyMg_bankLB
			// 
			this.keyMg_bankLB.Location = new System.Drawing.Point(26, 25);
			this.keyMg_bankLB.Name = "keyMg_bankLB";
			this.keyMg_bankLB.Size = new System.Drawing.Size(100, 23);
			this.keyMg_bankLB.TabIndex = 1;
			this.keyMg_bankLB.Text = "交易行";
			this.keyMg_bankLB.Click += new System.EventHandler(this.Label1Click);
			// 
			// listBox1
			// 
			this.keyMg_bankLBX.FormattingEnabled = true;
			this.keyMg_bankLBX.ItemHeight = 12;
			this.keyMg_bankLBX.Location = new System.Drawing.Point(156, 25);
			this.keyMg_bankLBX.Name = "keyMg_bankLBX";
			this.keyMg_bankLBX.Size = new System.Drawing.Size(234, 16);
			this.keyMg_bankLBX.TabIndex = 0;
			
			
			
			// 
			// pkgMgTab
			// 
			this.pkgMgTab.Controls.Add(this.pkgMg_saveBT);
			this.pkgMgTab.Controls.Add(this.pkgMg_logRTB);
			this.pkgMgTab.Controls.Add(this.pkgMg_bankLBX);
			this.pkgMgTab.Controls.Add(this.pkgMg_bankLB);
			this.pkgMgTab.Location = new System.Drawing.Point(4, 22);
			this.pkgMgTab.Name = "pkgMgTab";
			this.pkgMgTab.Padding = new System.Windows.Forms.Padding(3);
			this.pkgMgTab.Size = new System.Drawing.Size(733, 315);
			this.pkgMgTab.TabIndex = 2;
			this.pkgMgTab.Text = "交换包管理";
			this.pkgMgTab.UseVisualStyleBackColor = true;
			// 
			// pkgMg_saveBT
			// 
			this.pkgMg_saveBT.Location = new System.Drawing.Point(182, 215);
			this.pkgMg_saveBT.Name = "pkgMg_saveBT";
			this.pkgMg_saveBT.Size = new System.Drawing.Size(75, 23);
			this.pkgMg_saveBT.TabIndex = 3;
			this.pkgMg_saveBT.Text = "保存";
			this.pkgMg_saveBT.UseVisualStyleBackColor = true;
			// 
			// pkgMg_logRTB
			// 
			this.pkgMg_logRTB.Location = new System.Drawing.Point(75, 92);
			this.pkgMg_logRTB.Name = "pkgMg_logRTB";
			this.pkgMg_logRTB.Size = new System.Drawing.Size(279, 68);
			this.pkgMg_logRTB.TabIndex = 2;
			this.pkgMg_logRTB.Text = "";
			// 
			// pkgMg_bankLBX
			// 
			this.pkgMg_bankLBX.FormattingEnabled = true;
			this.pkgMg_bankLBX.ItemHeight = 12;
			this.pkgMg_bankLBX.Location = new System.Drawing.Point(182, 41);
			this.pkgMg_bankLBX.Name = "pkgMg_bankLBX";
			this.pkgMg_bankLBX.Size = new System.Drawing.Size(120, 28);
			this.pkgMg_bankLBX.TabIndex = 1;
			// 
			// pkgMg_bankLB
			// 
			this.pkgMg_bankLB.Location = new System.Drawing.Point(75, 41);
			this.pkgMg_bankLB.Name = "pkgMg_bankLB";
			this.pkgMg_bankLB.Size = new System.Drawing.Size(100, 23);
			this.pkgMg_bankLB.TabIndex = 0;
			this.pkgMg_bankLB.Text = "交易行";
			// 
			// DeliverMgTab
			// 
			this.DeliverMgTab.Controls.Add(this.deMg_saveBT);
			this.DeliverMgTab.Controls.Add(this.deMg_saveRTB);
			this.DeliverMgTab.Controls.Add(this.deMg_nameTB);
			this.DeliverMgTab.Controls.Add(this.deMg_nameLB);
			this.DeliverMgTab.Location = new System.Drawing.Point(4, 22);
			this.DeliverMgTab.Name = "DeliverMgTab";
			this.DeliverMgTab.Padding = new System.Windows.Forms.Padding(3);
			this.DeliverMgTab.Size = new System.Drawing.Size(733, 315);
			this.DeliverMgTab.TabIndex = 3;
			this.DeliverMgTab.Text = "交换员管理";
			this.DeliverMgTab.UseVisualStyleBackColor = true;
			// 
			// deMg_saveBT
			// 
			this.deMg_saveBT.Location = new System.Drawing.Point(166, 208);
			this.deMg_saveBT.Name = "deMg_saveBT";
			this.deMg_saveBT.Size = new System.Drawing.Size(75, 23);
			this.deMg_saveBT.TabIndex = 3;
			this.deMg_saveBT.Text = "保存";
			this.deMg_saveBT.UseVisualStyleBackColor = true;
			// 
			// deMg_saveRTB
			// 
			this.deMg_saveRTB.Location = new System.Drawing.Point(71, 91);
			this.deMg_saveRTB.Name = "deMg_saveRTB";
			this.deMg_saveRTB.Size = new System.Drawing.Size(288, 70);
			this.deMg_saveRTB.TabIndex = 2;
			this.deMg_saveRTB.Text = "";
			// 
			// deMg_nameTB
			// 
			this.deMg_nameTB.Location = new System.Drawing.Point(177, 42);
			this.deMg_nameTB.Name = "deMg_nameTB";
			this.deMg_nameTB.Size = new System.Drawing.Size(100, 21);
			this.deMg_nameTB.TabIndex = 1;
			// 
			// deMg_nameLB
			// 
			this.deMg_nameLB.Location = new System.Drawing.Point(71, 42);
			this.deMg_nameLB.Name = "deMg_nameLB";
			this.deMg_nameLB.Size = new System.Drawing.Size(100, 23);
			this.deMg_nameLB.TabIndex = 0;
			this.deMg_nameLB.Text = "姓名"; 
			this.deMg_nameLB.Click += new System.EventHandler(this.Label3Click);
			// 
			// bankMgTab
			// 
			this.bankMgTab.Controls.Add(this.bankMgDG);
			this.bankMgTab.Location = new System.Drawing.Point(4, 22);
			this.bankMgTab.Name = "bankMgTab";
			this.bankMgTab.Padding = new System.Windows.Forms.Padding(3);
			this.bankMgTab.Size = new System.Drawing.Size(733, 315);
			this.bankMgTab.TabIndex = 4;
			this.bankMgTab.Text = "交易行管理";
			this.bankMgTab.UseVisualStyleBackColor = true;
			// 
			// bankMgDG
			// 
			this.bankMgDG.DataMember = "";
			this.bankMgDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.bankMgDG.Location = new System.Drawing.Point(8, 6);
			this.bankMgDG.Name = "bankMgDG";
			this.bankMgDG.Size = new System.Drawing.Size(678, 283);
			this.bankMgDG.TabIndex = 0;
			this.bankMgDG.Navigate += new System.Windows.Forms.NavigateEventHandler(this.BankMgDGNavigate);
			// 
			// queryTab
			// 
			this.queryTab.Location = new System.Drawing.Point(4, 22);
			this.queryTab.Name = "queryTab";
			this.queryTab.Padding = new System.Windows.Forms.Padding(3);
			this.queryTab.Size = new System.Drawing.Size(733, 315);
			this.queryTab.TabIndex = 5;
			this.queryTab.Text = "交易查询";
			this.queryTab.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 338);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "支票包交换系统";
			this.tabControl1.ResumeLayout(false);
			this.checkExchangeMgTab.ResumeLayout(false);
			this.keyMgTab.ResumeLayout(false);
			this.pkgMgTab.ResumeLayout(false);
			this.DeliverMgTab.ResumeLayout(false);
			this.DeliverMgTab.PerformLayout();
			this.bankMgTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bankMgDG)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
