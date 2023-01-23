using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NepaliMitibar.My;
using NepaliMitibar.My.Resources;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	[DesignerGenerated]
	public class NoticeBoard : Form
	{
		private IContainer components;

		[AccessedThroughProperty("txtNotice")]
		private TextBox _txtNotice;

		[AccessedThroughProperty("picClose")]
		private PictureBox _picClose;

		[AccessedThroughProperty("lblLink")]
		private LinkLabel _lblLink;

		internal virtual LinkLabel lblLink
		{
			get
			{
				return this._lblLink;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				NoticeBoard noticeBoard = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(noticeBoard.lblLink_LinkClicked);
				if (this._lblLink != null)
				{
					this._lblLink.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._lblLink = value;
				if (this._lblLink != null)
				{
					this._lblLink.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual PictureBox picClose
		{
			get
			{
				return this._picClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				NoticeBoard noticeBoard = this;
				EventHandler eventHandler = new EventHandler(noticeBoard.picClose_Click);
				if (this._picClose != null)
				{
					this._picClose.Click -= eventHandler;
				}
				this._picClose = value;
				if (this._picClose != null)
				{
					this._picClose.Click += eventHandler;
				}
			}
		}

		internal virtual TextBox txtNotice
		{
			get
			{
				return this._txtNotice;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtNotice = value;
			}
		}

		public NoticeBoard()
		{
			NoticeBoard noticeBoard = this;
			base.Load += new EventHandler(noticeBoard.NoticeBoard_Load);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.txtNotice = new TextBox();
			this.picClose = new PictureBox();
			this.lblLink = new LinkLabel();
			((ISupportInitialize)this.picClose).BeginInit();
			this.SuspendLayout();
			this.txtNotice.BackColor = Color.Bisque;
			this.txtNotice.BorderStyle = BorderStyle.None;
			this.txtNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtNotice.ForeColor = Color.Black;
			TextBox textBox = this.txtNotice;
			Point point = new Point(12, 56);
			textBox.Location = point;
			this.txtNotice.Multiline = true;
			this.txtNotice.Name = "txtNotice";
			this.txtNotice.ReadOnly = true;
			TextBox textBox1 = this.txtNotice;
			System.Drawing.Size size = new System.Drawing.Size(524, 156);
			textBox1.Size = size;
			this.txtNotice.TabIndex = 0;
			this.txtNotice.TabStop = false;
			this.txtNotice.Text = "This is a sample notice\r\nयो नमुना नोटिस हो।\r\n";
			this.picClose.BackColor = Color.Transparent;
			this.picClose.Cursor = Cursors.Hand;
			this.picClose.Image = Resources.close;
			PictureBox pictureBox = this.picClose;
			point = new Point(446, 9);
			pictureBox.Location = point;
			this.picClose.Name = "picClose";
			PictureBox pictureBox1 = this.picClose;
			size = new System.Drawing.Size(32, 32);
			pictureBox1.Size = size;
			this.picClose.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 1;
			this.picClose.TabStop = false;
			this.lblLink.BackColor = Color.Bisque;
			this.lblLink.Cursor = Cursors.Hand;
			this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			LinkLabel linkLabel = this.lblLink;
			point = new Point(9, 197);
			linkLabel.Location = point;
			this.lblLink.Name = "lblLink";
			LinkLabel linkLabel1 = this.lblLink;
			size = new System.Drawing.Size(469, 29);
			linkLabel1.Size = size;
			this.lblLink.TabIndex = 2;
			this.lblLink.TabStop = true;
			this.lblLink.Text = "Download";
			this.lblLink.TextAlign = ContentAlignment.MiddleCenter;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.RoyalBlue;
			size = new System.Drawing.Size(575, 235);
			this.ClientSize = size;
			this.Controls.Add(this.lblLink);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.txtNotice);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NoticeBoard";
			this.ShowInTaskbar = false;
			this.Text = "Form1";
			((ISupportInitialize)this.picClose).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(mdlMain.GsNoticeLink);
		}

		private void NoticeBoard_Load(object sender, EventArgs e)
		{
			int num;
			int num1;
			Color color = new Color();
			Color color1;
			Color color2;
			this.TopMost = true;
			num = (!mdlMain.IsShowNoticeLink ? checked(MyProject.Forms.Mitibar.Height * 5) : checked(MyProject.Forms.Mitibar.Height * 6));
			num1 = (checked(MyProject.Computer.Screen.WorkingArea.Height - MyProject.Forms.Mitibar.Top) <= checked(num + MyProject.Forms.Mitibar.Height) ? checked(checked(MyProject.Forms.Mitibar.Top - num) - 1) : checked(checked(MyProject.Forms.Mitibar.Top + MyProject.Forms.Mitibar.Height) + 1));
			this.Height = num;
			this.Top = num1;
			this.Width = MyProject.Forms.Mitibar.Width;
			this.Left = MyProject.Forms.Mitibar.Left;
			this.picClose.Height = 16;
			this.picClose.Width = 16;
			this.picClose.Top = 5;
			this.picClose.Left = checked(checked(this.Width - this.picClose.Width) - 5);
			this.txtNotice.Left = 4;
			this.txtNotice.Top = 4;
			this.txtNotice.Height = checked(this.Height - 4);
			this.txtNotice.Width = checked(checked(this.Width - this.picClose.Width) - 12);
			if (mdlMain.IsShowNoticeLink)
			{
				this.txtNotice.Height = checked(this.txtNotice.Height - 25);
				this.lblLink.Left = 0;
				this.lblLink.Top = checked(this.txtNotice.Top + this.txtNotice.Height);
				this.lblLink.Height = 25;
				this.lblLink.Width = this.Width;
				this.lblLink.BackColor = Color.LightGray;
				this.lblLink.Text = mdlMain.GsNoticeLinkTitle;
			}
			TextBox textBox = this.txtNotice;
			object item = MySettingsProperty.Settings["TextColor"];
			if (item != null)
			{
				color1 = (Color)item;
			}
			else
			{
				color1 = color;
			}
			textBox.ForeColor = color1;
			TextBox textBox1 = this.txtNotice;
			object obj = MySettingsProperty.Settings["BackColor"];
			if (obj != null)
			{
				color2 = (Color)obj;
			}
			else
			{
				color2 = color;
			}
			textBox1.BackColor = color2;
			this.BackColor = this.txtNotice.BackColor;
			this.txtNotice.Text = mdlMain.GsNotice;
			this.TopMost = true;
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}