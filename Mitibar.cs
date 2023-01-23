using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using NepaliMitibar.My;
using NepaliMitibar.My.Resources;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	[DesignerGenerated]
	public class Mitibar : Form
	{
		private IContainer components;

		[AccessedThroughProperty("lblBSDate")]
		private Label _lblBSDate;

		[AccessedThroughProperty("ContextMenuStrip1")]
		private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip1;

		[AccessedThroughProperty("mnuShowCalendar")]
		private ToolStripMenuItem _mnuShowCalendar;

		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripSeparator _ToolStripMenuItem2;

		[AccessedThroughProperty("mnuExit")]
		private ToolStripMenuItem _mnuExit;

		[AccessedThroughProperty("mnuAbout")]
		private ToolStripMenuItem _mnuAbout;

		[AccessedThroughProperty("mnuAlwaysOnTop")]
		private ToolStripMenuItem _mnuAlwaysOnTop;

		[AccessedThroughProperty("mnuSettings")]
		private ToolStripMenuItem _mnuSettings;

		[AccessedThroughProperty("mnuDateConverter")]
		private ToolStripMenuItem _mnuDateConverter;

		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("mnuViewNoticeBoard")]
		private ToolStripMenuItem _mnuViewNoticeBoard;

		[AccessedThroughProperty("mnuPosition")]
		private ToolStripMenuItem _mnuPosition;

		[AccessedThroughProperty("mnuTopLeft")]
		private ToolStripMenuItem _mnuTopLeft;

		[AccessedThroughProperty("mnuTopCenter")]
		private ToolStripMenuItem _mnuTopCenter;

		[AccessedThroughProperty("mnuBottomLeft")]
		private ToolStripMenuItem _mnuBottomLeft;

		[AccessedThroughProperty("mnuBottomCenter")]
		private ToolStripMenuItem _mnuBottomCenter;

		[AccessedThroughProperty("mnuBottomRight")]
		private ToolStripMenuItem _mnuBottomRight;

		[AccessedThroughProperty("mnuDateCalculator")]
		private ToolStripMenuItem _mnuDateCalculator;

		private bool IsDownloadNotice;

		private bool IsShowNotice;

		private int iNoticeVerL;

		private int iNoticeVerR;

		private bool bDrag;

		private int iMitibarTop;

		private int iMitibarLeft;

		private int iMouseX;

		private int iMouseY;

		internal virtual System.Windows.Forms.ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this._ContextMenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		internal virtual Label lblBSDate
		{
			get
			{
				return this._lblBSDate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.lblBSDate_DoubleClick);
				Mitibar mitibar1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(mitibar1.lblBSDate_MouseUp);
				Mitibar mitibar2 = this;
				MouseEventHandler mouseEventHandler1 = new MouseEventHandler(mitibar2.lblBSDate_MouseMove);
				Mitibar mitibar3 = this;
				EventHandler eventHandler1 = new EventHandler(mitibar3.lblBSDate_Click);
				Mitibar mitibar4 = this;
				MouseEventHandler mouseEventHandler2 = new MouseEventHandler(mitibar4.lblBSDate_MouseDown);
				if (this._lblBSDate != null)
				{
					this._lblBSDate.DoubleClick -= eventHandler;
					this._lblBSDate.MouseUp -= mouseEventHandler;
					this._lblBSDate.MouseMove -= mouseEventHandler1;
					this._lblBSDate.Click -= eventHandler1;
					this._lblBSDate.MouseDown -= mouseEventHandler2;
				}
				this._lblBSDate = value;
				if (this._lblBSDate != null)
				{
					this._lblBSDate.DoubleClick += eventHandler;
					this._lblBSDate.MouseUp += mouseEventHandler;
					this._lblBSDate.MouseMove += mouseEventHandler1;
					this._lblBSDate.Click += eventHandler1;
					this._lblBSDate.MouseDown += mouseEventHandler2;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuAbout
		{
			get
			{
				return this._mnuAbout;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuAbout_Click);
				if (this._mnuAbout != null)
				{
					this._mnuAbout.Click -= eventHandler;
				}
				this._mnuAbout = value;
				if (this._mnuAbout != null)
				{
					this._mnuAbout.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuAlwaysOnTop
		{
			get
			{
				return this._mnuAlwaysOnTop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuAlwaysOnTop_Click);
				if (this._mnuAlwaysOnTop != null)
				{
					this._mnuAlwaysOnTop.Click -= eventHandler;
				}
				this._mnuAlwaysOnTop = value;
				if (this._mnuAlwaysOnTop != null)
				{
					this._mnuAlwaysOnTop.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuBottomCenter
		{
			get
			{
				return this._mnuBottomCenter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuBottomCenter_Click);
				if (this._mnuBottomCenter != null)
				{
					this._mnuBottomCenter.Click -= eventHandler;
				}
				this._mnuBottomCenter = value;
				if (this._mnuBottomCenter != null)
				{
					this._mnuBottomCenter.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuBottomLeft
		{
			get
			{
				return this._mnuBottomLeft;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuBottomLeft_Click);
				if (this._mnuBottomLeft != null)
				{
					this._mnuBottomLeft.Click -= eventHandler;
				}
				this._mnuBottomLeft = value;
				if (this._mnuBottomLeft != null)
				{
					this._mnuBottomLeft.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuBottomRight
		{
			get
			{
				return this._mnuBottomRight;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuBottomRight_Click);
				if (this._mnuBottomRight != null)
				{
					this._mnuBottomRight.Click -= eventHandler;
				}
				this._mnuBottomRight = value;
				if (this._mnuBottomRight != null)
				{
					this._mnuBottomRight.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuDateCalculator
		{
			get
			{
				return this._mnuDateCalculator;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuDateCalculator_Click);
				if (this._mnuDateCalculator != null)
				{
					this._mnuDateCalculator.Click -= eventHandler;
				}
				this._mnuDateCalculator = value;
				if (this._mnuDateCalculator != null)
				{
					this._mnuDateCalculator.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuDateConverter
		{
			get
			{
				return this._mnuDateConverter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuDateConverter_Click);
				if (this._mnuDateConverter != null)
				{
					this._mnuDateConverter.Click -= eventHandler;
				}
				this._mnuDateConverter = value;
				if (this._mnuDateConverter != null)
				{
					this._mnuDateConverter.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuExit
		{
			get
			{
				return this._mnuExit;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuExit_Click);
				if (this._mnuExit != null)
				{
					this._mnuExit.Click -= eventHandler;
				}
				this._mnuExit = value;
				if (this._mnuExit != null)
				{
					this._mnuExit.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuPosition
		{
			get
			{
				return this._mnuPosition;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mnuPosition = value;
			}
		}

		internal virtual ToolStripMenuItem mnuSettings
		{
			get
			{
				return this._mnuSettings;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuSettings_Click);
				if (this._mnuSettings != null)
				{
					this._mnuSettings.Click -= eventHandler;
				}
				this._mnuSettings = value;
				if (this._mnuSettings != null)
				{
					this._mnuSettings.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuShowCalendar
		{
			get
			{
				return this._mnuShowCalendar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuShowCalendar_Click);
				if (this._mnuShowCalendar != null)
				{
					this._mnuShowCalendar.Click -= eventHandler;
				}
				this._mnuShowCalendar = value;
				if (this._mnuShowCalendar != null)
				{
					this._mnuShowCalendar.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuTopCenter
		{
			get
			{
				return this._mnuTopCenter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuTopCenter_Click);
				if (this._mnuTopCenter != null)
				{
					this._mnuTopCenter.Click -= eventHandler;
				}
				this._mnuTopCenter = value;
				if (this._mnuTopCenter != null)
				{
					this._mnuTopCenter.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuTopLeft
		{
			get
			{
				return this._mnuTopLeft;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuTopLeft_Click);
				if (this._mnuTopLeft != null)
				{
					this._mnuTopLeft.Click -= eventHandler;
				}
				this._mnuTopLeft = value;
				if (this._mnuTopLeft != null)
				{
					this._mnuTopLeft.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuViewNoticeBoard
		{
			get
			{
				return this._mnuViewNoticeBoard;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.mnuViewNoticeBoard_Click);
				if (this._mnuViewNoticeBoard != null)
				{
					this._mnuViewNoticeBoard.Click -= eventHandler;
				}
				this._mnuViewNoticeBoard = value;
				if (this._mnuViewNoticeBoard != null)
				{
					this._mnuViewNoticeBoard.Click += eventHandler;
				}
			}
		}

		internal virtual Timer Timer1
		{
			get
			{
				return this._Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Mitibar mitibar = this;
				EventHandler eventHandler = new EventHandler(mitibar.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripMenuItem2
		{
			get
			{
				return this._ToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem2 = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		public Mitibar()
		{
			Mitibar mitibar = this;
			base.MouseMove += new MouseEventHandler(mitibar.Mitibar_MouseMove);
			Mitibar mitibar1 = this;
			base.MouseUp += new MouseEventHandler(mitibar1.Mitibar_MouseUp);
			Mitibar mitibar2 = this;
			base.DoubleClick += new EventHandler(mitibar2.Mitibar_DoubleClick);
			Mitibar mitibar3 = this;
			base.FormClosed += new FormClosedEventHandler(mitibar3.Mitibar_FormClosed);
			Mitibar mitibar4 = this;
			base.Load += new EventHandler(mitibar4.Mitibar_Load);
			Mitibar mitibar5 = this;
			base.Shown += new EventHandler(mitibar5.Mitibar_Shown);
			Mitibar mitibar6 = this;
			base.MouseDown += new MouseEventHandler(mitibar6.Mitibar_MouseDown);
			this.IsDownloadNotice = false;
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

		private void DownloadNotice()
		{
			if (!mdlMain.IsInternetConnected())
			{
				return;
			}
			try
			{
				if (File.Exists(string.Concat(mdlMain.GsDataDir, "\\temp.txt")))
				{
					File.Delete(string.Concat(mdlMain.GsDataDir, "\\temp.txt"));
				}
				MyProject.Computer.Network.DownloadFile("http://nareshmdr.com.np/android_data/nepalicalendar/nmb_notice.txt", string.Concat(mdlMain.GsDataDir, "\\temp.txt"));
				if (File.Exists(mdlMain.GsNoticePath))
				{
					File.Delete(mdlMain.GsNoticePath);
				}
				MyProject.Computer.FileSystem.RenameFile(string.Concat(mdlMain.GsDataDir, "\\temp.txt"), "notice.txt");
				MySettingsProperty.Settings["DataDay"] = DateAndTime.Today.Day;
				this.ParseNotice();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			this.IsDownloadNotice = false;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Mitibar));
			this.lblBSDate = new Label();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuShowCalendar = new ToolStripMenuItem();
			this.mnuViewNoticeBoard = new ToolStripMenuItem();
			this.mnuDateConverter = new ToolStripMenuItem();
			this.mnuDateCalculator = new ToolStripMenuItem();
			this.ToolStripSeparator2 = new ToolStripSeparator();
			this.mnuAlwaysOnTop = new ToolStripMenuItem();
			this.mnuSettings = new ToolStripMenuItem();
			this.mnuPosition = new ToolStripMenuItem();
			this.mnuTopLeft = new ToolStripMenuItem();
			this.mnuTopCenter = new ToolStripMenuItem();
			this.mnuBottomLeft = new ToolStripMenuItem();
			this.mnuBottomCenter = new ToolStripMenuItem();
			this.mnuBottomRight = new ToolStripMenuItem();
			this.mnuAbout = new ToolStripMenuItem();
			this.ToolStripMenuItem2 = new ToolStripSeparator();
			this.mnuExit = new ToolStripMenuItem();
			this.Timer1 = new Timer(this.components);
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.lblBSDate.AutoSize = true;
			this.lblBSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblBSDate.ForeColor = Color.White;
			this.lblBSDate.Location = new Point(93, 43);
			Label label = this.lblBSDate;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label.Margin = padding;
			this.lblBSDate.Name = "lblBSDate";
			Label label1 = this.lblBSDate;
			System.Drawing.Size size = new System.Drawing.Size(212, 29);
			label1.Size = size;
			this.lblBSDate.TabIndex = 4;
			this.lblBSDate.Text = "२०७३ फाल्गुण १६ मंगलबार";
			this.lblBSDate.TextAlign = ContentAlignment.MiddleCenter;
			ToolStripItemCollection items = this.ContextMenuStrip1.Items;
			ToolStripItem[] toolStripSeparator2 = new ToolStripItem[] { this.mnuShowCalendar, this.mnuViewNoticeBoard, this.mnuDateConverter, this.mnuDateCalculator, this.ToolStripSeparator2, this.mnuAlwaysOnTop, this.mnuSettings, this.mnuPosition, this.mnuAbout, this.ToolStripMenuItem2, this.mnuExit };
			items.AddRange(toolStripSeparator2);
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
			size = new System.Drawing.Size(215, 232);
			contextMenuStrip1.Size = size;
			this.mnuShowCalendar.Image = Resources.calendar_16;
			this.mnuShowCalendar.Name = "mnuShowCalendar";
			ToolStripMenuItem toolStripMenuItem = this.mnuShowCalendar;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem.Size = size;
			this.mnuShowCalendar.Text = "View &Calendar";
			this.mnuViewNoticeBoard.Image = Resources.notifications_16;
			this.mnuViewNoticeBoard.Name = "mnuViewNoticeBoard";
			ToolStripMenuItem toolStripMenuItem1 = this.mnuViewNoticeBoard;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem1.Size = size;
			this.mnuViewNoticeBoard.Text = "View Notification";
			this.mnuDateConverter.Image = Resources.convert_16;
			this.mnuDateConverter.Name = "mnuDateConverter";
			ToolStripMenuItem toolStripMenuItem2 = this.mnuDateConverter;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem2.Size = size;
			this.mnuDateConverter.Text = "Date Co&nverter";
			this.mnuDateCalculator.Image = Resources.calculator_16;
			this.mnuDateCalculator.Name = "mnuDateCalculator";
			ToolStripMenuItem toolStripMenuItem3 = this.mnuDateCalculator;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem3.Size = size;
			this.mnuDateCalculator.Text = "Age/Date Calculator";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripSeparator toolStripSeparator = this.ToolStripSeparator2;
			size = new System.Drawing.Size(211, 6);
			toolStripSeparator.Size = size;
			this.mnuAlwaysOnTop.Checked = true;
			this.mnuAlwaysOnTop.CheckState = CheckState.Checked;
			this.mnuAlwaysOnTop.Name = "mnuAlwaysOnTop";
			ToolStripMenuItem toolStripMenuItem4 = this.mnuAlwaysOnTop;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem4.Size = size;
			this.mnuAlwaysOnTop.Text = "Always On &Top";
			this.mnuSettings.Image = Resources.settings_16;
			this.mnuSettings.Name = "mnuSettings";
			ToolStripMenuItem toolStripMenuItem5 = this.mnuSettings;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem5.Size = size;
			this.mnuSettings.Text = "&Settings...";
			ToolStripItemCollection dropDownItems = this.mnuPosition.DropDownItems;
			toolStripSeparator2 = new ToolStripItem[] { this.mnuTopLeft, this.mnuTopCenter, this.mnuBottomLeft, this.mnuBottomCenter, this.mnuBottomRight };
			dropDownItems.AddRange(toolStripSeparator2);
			this.mnuPosition.Name = "mnuPosition";
			ToolStripMenuItem toolStripMenuItem6 = this.mnuPosition;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem6.Size = size;
			this.mnuPosition.Text = "Position";
			this.mnuTopLeft.Name = "mnuTopLeft";
			ToolStripMenuItem toolStripMenuItem7 = this.mnuTopLeft;
			size = new System.Drawing.Size(175, 24);
			toolStripMenuItem7.Size = size;
			this.mnuTopLeft.Text = "Top Left";
			this.mnuTopCenter.Name = "mnuTopCenter";
			ToolStripMenuItem toolStripMenuItem8 = this.mnuTopCenter;
			size = new System.Drawing.Size(175, 24);
			toolStripMenuItem8.Size = size;
			this.mnuTopCenter.Text = "Top Center";
			this.mnuBottomLeft.Name = "mnuBottomLeft";
			ToolStripMenuItem toolStripMenuItem9 = this.mnuBottomLeft;
			size = new System.Drawing.Size(175, 24);
			toolStripMenuItem9.Size = size;
			this.mnuBottomLeft.Text = "Botton Left";
			this.mnuBottomCenter.Name = "mnuBottomCenter";
			ToolStripMenuItem toolStripMenuItem10 = this.mnuBottomCenter;
			size = new System.Drawing.Size(175, 24);
			toolStripMenuItem10.Size = size;
			this.mnuBottomCenter.Text = "Bottom Center";
			this.mnuBottomRight.Name = "mnuBottomRight";
			ToolStripMenuItem toolStripMenuItem11 = this.mnuBottomRight;
			size = new System.Drawing.Size(175, 24);
			toolStripMenuItem11.Size = size;
			this.mnuBottomRight.Text = "Bottom Right";
			this.mnuAbout.Name = "mnuAbout";
			ToolStripMenuItem toolStripMenuItem12 = this.mnuAbout;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem12.Size = size;
			this.mnuAbout.Text = "&About...";
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			ToolStripSeparator toolStripMenuItem21 = this.ToolStripMenuItem2;
			size = new System.Drawing.Size(211, 6);
			toolStripMenuItem21.Size = size;
			this.mnuExit.Image = Resources.cross;
			this.mnuExit.Name = "mnuExit";
			ToolStripMenuItem toolStripMenuItem13 = this.mnuExit;
			size = new System.Drawing.Size(214, 24);
			toolStripMenuItem13.Size = size;
			this.mnuExit.Text = "Exit";
			this.Timer1.Interval = 10000;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.RoyalBlue;
			size = new System.Drawing.Size(476, 117);
			this.ClientSize = size;
			this.Controls.Add(this.lblBSDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			padding = new System.Windows.Forms.Padding(4);
			this.Margin = padding;
			this.Name = "Mitibar";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.Manual;
			this.Text = "Nepali Mitibar";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblBSDate_Click(object sender, EventArgs e)
		{
		}

		private void lblBSDate_DoubleClick(object sender, EventArgs e)
		{
			this.mnuShowCalendar_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void lblBSDate_MouseDown(object sender, MouseEventArgs e)
		{
			this.Mitibar_MouseDown(RuntimeHelpers.GetObjectValue(sender), e);
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				this.ContextMenuStrip1.Show(new Point(Control.MousePosition.X, Control.MousePosition.Y));
			}
		}

		private void lblBSDate_MouseMove(object sender, MouseEventArgs e)
		{
			this.Mitibar_MouseMove(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void lblBSDate_MouseUp(object sender, MouseEventArgs e)
		{
			this.Mitibar_MouseUp(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void LoadSettings()
		{
			Color color = new Color();
			Color color1;
			Color color2;
			Label label = this.lblBSDate;
			object item = MySettingsProperty.Settings["TextColor"];
			if (item != null)
			{
				color1 = (Color)item;
			}
			else
			{
				color1 = color;
			}
			label.ForeColor = color1;
			object obj = MySettingsProperty.Settings["BackColor"];
			if (obj != null)
			{
				color2 = (Color)obj;
			}
			else
			{
				color2 = color;
			}
			this.BackColor = color2;
			this.iNoticeVerL = Conversions.ToInteger(MySettingsProperty.Settings["NoticeVer"]);
			this.TopMost = Conversions.ToBoolean(MySettingsProperty.Settings["TopMost"]);
			this.mnuAlwaysOnTop.Checked = this.TopMost;
		}

		private void Mitibar_DoubleClick(object sender, EventArgs e)
		{
			this.mnuShowCalendar_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Mitibar_FormClosed(object sender, FormClosedEventArgs e)
		{
			mdl_DB.DBDisconnect();
		}

		private void Mitibar_Load(object sender, EventArgs e)
		{
			this.TopMost = Conversions.ToBoolean(MySettingsProperty.Settings["TopMost"]);
			mdlMain.GsDataDir = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "\\nm\\nmb");
			mdl_DB.GsDBPath = string.Concat(mdlMain.GsDataDir, "\\nmb_pedb");
			mdlMain.GsNoticePath = string.Concat(mdlMain.GsDataDir, "\\notice.txt");
			if (!Directory.Exists(mdlMain.GsDataDir))
			{
				Directory.CreateDirectory(mdlMain.GsDataDir);
			}
			NepDate.LoadDateData();
			this.ShowDate();
			mdl_DB.DBConnect();
			this.ResizeMitibar();
			this.PositionMitibar(Conversions.ToInteger(MySettingsProperty.Settings["StartupPos"]));
			this.LoadSettings();
			this.ParseNotice();
			if (Conversions.ToInteger(MySettingsProperty.Settings["DataDay"]) == DateAndTime.Today.Day)
			{
				this.IsDownloadNotice = false;
			}
			else
			{
				this.IsDownloadNotice = true;
			}
			this.Timer1.Enabled = true;
		}

		private void Mitibar_MouseDown(object sender, MouseEventArgs e)
		{
			this.bDrag = true;
			Point position = System.Windows.Forms.Cursor.Position;
			this.iMouseX = checked(position.X - this.Left);
			position = System.Windows.Forms.Cursor.Position;
			this.iMouseY = checked(position.Y - this.Top);
		}

		private void Mitibar_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bDrag)
			{
				Point position = System.Windows.Forms.Cursor.Position;
				this.Top = checked(position.Y - this.iMouseY);
				position = System.Windows.Forms.Cursor.Position;
				this.Left = checked(position.X - this.iMouseX);
			}
		}

		private void Mitibar_MouseUp(object sender, MouseEventArgs e)
		{
			this.bDrag = false;
		}

		private void Mitibar_Shown(object sender, EventArgs e)
		{
			if (this.IsDownloadNotice)
			{
				this.DownloadNotice();
			}
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		private void mnuAlwaysOnTop_Click(object sender, EventArgs e)
		{
			if (!this.mnuAlwaysOnTop.Checked)
			{
				this.TopMost = true;
			}
			else
			{
				this.TopMost = false;
			}
			this.mnuAlwaysOnTop.Checked = this.TopMost;
		}

		private void mnuBottomCenter_Click(object sender, EventArgs e)
		{
			this.PositionMitibar(3);
		}

		private void mnuBottomLeft_Click(object sender, EventArgs e)
		{
			this.PositionMitibar(2);
		}

		private void mnuBottomRight_Click(object sender, EventArgs e)
		{
			this.PositionMitibar(4);
		}

		private void mnuDateCalculator_Click(object sender, EventArgs e)
		{
			MyProject.Forms.DateCalculator.Show();
		}

		private void mnuDateConverter_Click(object sender, EventArgs e)
		{
			MyProject.Forms.DateConverter.Show();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question | MsgBoxStyle.Exclamation, null) == MsgBoxResult.Yes)
			{
				this.Close();
			}
		}

		private void mnuSettings_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Settings.ShowDialog();
			if (!mdlMain.IsCanceled)
			{
				this.LoadSettings();
				this.ResizeMitibar();
				this.PositionMitibar(Conversions.ToInteger(MySettingsProperty.Settings["StartupPos"]));
			}
		}

		private void mnuShowCalendar_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Calendar.Show();
		}

		private void mnuTopCenter_Click(object sender, EventArgs e)
		{
			this.PositionMitibar(1);
		}

		private void mnuTopLeft_Click(object sender, EventArgs e)
		{
			this.PositionMitibar(0);
		}

		private void mnuViewNoticeBoard_Click(object sender, EventArgs e)
		{
			MyProject.Forms.NoticeBoard.Show();
		}

		private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			MyProject.Forms.Calendar.ShowDialog();
		}

		private void ParseNotice()
		{
			if (!MyProject.Computer.FileSystem.FileExists(mdlMain.GsNoticePath))
			{
				this.iNoticeVerR = -1;
				this.IsShowNotice = false;
				mdlMain.GsNotice = "Thank you for using Nepali Mitibar.\r\nFor more info, click on the link given below.";
				mdlMain.IsShowNoticeLink = true;
				mdlMain.GsNoticeLink = "http://nareshmdr.com.np";
				mdlMain.GsNoticeLinkTitle = "Visit nareshmdr.com.np";
				return;
			}
			try
			{
				string[] strArrays = File.ReadAllLines(mdlMain.GsNoticePath);
				string str = strArrays[0];
				char[] chrArray = new char[] { '=' };
				this.iNoticeVerR = Conversions.ToInteger(str.Split(chrArray).GetValue(1));
				string str1 = strArrays[2];
				chrArray = new char[] { '=' };
				this.IsShowNotice = Conversions.ToInteger(str1.Split(chrArray).GetValue(1)) == 1;
				string str2 = strArrays[3];
				chrArray = new char[] { '=' };
				mdlMain.GsNotice = Conversions.ToString(str2.Split(chrArray).GetValue(1));
				string gsNotice = mdlMain.GsNotice;
				chrArray = new char[] { '|' };
				string[] strArrays1 = gsNotice.Split(chrArray);
				mdlMain.GsNotice = strArrays1[0];
				short upperBound = checked((short)strArrays1.GetUpperBound(0));
				for (short i = 1; i <= upperBound; i = checked((short)(i + 1)))
				{
					mdlMain.GsNotice = string.Concat(mdlMain.GsNotice, "\r\n", strArrays1[i]);
				}
				string str3 = strArrays[4];
				chrArray = new char[] { '=' };
				mdlMain.GsNoticeLink = Conversions.ToString(str3.Split(chrArray).GetValue(1));
				string str4 = strArrays[5];
				chrArray = new char[] { '=' };
				mdlMain.GsNoticeLinkTitle = Conversions.ToString(str4.Split(chrArray).GetValue(1));
				string str5 = strArrays[6];
				chrArray = new char[] { '=' };
				mdlMain.IsShowNoticeLink = Conversions.ToInteger(str5.Split(chrArray).GetValue(1)) == 1;
				if (this.iNoticeVerR > this.iNoticeVerL)
				{
					MySettingsProperty.Settings["NoticeVer"] = this.iNoticeVerR;
					if (this.IsShowNotice)
					{
						MyProject.Forms.NoticeBoard.Show();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox("Error parsing notice data.", MsgBoxStyle.Exclamation, null);
				ProjectData.ClearProjectError();
			}
		}

		public void PositionMitibar(int iPosition)
		{
			Rectangle workingArea;
			if (iPosition == 0)
			{
				this.iMitibarTop = 0;
				this.iMitibarLeft = 0;
			}
			else if (iPosition == 1)
			{
				this.iMitibarTop = 0;
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarLeft = checked((int)Math.Round((double)workingArea.Width / 2 - (double)this.Width / 2));
			}
			else if (iPosition == 2)
			{
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarTop = checked(workingArea.Height - this.Height);
				this.iMitibarLeft = 0;
			}
			else if (iPosition != 3)
			{
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarTop = checked(workingArea.Height - this.Height);
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarLeft = checked(workingArea.Width - this.Width);
			}
			else
			{
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarTop = checked(workingArea.Height - this.Height);
				workingArea = MyProject.Computer.Screen.WorkingArea;
				this.iMitibarLeft = checked((int)Math.Round((double)workingArea.Width / 2 - (double)this.Width / 2));
			}
			this.Top = this.iMitibarTop;
			this.Left = this.iMitibarLeft;
		}

		public void ResizeMitibar()
		{
			this.lblBSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)mdlMain.arFontSize[Conversions.ToInteger(MySettingsProperty.Settings["FontSize"])]);
			this.lblBSDate.Top = 2;
			this.lblBSDate.Left = 10;
			this.Height = checked(checked(this.lblBSDate.Top + this.lblBSDate.Height) + 2);
			this.Width = checked(checked(this.lblBSDate.Left + this.lblBSDate.Width) + 10);
		}

		public void ShowDate()
		{
			string str = NepDate.AD2BS(DateAndTime.Today);
			string[] strArrays = Strings.Split(str, NepDate.sDateSep, -1, CompareMethod.Binary);
			mdlMain.GiCurBSYear = Conversions.ToShort(strArrays[0]);
			mdlMain.GiCurBSMonth = Conversions.ToShort(strArrays[1]);
			mdlMain.GiCurBSDay = Conversions.ToShort(strArrays[2]);
			Label label = this.lblBSDate;
			string[] strArrays1 = new string[] { mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSYear)), " ", NepDate.arBSMonthName[checked(mdlMain.GiCurBSMonth - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSDay)), " गते ", null, null };
			strArrays1[6] = NepDate.arBSDayName[(int)DateAndTime.Today.DayOfWeek];
			strArrays1[7] = "बार";
			label.Text = string.Concat(strArrays1);
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.ShowDate();
		}
	}
}