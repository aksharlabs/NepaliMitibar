using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using NepaliMitibar.My;
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
	public class Settings : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("gbMitibar")]
		private GroupBox _gbMitibar;

		[AccessedThroughProperty("lblBackColor")]
		private Label _lblBackColor;

		[AccessedThroughProperty("lblTextColor")]
		private Label _lblTextColor;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("ColorDialog1")]
		private ColorDialog _ColorDialog1;

		[AccessedThroughProperty("gbCalendar")]
		private GroupBox _gbCalendar;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("cboStartupPos")]
		private ComboBox _cboStartupPos;

		[AccessedThroughProperty("cbShowTithi")]
		private CheckBox _cbShowTithi;

		[AccessedThroughProperty("lblResetData")]
		private LinkLabel _lblResetData;

		[AccessedThroughProperty("cbAlwaysOnTop")]
		private CheckBox _cbAlwaysOnTop;

		[AccessedThroughProperty("cboFontSize")]
		private ComboBox _cboFontSize;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		internal virtual Button btnCancel
		{
			get
			{
				return this._btnCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Settings setting = this;
				EventHandler eventHandler = new EventHandler(setting.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= eventHandler;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnOK
		{
			get
			{
				return this._btnOK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Settings setting = this;
				EventHandler eventHandler = new EventHandler(setting.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= eventHandler;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += eventHandler;
				}
			}
		}

		internal virtual CheckBox cbAlwaysOnTop
		{
			get
			{
				return this._cbAlwaysOnTop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbAlwaysOnTop = value;
			}
		}

		internal virtual ComboBox cboFontSize
		{
			get
			{
				return this._cboFontSize;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboFontSize = value;
			}
		}

		internal virtual ComboBox cboStartupPos
		{
			get
			{
				return this._cboStartupPos;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboStartupPos = value;
			}
		}

		internal virtual CheckBox cbShowTithi
		{
			get
			{
				return this._cbShowTithi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbShowTithi = value;
			}
		}

		internal virtual ColorDialog ColorDialog1
		{
			get
			{
				return this._ColorDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColorDialog1 = value;
			}
		}

		internal virtual GroupBox gbCalendar
		{
			get
			{
				return this._gbCalendar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbCalendar = value;
			}
		}

		internal virtual GroupBox gbMitibar
		{
			get
			{
				return this._gbMitibar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbMitibar = value;
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label lblBackColor
		{
			get
			{
				return this._lblBackColor;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Settings setting = this;
				EventHandler eventHandler = new EventHandler(setting.lblBackColor_Click);
				if (this._lblBackColor != null)
				{
					this._lblBackColor.Click -= eventHandler;
				}
				this._lblBackColor = value;
				if (this._lblBackColor != null)
				{
					this._lblBackColor.Click += eventHandler;
				}
			}
		}

		internal virtual LinkLabel lblResetData
		{
			get
			{
				return this._lblResetData;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Settings setting = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(setting.lblResetData_LinkClicked);
				if (this._lblResetData != null)
				{
					this._lblResetData.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._lblResetData = value;
				if (this._lblResetData != null)
				{
					this._lblResetData.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual Label lblTextColor
		{
			get
			{
				return this._lblTextColor;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Settings setting = this;
				EventHandler eventHandler = new EventHandler(setting.lblTextColor_Click);
				if (this._lblTextColor != null)
				{
					this._lblTextColor.Click -= eventHandler;
				}
				this._lblTextColor = value;
				if (this._lblTextColor != null)
				{
					this._lblTextColor.Click += eventHandler;
				}
			}
		}

		public Settings()
		{
			Settings setting = this;
			base.Load += new EventHandler(setting.Settings_Load);
			this.InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			mdlMain.IsCanceled = true;
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.cboStartupPos.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid settings.", MsgBoxStyle.Information, null);
				return;
			}
			MySettingsProperty.Settings["TextColor"] = this.lblTextColor.BackColor;
			MySettingsProperty.Settings["BackColor"] = this.lblBackColor.BackColor;
			MySettingsProperty.Settings["FontSize"] = this.cboFontSize.SelectedIndex;
			MySettingsProperty.Settings["TopMost"] = this.cbAlwaysOnTop.Checked;
			MySettingsProperty.Settings["StartupPos"] = this.cboStartupPos.SelectedIndex;
			MySettingsProperty.Settings["ShowTithi"] = this.cbShowTithi.Checked;
			MySettingsProperty.Settings.Save();
			mdlMain.IsCanceled = false;
			this.Close();
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
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.gbMitibar = new GroupBox();
			this.cbAlwaysOnTop = new CheckBox();
			this.Label3 = new Label();
			this.cboStartupPos = new ComboBox();
			this.lblBackColor = new Label();
			this.lblTextColor = new Label();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.ColorDialog1 = new ColorDialog();
			this.gbCalendar = new GroupBox();
			this.cbShowTithi = new CheckBox();
			this.lblResetData = new LinkLabel();
			this.Label4 = new Label();
			this.cboFontSize = new ComboBox();
			this.gbMitibar.SuspendLayout();
			this.gbCalendar.SuspendLayout();
			this.SuspendLayout();
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button = this.btnOK;
			Point point = new Point(308, 30);
			button.Location = point;
			Button button1 = this.btnOK;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(4);
			button1.Margin = padding;
			this.btnOK.Name = "btnOK";
			Button button2 = this.btnOK;
			System.Drawing.Size size = new System.Drawing.Size(121, 41);
			button2.Size = size;
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button3 = this.btnCancel;
			point = new Point(308, 78);
			button3.Location = point;
			Button button4 = this.btnCancel;
			padding = new System.Windows.Forms.Padding(4);
			button4.Margin = padding;
			this.btnCancel.Name = "btnCancel";
			Button button5 = this.btnCancel;
			size = new System.Drawing.Size(121, 41);
			button5.Size = size;
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.gbMitibar.Controls.Add(this.cboFontSize);
			this.gbMitibar.Controls.Add(this.Label4);
			this.gbMitibar.Controls.Add(this.cbAlwaysOnTop);
			this.gbMitibar.Controls.Add(this.Label3);
			this.gbMitibar.Controls.Add(this.cboStartupPos);
			this.gbMitibar.Controls.Add(this.lblBackColor);
			this.gbMitibar.Controls.Add(this.lblTextColor);
			this.gbMitibar.Controls.Add(this.Label2);
			this.gbMitibar.Controls.Add(this.Label1);
			this.gbMitibar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox = this.gbMitibar;
			point = new Point(18, 18);
			groupBox.Location = point;
			GroupBox groupBox1 = this.gbMitibar;
			padding = new System.Windows.Forms.Padding(4);
			groupBox1.Margin = padding;
			this.gbMitibar.Name = "gbMitibar";
			GroupBox groupBox2 = this.gbMitibar;
			padding = new System.Windows.Forms.Padding(4);
			groupBox2.Padding = padding;
			GroupBox groupBox3 = this.gbMitibar;
			size = new System.Drawing.Size(258, 291);
			groupBox3.Size = size;
			this.gbMitibar.TabIndex = 2;
			this.gbMitibar.TabStop = false;
			this.gbMitibar.Text = "Mitibar";
			this.cbAlwaysOnTop.AutoSize = true;
			CheckBox checkBox = this.cbAlwaysOnTop;
			point = new Point(17, 156);
			checkBox.Location = point;
			this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
			CheckBox checkBox1 = this.cbAlwaysOnTop;
			size = new System.Drawing.Size(135, 24);
			checkBox1.Size = size;
			this.cbAlwaysOnTop.TabIndex = 7;
			this.cbAlwaysOnTop.Text = "Always on top";
			this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(13, 194);
			label3.Location = point;
			Label label = this.Label3;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label.Margin = padding;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(133, 20);
			label31.Size = size;
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Startup Position:";
			this.cboStartupPos.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboStartupPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboStartupPos.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cboStartupPos.Items;
			object[] objArray = new object[] { "Top Left", "Top Center", "Bottom Left", "Bottom Center", "Bottom Right" };
			items.AddRange(objArray);
			ComboBox comboBox = this.cboStartupPos;
			point = new Point(12, 226);
			comboBox.Location = point;
			this.cboStartupPos.Name = "cboStartupPos";
			ComboBox comboBox1 = this.cboStartupPos;
			size = new System.Drawing.Size(234, 28);
			comboBox1.Size = size;
			this.cboStartupPos.TabIndex = 0;
			this.lblBackColor.BackColor = Color.RoyalBlue;
			this.lblBackColor.BorderStyle = BorderStyle.FixedSingle;
			Label label1 = this.lblBackColor;
			point = new Point(128, 70);
			label1.Location = point;
			Label label2 = this.lblBackColor;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Margin = padding;
			this.lblBackColor.Name = "lblBackColor";
			Label label4 = this.lblBackColor;
			size = new System.Drawing.Size(43, 35);
			label4.Size = size;
			this.lblBackColor.TabIndex = 3;
			this.lblTextColor.BackColor = Color.White;
			this.lblTextColor.BorderStyle = BorderStyle.FixedSingle;
			Label label5 = this.lblTextColor;
			point = new Point(128, 26);
			label5.Location = point;
			Label label6 = this.lblTextColor;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label6.Margin = padding;
			this.lblTextColor.Name = "lblTextColor";
			Label label7 = this.lblTextColor;
			size = new System.Drawing.Size(43, 35);
			label7.Size = size;
			this.lblTextColor.TabIndex = 2;
			this.Label2.AutoSize = true;
			Label label21 = this.Label2;
			point = new Point(13, 77);
			label21.Location = point;
			Label label22 = this.Label2;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label22.Margin = padding;
			this.Label2.Name = "Label2";
			Label label23 = this.Label2;
			size = new System.Drawing.Size(97, 20);
			label23.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Back Color:";
			this.Label1.AutoSize = true;
			Label label11 = this.Label1;
			point = new Point(13, 34);
			label11.Location = point;
			Label label12 = this.Label1;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label12.Margin = padding;
			this.Label1.Name = "Label1";
			Label label13 = this.Label1;
			size = new System.Drawing.Size(91, 20);
			label13.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Text Color:";
			this.gbCalendar.Controls.Add(this.cbShowTithi);
			this.gbCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox4 = this.gbCalendar;
			point = new Point(18, 316);
			groupBox4.Location = point;
			this.gbCalendar.Name = "gbCalendar";
			GroupBox groupBox5 = this.gbCalendar;
			size = new System.Drawing.Size(258, 74);
			groupBox5.Size = size;
			this.gbCalendar.TabIndex = 5;
			this.gbCalendar.TabStop = false;
			this.gbCalendar.Text = "Calendar";
			this.cbShowTithi.AutoSize = true;
			CheckBox checkBox2 = this.cbShowTithi;
			point = new Point(12, 35);
			checkBox2.Location = point;
			this.cbShowTithi.Name = "cbShowTithi";
			CheckBox checkBox3 = this.cbShowTithi;
			size = new System.Drawing.Size(109, 24);
			checkBox3.Size = size;
			this.cbShowTithi.TabIndex = 1;
			this.cbShowTithi.Text = "Show Tithi";
			this.cbShowTithi.UseVisualStyleBackColor = true;
			this.lblResetData.AutoSize = true;
			this.lblResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			LinkLabel linkLabel = this.lblResetData;
			point = new Point(21, 405);
			linkLabel.Location = point;
			this.lblResetData.Name = "lblResetData";
			LinkLabel linkLabel1 = this.lblResetData;
			size = new System.Drawing.Size(94, 20);
			linkLabel1.Size = size;
			this.lblResetData.TabIndex = 6;
			this.lblResetData.TabStop = true;
			this.lblResetData.Text = "Reset Data";
			this.Label4.AutoSize = true;
			Label label41 = this.Label4;
			point = new Point(13, 119);
			label41.Location = point;
			Label label42 = this.Label4;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label42.Margin = padding;
			this.Label4.Name = "Label4";
			Label label43 = this.Label4;
			size = new System.Drawing.Size(85, 20);
			label43.Size = size;
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Font Size:";
			this.cboFontSize.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboFontSize.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.cboFontSize.Items;
			objArray = new object[] { "8", "10", "12", "14", "16", "18" };
			objectCollections.AddRange(objArray);
			ComboBox comboBox2 = this.cboFontSize;
			point = new Point(128, 116);
			comboBox2.Location = point;
			this.cboFontSize.Name = "cboFontSize";
			ComboBox comboBox3 = this.cboFontSize;
			size = new System.Drawing.Size(118, 28);
			comboBox3.Size = size;
			this.cboFontSize.TabIndex = 9;
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			size = new System.Drawing.Size(695, 619);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.lblResetData);
			this.Controls.Add(this.gbCalendar);
			this.Controls.Add(this.gbMitibar);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			padding = new System.Windows.Forms.Padding(4);
			this.Margin = padding;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.gbMitibar.ResumeLayout(false);
			this.gbMitibar.PerformLayout();
			this.gbCalendar.ResumeLayout(false);
			this.gbCalendar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblBackColor_Click(object sender, EventArgs e)
		{
			if (this.ColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.lblBackColor.BackColor = this.ColorDialog1.Color;
			}
		}

		private void lblResetData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question | MsgBoxStyle.Exclamation, null) == MsgBoxResult.Yes)
			{
				try
				{
					mdl_DB.DBDisconnect();
					MyProject.Computer.FileSystem.DeleteFile(mdl_DB.GsDBPath);
					MyProject.Computer.FileSystem.DeleteFile(mdlMain.GsNoticePath);
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					Interaction.MsgBox("Error occurred while reseting data.", MsgBoxStyle.Exclamation, null);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void lblTextColor_Click(object sender, EventArgs e)
		{
			if (this.ColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.lblTextColor.BackColor = this.ColorDialog1.Color;
			}
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			Color color = new Color();
			Color color1;
			Color color2;
			this.Width = checked(checked(this.btnOK.Left + this.btnOK.Width) + 30);
			this.Height = checked(checked(this.gbCalendar.Top + this.gbCalendar.Height) + 80);
			Label label = this.lblTextColor;
			object item = MySettingsProperty.Settings["TextColor"];
			if (item != null)
			{
				color1 = (Color)item;
			}
			else
			{
				color1 = color;
			}
			label.BackColor = color1;
			Label label1 = this.lblBackColor;
			object obj = MySettingsProperty.Settings["BackColor"];
			if (obj != null)
			{
				color2 = (Color)obj;
			}
			else
			{
				color2 = color;
			}
			label1.BackColor = color2;
			this.cboFontSize.SelectedIndex = Conversions.ToInteger(MySettingsProperty.Settings["FontSize"]);
			this.cbAlwaysOnTop.Checked = Conversions.ToBoolean(MySettingsProperty.Settings["TopMost"]);
			this.cboStartupPos.SelectedIndex = Conversions.ToInteger(MySettingsProperty.Settings["StartupPos"]);
			this.cbShowTithi.Checked = Conversions.ToBoolean(MySettingsProperty.Settings["ShowTithi"]);
		}
	}
}