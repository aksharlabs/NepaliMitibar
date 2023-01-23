using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using NepaliMitibar.My;
using NepaliMitibar.My.Resources;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	[DesignerGenerated]
	public class Splash : Form
	{
		private IContainer components;

		[AccessedThroughProperty("lblTitle")]
		private Label _lblTitle;

		[AccessedThroughProperty("lblVersion")]
		private Label _lblVersion;

		[AccessedThroughProperty("lblDevelopedby")]
		private Label _lblDevelopedby;

		[AccessedThroughProperty("lblNM")]
		private Label _lblNM;

		[AccessedThroughProperty("pbIcon")]
		private PictureBox _pbIcon;

		internal virtual Label lblDevelopedby
		{
			get
			{
				return this._lblDevelopedby;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDevelopedby = value;
			}
		}

		internal virtual Label lblNM
		{
			get
			{
				return this._lblNM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNM = value;
			}
		}

		internal virtual Label lblTitle
		{
			get
			{
				return this._lblTitle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTitle = value;
			}
		}

		internal virtual Label lblVersion
		{
			get
			{
				return this._lblVersion;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblVersion = value;
			}
		}

		internal virtual PictureBox pbIcon
		{
			get
			{
				return this._pbIcon;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pbIcon = value;
			}
		}

		public Splash()
		{
			Splash splash = this;
			base.Load += new EventHandler(splash.Splash_Load);
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
			this.lblTitle = new Label();
			this.lblVersion = new Label();
			this.lblDevelopedby = new Label();
			this.lblNM = new Label();
			this.pbIcon = new PictureBox();
			((ISupportInitialize)this.pbIcon).BeginInit();
			this.SuspendLayout();
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = Color.White;
			Label label = this.lblTitle;
			Point point = new Point(93, 28);
			label.Location = point;
			this.lblTitle.Name = "lblTitle";
			Label label1 = this.lblTitle;
			System.Drawing.Size size = new System.Drawing.Size(190, 32);
			label1.Size = size;
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Nepali Mitibar";
			this.lblVersion.AutoSize = true;
			this.lblVersion.BackColor = Color.Transparent;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblVersion.ForeColor = Color.White;
			Label label2 = this.lblVersion;
			point = new Point(95, 73);
			label2.Location = point;
			this.lblVersion.Name = "lblVersion";
			Label label3 = this.lblVersion;
			size = new System.Drawing.Size(93, 20);
			label3.Size = size;
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "Version 3.0";
			this.lblDevelopedby.AutoSize = true;
			this.lblDevelopedby.BackColor = Color.Transparent;
			this.lblDevelopedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.lblDevelopedby.ForeColor = Color.White;
			Label label4 = this.lblDevelopedby;
			point = new Point(95, 122);
			label4.Location = point;
			this.lblDevelopedby.Name = "lblDevelopedby";
			Label label5 = this.lblDevelopedby;
			size = new System.Drawing.Size(115, 20);
			label5.Size = size;
			this.lblDevelopedby.TabIndex = 2;
			this.lblDevelopedby.Text = "Developed by:";
			this.lblDevelopedby.TextAlign = ContentAlignment.MiddleRight;
			this.lblNM.AutoSize = true;
			this.lblNM.BackColor = Color.Transparent;
			this.lblNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblNM.ForeColor = Color.White;
			Label label6 = this.lblNM;
			point = new Point(95, 152);
			label6.Location = point;
			this.lblNM.Name = "lblNM";
			Label label7 = this.lblNM;
			size = new System.Drawing.Size(151, 40);
			label7.Size = size;
			this.lblNM.TabIndex = 3;
			this.lblNM.Text = "Naresh Manandhar\r\nCrystal Softworks\r\n";
			this.pbIcon.Image = Resources.icon;
			PictureBox pictureBox = this.pbIcon;
			point = new Point(23, 29);
			pictureBox.Location = point;
			this.pbIcon.Name = "pbIcon";
			PictureBox pictureBox1 = this.pbIcon;
			size = new System.Drawing.Size(64, 64);
			pictureBox1.Size = size;
			this.pbIcon.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pbIcon.TabIndex = 5;
			this.pbIcon.TabStop = false;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Black;
			size = new System.Drawing.Size(318, 223);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.pbIcon);
			this.Controls.Add(this.lblNM);
			this.Controls.Add(this.lblDevelopedby);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Splash";
			((ISupportInitialize)this.pbIcon).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Splash_Load(object sender, EventArgs e)
		{
			this.lblTitle.Text = "Nepali Mitibar";
			this.lblVersion.Text = string.Concat("Version ", Conversions.ToString(MyProject.Application.Info.Version.Major), ".", Conversions.ToString(MyProject.Application.Info.Version.Minor));
			this.lblDevelopedby.Text = "Developed by:";
			this.lblNM.Text = "Naresh Manandhar\r\nCrystal Softworks";
			this.pbIcon.Height = 52;
			this.pbIcon.Width = 52;
			this.pbIcon.Top = 20;
			this.pbIcon.Left = 20;
			this.lblTitle.Top = checked(this.pbIcon.Top + 5);
			this.lblTitle.Left = checked(checked(this.pbIcon.Left + this.pbIcon.Width) + 5);
			this.lblVersion.Top = checked(checked(this.lblTitle.Top + this.lblTitle.Height) + 5);
			this.lblVersion.Left = this.lblTitle.Left;
			this.lblDevelopedby.Top = checked(checked(this.pbIcon.Top + this.pbIcon.Height) + 20);
			this.lblDevelopedby.Left = this.lblTitle.Left;
			this.lblNM.Top = checked(checked(this.lblDevelopedby.Top + this.lblDevelopedby.Height) + 5);
			this.lblNM.Left = this.lblDevelopedby.Left;
			this.Width = checked(checked(this.lblTitle.Left + this.lblTitle.Width) + 20);
			this.Height = checked(checked(this.lblNM.Top + this.lblNM.Height) + 20);
		}
	}
}