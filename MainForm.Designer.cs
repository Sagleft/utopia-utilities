namespace UtopiaUtilities
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_clearlog = new System.Windows.Forms.Button();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabConnection = new System.Windows.Forms.TabPage();
			this.btn_connect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_token = new System.Windows.Forms.TextBox();
			this.textBox2_host = new System.Windows.Forms.TextBox();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.tabAccount = new System.Windows.Forms.TabPage();
			this.btn_getMyPubkey = new System.Windows.Forms.Button();
			this.tabAuth = new System.Windows.Forms.TabPage();
			this.tabBalance = new System.Windows.Forms.TabPage();
			this.tabChannels = new System.Windows.Forms.TabPage();
			this.tabContacts = new System.Windows.Forms.TabPage();
			this.tabCryptoCards = new System.Windows.Forms.TabPage();
			this.tabFinance = new System.Windows.Forms.TabPage();
			this.tabInvoice = new System.Windows.Forms.TabPage();
			this.tabMessage = new System.Windows.Forms.TabPage();
			this.tabMining = new System.Windows.Forms.TabPage();
			this.tabOther = new System.Windows.Forms.TabPage();
			this.tabPayment = new System.Windows.Forms.TabPage();
			this.tabProxy = new System.Windows.Forms.TabPage();
			this.tabStickers = new System.Windows.Forms.TabPage();
			this.tabSystemInfo = new System.Windows.Forms.TabPage();
			this.tabVouchers = new System.Windows.Forms.TabPage();
			this.tabUCode = new System.Windows.Forms.TabPage();
			this.tabUMail = new System.Windows.Forms.TabPage();
			this.tabUNS = new System.Windows.Forms.TabPage();
			this.tabAbout = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnOpenGithub = new System.Windows.Forms.Button();
			this.btn_copyMyPubkeyCLP = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabConnection.SuspendLayout();
			this.tabAccount.SuspendLayout();
			this.tabAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_clearlog);
			this.groupBox1.Controls.Add(this.textBox_log);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 553);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Log";
			// 
			// btn_clearlog
			// 
			this.btn_clearlog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_clearlog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_clearlog.Location = new System.Drawing.Point(3, 518);
			this.btn_clearlog.Name = "btn_clearlog";
			this.btn_clearlog.Size = new System.Drawing.Size(274, 32);
			this.btn_clearlog.TabIndex = 1;
			this.btn_clearlog.Text = "Clear";
			this.btn_clearlog.UseVisualStyleBackColor = true;
			this.btn_clearlog.Click += new System.EventHandler(this.Btn_clearlogClick);
			// 
			// textBox_log
			// 
			this.textBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_log.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_log.Location = new System.Drawing.Point(3, 26);
			this.textBox_log.Margin = new System.Windows.Forms.Padding(3, 3, 3, 32);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(274, 524);
			this.textBox_log.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabConnection);
			this.tabControl1.Controls.Add(this.tabAccount);
			this.tabControl1.Controls.Add(this.tabAuth);
			this.tabControl1.Controls.Add(this.tabBalance);
			this.tabControl1.Controls.Add(this.tabChannels);
			this.tabControl1.Controls.Add(this.tabContacts);
			this.tabControl1.Controls.Add(this.tabCryptoCards);
			this.tabControl1.Controls.Add(this.tabFinance);
			this.tabControl1.Controls.Add(this.tabInvoice);
			this.tabControl1.Controls.Add(this.tabMessage);
			this.tabControl1.Controls.Add(this.tabMining);
			this.tabControl1.Controls.Add(this.tabOther);
			this.tabControl1.Controls.Add(this.tabPayment);
			this.tabControl1.Controls.Add(this.tabProxy);
			this.tabControl1.Controls.Add(this.tabStickers);
			this.tabControl1.Controls.Add(this.tabSystemInfo);
			this.tabControl1.Controls.Add(this.tabVouchers);
			this.tabControl1.Controls.Add(this.tabUCode);
			this.tabControl1.Controls.Add(this.tabUMail);
			this.tabControl1.Controls.Add(this.tabUNS);
			this.tabControl1.Controls.Add(this.tabAbout);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(280, 0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(502, 553);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 10;
			// 
			// tabConnection
			// 
			this.tabConnection.Controls.Add(this.btn_connect);
			this.tabConnection.Controls.Add(this.label3);
			this.tabConnection.Controls.Add(this.label2);
			this.tabConnection.Controls.Add(this.label1);
			this.tabConnection.Controls.Add(this.textBox_token);
			this.tabConnection.Controls.Add(this.textBox2_host);
			this.tabConnection.Controls.Add(this.textBox_port);
			this.tabConnection.Location = new System.Drawing.Point(4, 116);
			this.tabConnection.Name = "tabConnection";
			this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
			this.tabConnection.Size = new System.Drawing.Size(494, 433);
			this.tabConnection.TabIndex = 0;
			this.tabConnection.Text = "Connection";
			this.tabConnection.UseVisualStyleBackColor = true;
			// 
			// btn_connect
			// 
			this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_connect.Location = new System.Drawing.Point(281, 128);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(191, 27);
			this.btn_connect.TabIndex = 17;
			this.btn_connect.Text = "Connect";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.Btn_connectClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(195, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Token";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(195, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Host";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(195, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Port";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_token
			// 
			this.textBox_token.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox_token.Location = new System.Drawing.Point(281, 92);
			this.textBox_token.Name = "textBox_token";
			this.textBox_token.Size = new System.Drawing.Size(191, 30);
			this.textBox_token.TabIndex = 11;
			this.textBox_token.Text = "B5CE71CCCEF49B0E89BA07C214B2E583";
			this.textBox_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2_host
			// 
			this.textBox2_host.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2_host.Location = new System.Drawing.Point(281, 63);
			this.textBox2_host.Name = "textBox2_host";
			this.textBox2_host.Size = new System.Drawing.Size(191, 30);
			this.textBox2_host.TabIndex = 12;
			this.textBox2_host.Text = "http://127.0.0.1";
			this.textBox2_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_port
			// 
			this.textBox_port.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox_port.Location = new System.Drawing.Point(281, 34);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(191, 30);
			this.textBox_port.TabIndex = 13;
			this.textBox_port.Text = "22824";
			this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabAccount
			// 
			this.tabAccount.Controls.Add(this.btn_copyMyPubkeyCLP);
			this.tabAccount.Controls.Add(this.btn_getMyPubkey);
			this.tabAccount.Location = new System.Drawing.Point(4, 116);
			this.tabAccount.Name = "tabAccount";
			this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
			this.tabAccount.Size = new System.Drawing.Size(494, 433);
			this.tabAccount.TabIndex = 1;
			this.tabAccount.Text = "Account";
			this.tabAccount.UseVisualStyleBackColor = true;
			// 
			// btn_getMyPubkey
			// 
			this.btn_getMyPubkey.Location = new System.Drawing.Point(16, 17);
			this.btn_getMyPubkey.Name = "btn_getMyPubkey";
			this.btn_getMyPubkey.Size = new System.Drawing.Size(199, 34);
			this.btn_getMyPubkey.TabIndex = 0;
			this.btn_getMyPubkey.Text = "get my pubkey";
			this.btn_getMyPubkey.UseVisualStyleBackColor = true;
			this.btn_getMyPubkey.Click += new System.EventHandler(this.Btn_getMyPubkeyClick);
			// 
			// tabAuth
			// 
			this.tabAuth.Location = new System.Drawing.Point(4, 67);
			this.tabAuth.Name = "tabAuth";
			this.tabAuth.Size = new System.Drawing.Size(494, 482);
			this.tabAuth.TabIndex = 2;
			this.tabAuth.Text = "Auth";
			this.tabAuth.UseVisualStyleBackColor = true;
			// 
			// tabBalance
			// 
			this.tabBalance.Location = new System.Drawing.Point(4, 67);
			this.tabBalance.Name = "tabBalance";
			this.tabBalance.Size = new System.Drawing.Size(494, 482);
			this.tabBalance.TabIndex = 3;
			this.tabBalance.Text = "Balance";
			this.tabBalance.UseVisualStyleBackColor = true;
			// 
			// tabChannels
			// 
			this.tabChannels.Location = new System.Drawing.Point(4, 67);
			this.tabChannels.Name = "tabChannels";
			this.tabChannels.Size = new System.Drawing.Size(494, 482);
			this.tabChannels.TabIndex = 4;
			this.tabChannels.Text = "Channels";
			this.tabChannels.UseVisualStyleBackColor = true;
			// 
			// tabContacts
			// 
			this.tabContacts.Location = new System.Drawing.Point(4, 67);
			this.tabContacts.Name = "tabContacts";
			this.tabContacts.Size = new System.Drawing.Size(494, 482);
			this.tabContacts.TabIndex = 5;
			this.tabContacts.Text = "Contacts";
			this.tabContacts.UseVisualStyleBackColor = true;
			// 
			// tabCryptoCards
			// 
			this.tabCryptoCards.Location = new System.Drawing.Point(4, 67);
			this.tabCryptoCards.Name = "tabCryptoCards";
			this.tabCryptoCards.Size = new System.Drawing.Size(494, 482);
			this.tabCryptoCards.TabIndex = 6;
			this.tabCryptoCards.Text = "CryptoCards";
			this.tabCryptoCards.UseVisualStyleBackColor = true;
			// 
			// tabFinance
			// 
			this.tabFinance.Location = new System.Drawing.Point(4, 67);
			this.tabFinance.Name = "tabFinance";
			this.tabFinance.Size = new System.Drawing.Size(494, 482);
			this.tabFinance.TabIndex = 7;
			this.tabFinance.Text = "Finance";
			this.tabFinance.UseVisualStyleBackColor = true;
			// 
			// tabInvoice
			// 
			this.tabInvoice.Location = new System.Drawing.Point(4, 67);
			this.tabInvoice.Name = "tabInvoice";
			this.tabInvoice.Size = new System.Drawing.Size(494, 482);
			this.tabInvoice.TabIndex = 8;
			this.tabInvoice.Text = "Invoice";
			this.tabInvoice.UseVisualStyleBackColor = true;
			// 
			// tabMessage
			// 
			this.tabMessage.Location = new System.Drawing.Point(4, 67);
			this.tabMessage.Name = "tabMessage";
			this.tabMessage.Size = new System.Drawing.Size(494, 482);
			this.tabMessage.TabIndex = 9;
			this.tabMessage.Text = "Message";
			this.tabMessage.UseVisualStyleBackColor = true;
			// 
			// tabMining
			// 
			this.tabMining.Location = new System.Drawing.Point(4, 67);
			this.tabMining.Name = "tabMining";
			this.tabMining.Size = new System.Drawing.Size(494, 482);
			this.tabMining.TabIndex = 10;
			this.tabMining.Text = "Mining";
			this.tabMining.UseVisualStyleBackColor = true;
			// 
			// tabOther
			// 
			this.tabOther.Location = new System.Drawing.Point(4, 67);
			this.tabOther.Name = "tabOther";
			this.tabOther.Size = new System.Drawing.Size(494, 482);
			this.tabOther.TabIndex = 11;
			this.tabOther.Text = "Other";
			this.tabOther.UseVisualStyleBackColor = true;
			// 
			// tabPayment
			// 
			this.tabPayment.Location = new System.Drawing.Point(4, 67);
			this.tabPayment.Name = "tabPayment";
			this.tabPayment.Size = new System.Drawing.Size(494, 482);
			this.tabPayment.TabIndex = 12;
			this.tabPayment.Text = "Payment";
			this.tabPayment.UseVisualStyleBackColor = true;
			// 
			// tabProxy
			// 
			this.tabProxy.Location = new System.Drawing.Point(4, 67);
			this.tabProxy.Name = "tabProxy";
			this.tabProxy.Size = new System.Drawing.Size(494, 482);
			this.tabProxy.TabIndex = 13;
			this.tabProxy.Text = "Proxy";
			this.tabProxy.UseVisualStyleBackColor = true;
			// 
			// tabStickers
			// 
			this.tabStickers.Location = new System.Drawing.Point(4, 67);
			this.tabStickers.Name = "tabStickers";
			this.tabStickers.Size = new System.Drawing.Size(494, 482);
			this.tabStickers.TabIndex = 14;
			this.tabStickers.Text = "Stickers";
			this.tabStickers.UseVisualStyleBackColor = true;
			// 
			// tabSystemInfo
			// 
			this.tabSystemInfo.Location = new System.Drawing.Point(4, 67);
			this.tabSystemInfo.Name = "tabSystemInfo";
			this.tabSystemInfo.Size = new System.Drawing.Size(494, 482);
			this.tabSystemInfo.TabIndex = 15;
			this.tabSystemInfo.Text = "SystemInfo";
			this.tabSystemInfo.UseVisualStyleBackColor = true;
			// 
			// tabVouchers
			// 
			this.tabVouchers.Location = new System.Drawing.Point(4, 67);
			this.tabVouchers.Name = "tabVouchers";
			this.tabVouchers.Size = new System.Drawing.Size(494, 482);
			this.tabVouchers.TabIndex = 16;
			this.tabVouchers.Text = "Vouchers";
			this.tabVouchers.UseVisualStyleBackColor = true;
			// 
			// tabUCode
			// 
			this.tabUCode.Location = new System.Drawing.Point(4, 67);
			this.tabUCode.Name = "tabUCode";
			this.tabUCode.Size = new System.Drawing.Size(494, 482);
			this.tabUCode.TabIndex = 17;
			this.tabUCode.Text = "uCode";
			this.tabUCode.UseVisualStyleBackColor = true;
			// 
			// tabUMail
			// 
			this.tabUMail.Location = new System.Drawing.Point(4, 67);
			this.tabUMail.Name = "tabUMail";
			this.tabUMail.Size = new System.Drawing.Size(494, 482);
			this.tabUMail.TabIndex = 18;
			this.tabUMail.Text = "uMail";
			this.tabUMail.UseVisualStyleBackColor = true;
			// 
			// tabUNS
			// 
			this.tabUNS.Location = new System.Drawing.Point(4, 67);
			this.tabUNS.Name = "tabUNS";
			this.tabUNS.Size = new System.Drawing.Size(494, 482);
			this.tabUNS.TabIndex = 19;
			this.tabUNS.Text = "uNS";
			this.tabUNS.UseVisualStyleBackColor = true;
			// 
			// tabAbout
			// 
			this.tabAbout.Controls.Add(this.label4);
			this.tabAbout.Controls.Add(this.pictureBox1);
			this.tabAbout.Controls.Add(this.btnOpenGithub);
			this.tabAbout.Location = new System.Drawing.Point(4, 67);
			this.tabAbout.Name = "tabAbout";
			this.tabAbout.Size = new System.Drawing.Size(494, 482);
			this.tabAbout.TabIndex = 20;
			this.tabAbout.Text = "About";
			this.tabAbout.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(23, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(441, 151);
			this.label4.TabIndex = 21;
			this.label4.Text = "Utility for working with Utopia Ecosystem and Utopia API accounts.\r\n\r\nLicense: MI" +
	"T\r\n\r\n(C) 2020 Sagleft";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(155, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(158, 79);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// btnOpenGithub
			// 
			this.btnOpenGithub.Location = new System.Drawing.Point(155, 367);
			this.btnOpenGithub.Name = "btnOpenGithub";
			this.btnOpenGithub.Size = new System.Drawing.Size(158, 36);
			this.btnOpenGithub.TabIndex = 19;
			this.btnOpenGithub.Text = "Github";
			this.btnOpenGithub.UseVisualStyleBackColor = true;
			this.btnOpenGithub.Click += new System.EventHandler(this.BtnOpenGithubClick);
			// 
			// btn_copyMyPubkeyCLP
			// 
			this.btn_copyMyPubkeyCLP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_copyMyPubkeyCLP.Location = new System.Drawing.Point(16, 57);
			this.btn_copyMyPubkeyCLP.Name = "btn_copyMyPubkeyCLP";
			this.btn_copyMyPubkeyCLP.Size = new System.Drawing.Size(199, 34);
			this.btn_copyMyPubkeyCLP.TabIndex = 0;
			this.btn_copyMyPubkeyCLP.Text = "copy my pubkey to clipboard";
			this.btn_copyMyPubkeyCLP.UseVisualStyleBackColor = true;
			this.btn_copyMyPubkeyCLP.Click += new System.EventHandler(this.Btn_getMyPubkeyCLPClick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Utopia Utilities";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabConnection.ResumeLayout(false);
			this.tabConnection.PerformLayout();
			this.tabAccount.ResumeLayout(false);
			this.tabAbout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btn_clearlog;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.TextBox textBox2_host;
		private System.Windows.Forms.TextBox textBox_token;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabConnection;
		private System.Windows.Forms.TabPage tabAccount;
		private System.Windows.Forms.TabPage tabAuth;
		private System.Windows.Forms.TabPage tabBalance;
		private System.Windows.Forms.TabPage tabChannels;
		private System.Windows.Forms.TabPage tabContacts;
		private System.Windows.Forms.TabPage tabCryptoCards;
		private System.Windows.Forms.TabPage tabFinance;
		private System.Windows.Forms.TabPage tabInvoice;
		private System.Windows.Forms.TabPage tabMessage;
		private System.Windows.Forms.TabPage tabMining;
		private System.Windows.Forms.TabPage tabOther;
		private System.Windows.Forms.TabPage tabPayment;
		private System.Windows.Forms.TabPage tabProxy;
		private System.Windows.Forms.TabPage tabStickers;
		private System.Windows.Forms.TabPage tabSystemInfo;
		private System.Windows.Forms.TabPage tabVouchers;
		private System.Windows.Forms.TabPage tabUCode;
		private System.Windows.Forms.TabPage tabUMail;
		private System.Windows.Forms.TabPage tabUNS;
		private System.Windows.Forms.Button btnOpenGithub;
		private System.Windows.Forms.TabPage tabAbout;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_getMyPubkey;
		private System.Windows.Forms.Button btn_copyMyPubkeyCLP;
	}
}
