using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using NepaliMitibar.My;
using NepaliMitibar.My.Resources;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	[DesignerGenerated]
	public class Calendar : Form
	{
		private IContainer components;

		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		[AccessedThroughProperty("mnuFile")]
		private ToolStripMenuItem _mnuFile;

		[AccessedThroughProperty("mnuHelp")]
		private ToolStripMenuItem _mnuHelp;

		[AccessedThroughProperty("mnuAbout")]
		private ToolStripMenuItem _mnuAbout;

		[AccessedThroughProperty("pnlStatus")]
		private Panel _pnlStatus;

		[AccessedThroughProperty("lblStatus")]
		private Label _lblStatus;

		[AccessedThroughProperty("mnuExit")]
		private ToolStripMenuItem _mnuExit;

		[AccessedThroughProperty("CalendarToolStripMenuItem")]
		private ToolStripMenuItem _CalendarToolStripMenuItem;

		[AccessedThroughProperty("mnuUpdateData")]
		private ToolStripMenuItem _mnuUpdateData;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[AccessedThroughProperty("mnuShowTithi")]
		private ToolStripMenuItem _mnuShowTithi;

		[AccessedThroughProperty("mnuToday")]
		private ToolStripMenuItem _mnuToday;

		[AccessedThroughProperty("lblFS14")]
		private Label _lblFS14;

		[AccessedThroughProperty("lblFS15")]
		private Label _lblFS15;

		[AccessedThroughProperty("lblFS16")]
		private Label _lblFS16;

		[AccessedThroughProperty("lblFS18")]
		private Label _lblFS18;

		[AccessedThroughProperty("lblFS8")]
		private Label _lblFS8;

		[AccessedThroughProperty("pnlTop")]
		private Panel _pnlTop;

		[AccessedThroughProperty("pnlBody")]
		private Panel _pnlBody;

		[AccessedThroughProperty("tabEvents")]
		private TabControl _tabEvents;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("txtSelectedEvent")]
		private TextBox _txtSelectedEvent;

		[AccessedThroughProperty("lvEvents")]
		private ListView _lvEvents;

		[AccessedThroughProperty("d")]
		private ColumnHeader _d;

		[AccessedThroughProperty("e")]
		private ColumnHeader _e;

		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		[AccessedThroughProperty("pnlCalendar")]
		private Panel _pnlCalendar;

		[AccessedThroughProperty("btnToday")]
		private Button _btnToday;

		[AccessedThroughProperty("btnMonthDown")]
		private Button _btnMonthDown;

		[AccessedThroughProperty("btnMonthUp")]
		private Button _btnMonthUp;

		[AccessedThroughProperty("lblBSSelDay")]
		private Label _lblBSSelDay;

		[AccessedThroughProperty("lblADYearMonth")]
		private Label _lblADYearMonth;

		[AccessedThroughProperty("lblBSYearMonth")]
		private Label _lblBSYearMonth;

		[AccessedThroughProperty("cboBSMonth")]
		private ComboBox _cboBSMonth;

		[AccessedThroughProperty("cboBSYear")]
		private ComboBox _cboBSYear;

		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		[AccessedThroughProperty("lblFS6")]
		private Label _lblFS6;

		[AccessedThroughProperty("txtSelectedEventM")]
		private TextBox _txtSelectedEventM;

		[AccessedThroughProperty("lvEventsM")]
		private ListView _lvEventsM;

		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		private bool IsUserClick;

		private int a;

		private int b;

		private Label[] lblDayA;

		private Label[] lblDayB;

		private Label[] lblME;

		private Label[] lblUE;

		private short ilblDayPrevIndex;

		private short[] iLVItemIndex;

		private bool IsShowTithi;

		private short iSelYear;

		private short iSelMonth;

		private Color colorDayText;

		private Color colorDayBg;

		private Color colorSelDayBg;

		private Color colorHolidayText;

		private Color colorTodayBg;

		private Color colorMEText;

		private Color colorMEBg;

		private Color colorUEText;

		private Color colorUEBg;

		internal virtual Button btnMonthDown
		{
			get
			{
				return this._btnMonthDown;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.btnMonthDown_Click);
				if (this._btnMonthDown != null)
				{
					this._btnMonthDown.Click -= eventHandler;
				}
				this._btnMonthDown = value;
				if (this._btnMonthDown != null)
				{
					this._btnMonthDown.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnMonthUp
		{
			get
			{
				return this._btnMonthUp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.btnMonthUp_Click);
				if (this._btnMonthUp != null)
				{
					this._btnMonthUp.Click -= eventHandler;
				}
				this._btnMonthUp = value;
				if (this._btnMonthUp != null)
				{
					this._btnMonthUp.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnToday
		{
			get
			{
				return this._btnToday;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.btnToday_Click);
				if (this._btnToday != null)
				{
					this._btnToday.Click -= eventHandler;
				}
				this._btnToday = value;
				if (this._btnToday != null)
				{
					this._btnToday.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem CalendarToolStripMenuItem
		{
			get
			{
				return this._CalendarToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CalendarToolStripMenuItem = value;
			}
		}

		internal virtual ComboBox cboBSMonth
		{
			get
			{
				return this._cboBSMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.cboBSMonth_SelectedIndexChanged);
				if (this._cboBSMonth != null)
				{
					this._cboBSMonth.SelectedIndexChanged -= eventHandler;
				}
				this._cboBSMonth = value;
				if (this._cboBSMonth != null)
				{
					this._cboBSMonth.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboBSYear
		{
			get
			{
				return this._cboBSYear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.cboBSYear_SelectedIndexChanged);
				if (this._cboBSYear != null)
				{
					this._cboBSYear.SelectedIndexChanged -= eventHandler;
				}
				this._cboBSYear = value;
				if (this._cboBSYear != null)
				{
					this._cboBSYear.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader1
		{
			get
			{
				return this._ColumnHeader1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader1 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader2
		{
			get
			{
				return this._ColumnHeader2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader2 = value;
			}
		}

		internal virtual ColumnHeader d
		{
			get
			{
				return this._d;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._d = value;
			}
		}

		internal virtual ColumnHeader e
		{
			get
			{
				return this._e;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._e = value;
			}
		}

		internal virtual ImageList ImageList1
		{
			get
			{
				return this._ImageList1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageList1 = value;
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

		internal virtual Label lblADYearMonth
		{
			get
			{
				return this._lblADYearMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblADYearMonth = value;
			}
		}

		internal virtual Label lblBSSelDay
		{
			get
			{
				return this._lblBSSelDay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblBSSelDay = value;
			}
		}

		internal virtual Label lblBSYearMonth
		{
			get
			{
				return this._lblBSYearMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblBSYearMonth = value;
			}
		}

		internal virtual Label lblFS14
		{
			get
			{
				return this._lblFS14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS14 = value;
			}
		}

		internal virtual Label lblFS15
		{
			get
			{
				return this._lblFS15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS15 = value;
			}
		}

		internal virtual Label lblFS16
		{
			get
			{
				return this._lblFS16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS16 = value;
			}
		}

		internal virtual Label lblFS18
		{
			get
			{
				return this._lblFS18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS18 = value;
			}
		}

		internal virtual Label lblFS6
		{
			get
			{
				return this._lblFS6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS6 = value;
			}
		}

		internal virtual Label lblFS8
		{
			get
			{
				return this._lblFS8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFS8 = value;
			}
		}

		internal virtual Label lblStatus
		{
			get
			{
				return this._lblStatus;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStatus = value;
			}
		}

		internal virtual ListView lvEvents
		{
			get
			{
				return this._lvEvents;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.lvEvents_DoubleClick);
				Calendar calendar1 = this;
				EventHandler eventHandler1 = new EventHandler(calendar1.lvEvents_Click);
				if (this._lvEvents != null)
				{
					this._lvEvents.DoubleClick -= eventHandler;
					this._lvEvents.Click -= eventHandler1;
				}
				this._lvEvents = value;
				if (this._lvEvents != null)
				{
					this._lvEvents.DoubleClick += eventHandler;
					this._lvEvents.Click += eventHandler1;
				}
			}
		}

		internal virtual ListView lvEventsM
		{
			get
			{
				return this._lvEventsM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.lvEventsM_Click);
				if (this._lvEventsM != null)
				{
					this._lvEventsM.Click -= eventHandler;
				}
				this._lvEventsM = value;
				if (this._lvEventsM != null)
				{
					this._lvEventsM.Click += eventHandler;
				}
			}
		}

		internal virtual MenuStrip MenuStrip1
		{
			get
			{
				return this._MenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
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
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.mnuAbout_Click);
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

		internal virtual ToolStripMenuItem mnuExit
		{
			get
			{
				return this._mnuExit;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.mnuExit_Click);
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

		internal virtual ToolStripMenuItem mnuFile
		{
			get
			{
				return this._mnuFile;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mnuFile = value;
			}
		}

		internal virtual ToolStripMenuItem mnuHelp
		{
			get
			{
				return this._mnuHelp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mnuHelp = value;
			}
		}

		internal virtual ToolStripMenuItem mnuShowTithi
		{
			get
			{
				return this._mnuShowTithi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.mnuShowTithi_Click);
				if (this._mnuShowTithi != null)
				{
					this._mnuShowTithi.Click -= eventHandler;
				}
				this._mnuShowTithi = value;
				if (this._mnuShowTithi != null)
				{
					this._mnuShowTithi.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuToday
		{
			get
			{
				return this._mnuToday;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.mnuToday_Click);
				if (this._mnuToday != null)
				{
					this._mnuToday.Click -= eventHandler;
				}
				this._mnuToday = value;
				if (this._mnuToday != null)
				{
					this._mnuToday.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem mnuUpdateData
		{
			get
			{
				return this._mnuUpdateData;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.mnuUpdateData_Click);
				if (this._mnuUpdateData != null)
				{
					this._mnuUpdateData.Click -= eventHandler;
				}
				this._mnuUpdateData = value;
				if (this._mnuUpdateData != null)
				{
					this._mnuUpdateData.Click += eventHandler;
				}
			}
		}

		internal virtual Panel pnlBody
		{
			get
			{
				return this._pnlBody;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlBody = value;
			}
		}

		internal virtual Panel pnlCalendar
		{
			get
			{
				return this._pnlCalendar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlCalendar = value;
			}
		}

		internal virtual Panel pnlStatus
		{
			get
			{
				return this._pnlStatus;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.pnlStatus_Click);
				if (this._pnlStatus != null)
				{
					this._pnlStatus.Click -= eventHandler;
				}
				this._pnlStatus = value;
				if (this._pnlStatus != null)
				{
					this._pnlStatus.Click += eventHandler;
				}
			}
		}

		internal virtual Panel pnlTop
		{
			get
			{
				return this._pnlTop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pnlTop = value;
			}
		}

		internal virtual TabControl tabEvents
		{
			get
			{
				return this._tabEvents;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tabEvents = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			get
			{
				return this._TabPage1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		internal virtual TabPage TabPage2
		{
			get
			{
				return this._TabPage2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage2 = value;
			}
		}

		internal virtual TabPage TabPage3
		{
			get
			{
				return this._TabPage3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage3 = value;
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
				Calendar calendar = this;
				EventHandler eventHandler = new EventHandler(calendar.Timer1_Tick);
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

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		internal virtual TextBox txtSelectedEvent
		{
			get
			{
				return this._txtSelectedEvent;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtSelectedEvent = value;
			}
		}

		internal virtual TextBox txtSelectedEventM
		{
			get
			{
				return this._txtSelectedEventM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtSelectedEventM = value;
			}
		}

		public Calendar()
		{
			Calendar calendar = this;
			base.HandleDestroyed += new EventHandler(calendar.Calendar_HandleDestroyed);
			Calendar calendar1 = this;
			base.Load += new EventHandler(calendar1.Calendar_Load);
			this.lblDayA = new Label[43];
			this.lblDayB = new Label[43];
			this.lblME = new Label[43];
			this.lblUE = new Label[43];
			this.ilblDayPrevIndex = 0;
			this.iLVItemIndex = new short[42];
			this.colorDayText = Color.DimGray;
			this.colorDayBg = Color.White;
			this.colorSelDayBg = Color.LightSteelBlue;
			this.colorHolidayText = Color.Red;
			this.colorTodayBg = Color.SkyBlue;
			this.colorMEText = Color.White;
			this.colorMEBg = Color.Red;
			this.colorUEText = Color.White;
			this.colorUEBg = Color.RoyalBlue;
			this.InitializeComponent();
		}

		private void btnMonthDown_Click(object sender, EventArgs e)
		{
			if (this.cboBSMonth.SelectedIndex != 11)
			{
				this.cboBSMonth.SelectedIndex = checked(this.cboBSMonth.SelectedIndex + 1);
			}
			else if (this.cboBSYear.SelectedIndex < 120)
			{
				this.cboBSYear.SelectedIndex = checked(this.cboBSYear.SelectedIndex + 1);
				this.cboBSMonth.SelectedIndex = 0;
			}
		}

		private void btnMonthUp_Click(object sender, EventArgs e)
		{
			if (this.cboBSMonth.SelectedIndex != 0)
			{
				this.cboBSMonth.SelectedIndex = checked(this.cboBSMonth.SelectedIndex - 1);
			}
			else if (this.cboBSYear.SelectedIndex > 0)
			{
				this.cboBSYear.SelectedIndex = checked(this.cboBSYear.SelectedIndex - 1);
				this.cboBSMonth.SelectedIndex = 11;
			}
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			this.mnuToday_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Calendar_HandleDestroyed(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void Calendar_Load(object sender, EventArgs e)
		{
			this.IsUserClick = true;
			this.mnuShowTithi.Checked = Conversions.ToBoolean(MySettingsProperty.Settings["ShowTithi"]);
			this.IsShowTithi = this.mnuShowTithi.Checked;
			mdlMain.LoadCurBSDate();
			this.InitCtrl();
			this.CreateCalendar();
			this.FillCalendar(mdlMain.GiCurBSYear, mdlMain.GiCurBSMonth, mdlMain.GiCurBSDay);
			Label label = this.lblBSSelDay;
			string[] strArrays = new string[] { mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSYear)), " ", NepDate.arBSMonthName[checked(mdlMain.GiCurBSMonth - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSDay)), ", ", null, null };
			strArrays[6] = NepDate.arBSDayName[(int)DateAndTime.Today.DayOfWeek];
			strArrays[7] = "बार";
			label.Text = string.Concat(strArrays);
			this.Text = string.Concat("Nepali Calendar (", this.lblBSSelDay.Text, ")");
			this.SetStatus(string.Concat("Data last updated on ", this.GetDBLastUpdated()), Color.Black);
			this.SetBSYearMonthIndex(mdlMain.GiCurBSYear, mdlMain.GiCurBSMonth);
		}

		private void cboBSMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cboBSYear_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cboBSYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cboBSYear.SelectedIndex >= 0 & this.cboBSMonth.SelectedIndex >= 0)
			{
				this.iSelYear = mdlMain.NepNum2Num(this.cboBSYear.SelectedItem.ToString());
				this.iSelMonth = checked((short)(checked(this.cboBSMonth.SelectedIndex + 1)));
				if (!(this.iSelYear == mdlMain.GiCurBSYear & this.iSelMonth == mdlMain.GiCurBSMonth))
				{
					this.FillCalendar(this.iSelYear, this.iSelMonth, 0);
				}
				else
				{
					this.FillCalendar(this.iSelYear, this.iSelMonth, mdlMain.GiCurBSDay);
				}
			}
		}

		private void CreateCalendar()
		{
			Label label;
			Label red;
			System.Drawing.Size size;
			Point point;
			this.pnlCalendar.Top = 10;
			this.pnlCalendar.Left = 20;
			short num = 0;
			this.cboBSYear.Top = 5;
			this.cboBSYear.Left = 5;
			this.cboBSMonth.Top = this.cboBSYear.Top;
			this.cboBSMonth.Left = checked(checked(this.cboBSYear.Left + this.cboBSYear.Width) + 5);
			this.btnMonthUp.Top = this.cboBSYear.Top;
			this.btnMonthUp.Left = checked(checked(this.cboBSMonth.Left + this.cboBSMonth.Width) + 5);
			this.btnMonthUp.Height = this.cboBSYear.Height;
			this.btnMonthUp.Width = this.cboBSYear.Height;
			this.btnMonthDown.Top = this.btnMonthUp.Top;
			this.btnMonthDown.Left = checked(checked(this.btnMonthUp.Left + this.btnMonthUp.Width) + 5);
			this.btnMonthDown.Height = this.btnMonthUp.Height;
			this.btnMonthDown.Width = this.btnMonthUp.Width;
			this.btnToday.Top = this.btnMonthUp.Top;
			this.btnToday.Left = checked(checked(this.btnMonthDown.Left + this.btnMonthDown.Width) + 5);
			this.btnToday.Height = this.btnMonthUp.Height;
			this.btnToday.Width = this.btnMonthUp.Width;
			this.lblBSYearMonth.Top = checked(checked(this.cboBSYear.Top + this.cboBSYear.Height) + 5);
			this.lblBSYearMonth.Height = checked(this.lblFS16.Height + 5);
			this.lblBSYearMonth.BackColor = Color.LightSlateGray;
			this.lblADYearMonth.Top = this.lblBSYearMonth.Top;
			this.lblADYearMonth.Height = this.lblBSYearMonth.Height;
			this.lblADYearMonth.BackColor = this.lblBSYearMonth.BackColor;
			short num1 = 1;
			short top = checked((short)(checked(checked(this.lblBSYearMonth.Top + this.lblBSYearMonth.Height) + 1)));
			short height = checked((short)(checked(this.lblFS18.Height + 25)));
			short height1 = checked((short)(checked(this.lblFS14.Height + 10)));
			short height2 = checked((short)(checked(this.lblFS8.Height + 10)));
			short num2 = checked((short)this.lblFS8.Height);
			short height3 = checked((short)this.lblFS6.Height);
			short num3 = checked((short)this.lblFS6.Height);
			short num4 = 0;
			do
			{
				red = new Label()
				{
					Text = NepDate.arBSDayName[num4],
					Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, FontStyle.Regular),
					TextAlign = ContentAlignment.MiddleCenter,
					BackColor = Color.SlateGray,
					ForeColor = Color.White
				};
				size = new System.Drawing.Size(height, height1);
				red.Size = size;
				point = new Point(num1, top);
				red.Location = point;
				if (num4 == 6)
				{
					red.BackColor = Color.Red;
				}
				this.pnlCalendar.Controls.Add(red);
				num1 = checked((short)(checked(checked((short)(num1 + height)) + 1)));
				num4 = checked((short)(num4 + 1));
			}
			while (num4 <= 6);
			num1 = 1;
			top = checked((short)(checked(checked(red.Top + red.Height) + 1)));
			height1 = checked((short)(checked(this.lblFS18.Height + 16)));
			num4 = 0;
			do
			{
				label = new Label()
				{
					Text = "",
					Tag = num4,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, FontStyle.Regular),
					TextAlign = ContentAlignment.TopCenter,
					ForeColor = this.colorDayText,
					BackColor = this.colorDayBg,
					AutoSize = false
				};
				size = new System.Drawing.Size(height, height1);
				label.Size = size;
				if (num == 7)
				{
					top = checked((short)(checked(checked((short)(top + height1)) + 1)));
					num1 = 1;
					num = 0;
				}
				point = new Point(num1, top);
				label.Location = point;
				Calendar calendar = this;
				label.Click += new EventHandler(calendar.lblDay_Click);
				this.lblDayA[num4] = label;
				this.pnlCalendar.Controls.Add(label);
				Label label1 = new Label()
				{
					Text = "0",
					Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular),
					TextAlign = ContentAlignment.MiddleCenter,
					ForeColor = this.colorMEText,
					BackColor = this.colorMEBg,
					AutoSize = false
				};
				size = new System.Drawing.Size(height3, num3);
				label1.Size = size;
				point = new Point(checked(label.Left + 2), checked(checked(checked(label.Top + height1) - num3) - 2));
				label1.Location = point;
				Calendar calendar1 = this;
				label1.Click += new EventHandler(calendar1.lblDay_Click);
				this.lblME[num4] = label1;
				this.pnlCalendar.Controls.Add(label1);
				label1.BringToFront();
				Label label2 = new Label()
				{
					Text = "0",
					Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular),
					TextAlign = ContentAlignment.MiddleCenter,
					ForeColor = this.colorUEText,
					BackColor = this.colorUEBg,
					AutoSize = false
				};
				size = new System.Drawing.Size(height3, num3);
				label2.Size = size;
				point = new Point(checked(checked(label1.Left + height3) + 2), label1.Top);
				label2.Location = point;
				Calendar calendar2 = this;
				label1.Click += new EventHandler(calendar2.lblDay_Click);
				this.lblUE[num4] = label2;
				this.pnlCalendar.Controls.Add(label2);
				label2.BringToFront();
				Label label3 = new Label()
				{
					Text = "",
					Tag = num4,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular),
					TextAlign = ContentAlignment.TopCenter,
					ForeColor = this.colorDayText,
					BackColor = this.colorDayBg,
					AutoSize = false
				};
				size = new System.Drawing.Size(height2, num2);
				label3.Size = size;
				point = new Point(checked(checked(label.Left + height) - height2), checked(checked(checked(label.Top + height1) - num2) - 2));
				label3.Location = point;
				Calendar calendar3 = this;
				label3.Click += new EventHandler(calendar3.lblDay_Click);
				this.lblDayB[num4] = label3;
				this.pnlCalendar.Controls.Add(label3);
				label3.BringToFront();
				num1 = checked((short)(checked(checked((short)(num1 + height)) + 1)));
				num = checked((short)(checked(num + 1)));
				num4 = checked((short)(num4 + 1));
			}
			while (num4 <= 41);
			this.pnlCalendar.Height = checked(checked(label.Top + label.Height) + 3);
			this.pnlCalendar.Width = checked(checked(label.Left + label.Width) + 3);
			this.lblBSYearMonth.Left = 1;
			this.lblBSYearMonth.Width = checked(this.pnlCalendar.Width - 4);
			this.lblADYearMonth.Left = checked(this.lblBSYearMonth.Width - this.lblADYearMonth.Width);
			this.tabEvents.Top = this.pnlCalendar.Top;
			this.tabEvents.Height = this.pnlCalendar.Height;
			this.tabEvents.Left = checked(checked(this.pnlCalendar.Left + this.pnlCalendar.Width) + 5);
			this.tabEvents.Width = this.pnlCalendar.Width;
			this.txtSelectedEvent.Top = 5;
			this.txtSelectedEvent.Left = 5;
			this.txtSelectedEvent.Width = checked(this.tabEvents.TabPages[0].Width - 10);
			this.lvEvents.Top = checked(checked(this.txtSelectedEvent.Top + this.txtSelectedEvent.Height) + 5);
			this.lvEvents.Height = checked(checked(this.tabEvents.TabPages[0].Height - this.lvEvents.Top) - 5);
			this.lvEvents.Left = this.txtSelectedEvent.Left;
			this.lvEvents.Width = this.txtSelectedEvent.Width;
			this.txtSelectedEventM.Top = this.txtSelectedEvent.Top;
			this.txtSelectedEventM.Left = this.txtSelectedEvent.Left;
			this.txtSelectedEventM.Width = this.txtSelectedEvent.Width;
			this.lvEventsM.Top = this.lvEvents.Top;
			this.lvEventsM.Left = this.lvEvents.Left;
			this.lvEventsM.Height = this.lvEvents.Height;
			this.lvEventsM.Width = this.lvEvents.Width;
			this.pnlBody.Height = checked(this.pnlCalendar.Height + 20);
			this.pnlStatus.Height = checked(this.lblStatus.Height + 8);
			this.lblStatus.Left = 5;
			this.lblStatus.Top = 4;
			this.Height = checked(checked(checked(this.pnlBody.Top + this.pnlBody.Height) + this.pnlStatus.Height) + 40);
			this.Width = checked(checked(this.tabEvents.Left + this.tabEvents.Width) + 30);
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

		public void FillCalendar(short iBSYear, short iBSMonth, short iBSDay)
		{
			string[] str;
			short num = NepDate.BSMonthLen(iBSYear, iBSMonth);
			DateTime dateTime = NepDate.BS2AD(iBSYear, iBSMonth, 1);
			short dayOfWeek = checked((short)(checked((int)dateTime.DayOfWeek + (int)DayOfWeek.Monday)));
			short year = checked((short)dateTime.Year);
			short month = checked((short)dateTime.Month);
			this.lblBSYearMonth.Text = string.Concat(mdlMain.Num2NepNum(Conversions.ToString((int)iBSYear)), " ", NepDate.arBSMonthName[checked(iBSMonth - 1)]);
			if (month != 12)
			{
				Label label = this.lblADYearMonth;
				str = new string[] { NepDate.arADMonthName[checked(month - 1)], " / ", NepDate.arADMonthName[month], " ", Conversions.ToString((int)year) };
				label.Text = string.Concat(str);
			}
			else
			{
				Label label1 = this.lblADYearMonth;
				str = new string[] { NepDate.arADMonthName[checked(month - 1)], " ", Conversions.ToString(year % 100), " / ", NepDate.arADMonthName[0], " ", Conversions.ToString((checked(year + 1)) % 100) };
				label1.Text = string.Concat(str);
			}
			short num1 = checked((short)DateTime.DaysInMonth(year, month));
			short i = 0;
			do
			{
				this.lblDayA[i].Text = "";
				this.lblDayA[i].ForeColor = this.colorDayText;
				this.lblDayA[i].BackColor = this.colorDayBg;
				this.lblDayA[i].Visible = false;
				this.lblDayB[i].Text = "";
				this.lblDayB[i].ForeColor = this.colorDayText;
				this.lblDayB[i].BackColor = this.colorDayBg;
				this.lblDayB[i].Visible = false;
				this.iLVItemIndex[i] = -1;
				i = checked((short)(i + 1));
			}
			while (i <= 41);
			short num2 = checked((short)(checked(dayOfWeek - 1)));
			short day = checked((short)dateTime.Day);
			short num3 = num;
			for (i = 1; i <= num3; i = checked((short)(i + 1)))
			{
				this.lblDayA[num2].Text = NepDate.arBSDayNo[i];
				this.lblDayA[num2].Visible = true;
				this.lblDayB[num2].Text = Conversions.ToString((int)day);
				this.lblDayB[num2].Visible = true;
				if (iBSDay != 0 && iBSDay == i)
				{
					this.lblDayA[num2].BackColor = this.colorSelDayBg;
					this.lblDayB[num2].BackColor = this.colorSelDayBg;
					this.ilblDayPrevIndex = num2;
				}
				if (day >= num1)
				{
					day = 0;
				}
				num2 = checked((short)(checked(num2 + 1)));
				day = checked((short)(checked(day + 1)));
			}
			this.LoadEvents(iBSYear, iBSMonth, iBSDay);
			i = 6;
			do
			{
				this.lblDayA[i].ForeColor = this.colorHolidayText;
				this.lblDayB[i].ForeColor = this.colorHolidayText;
				i = checked((short)(i + 7));
			}
			while (i <= 41);
			this.LoadMiscEvent(iBSYear, iBSMonth, iBSDay);
		}

		private string GetDBLastUpdated()
		{
			DateTime date = Conversions.ToDate(MySettingsProperty.Settings["DBLastUpdated"]);
			if (DateTime.Compare(date, new DateTime(636503616000000000L)) < 0)
			{
				return "(N/A)";
			}
			return string.Concat(NepDate.AD2BS(date).Replace("/", "-"), " (", Strings.Format(date, "MMM d, yyyy"), ")");
		}

		private void InitCtrl()
		{
			this.cboBSYear.Items.Clear();
			short num = 1990;
			do
			{
				this.cboBSYear.Items.Add(mdlMain.Num2NepNum(Conversions.ToString((int)num)));
				num = checked((short)(num + 1));
			}
			while (num <= 2110);
			this.cboBSMonth.Items.Clear();
			num = 0;
			do
			{
				this.cboBSMonth.Items.Add(NepDate.arBSMonthName[num]);
				num = checked((short)(num + 1));
			}
			while (num <= 11);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Calendar));
			this.MenuStrip1 = new MenuStrip();
			this.mnuFile = new ToolStripMenuItem();
			this.mnuExit = new ToolStripMenuItem();
			this.CalendarToolStripMenuItem = new ToolStripMenuItem();
			this.mnuToday = new ToolStripMenuItem();
			this.mnuShowTithi = new ToolStripMenuItem();
			this.ToolStripSeparator1 = new ToolStripSeparator();
			this.mnuUpdateData = new ToolStripMenuItem();
			this.mnuHelp = new ToolStripMenuItem();
			this.mnuAbout = new ToolStripMenuItem();
			this.pnlStatus = new Panel();
			this.lblStatus = new Label();
			this.Timer1 = new Timer(this.components);
			this.lblFS14 = new Label();
			this.lblFS15 = new Label();
			this.lblFS16 = new Label();
			this.lblFS18 = new Label();
			this.lblFS8 = new Label();
			this.pnlTop = new Panel();
			this.pnlBody = new Panel();
			this.tabEvents = new TabControl();
			this.TabPage1 = new TabPage();
			this.txtSelectedEvent = new TextBox();
			this.lvEvents = new ListView();
			this.d = new ColumnHeader();
			this.e = new ColumnHeader();
			this.TabPage2 = new TabPage();
			this.txtSelectedEventM = new TextBox();
			this.lvEventsM = new ListView();
			this.ColumnHeader1 = new ColumnHeader();
			this.ColumnHeader2 = new ColumnHeader();
			this.TabPage3 = new TabPage();
			this.Label1 = new Label();
			this.ImageList1 = new ImageList(this.components);
			this.pnlCalendar = new Panel();
			this.btnToday = new Button();
			this.btnMonthDown = new Button();
			this.btnMonthUp = new Button();
			this.lblBSSelDay = new Label();
			this.lblADYearMonth = new Label();
			this.lblBSYearMonth = new Label();
			this.cboBSMonth = new ComboBox();
			this.cboBSYear = new ComboBox();
			this.lblFS6 = new Label();
			this.MenuStrip1.SuspendLayout();
			this.pnlStatus.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.tabEvents.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.pnlCalendar.SuspendLayout();
			this.SuspendLayout();
			ToolStripItemCollection items = this.MenuStrip1.Items;
			ToolStripItem[] calendarToolStripMenuItem = new ToolStripItem[] { this.mnuFile, this.CalendarToolStripMenuItem, this.mnuHelp };
			items.AddRange(calendarToolStripMenuItem);
			MenuStrip menuStrip1 = this.MenuStrip1;
			Point point = new Point(0, 0);
			menuStrip1.Location = point;
			this.MenuStrip1.Name = "MenuStrip1";
			MenuStrip menuStrip = this.MenuStrip1;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			menuStrip.Padding = padding;
			MenuStrip menuStrip11 = this.MenuStrip1;
			System.Drawing.Size size = new System.Drawing.Size(1166, 28);
			menuStrip11.Size = size;
			this.MenuStrip1.TabIndex = 7;
			this.MenuStrip1.Text = "MenuStrip1";
			ToolStripItemCollection dropDownItems = this.mnuFile.DropDownItems;
			calendarToolStripMenuItem = new ToolStripItem[] { this.mnuExit };
			dropDownItems.AddRange(calendarToolStripMenuItem);
			this.mnuFile.Name = "mnuFile";
			ToolStripMenuItem toolStripMenuItem = this.mnuFile;
			size = new System.Drawing.Size(44, 24);
			toolStripMenuItem.Size = size;
			this.mnuFile.Text = "&File";
			this.mnuExit.Image = Resources.cross;
			this.mnuExit.Name = "mnuExit";
			ToolStripMenuItem toolStripMenuItem1 = this.mnuExit;
			size = new System.Drawing.Size(102, 24);
			toolStripMenuItem1.Size = size;
			this.mnuExit.Text = "E&xit";
			ToolStripItemCollection toolStripItemCollections = this.CalendarToolStripMenuItem.DropDownItems;
			calendarToolStripMenuItem = new ToolStripItem[] { this.mnuToday, this.mnuShowTithi, this.ToolStripSeparator1, this.mnuUpdateData };
			toolStripItemCollections.AddRange(calendarToolStripMenuItem);
			this.CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem";
			ToolStripMenuItem calendarToolStripMenuItem1 = this.CalendarToolStripMenuItem;
			size = new System.Drawing.Size(80, 24);
			calendarToolStripMenuItem1.Size = size;
			this.CalendarToolStripMenuItem.Text = "&Calendar";
			this.mnuToday.Name = "mnuToday";
			ToolStripMenuItem toolStripMenuItem2 = this.mnuToday;
			size = new System.Drawing.Size(226, 24);
			toolStripMenuItem2.Size = size;
			this.mnuToday.Text = "To&day";
			this.mnuShowTithi.Name = "mnuShowTithi";
			ToolStripMenuItem toolStripMenuItem3 = this.mnuShowTithi;
			size = new System.Drawing.Size(226, 24);
			toolStripMenuItem3.Size = size;
			this.mnuShowTithi.Text = "&Show &Tithi";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
			size = new System.Drawing.Size(223, 6);
			toolStripSeparator1.Size = size;
			this.mnuUpdateData.Image = Resources.update_16;
			this.mnuUpdateData.Name = "mnuUpdateData";
			ToolStripMenuItem toolStripMenuItem4 = this.mnuUpdateData;
			size = new System.Drawing.Size(226, 24);
			toolStripMenuItem4.Size = size;
			this.mnuUpdateData.Text = "&Update Calendar Data";
			ToolStripItemCollection dropDownItems1 = this.mnuHelp.DropDownItems;
			calendarToolStripMenuItem = new ToolStripItem[] { this.mnuAbout };
			dropDownItems1.AddRange(calendarToolStripMenuItem);
			this.mnuHelp.Name = "mnuHelp";
			ToolStripMenuItem toolStripMenuItem5 = this.mnuHelp;
			size = new System.Drawing.Size(53, 24);
			toolStripMenuItem5.Size = size;
			this.mnuHelp.Text = "&Help";
			this.mnuAbout.Name = "mnuAbout";
			ToolStripMenuItem toolStripMenuItem6 = this.mnuAbout;
			size = new System.Drawing.Size(128, 24);
			toolStripMenuItem6.Size = size;
			this.mnuAbout.Text = "&About...";
			this.pnlStatus.BackColor = Color.White;
			this.pnlStatus.Controls.Add(this.lblStatus);
			this.pnlStatus.Dock = DockStyle.Bottom;
			Panel panel = this.pnlStatus;
			point = new Point(0, 684);
			panel.Location = point;
			this.pnlStatus.Name = "pnlStatus";
			Panel panel1 = this.pnlStatus;
			size = new System.Drawing.Size(1166, 34);
			panel1.Size = size;
			this.pnlStatus.TabIndex = 10;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label = this.lblStatus;
			point = new Point(12, 4);
			label.Location = point;
			this.lblStatus.Name = "lblStatus";
			Label label1 = this.lblStatus;
			size = new System.Drawing.Size(68, 20);
			label1.Size = size;
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Ready...";
			this.Timer1.Interval = 5000;
			this.lblFS14.AutoSize = true;
			this.lblFS14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.lblFS14;
			point = new Point(547, -1);
			label2.Location = point;
			this.lblFS14.Name = "lblFS14";
			Label label3 = this.lblFS14;
			size = new System.Drawing.Size(70, 29);
			label3.Size = size;
			this.lblFS14.TabIndex = 12;
			this.lblFS14.Text = "FS14";
			this.lblFS14.Visible = false;
			this.lblFS15.AutoSize = true;
			this.lblFS15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = this.lblFS15;
			point = new Point(636, 0);
			label4.Location = point;
			this.lblFS15.Name = "lblFS15";
			Label label5 = this.lblFS15;
			size = new System.Drawing.Size(73, 29);
			label5.Size = size;
			this.lblFS15.TabIndex = 13;
			this.lblFS15.Text = "FS15";
			this.lblFS15.Visible = false;
			this.lblFS16.AutoSize = true;
			this.lblFS16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label6 = this.lblFS16;
			point = new Point(715, 0);
			label6.Location = point;
			this.lblFS16.Name = "lblFS16";
			Label label7 = this.lblFS16;
			size = new System.Drawing.Size(83, 32);
			label7.Size = size;
			this.lblFS16.TabIndex = 14;
			this.lblFS16.Text = "FS16";
			this.lblFS16.Visible = false;
			this.lblFS18.AutoSize = true;
			this.lblFS18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label8 = this.lblFS18;
			point = new Point(804, 0);
			label8.Location = point;
			this.lblFS18.Name = "lblFS18";
			Label label9 = this.lblFS18;
			size = new System.Drawing.Size(87, 36);
			label9.Size = size;
			this.lblFS18.TabIndex = 15;
			this.lblFS18.Text = "FS18";
			this.lblFS18.Visible = false;
			this.lblFS8.AutoSize = true;
			this.lblFS8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label10 = this.lblFS8;
			point = new Point(517, 0);
			label10.Location = point;
			this.lblFS8.Name = "lblFS8";
			Label label11 = this.lblFS8;
			size = new System.Drawing.Size(33, 17);
			label11.Size = size;
			this.lblFS8.TabIndex = 16;
			this.lblFS8.Text = "FS8";
			this.lblFS8.Visible = false;
			this.pnlTop.BackColor = Color.LightGray;
			this.pnlTop.Dock = DockStyle.Top;
			Panel panel2 = this.pnlTop;
			point = new Point(0, 28);
			panel2.Location = point;
			this.pnlTop.Name = "pnlTop";
			Panel panel3 = this.pnlTop;
			size = new System.Drawing.Size(1166, 0);
			panel3.Size = size;
			this.pnlTop.TabIndex = 18;
			this.pnlBody.BackColor = SystemColors.Control;
			this.pnlBody.Controls.Add(this.tabEvents);
			this.pnlBody.Controls.Add(this.pnlCalendar);
			this.pnlBody.Dock = DockStyle.Top;
			Panel panel4 = this.pnlBody;
			point = new Point(0, 28);
			panel4.Location = point;
			this.pnlBody.Name = "pnlBody";
			Panel panel5 = this.pnlBody;
			size = new System.Drawing.Size(1166, 522);
			panel5.Size = size;
			this.pnlBody.TabIndex = 19;
			this.tabEvents.Controls.Add(this.TabPage1);
			this.tabEvents.Controls.Add(this.TabPage2);
			this.tabEvents.Controls.Add(this.TabPage3);
			this.tabEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tabEvents.ImageList = this.ImageList1;
			TabControl tabControl = this.tabEvents;
			point = new Point(507, 46);
			tabControl.Location = point;
			this.tabEvents.Name = "tabEvents";
			this.tabEvents.SelectedIndex = 0;
			TabControl tabControl1 = this.tabEvents;
			size = new System.Drawing.Size(580, 430);
			tabControl1.Size = size;
			this.tabEvents.TabIndex = 19;
			this.TabPage1.Controls.Add(this.txtSelectedEvent);
			this.TabPage1.Controls.Add(this.lvEvents);
			TabPage tabPage1 = this.TabPage1;
			point = new Point(4, 29);
			tabPage1.Location = point;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage = this.TabPage1;
			padding = new System.Windows.Forms.Padding(3);
			tabPage.Padding = padding;
			TabPage tabPage11 = this.TabPage1;
			size = new System.Drawing.Size(572, 397);
			tabPage11.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Public Events";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.txtSelectedEvent.BackColor = Color.White;
			this.txtSelectedEvent.BorderStyle = BorderStyle.FixedSingle;
			this.txtSelectedEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBox = this.txtSelectedEvent;
			point = new Point(7, 6);
			textBox.Location = point;
			this.txtSelectedEvent.Name = "txtSelectedEvent";
			this.txtSelectedEvent.ReadOnly = true;
			TextBox textBox1 = this.txtSelectedEvent;
			size = new System.Drawing.Size(523, 30);
			textBox1.Size = size;
			this.txtSelectedEvent.TabIndex = 13;
			this.txtSelectedEvent.TabStop = false;
			this.txtSelectedEvent.Text = "बैशाख १ - नयाँ वर्ष";
			this.lvEvents.BorderStyle = BorderStyle.FixedSingle;
			ListView.ColumnHeaderCollection columns = this.lvEvents.Columns;
			ColumnHeader[] columnHeader1 = new ColumnHeader[] { this.d, this.e };
			columns.AddRange(columnHeader1);
			this.lvEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lvEvents.FullRowSelect = true;
			this.lvEvents.HeaderStyle = ColumnHeaderStyle.None;
			ListView listView = this.lvEvents;
			point = new Point(9, 50);
			listView.Location = point;
			this.lvEvents.MultiSelect = false;
			this.lvEvents.Name = "lvEvents";
			this.lvEvents.ShowGroups = false;
			ListView listView1 = this.lvEvents;
			size = new System.Drawing.Size(527, 333);
			listView1.Size = size;
			this.lvEvents.TabIndex = 12;
			this.lvEvents.UseCompatibleStateImageBehavior = false;
			this.lvEvents.View = View.Details;
			this.d.Text = "Day";
			this.d.Width = 100;
			this.e.Text = "Event";
			this.e.Width = 300;
			this.TabPage2.Controls.Add(this.txtSelectedEventM);
			this.TabPage2.Controls.Add(this.lvEventsM);
			this.TabPage2.ForeColor = SystemColors.ControlText;
			this.TabPage2.ImageIndex = 0;
			TabPage tabPage2 = this.TabPage2;
			point = new Point(4, 29);
			tabPage2.Location = point;
			this.TabPage2.Name = "TabPage2";
			TabPage tabPage21 = this.TabPage2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage21.Padding = padding;
			TabPage tabPage22 = this.TabPage2;
			size = new System.Drawing.Size(572, 397);
			tabPage22.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Misc. Events";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.txtSelectedEventM.BackColor = Color.White;
			this.txtSelectedEventM.BorderStyle = BorderStyle.FixedSingle;
			this.txtSelectedEventM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBox2 = this.txtSelectedEventM;
			point = new Point(9, 10);
			textBox2.Location = point;
			this.txtSelectedEventM.Name = "txtSelectedEventM";
			this.txtSelectedEventM.ReadOnly = true;
			TextBox textBox3 = this.txtSelectedEventM;
			size = new System.Drawing.Size(523, 30);
			textBox3.Size = size;
			this.txtSelectedEventM.TabIndex = 15;
			this.txtSelectedEventM.TabStop = false;
			this.txtSelectedEventM.Text = "बैशाख १ - नयाँ वर्ष";
			this.lvEventsM.BorderStyle = BorderStyle.FixedSingle;
			ListView.ColumnHeaderCollection columnHeaderCollections = this.lvEventsM.Columns;
			columnHeader1 = new ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2 };
			columnHeaderCollections.AddRange(columnHeader1);
			this.lvEventsM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lvEventsM.FullRowSelect = true;
			this.lvEventsM.HeaderStyle = ColumnHeaderStyle.None;
			ListView listView2 = this.lvEventsM;
			point = new Point(9, 46);
			listView2.Location = point;
			this.lvEventsM.MultiSelect = false;
			this.lvEventsM.Name = "lvEventsM";
			this.lvEventsM.ShowGroups = false;
			ListView listView3 = this.lvEventsM;
			size = new System.Drawing.Size(527, 333);
			listView3.Size = size;
			this.lvEventsM.TabIndex = 14;
			this.lvEventsM.UseCompatibleStateImageBehavior = false;
			this.lvEventsM.View = View.Details;
			this.ColumnHeader1.Text = "Day";
			this.ColumnHeader1.Width = 100;
			this.ColumnHeader2.Text = "Event";
			this.ColumnHeader2.Width = 300;
			this.TabPage3.Controls.Add(this.Label1);
			this.TabPage3.ForeColor = SystemColors.ControlText;
			this.TabPage3.ImageIndex = 1;
			TabPage tabPage3 = this.TabPage3;
			point = new Point(4, 29);
			tabPage3.Location = point;
			this.TabPage3.Name = "TabPage3";
			TabPage tabPage31 = this.TabPage3;
			size = new System.Drawing.Size(572, 397);
			tabPage31.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "User Events";
			this.TabPage3.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = Color.Silver;
			Label label12 = this.Label1;
			point = new Point(5, 10);
			label12.Location = point;
			this.Label1.Name = "Label1";
			Label label13 = this.Label1;
			size = new System.Drawing.Size(165, 20);
			label13.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "(Under development)";
			this.ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "circle_red.png");
			this.ImageList1.Images.SetKeyName(1, "circle_blue_16_ns.png");
			this.pnlCalendar.BackColor = Color.WhiteSmoke;
			this.pnlCalendar.BorderStyle = BorderStyle.FixedSingle;
			this.pnlCalendar.Controls.Add(this.btnToday);
			this.pnlCalendar.Controls.Add(this.btnMonthDown);
			this.pnlCalendar.Controls.Add(this.btnMonthUp);
			this.pnlCalendar.Controls.Add(this.lblBSSelDay);
			this.pnlCalendar.Controls.Add(this.lblADYearMonth);
			this.pnlCalendar.Controls.Add(this.lblBSYearMonth);
			this.pnlCalendar.Controls.Add(this.cboBSMonth);
			this.pnlCalendar.Controls.Add(this.cboBSYear);
			Panel panel6 = this.pnlCalendar;
			point = new Point(10, 10);
			panel6.Location = point;
			Panel panel7 = this.pnlCalendar;
			padding = new System.Windows.Forms.Padding(4);
			panel7.Margin = padding;
			this.pnlCalendar.Name = "pnlCalendar";
			Panel panel8 = this.pnlCalendar;
			size = new System.Drawing.Size(475, 430);
			panel8.Size = size;
			this.pnlCalendar.TabIndex = 18;
			this.btnToday.Image = Resources.circle_green;
			Button button = this.btnToday;
			point = new Point(344, 15);
			button.Location = point;
			this.btnToday.Name = "btnToday";
			Button button1 = this.btnToday;
			size = new System.Drawing.Size(37, 37);
			button1.Size = size;
			this.btnToday.TabIndex = 7;
			this.btnToday.UseVisualStyleBackColor = true;
			this.btnMonthDown.Image = Resources.down;
			Button button2 = this.btnMonthDown;
			point = new Point(301, 15);
			button2.Location = point;
			this.btnMonthDown.Name = "btnMonthDown";
			Button button3 = this.btnMonthDown;
			size = new System.Drawing.Size(37, 37);
			button3.Size = size;
			this.btnMonthDown.TabIndex = 6;
			this.btnMonthDown.UseVisualStyleBackColor = true;
			this.btnMonthUp.Image = Resources.up;
			Button button4 = this.btnMonthUp;
			point = new Point(258, 15);
			button4.Location = point;
			this.btnMonthUp.Name = "btnMonthUp";
			Button button5 = this.btnMonthUp;
			size = new System.Drawing.Size(37, 37);
			button5.Size = size;
			this.btnMonthUp.TabIndex = 5;
			this.btnMonthUp.UseVisualStyleBackColor = true;
			this.lblBSSelDay.AutoSize = true;
			this.lblBSSelDay.BackColor = Color.Transparent;
			this.lblBSSelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblBSSelDay.ForeColor = Color.DimGray;
			Label label14 = this.lblBSSelDay;
			point = new Point(115, 309);
			label14.Location = point;
			Label label15 = this.lblBSSelDay;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label15.Margin = padding;
			this.lblBSSelDay.Name = "lblBSSelDay";
			Label label16 = this.lblBSSelDay;
			size = new System.Drawing.Size(114, 25);
			label16.Size = size;
			this.lblBSSelDay.TabIndex = 4;
			this.lblBSSelDay.Text = "२०७३ फाल्गुण १६";
			this.lblBSSelDay.TextAlign = ContentAlignment.MiddleCenter;
			this.lblBSSelDay.Visible = false;
			this.lblADYearMonth.BackColor = Color.LightSalmon;
			this.lblADYearMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblADYearMonth.ForeColor = Color.White;
			Label label17 = this.lblADYearMonth;
			point = new Point(288, 62);
			label17.Location = point;
			Label label18 = this.lblADYearMonth;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label18.Margin = padding;
			this.lblADYearMonth.Name = "lblADYearMonth";
			Label label19 = this.lblADYearMonth;
			size = new System.Drawing.Size(181, 37);
			label19.Size = size;
			this.lblADYearMonth.TabIndex = 3;
			this.lblADYearMonth.Text = "2017 Janaury";
			this.lblADYearMonth.TextAlign = ContentAlignment.MiddleRight;
			this.lblBSYearMonth.BackColor = Color.LightSalmon;
			this.lblBSYearMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblBSYearMonth.ForeColor = Color.White;
			Label label20 = this.lblBSYearMonth;
			point = new Point(7, 62);
			label20.Location = point;
			Label label21 = this.lblBSYearMonth;
			padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label21.Margin = padding;
			this.lblBSYearMonth.Name = "lblBSYearMonth";
			Label label22 = this.lblBSYearMonth;
			size = new System.Drawing.Size(463, 37);
			label22.Size = size;
			this.lblBSYearMonth.TabIndex = 2;
			this.lblBSYearMonth.Text = "२०७३ बैशाख";
			this.lblBSYearMonth.TextAlign = ContentAlignment.MiddleLeft;
			this.cboBSMonth.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboBSMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSMonth.FormattingEnabled = true;
			this.cboBSMonth.ItemHeight = 29;
			ComboBox comboBox = this.cboBSMonth;
			point = new Point(120, 15);
			comboBox.Location = point;
			ComboBox comboBox1 = this.cboBSMonth;
			padding = new System.Windows.Forms.Padding(4);
			comboBox1.Margin = padding;
			this.cboBSMonth.Name = "cboBSMonth";
			ComboBox comboBox2 = this.cboBSMonth;
			size = new System.Drawing.Size(131, 37);
			comboBox2.Size = size;
			this.cboBSMonth.TabIndex = 1;
			this.cboBSYear.DropDownHeight = 300;
			this.cboBSYear.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboBSYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSYear.FormattingEnabled = true;
			this.cboBSYear.IntegralHeight = false;
			this.cboBSYear.ItemHeight = 29;
			ComboBox comboBox3 = this.cboBSYear;
			point = new Point(13, 15);
			comboBox3.Location = point;
			ComboBox comboBox4 = this.cboBSYear;
			padding = new System.Windows.Forms.Padding(4);
			comboBox4.Margin = padding;
			this.cboBSYear.Name = "cboBSYear";
			ComboBox comboBox5 = this.cboBSYear;
			size = new System.Drawing.Size(99, 37);
			comboBox5.Size = size;
			this.cboBSYear.TabIndex = 0;
			this.lblFS6.AutoSize = true;
			this.lblFS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label23 = this.lblFS6;
			point = new Point(475, 4);
			label23.Location = point;
			this.lblFS6.Name = "lblFS6";
			Label label24 = this.lblFS6;
			size = new System.Drawing.Size(26, 13);
			label24.Size = size;
			this.lblFS6.TabIndex = 20;
			this.lblFS6.Text = "FS6";
			this.lblFS6.Visible = false;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(1166, 718);
			this.ClientSize = size;
			this.Controls.Add(this.lblFS6);
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.lblFS8);
			this.Controls.Add(this.lblFS18);
			this.Controls.Add(this.lblFS16);
			this.Controls.Add(this.lblFS15);
			this.Controls.Add(this.lblFS14);
			this.Controls.Add(this.pnlStatus);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			padding = new System.Windows.Forms.Padding(4);
			this.Margin = padding;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Calendar";
			this.ShowIcon = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Nepali Calendar";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.pnlStatus.ResumeLayout(false);
			this.pnlStatus.PerformLayout();
			this.pnlBody.ResumeLayout(false);
			this.tabEvents.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.pnlCalendar.ResumeLayout(false);
			this.pnlCalendar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblDay_Click(object sender, EventArgs e)
		{
			short num = Conversions.ToShort(((Label)sender).Tag);
			if (this.IsUserClick && this.iLVItemIndex[num] >= 0)
			{
				this.lvEvents.Items[this.iLVItemIndex[num]].Selected = true;
				this.lvEvents.TopItem = this.lvEvents.Items[this.iLVItemIndex[num]];
				this.txtSelectedEvent.Text = string.Concat(this.lvEvents.SelectedItems[0].Text, " - ", this.lvEvents.SelectedItems[0].SubItems[1].Text);
				this.txtSelectedEvent.ForeColor = this.lvEvents.SelectedItems[0].ForeColor;
			}
			if (num == this.ilblDayPrevIndex)
			{
				return;
			}
			this.lblDayA[this.ilblDayPrevIndex].BackColor = this.colorDayBg;
			this.lblDayB[this.ilblDayPrevIndex].BackColor = this.colorDayBg;
			this.lblDayA[num].BackColor = this.colorSelDayBg;
			this.lblDayB[num].BackColor = this.colorSelDayBg;
			Label label = this.lblBSSelDay;
			string[] str = new string[] { this.cboBSYear.SelectedItem.ToString(), " ", this.cboBSMonth.SelectedItem.ToString(), " ", this.lblDayA[num].Text, ", ", NepDate.arBSDayName[num % 7], "बार" };
			label.Text = string.Concat(str);
			this.ilblDayPrevIndex = num;
		}

		private void LoadEvents(short iYear, short iMonth, short iDay)
		{
			OleDbDataReader oleDbDataReader = null;
			short i;
			short num = 0;
			bool flag = false;
			ListViewItem listViewItem;
			string str;
			string[] strArrays;
			this.txtSelectedEvent.Text = "";
			if (!mdl_DB.IsPEDBLoaded)
			{
				this.lvEvents.Items.Clear();
				this.lvEvents.Items.Add(" ");
				this.lvEvents.Items[0].SubItems.Add("(Please, update calendar data.)");
				this.SetStatus("Calendar data not found. Download calendar data by clicking on 'Calendar -> Update Calendar Data'.", Color.Red);
				this.lvEvents.Enabled = false;
				return;
			}
			Color[] black = new Color[] { Color.Black, Color.Red, Color.DarkOrange };
			Color[] colorArray = black;
			if (this.IsShowTithi)
			{
				strArrays = new string[] { "SELECT * FROM tithi WHERE(event_year=", Conversions.ToString((int)iYear), " AND event_month=", Conversions.ToString((int)iMonth), ") ORDER BY event_day" };
				oleDbDataReader = mdl_DB.DBQuery(string.Concat(strArrays));
			}
			strArrays = new string[] { "SELECT * FROM events WHERE(event_year=", Conversions.ToString((int)iYear), " AND event_month=", Conversions.ToString((int)iMonth), ") ORDER BY event_day" };
			OleDbDataReader oleDbDataReader1 = mdl_DB.DBQuery(string.Concat(strArrays));
			short num1 = 0;
			short num2 = 0;
			bool flag1 = false;
			this.lvEvents.Items.Clear();
			this.lvEvents.Enabled = true;
			if (!this.IsShowTithi)
			{
				while (oleDbDataReader1.Read())
				{
					listViewItem = this.lvEvents.Items.Add(string.Concat(NepDate.arBSMonthName[checked(Conversions.ToInteger(oleDbDataReader1["event_month"]) - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString(oleDbDataReader1["event_day"]))));
					listViewItem.SubItems.Add(Conversions.ToString(oleDbDataReader1["event_title"]));
					listViewItem.SubItems[0].ForeColor = colorArray[Conversions.ToInteger(oleDbDataReader1["holiday"])];
					str = NepDate.arBSDayNo[Conversions.ToInteger(oleDbDataReader1["event_day"])];
					if (Conversions.ToInteger(oleDbDataReader1["holiday"]) > 0)
					{
						num = Conversions.ToShort(oleDbDataReader1["event_day"]);
					}
					i = num1;
					while (i <= 41)
					{
						if (Operators.CompareString(this.lblDayA[i].Text, str, false) == 0)
						{
							this.iLVItemIndex[i] = num2;
							num1 = i;
						}
						if (num <= 0 || Operators.CompareString(this.lblDayA[i].Text, NepDate.arBSDayNo[num], false) != 0)
						{
							i = checked((short)(i + 1));
						}
						else
						{
							this.lblDayA[i].ForeColor = colorArray[Conversions.ToInteger(oleDbDataReader1["holiday"])];
							num1 = i;
							num = 0;
							break;
						}
					}
					num2 = checked((short)(checked(num2 + 1)));
				}
			}
			else
			{
				while (oleDbDataReader.Read())
				{
					listViewItem = this.lvEvents.Items.Add(string.Concat(NepDate.arBSMonthName[checked(Conversions.ToInteger(oleDbDataReader["event_month"]) - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString(oleDbDataReader["event_day"]))));
					string str1 = NepDate.arTithiName[checked(Conversions.ToInteger(oleDbDataReader["tithi"]) - 1)];
					str = NepDate.arBSDayNo[Conversions.ToInteger(oleDbDataReader["event_day"])];
					Color color = colorArray[0];
					if (!flag1)
					{
						flag = oleDbDataReader1.Read();
						flag1 = true;
					}
					if (flag && Conversions.ToInteger(oleDbDataReader1["event_day"]) == Conversions.ToInteger(oleDbDataReader["event_day"]))
					{
						str1 = string.Concat(Conversions.ToString(oleDbDataReader1["event_title"]), " / ", NepDate.arTithiName[checked(Conversions.ToInteger(oleDbDataReader["tithi"]) - 1)]);
						color = colorArray[Conversions.ToInteger(oleDbDataReader1["holiday"])];
						str = NepDate.arBSDayNo[Conversions.ToInteger(oleDbDataReader1["event_day"])];
						if (Conversions.ToInteger(oleDbDataReader1["holiday"]) > 0)
						{
							num = Conversions.ToShort(oleDbDataReader1["event_day"]);
						}
						i = num1;
						while (i <= 41)
						{
							if (num <= 0 || Operators.CompareString(this.lblDayA[i].Text, NepDate.arBSDayNo[num], false) != 0)
							{
								i = checked((short)(i + 1));
							}
							else
							{
								this.lblDayA[i].ForeColor = colorArray[Conversions.ToInteger(oleDbDataReader1["holiday"])];
								num1 = i;
								num = 0;
								break;
							}
						}
						flag1 = false;
					}
					listViewItem.SubItems.Add(str1);
					listViewItem.SubItems[0].ForeColor = color;
					for (i = num1; i <= 41; i = checked((short)(i + 1)))
					{
						if (Operators.CompareString(this.lblDayA[i].Text, str, false) == 0)
						{
							this.iLVItemIndex[i] = num2;
							num1 = i;
						}
					}
					num2 = checked((short)(num2 + 1));
				}
				oleDbDataReader.Close();
			}
			oleDbDataReader1.Close();
			if (this.lvEvents.Items.Count == 0)
			{
				listViewItem = this.lvEvents.Items.Add(" ");
				listViewItem.SubItems.Add("(No events found.)");
				this.lvEvents.Enabled = false;
			}
		}

		private void LoadMiscEvent(short iYear, short iMonth, short iDay)
		{
			short num = 0;
			do
			{
				this.lblME[num].Visible = false;
				this.lblME[num].Text = "0";
				this.lblUE[num].Visible = false;
				num = checked((short)(num + 1));
			}
			while (num <= 41);
			this.txtSelectedEventM.Text = "";
			if (!mdl_DB.IsPEDBLoaded)
			{
				this.lvEventsM.Items.Clear();
				this.lvEventsM.Items.Add(" ");
				this.lvEventsM.Items[0].SubItems.Add("(Please, update calendar data.)");
				this.SetStatus("Calendar data not found. Download calendar data by clicking on 'Calendar -> Update Calendar Data'.", Color.Red);
				this.lvEventsM.Enabled = false;
				this.txtSelectedEventM.Text = "(Please, update calendar data.)";
				return;
			}
			int num1 = checked(checked(iYear * 10000) + checked(iMonth * 100));
			int num2 = checked(num1 + 33);
			string[] str = new string[] { "SELECT * FROM mevents WHERE(event_date>", Conversions.ToString(num1), " AND event_date<", Conversions.ToString(num2), ") ORDER BY event_date" };
			OleDbDataReader oleDbDataReader = mdl_DB.DBQuery(string.Concat(str));
			short num3 = 0;
			this.lvEventsM.Enabled = true;
			this.lvEventsM.Items.Clear();
		Label0:
			while (oleDbDataReader.Read())
			{
				string str1 = NepDate.arBSDayNo[Conversions.ToInteger(oleDbDataReader["event_date"]) % 100];
				ListViewItem listViewItem = this.lvEventsM.Items.Add(string.Concat(NepDate.arBSMonthName[checked(iMonth - 1)], " ", str1));
				listViewItem.SubItems.Add(Conversions.ToString(oleDbDataReader["event_title"]));
				num = num3;
				while (num <= 41)
				{
					if (Operators.CompareString(this.lblDayA[num].Text, str1, false) != 0)
					{
						num = checked((short)(num + 1));
					}
					else
					{
						this.lblME[num].Visible = true;
						this.lblME[num].Text = Conversions.ToString(checked(Conversions.ToShort(this.lblME[num].Text) + 1));
						num3 = num;
						goto Label0;
					}
				}
			}
			oleDbDataReader.Close();
		}

		private void lvEvents_Click(object sender, EventArgs e)
		{
			if (this.lvEvents.Items.Count == 0)
			{
				return;
			}
			this.txtSelectedEvent.Text = string.Concat(this.lvEvents.SelectedItems[0].Text, " - ", this.lvEvents.SelectedItems[0].SubItems[1].Text);
			this.txtSelectedEvent.ForeColor = this.lvEvents.SelectedItems[0].ForeColor;
			this.b = this.lvEvents.SelectedIndices[0];
			this.a = 0;
			do
			{
				if (this.iLVItemIndex[this.a] != this.b)
				{
					Calendar calendar = this;
					calendar.a = checked(calendar.a + 1);
				}
				else
				{
					this.IsUserClick = false;
					this.lblDay_Click(this.lblDayA[this.a], e);
					this.IsUserClick = true;
					break;
				}
			}
			while (this.a <= 41);
		}

		private void lvEvents_DoubleClick(object sender, EventArgs e)
		{
			if (this.lvEvents.Items.Count == 0)
			{
				return;
			}
			Interaction.MsgBox(this.lvEvents.SelectedItems[0].SubItems[1].Text, MsgBoxStyle.OkOnly, string.Concat(this.cboBSYear.Text, " ", this.lvEvents.SelectedItems[0].Text, " गते"));
		}

		private void lvEventsM_Click(object sender, EventArgs e)
		{
			if (this.lvEventsM.Items.Count == 0)
			{
				return;
			}
			this.txtSelectedEventM.Text = string.Concat(this.lvEventsM.SelectedItems[0].Text, " - ", this.lvEventsM.SelectedItems[0].SubItems[1].Text);
			this.txtSelectedEventM.ForeColor = this.lvEventsM.SelectedItems[0].ForeColor;
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuShowTithi_Click(object sender, EventArgs e)
		{
			if (!this.mnuShowTithi.Checked)
			{
				this.mnuShowTithi.Checked = true;
			}
			else
			{
				this.mnuShowTithi.Checked = false;
			}
			this.IsShowTithi = this.mnuShowTithi.Checked;
			this.FillCalendar(this.iSelYear, this.iSelMonth, 0);
		}

		private void mnuToday_Click(object sender, EventArgs e)
		{
			this.FillCalendar(mdlMain.GiCurBSYear, mdlMain.GiCurBSMonth, mdlMain.GiCurBSDay);
			this.SetBSYearMonthIndex(mdlMain.GiCurBSYear, mdlMain.GiCurBSMonth);
		}

		private void mnuUpdateData_Click(object sender, EventArgs e)
		{
			if (!mdlMain.IsInternetConnected())
			{
				this.SetStatus("No internet connection...", Color.Red);
				Interaction.MsgBox("No internet connection.", MsgBoxStyle.Exclamation, null);
				this.Timer1.Enabled = true;
				return;
			}
			this.SetStatus("Updating calendar data...", Color.Blue);
			this.mnuUpdateData.Enabled = false;
			this.pnlCalendar.Enabled = false;
			mdl_DB.DBDisconnect();
			try
			{
				if (File.Exists(string.Concat(mdlMain.GsDataDir, "\\temp.db")))
				{
					File.Delete(string.Concat(mdlMain.GsDataDir, "\\temp.db"));
				}
				MyProject.Computer.Network.DownloadFile("http://nareshmdr.com.np/android_data/nepalicalendar/nmb_pedb", string.Concat(mdlMain.GsDataDir, "\\temp.db"));
				if (File.Exists(mdl_DB.GsDBPath))
				{
					File.Delete(mdl_DB.GsDBPath);
				}
				MyProject.Computer.FileSystem.RenameFile(string.Concat(mdlMain.GsDataDir, "\\temp.db"), "nmb_pedb");
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				this.SetStatus("Calendar data update failed...", Color.Red);
				Interaction.MsgBox("Failed to update calendar data.\r\nPlease, try again later.", MsgBoxStyle.Critical, null);
				mdl_DB.DBConnect();
				this.mnuUpdateData.Enabled = true;
				this.pnlCalendar.Enabled = true;
				this.Timer1.Enabled = true;
				ProjectData.ClearProjectError();
				return;
			}
			MySettingsProperty.Settings["DBLastUpdated"] = DateAndTime.Today;
			this.SetStatus("Calendar data update successful...", Color.Green);
			Interaction.MsgBox("Calendar data updated successfully.", MsgBoxStyle.Information, null);
			mdl_DB.DBConnect();
			this.cboBSYear_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			this.mnuUpdateData.Enabled = true;
			this.pnlCalendar.Enabled = true;
			this.Timer1.Enabled = true;
		}

		private void pnlStatus_Click(object sender, EventArgs e)
		{
		}

		private void SetBSYearMonthIndex(short iYear, short iMonth)
		{
			this.cboBSYear.SelectedIndex = checked(iYear - 1990);
			this.cboBSMonth.SelectedIndex = checked(iMonth - 1);
		}

		public void SetStatus(string sText, Color cColor)
		{
			this.lblStatus.Text = sText;
			this.lblStatus.ForeColor = cColor;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.SetStatus(string.Concat("Data last updated on ", this.GetDBLastUpdated()), Color.Black);
			this.Timer1.Enabled = false;
		}
	}
}