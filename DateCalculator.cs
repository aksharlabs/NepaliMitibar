using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	[DesignerGenerated]
	public class DateCalculator : Form
	{
		private IContainer components;

		[AccessedThroughProperty("btnCalculate")]
		private Button _btnCalculate;

		[AccessedThroughProperty("gbDate")]
		private GroupBox _gbDate;

		[AccessedThroughProperty("cboBSDay")]
		private ComboBox _cboBSDay;

		[AccessedThroughProperty("cboBSMonth")]
		private ComboBox _cboBSMonth;

		[AccessedThroughProperty("cboBSYear")]
		private ComboBox _cboBSYear;

		[AccessedThroughProperty("gbDate1")]
		private GroupBox _gbDate1;

		[AccessedThroughProperty("cboBSDay1")]
		private ComboBox _cboBSDay1;

		[AccessedThroughProperty("cboBSMonth1")]
		private ComboBox _cboBSMonth1;

		[AccessedThroughProperty("cboBSYear1")]
		private ComboBox _cboBSYear1;

		[AccessedThroughProperty("gbDateAdd")]
		private GroupBox _gbDateAdd;

		[AccessedThroughProperty("rbSubtract")]
		private RadioButton _rbSubtract;

		[AccessedThroughProperty("rbAdd")]
		private RadioButton _rbAdd;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("gbResult")]
		private GroupBox _gbResult;

		[AccessedThroughProperty("txtResult")]
		private TextBox _txtResult;

		[AccessedThroughProperty("txtYear")]
		private TextBox _txtYear;

		[AccessedThroughProperty("txtDay")]
		private TextBox _txtDay;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("txtMonth")]
		private TextBox _txtMonth;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("rbAge")]
		private RadioButton _rbAge;

		[AccessedThroughProperty("rbDateDiff")]
		private RadioButton _rbDateDiff;

		[AccessedThroughProperty("rbDateAdd")]
		private RadioButton _rbDateAdd;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		private short iCalc;

		internal virtual Button btnCalculate
		{
			get
			{
				return this._btnCalculate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.btnCalculate_Click);
				if (this._btnCalculate != null)
				{
					this._btnCalculate.Click -= eventHandler;
				}
				this._btnCalculate = value;
				if (this._btnCalculate != null)
				{
					this._btnCalculate.Click += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboBSDay
		{
			get
			{
				return this._cboBSDay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSDay_TextChanged);
				if (this._cboBSDay != null)
				{
					this._cboBSDay.TextChanged -= eventHandler;
				}
				this._cboBSDay = value;
				if (this._cboBSDay != null)
				{
					this._cboBSDay.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboBSDay1
		{
			get
			{
				return this._cboBSDay1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSDay1_TextChanged);
				if (this._cboBSDay1 != null)
				{
					this._cboBSDay1.TextChanged -= eventHandler;
				}
				this._cboBSDay1 = value;
				if (this._cboBSDay1 != null)
				{
					this._cboBSDay1.TextChanged += eventHandler;
				}
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
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSMonth_TextChanged);
				if (this._cboBSMonth != null)
				{
					this._cboBSMonth.TextChanged -= eventHandler;
				}
				this._cboBSMonth = value;
				if (this._cboBSMonth != null)
				{
					this._cboBSMonth.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboBSMonth1
		{
			get
			{
				return this._cboBSMonth1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSMonth1_TextChanged);
				if (this._cboBSMonth1 != null)
				{
					this._cboBSMonth1.TextChanged -= eventHandler;
				}
				this._cboBSMonth1 = value;
				if (this._cboBSMonth1 != null)
				{
					this._cboBSMonth1.TextChanged += eventHandler;
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
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSYear_TextChanged);
				if (this._cboBSYear != null)
				{
					this._cboBSYear.TextChanged -= eventHandler;
				}
				this._cboBSYear = value;
				if (this._cboBSYear != null)
				{
					this._cboBSYear.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboBSYear1
		{
			get
			{
				return this._cboBSYear1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.cboBSYear11_TextChanged);
				if (this._cboBSYear1 != null)
				{
					this._cboBSYear1.TextChanged -= eventHandler;
				}
				this._cboBSYear1 = value;
				if (this._cboBSYear1 != null)
				{
					this._cboBSYear1.TextChanged += eventHandler;
				}
			}
		}

		internal virtual GroupBox gbDate
		{
			get
			{
				return this._gbDate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbDate = value;
			}
		}

		internal virtual GroupBox gbDate1
		{
			get
			{
				return this._gbDate1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbDate1 = value;
			}
		}

		internal virtual GroupBox gbDateAdd
		{
			get
			{
				return this._gbDateAdd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbDateAdd = value;
			}
		}

		internal virtual GroupBox gbResult
		{
			get
			{
				return this._gbResult;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gbResult = value;
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

		internal virtual RadioButton rbAdd
		{
			get
			{
				return this._rbAdd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbAdd = value;
			}
		}

		internal virtual RadioButton rbAge
		{
			get
			{
				return this._rbAge;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.rbAge_CheckedChanged);
				DateCalculator dateCalculator1 = this;
				EventHandler eventHandler1 = new EventHandler(dateCalculator1.rbAge_Click);
				if (this._rbAge != null)
				{
					this._rbAge.CheckedChanged -= eventHandler;
					this._rbAge.Click -= eventHandler1;
				}
				this._rbAge = value;
				if (this._rbAge != null)
				{
					this._rbAge.CheckedChanged += eventHandler;
					this._rbAge.Click += eventHandler1;
				}
			}
		}

		internal virtual RadioButton rbDateAdd
		{
			get
			{
				return this._rbDateAdd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.rbDateAdd_Click);
				if (this._rbDateAdd != null)
				{
					this._rbDateAdd.Click -= eventHandler;
				}
				this._rbDateAdd = value;
				if (this._rbDateAdd != null)
				{
					this._rbDateAdd.Click += eventHandler;
				}
			}
		}

		internal virtual RadioButton rbDateDiff
		{
			get
			{
				return this._rbDateDiff;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateCalculator dateCalculator = this;
				EventHandler eventHandler = new EventHandler(dateCalculator.rbDateDiff_CheckedChanged);
				if (this._rbDateDiff != null)
				{
					this._rbDateDiff.CheckedChanged -= eventHandler;
				}
				this._rbDateDiff = value;
				if (this._rbDateDiff != null)
				{
					this._rbDateDiff.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton rbSubtract
		{
			get
			{
				return this._rbSubtract;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbSubtract = value;
			}
		}

		internal virtual TextBox txtDay
		{
			get
			{
				return this._txtDay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDay = value;
			}
		}

		internal virtual TextBox txtMonth
		{
			get
			{
				return this._txtMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtMonth = value;
			}
		}

		internal virtual TextBox txtResult
		{
			get
			{
				return this._txtResult;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtResult = value;
			}
		}

		internal virtual TextBox txtYear
		{
			get
			{
				return this._txtYear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtYear = value;
			}
		}

		public DateCalculator()
		{
			DateCalculator dateCalculator = this;
			base.Load += new EventHandler(dateCalculator.DateCalculator_Load);
			this.InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			DateTime dateTime = new DateTime();
			int integer = 0;
			int selectedIndex = 0;
			int num = 0;
			string str;
			string[] strArrays;
			int num1;
			int num2;
			if (this.cboBSYear.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid Year", MsgBoxStyle.Information, null);
				this.cboBSYear.Focus();
				return;
			}
			if (this.cboBSMonth.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid Month", MsgBoxStyle.Information, null);
				this.cboBSMonth.Focus();
				return;
			}
			if (this.cboBSDay.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid Day", MsgBoxStyle.Information, null);
				this.cboBSDay.Focus();
				return;
			}
			int integer1 = mdlMain.NepNum2Num(this.cboBSYear.Text);
			int selectedIndex1 = checked(this.cboBSMonth.SelectedIndex + 1);
			int integer2 = mdlMain.NepNum2Num(this.cboBSDay.Text);
			short num3 = NepDate.BSMonthLen(checked((short)integer1), checked((short)selectedIndex1));
			if (integer2 > num3)
			{
				Interaction.MsgBox(string.Concat("Invalid Day.\r\nDay must be between 1 and ", Conversions.ToString((int)num3), " for the selected month."), MsgBoxStyle.Information, null);
				this.cboBSDay.Focus();
				return;
			}
			DateTime dateTime1 = NepDate.BS2AD(checked((short)integer1), checked((short)selectedIndex1), checked((short)integer2));
			if (this.iCalc == 0 | this.iCalc == 1)
			{
				if (this.iCalc == 0)
				{
					dateTime = DateAndTime.Today;
					if (DateTime.Compare(dateTime1, dateTime) > 0)
					{
						Interaction.MsgBox("'Date of Birth' must be before 'Today'.", MsgBoxStyle.Information, null);
						return;
					}
					str = NepDate.AD2BS(dateTime);
					strArrays = Strings.Split(str, NepDate.sDateSep, -1, CompareMethod.Binary);
					num = Conversions.ToInteger(strArrays[0]);
					selectedIndex = Conversions.ToInteger(strArrays[1]);
					integer = Conversions.ToInteger(strArrays[2]);
				}
				else if (this.iCalc == 1)
				{
					if (this.cboBSYear1.SelectedIndex < 0)
					{
						Interaction.MsgBox("Invalid Year", MsgBoxStyle.Information, null);
						this.cboBSYear1.Focus();
						return;
					}
					if (this.cboBSMonth1.SelectedIndex < 0)
					{
						Interaction.MsgBox("Invalid Month", MsgBoxStyle.Information, null);
						this.cboBSMonth1.Focus();
						return;
					}
					if (this.cboBSDay1.SelectedIndex < 0)
					{
						Interaction.MsgBox("Invalid Day", MsgBoxStyle.Information, null);
						this.cboBSDay1.Focus();
						return;
					}
					num = mdlMain.NepNum2Num(this.cboBSYear1.Text);
					selectedIndex = checked(this.cboBSMonth1.SelectedIndex + 1);
					integer = mdlMain.NepNum2Num(this.cboBSDay1.Text);
					num3 = NepDate.BSMonthLen(checked((short)num), checked((short)selectedIndex));
					if (integer > num3)
					{
						Interaction.MsgBox(string.Concat("Invalid Day.\r\nDay must be between 1 and ", Conversions.ToString((int)num3), " for the selected month."), MsgBoxStyle.Information, null);
						this.cboBSDay.Focus();
						return;
					}
					dateTime = NepDate.BS2AD(checked((short)num), checked((short)selectedIndex), checked((short)integer));
					if (DateTime.Compare(dateTime1, dateTime) > 0)
					{
						Interaction.MsgBox("'Second Date' must be greater than 'First Date'.", MsgBoxStyle.Information, null);
						return;
					}
				}
				int num4 = checked((int)DateAndTime.DateDiff("d", dateTime1, dateTime, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
				int num5 = checked(num - integer1);
				if (selectedIndex < selectedIndex1)
				{
					num5 = checked(num5 - 1);
					num2 = checked(12 - (checked(selectedIndex1 - selectedIndex)));
					if (integer < integer2)
					{
						num2 = checked(num2 - 1);
						num1 = checked(NepDate.BSMonthLen(checked((short)integer1), checked((short)selectedIndex1)) - (checked(integer2 - integer)));
					}
					else
					{
						num1 = checked(integer - integer2);
					}
				}
				else
				{
					num2 = checked(selectedIndex - selectedIndex1);
					if (integer < integer2)
					{
						num2 = checked(num2 - 1);
						num1 = checked(NepDate.BSMonthLen(checked((short)integer1), checked((short)selectedIndex1)) - (checked(integer2 - integer)));
					}
					else
					{
						num1 = checked(integer - integer2);
					}
				}
				if (num2 < 0)
				{
					num5 = checked(num5 - 1);
					num2 = checked(12 + num2);
				}
				this.txtResult.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(num5 == 0, "", string.Concat(mdlMain.Num2NepNum(Conversions.ToString(num5)), " वर्ष ")), Interaction.IIf(num2 == 0, "", string.Concat(mdlMain.Num2NepNum(Conversions.ToString(num2)), " महिना "))), Interaction.IIf(num1 == 0, "", string.Concat(mdlMain.Num2NepNum(Conversions.ToString(num1)), " दिन "))), " ("), mdlMain.Num2NepNum(Conversions.ToString(num4))), " दिन)"));
			}
			else if (this.iCalc == 2)
			{
				if (!Versioned.IsNumeric(this.txtYear.Text))
				{
					Interaction.MsgBox("Invalid year number.", MsgBoxStyle.Information, null);
					this.txtYear.Focus();
					return;
				}
				if (!Versioned.IsNumeric(this.txtMonth.Text))
				{
					Interaction.MsgBox("Invalid month number.", MsgBoxStyle.Information, null);
					this.txtMonth.Focus();
					return;
				}
				if (!Versioned.IsNumeric(this.txtDay.Text))
				{
					Interaction.MsgBox("Invalid day number.", MsgBoxStyle.Information, null);
					this.txtDay.Focus();
					return;
				}
				integer1 = Math.Abs(Conversions.ToInteger(this.txtYear.Text));
				selectedIndex1 = Math.Abs(Conversions.ToInteger(this.txtMonth.Text));
				integer2 = Math.Abs(Conversions.ToInteger(this.txtDay.Text));
				if (this.rbSubtract.Checked)
				{
					integer1 = checked(0 - integer1);
					selectedIndex1 = checked(0 - selectedIndex1);
					integer2 = checked(0 - integer2);
				}
				dateTime = DateAndTime.DateAdd(DateInterval.Year, (double)integer1, dateTime1);
				dateTime = DateAndTime.DateAdd(DateInterval.Month, (double)selectedIndex1, dateTime);
				dateTime = DateAndTime.DateAdd(DateInterval.Day, (double)integer2, dateTime);
				str = NepDate.AD2BS(dateTime);
				if (NepDate.IsDateOutOfRange)
				{
					Interaction.MsgBox("The date is out of range.", MsgBoxStyle.Exclamation, null);
					this.txtResult.Text = "";
					return;
				}
				strArrays = Strings.Split(str, NepDate.sDateSep, -1, CompareMethod.Binary);
				integer1 = Conversions.ToInteger(strArrays[0]);
				selectedIndex1 = Conversions.ToInteger(strArrays[1]);
				integer2 = Conversions.ToInteger(strArrays[2]);
				TextBox textBox = this.txtResult;
				string[] strArrays1 = new string[] { mdlMain.Num2NepNum(Conversions.ToString(integer1)), " ", NepDate.arBSMonthName[checked(selectedIndex1 - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString(integer2)), " गते ", NepDate.arBSDayName[(int)dateTime.DayOfWeek], "बार" };
				textBox.Text = string.Concat(strArrays1);
			}
		}

		private void cboBSDay_TextChanged(object sender, EventArgs e)
		{
			this.cboBSDay.Text = mdlMain.Num2NepNum(this.cboBSDay.Text);
			this.cboBSDay.SelectionStart = this.cboBSDay.Text.Length;
		}

		private void cboBSDay1_TextChanged(object sender, EventArgs e)
		{
			this.cboBSDay1.Text = mdlMain.Num2NepNum(this.cboBSDay1.Text);
			this.cboBSDay1.SelectionStart = this.cboBSDay1.Text.Length;
		}

		private void cboBSMonth_TextChanged(object sender, EventArgs e)
		{
			this.cboBSMonth.Text = mdlMain.Num2NepNum(this.cboBSMonth.Text);
			this.cboBSMonth.SelectionStart = this.cboBSMonth.Text.Length;
		}

		private void cboBSMonth1_TextChanged(object sender, EventArgs e)
		{
			this.cboBSMonth1.Text = mdlMain.Num2NepNum(this.cboBSMonth1.Text);
			this.cboBSMonth1.SelectionStart = this.cboBSMonth1.Text.Length;
		}

		private void cboBSYear_TextChanged(object sender, EventArgs e)
		{
			this.cboBSYear.Text = mdlMain.Num2NepNum(this.cboBSYear.Text);
			this.cboBSYear.SelectionStart = this.cboBSYear.Text.Length;
		}

		private void cboBSYear11_TextChanged(object sender, EventArgs e)
		{
			this.cboBSYear1.Text = mdlMain.Num2NepNum(this.cboBSYear1.Text);
			this.cboBSYear1.SelectionStart = this.cboBSYear1.Text.Length;
		}

		private void DateCalculator_Load(object sender, EventArgs e)
		{
			string[] strArrays = new string[] { "Date Calculator (", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSYear)), " ", NepDate.arBSMonthName[checked(mdlMain.GiCurBSMonth - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSDay)), ", ", null, null };
			strArrays[7] = NepDate.arBSDayName[(int)DateAndTime.Today.DayOfWeek];
			strArrays[8] = "बार)";
			this.Text = string.Concat(strArrays);
			this.cboBSYear.Items.Clear();
			this.cboBSYear1.Items.Clear();
			int num = 1990;
			do
			{
				this.cboBSYear.Items.Add(mdlMain.Num2NepNum(Conversions.ToString(num)));
				this.cboBSYear1.Items.Add(mdlMain.Num2NepNum(Conversions.ToString(num)));
				num = checked(num + 1);
			}
			while (num <= 2110);
			this.cboBSMonth.Items.Clear();
			this.cboBSMonth1.Items.Clear();
			int num1 = 0;
			do
			{
				this.cboBSMonth.Items.Add(string.Concat(mdlMain.Num2NepNum(Conversions.ToString(checked(num1 + 1))), ". ", NepDate.arBSMonthName[num1]));
				this.cboBSMonth1.Items.Add(string.Concat(mdlMain.Num2NepNum(Conversions.ToString(checked(num1 + 1))), ". ", NepDate.arBSMonthName[num1]));
				num1 = checked(num1 + 1);
			}
			while (num1 <= 11);
			this.cboBSDay.Items.Clear();
			this.cboBSDay1.Items.Clear();
			int num2 = 1;
			do
			{
				this.cboBSDay.Items.Add(mdlMain.Num2NepNum(Conversions.ToString(num2)));
				this.cboBSDay1.Items.Add(mdlMain.Num2NepNum(Conversions.ToString(num2)));
				num2 = checked(num2 + 1);
			}
			while (num2 <= 31);
			this.cboBSDay.Items.Add("३२");
			this.cboBSDay1.Items.Add("३२");
			this.cboBSYear.SelectedIndex = checked(mdlMain.GiCurBSYear - 1990);
			this.cboBSMonth.SelectedIndex = checked(mdlMain.GiCurBSMonth - 1);
			this.cboBSDay.SelectedIndex = checked(mdlMain.GiCurBSDay - 1);
			this.cboBSYear1.SelectedIndex = this.cboBSYear.SelectedIndex;
			this.cboBSMonth1.SelectedIndex = this.cboBSMonth.SelectedIndex;
			this.cboBSDay1.SelectedIndex = this.cboBSDay.SelectedIndex;
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

		private void InitCtrl(short iOpt)
		{
			if (iOpt == 0)
			{
				this.gbDate.Text = "Date of Birth:";
				this.gbDate.Enabled = true;
				this.gbDate1.Enabled = false;
				this.gbDateAdd.Enabled = false;
			}
			else if (iOpt == 1)
			{
				this.gbDate.Text = "From:";
				this.gbDate.Enabled = true;
				this.gbDate1.Enabled = true;
				this.gbDateAdd.Enabled = false;
			}
			else if (iOpt == 2)
			{
				this.gbDate.Text = "From:";
				this.gbDate.Enabled = true;
				this.gbDate1.Enabled = false;
				this.gbDateAdd.Enabled = true;
			}
			this.txtResult.Text = "";
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btnCalculate = new Button();
			this.gbDate = new GroupBox();
			this.cboBSDay = new ComboBox();
			this.cboBSMonth = new ComboBox();
			this.cboBSYear = new ComboBox();
			this.gbDate1 = new GroupBox();
			this.cboBSDay1 = new ComboBox();
			this.cboBSMonth1 = new ComboBox();
			this.cboBSYear1 = new ComboBox();
			this.gbDateAdd = new GroupBox();
			this.txtDay = new TextBox();
			this.Label3 = new Label();
			this.txtMonth = new TextBox();
			this.Label1 = new Label();
			this.txtYear = new TextBox();
			this.rbSubtract = new RadioButton();
			this.rbAdd = new RadioButton();
			this.Label2 = new Label();
			this.gbResult = new GroupBox();
			this.txtResult = new TextBox();
			this.rbAge = new RadioButton();
			this.rbDateDiff = new RadioButton();
			this.rbDateAdd = new RadioButton();
			this.Label4 = new Label();
			this.gbDate.SuspendLayout();
			this.gbDate1.SuspendLayout();
			this.gbDateAdd.SuspendLayout();
			this.gbResult.SuspendLayout();
			this.SuspendLayout();
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button = this.btnCalculate;
			Point point = new Point(348, 84);
			button.Location = point;
			this.btnCalculate.Name = "btnCalculate";
			Button button1 = this.btnCalculate;
			System.Drawing.Size size = new System.Drawing.Size(127, 54);
			button1.Size = size;
			this.btnCalculate.TabIndex = 14;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.gbDate.Controls.Add(this.cboBSDay);
			this.gbDate.Controls.Add(this.cboBSMonth);
			this.gbDate.Controls.Add(this.cboBSYear);
			this.gbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox = this.gbDate;
			point = new Point(25, 155);
			groupBox.Location = point;
			this.gbDate.Name = "gbDate";
			GroupBox groupBox1 = this.gbDate;
			size = new System.Drawing.Size(450, 79);
			groupBox1.Size = size;
			this.gbDate.TabIndex = 19;
			this.gbDate.TabStop = false;
			this.gbDate.Text = "From:";
			this.cboBSDay.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSDay.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSDay.DropDownHeight = 300;
			this.cboBSDay.FlatStyle = FlatStyle.Popup;
			this.cboBSDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSDay.FormattingEnabled = true;
			this.cboBSDay.IntegralHeight = false;
			this.cboBSDay.ItemHeight = 29;
			ComboBox comboBox = this.cboBSDay;
			point = new Point(349, 27);
			comboBox.Location = point;
			ComboBox comboBox1 = this.cboBSDay;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(4);
			comboBox1.Margin = padding;
			this.cboBSDay.Name = "cboBSDay";
			ComboBox comboBox2 = this.cboBSDay;
			size = new System.Drawing.Size(90, 37);
			comboBox2.Size = size;
			this.cboBSDay.TabIndex = 5;
			this.cboBSMonth.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSMonth.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSMonth.FlatStyle = FlatStyle.Popup;
			this.cboBSMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSMonth.FormattingEnabled = true;
			this.cboBSMonth.ItemHeight = 29;
			ComboBox comboBox3 = this.cboBSMonth;
			point = new Point(138, 27);
			comboBox3.Location = point;
			ComboBox comboBox4 = this.cboBSMonth;
			padding = new System.Windows.Forms.Padding(4);
			comboBox4.Margin = padding;
			this.cboBSMonth.Name = "cboBSMonth";
			ComboBox comboBox5 = this.cboBSMonth;
			size = new System.Drawing.Size(203, 37);
			comboBox5.Size = size;
			this.cboBSMonth.TabIndex = 4;
			this.cboBSYear.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSYear.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSYear.DropDownHeight = 300;
			this.cboBSYear.FlatStyle = FlatStyle.Popup;
			this.cboBSYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSYear.FormattingEnabled = true;
			this.cboBSYear.IntegralHeight = false;
			this.cboBSYear.ItemHeight = 29;
			ComboBox comboBox6 = this.cboBSYear;
			point = new Point(17, 27);
			comboBox6.Location = point;
			ComboBox comboBox7 = this.cboBSYear;
			padding = new System.Windows.Forms.Padding(4);
			comboBox7.Margin = padding;
			this.cboBSYear.Name = "cboBSYear";
			ComboBox comboBox8 = this.cboBSYear;
			size = new System.Drawing.Size(113, 37);
			comboBox8.Size = size;
			this.cboBSYear.TabIndex = 3;
			this.gbDate1.Controls.Add(this.cboBSDay1);
			this.gbDate1.Controls.Add(this.cboBSMonth1);
			this.gbDate1.Controls.Add(this.cboBSYear1);
			this.gbDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox2 = this.gbDate1;
			point = new Point(25, 246);
			groupBox2.Location = point;
			this.gbDate1.Name = "gbDate1";
			GroupBox groupBox3 = this.gbDate1;
			size = new System.Drawing.Size(450, 79);
			groupBox3.Size = size;
			this.gbDate1.TabIndex = 20;
			this.gbDate1.TabStop = false;
			this.gbDate1.Text = "To:";
			this.cboBSDay1.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSDay1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSDay1.DropDownHeight = 300;
			this.cboBSDay1.FlatStyle = FlatStyle.Popup;
			this.cboBSDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSDay1.FormattingEnabled = true;
			this.cboBSDay1.IntegralHeight = false;
			this.cboBSDay1.ItemHeight = 29;
			ComboBox comboBox9 = this.cboBSDay1;
			point = new Point(349, 27);
			comboBox9.Location = point;
			ComboBox comboBox10 = this.cboBSDay1;
			padding = new System.Windows.Forms.Padding(4);
			comboBox10.Margin = padding;
			this.cboBSDay1.Name = "cboBSDay1";
			ComboBox comboBox11 = this.cboBSDay1;
			size = new System.Drawing.Size(90, 37);
			comboBox11.Size = size;
			this.cboBSDay1.TabIndex = 8;
			this.cboBSMonth1.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSMonth1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSMonth1.FlatStyle = FlatStyle.Popup;
			this.cboBSMonth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSMonth1.FormattingEnabled = true;
			this.cboBSMonth1.ItemHeight = 29;
			ComboBox comboBox12 = this.cboBSMonth1;
			point = new Point(138, 27);
			comboBox12.Location = point;
			ComboBox comboBox13 = this.cboBSMonth1;
			padding = new System.Windows.Forms.Padding(4);
			comboBox13.Margin = padding;
			this.cboBSMonth1.Name = "cboBSMonth1";
			ComboBox comboBox14 = this.cboBSMonth1;
			size = new System.Drawing.Size(203, 37);
			comboBox14.Size = size;
			this.cboBSMonth1.TabIndex = 7;
			this.cboBSYear1.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSYear1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSYear1.DropDownHeight = 300;
			this.cboBSYear1.FlatStyle = FlatStyle.Popup;
			this.cboBSYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSYear1.FormattingEnabled = true;
			this.cboBSYear1.IntegralHeight = false;
			this.cboBSYear1.ItemHeight = 29;
			ComboBox comboBox15 = this.cboBSYear1;
			point = new Point(17, 27);
			comboBox15.Location = point;
			ComboBox comboBox16 = this.cboBSYear1;
			padding = new System.Windows.Forms.Padding(4);
			comboBox16.Margin = padding;
			this.cboBSYear1.Name = "cboBSYear1";
			ComboBox comboBox17 = this.cboBSYear1;
			size = new System.Drawing.Size(113, 37);
			comboBox17.Size = size;
			this.cboBSYear1.TabIndex = 6;
			this.gbDateAdd.Controls.Add(this.txtDay);
			this.gbDateAdd.Controls.Add(this.Label3);
			this.gbDateAdd.Controls.Add(this.txtMonth);
			this.gbDateAdd.Controls.Add(this.Label1);
			this.gbDateAdd.Controls.Add(this.txtYear);
			this.gbDateAdd.Controls.Add(this.rbSubtract);
			this.gbDateAdd.Controls.Add(this.rbAdd);
			this.gbDateAdd.Controls.Add(this.Label2);
			this.gbDateAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox4 = this.gbDateAdd;
			point = new Point(25, 338);
			groupBox4.Location = point;
			this.gbDateAdd.Name = "gbDateAdd";
			GroupBox groupBox5 = this.gbDateAdd;
			size = new System.Drawing.Size(450, 150);
			groupBox5.Size = size;
			this.gbDateAdd.TabIndex = 21;
			this.gbDateAdd.TabStop = false;
			this.gbDateAdd.Text = "Add/Subtract";
			this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBox = this.txtDay;
			point = new Point(262, 92);
			textBox.Location = point;
			this.txtDay.MaxLength = 4;
			this.txtDay.Name = "txtDay";
			TextBox textBox1 = this.txtDay;
			size = new System.Drawing.Size(100, 30);
			textBox1.Size = size;
			this.txtDay.TabIndex = 13;
			this.txtDay.Text = "0";
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(258, 69);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label = this.Label3;
			size = new System.Drawing.Size(39, 20);
			label.Size = size;
			this.Label3.TabIndex = 23;
			this.Label3.Text = "Day";
			this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBox2 = this.txtMonth;
			point = new Point(138, 92);
			textBox2.Location = point;
			this.txtMonth.MaxLength = 3;
			this.txtMonth.Name = "txtMonth";
			TextBox textBox3 = this.txtMonth;
			size = new System.Drawing.Size(100, 30);
			textBox3.Size = size;
			this.txtMonth.TabIndex = 12;
			this.txtMonth.Text = "0";
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(134, 69);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(55, 20);
			label11.Size = size;
			this.Label1.TabIndex = 21;
			this.Label1.Text = "Month";
			this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBox4 = this.txtYear;
			point = new Point(17, 92);
			textBox4.Location = point;
			this.txtYear.MaxLength = 2;
			this.txtYear.Name = "txtYear";
			TextBox textBox5 = this.txtYear;
			size = new System.Drawing.Size(100, 30);
			textBox5.Size = size;
			this.txtYear.TabIndex = 11;
			this.txtYear.Text = "0";
			this.rbSubtract.AutoSize = true;
			RadioButton radioButton = this.rbSubtract;
			point = new Point(154, 31);
			radioButton.Location = point;
			this.rbSubtract.Name = "rbSubtract";
			RadioButton radioButton1 = this.rbSubtract;
			size = new System.Drawing.Size(93, 24);
			radioButton1.Size = size;
			this.rbSubtract.TabIndex = 10;
			this.rbSubtract.Text = "Subtract";
			this.rbSubtract.UseVisualStyleBackColor = true;
			this.rbAdd.AutoSize = true;
			this.rbAdd.Checked = true;
			RadioButton radioButton2 = this.rbAdd;
			point = new Point(17, 31);
			radioButton2.Location = point;
			this.rbAdd.Name = "rbAdd";
			RadioButton radioButton3 = this.rbAdd;
			size = new System.Drawing.Size(59, 24);
			radioButton3.Size = size;
			this.rbAdd.TabIndex = 9;
			this.rbAdd.TabStop = true;
			this.rbAdd.Text = "Add";
			this.rbAdd.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(13, 69);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(43, 20);
			label21.Size = size;
			this.Label2.TabIndex = 17;
			this.Label2.Text = "Year";
			this.gbResult.Controls.Add(this.txtResult);
			this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox6 = this.gbResult;
			point = new Point(25, 503);
			groupBox6.Location = point;
			this.gbResult.Name = "gbResult";
			GroupBox groupBox7 = this.gbResult;
			size = new System.Drawing.Size(450, 73);
			groupBox7.Size = size;
			this.gbResult.TabIndex = 22;
			this.gbResult.TabStop = false;
			this.gbResult.Text = "Result:";
			this.txtResult.BackColor = SystemColors.Control;
			this.txtResult.BorderStyle = BorderStyle.None;
			this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtResult.ForeColor = Color.Red;
			TextBox textBox6 = this.txtResult;
			point = new Point(17, 30);
			textBox6.Location = point;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			TextBox textBox7 = this.txtResult;
			size = new System.Drawing.Size(422, 27);
			textBox7.Size = size;
			this.txtResult.TabIndex = 16;
			this.txtResult.TabStop = false;
			this.txtResult.Text = "साल, महिना र गते छान्नुहोस् ।";
			this.rbAge.AutoSize = true;
			this.rbAge.Checked = true;
			this.rbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RadioButton radioButton4 = this.rbAge;
			point = new Point(42, 54);
			radioButton4.Location = point;
			this.rbAge.Name = "rbAge";
			RadioButton radioButton5 = this.rbAge;
			size = new System.Drawing.Size(59, 24);
			radioButton5.Size = size;
			this.rbAge.TabIndex = 0;
			this.rbAge.TabStop = true;
			this.rbAge.Text = "Age";
			this.rbAge.UseVisualStyleBackColor = true;
			this.rbDateDiff.AutoSize = true;
			this.rbDateDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RadioButton radioButton6 = this.rbDateDiff;
			point = new Point(42, 84);
			radioButton6.Location = point;
			this.rbDateDiff.Name = "rbDateDiff";
			RadioButton radioButton7 = this.rbDateDiff;
			size = new System.Drawing.Size(149, 24);
			radioButton7.Size = size;
			this.rbDateDiff.TabIndex = 1;
			this.rbDateDiff.Text = "Date Difference";
			this.rbDateDiff.UseVisualStyleBackColor = true;
			this.rbDateAdd.AutoSize = true;
			this.rbDateAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RadioButton radioButton8 = this.rbDateAdd;
			point = new Point(42, 114);
			radioButton8.Location = point;
			this.rbDateAdd.Name = "rbDateAdd";
			RadioButton radioButton9 = this.rbDateAdd;
			size = new System.Drawing.Size(171, 24);
			radioButton9.Size = size;
			this.rbDateAdd.TabIndex = 2;
			this.rbDateAdd.Text = "Add/Subtract Days";
			this.rbDateAdd.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Underline, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(21, 22);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(138, 20);
			label41.Size = size;
			this.Label4.TabIndex = 23;
			this.Label4.Text = "Calculation Mode";
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(500, 599);
			this.ClientSize = size;
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.rbDateAdd);
			this.Controls.Add(this.rbDateDiff);
			this.Controls.Add(this.rbAge);
			this.Controls.Add(this.gbResult);
			this.Controls.Add(this.gbDateAdd);
			this.Controls.Add(this.gbDate1);
			this.Controls.Add(this.gbDate);
			this.Controls.Add(this.btnCalculate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DateCalculator";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Date Calculator";
			this.gbDate.ResumeLayout(false);
			this.gbDate1.ResumeLayout(false);
			this.gbDateAdd.ResumeLayout(false);
			this.gbDateAdd.PerformLayout();
			this.gbResult.ResumeLayout(false);
			this.gbResult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void rbAge_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void rbAge_Click(object sender, EventArgs e)
		{
			this.gbResult.Text = "Result (Age):";
			this.iCalc = 0;
			this.InitCtrl(this.iCalc);
		}

		private void rbDateAdd_Click(object sender, EventArgs e)
		{
			this.gbResult.Text = "Result (Date):";
			this.iCalc = 2;
			this.InitCtrl(this.iCalc);
		}

		private void rbDateDiff_CheckedChanged(object sender, EventArgs e)
		{
			this.gbResult.Text = "Result (Difference):";
			this.iCalc = 1;
			this.InitCtrl(this.iCalc);
		}
	}
}