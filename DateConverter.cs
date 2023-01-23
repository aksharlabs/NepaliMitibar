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
	public class DateConverter : Form
	{
		private IContainer components;

		[AccessedThroughProperty("cboBSMonth")]
		private ComboBox _cboBSMonth;

		[AccessedThroughProperty("cboBSYear")]
		private ComboBox _cboBSYear;

		[AccessedThroughProperty("cboBSDay")]
		private ComboBox _cboBSDay;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("txtADDate")]
		private TextBox _txtADDate;

		[AccessedThroughProperty("txtBSDate")]
		private TextBox _txtBSDate;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("cboADDay")]
		private ComboBox _cboADDay;

		[AccessedThroughProperty("cboADMonth")]
		private ComboBox _cboADMonth;

		[AccessedThroughProperty("cboADYear")]
		private ComboBox _cboADYear;

		[AccessedThroughProperty("btnBS2AD")]
		private Button _btnBS2AD;

		[AccessedThroughProperty("btnAD2BS")]
		private Button _btnAD2BS;

		internal virtual Button btnAD2BS
		{
			get
			{
				return this._btnAD2BS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateConverter dateConverter = this;
				EventHandler eventHandler = new EventHandler(dateConverter.btnAD2BS_Click);
				if (this._btnAD2BS != null)
				{
					this._btnAD2BS.Click -= eventHandler;
				}
				this._btnAD2BS = value;
				if (this._btnAD2BS != null)
				{
					this._btnAD2BS.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnBS2AD
		{
			get
			{
				return this._btnBS2AD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateConverter dateConverter = this;
				EventHandler eventHandler = new EventHandler(dateConverter.btnBS2AD_Click);
				if (this._btnBS2AD != null)
				{
					this._btnBS2AD.Click -= eventHandler;
				}
				this._btnBS2AD = value;
				if (this._btnBS2AD != null)
				{
					this._btnBS2AD.Click += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboADDay
		{
			get
			{
				return this._cboADDay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboADDay = value;
			}
		}

		internal virtual ComboBox cboADMonth
		{
			get
			{
				return this._cboADMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboADMonth = value;
			}
		}

		internal virtual ComboBox cboADYear
		{
			get
			{
				return this._cboADYear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboADYear = value;
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
				DateConverter dateConverter = this;
				EventHandler eventHandler = new EventHandler(dateConverter.cboBSDay_TextChanged);
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

		internal virtual ComboBox cboBSMonth
		{
			get
			{
				return this._cboBSMonth;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateConverter dateConverter = this;
				EventHandler eventHandler = new EventHandler(dateConverter.cboBSMonth_TextChanged);
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

		internal virtual ComboBox cboBSYear
		{
			get
			{
				return this._cboBSYear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DateConverter dateConverter = this;
				EventHandler eventHandler = new EventHandler(dateConverter.cboBSYear_SelectedIndexChanged);
				DateConverter dateConverter1 = this;
				EventHandler eventHandler1 = new EventHandler(dateConverter1.cboBSYear_TextChanged);
				if (this._cboBSYear != null)
				{
					this._cboBSYear.SelectedIndexChanged -= eventHandler;
					this._cboBSYear.TextChanged -= eventHandler1;
				}
				this._cboBSYear = value;
				if (this._cboBSYear != null)
				{
					this._cboBSYear.SelectedIndexChanged += eventHandler;
					this._cboBSYear.TextChanged += eventHandler1;
				}
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

		internal virtual TextBox txtADDate
		{
			get
			{
				return this._txtADDate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtADDate = value;
			}
		}

		internal virtual TextBox txtBSDate
		{
			get
			{
				return this._txtBSDate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBSDate = value;
			}
		}

		public DateConverter()
		{
			DateConverter dateConverter = this;
			base.Load += new EventHandler(dateConverter.DateConverter_Load);
			this.InitializeComponent();
		}

		private void btnAD2BS_Click(object sender, EventArgs e)
		{
			if (this.cboADYear.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'AD Year'", MsgBoxStyle.Information, null);
				this.cboADYear.Focus();
				return;
			}
			if (this.cboADMonth.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'AD Month'", MsgBoxStyle.Information, null);
				this.cboADMonth.Focus();
				return;
			}
			if (this.cboADDay.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'AD Day'", MsgBoxStyle.Information, null);
				this.cboADDay.Focus();
				return;
			}
			string[] text = new string[] { this.cboADYear.Text, "/", Conversions.ToString(checked(this.cboADMonth.SelectedIndex + 1)), "/", this.cboADDay.Text };
			if (!Information.IsDate(string.Concat(text)))
			{
				Interaction.MsgBox("Invalid 'AD Day'", MsgBoxStyle.Information, null);
				this.cboADDay.Focus();
				return;
			}
			DateTime dateTime = DateAndTime.DateSerial(Conversions.ToInteger(this.cboADYear.Text), checked(this.cboADMonth.SelectedIndex + 1), Conversions.ToInteger(this.cboADDay.Text));
			string str = NepDate.AD2BS(dateTime);
			TextBox textBox = this.txtBSDate;
			text = new string[] { mdlMain.Num2NepNum(Conversions.ToString((int)NepDate.NepDatePart(str, "y"))), " ", NepDate.arBSMonthName[checked(NepDate.NepDatePart(str, "m") - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString((int)NepDate.NepDatePart(str, "d"))), " गते ", NepDate.arBSDayName[(int)dateTime.DayOfWeek], "बार" };
			textBox.Text = string.Concat(text);
		}

		private void btnBS2AD_Click(object sender, EventArgs e)
		{
			if (this.cboBSYear.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'BS Year'", MsgBoxStyle.Information, null);
				this.cboBSYear.Focus();
				return;
			}
			if (this.cboBSMonth.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'BS Month'", MsgBoxStyle.Information, null);
				this.cboBSMonth.Focus();
				return;
			}
			if (this.cboBSDay.SelectedIndex < 0)
			{
				Interaction.MsgBox("Invalid 'BS Day'", MsgBoxStyle.Information, null);
				this.cboBSDay.Focus();
				return;
			}
			short num = mdlMain.NepNum2Num(this.cboBSYear.Text);
			short selectedIndex = checked((short)(checked(this.cboBSMonth.SelectedIndex + 1)));
			short num1 = mdlMain.NepNum2Num(this.cboBSDay.Text);
			short num2 = NepDate.BSMonthLen(num, selectedIndex);
			if (num1 <= num2)
			{
				DateTime dateTime = NepDate.BS2AD(num, selectedIndex, num1);
				this.txtADDate.Text = Strings.Format(dateTime, "yyyy MMMM d, dddd");
				return;
			}
			Interaction.MsgBox(string.Concat("Invalid 'BS Day'\r\n'BS Day' must be between 1 and ", Conversions.ToString((int)num2), " for the selected month."), MsgBoxStyle.Information, null);
			this.cboBSDay.Focus();
		}

		private void cboBSDay_TextChanged(object sender, EventArgs e)
		{
			this.cboBSDay.Text = mdlMain.Num2NepNum(this.cboBSDay.Text);
			this.cboBSDay.SelectionStart = this.cboBSDay.Text.Length;
		}

		private void cboBSMonth_TextChanged(object sender, EventArgs e)
		{
			this.cboBSMonth.Text = mdlMain.Num2NepNum(this.cboBSMonth.Text);
			this.cboBSMonth.SelectionStart = this.cboBSMonth.Text.Length;
		}

		private void cboBSYear_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void cboBSYear_TextChanged(object sender, EventArgs e)
		{
			this.cboBSYear.Text = mdlMain.Num2NepNum(this.cboBSYear.Text);
			this.cboBSYear.SelectionStart = this.cboBSYear.Text.Length;
		}

		private void DateConverter_Load(object sender, EventArgs e)
		{
			string[] strArrays = new string[] { "Date Calculator (", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSYear)), " ", NepDate.arBSMonthName[checked(mdlMain.GiCurBSMonth - 1)], " ", mdlMain.Num2NepNum(Conversions.ToString((int)mdlMain.GiCurBSDay)), ", ", null, null };
			strArrays[7] = NepDate.arBSDayName[(int)DateAndTime.Today.DayOfWeek];
			strArrays[8] = "बार)";
			this.Text = string.Concat(strArrays);
			this.InitCtrl();
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

		private void InitCtrl()
		{
			this.cboBSYear.Items.Clear();
			this.cboADYear.Items.Clear();
			short num = 1990;
			do
			{
				this.cboBSYear.Items.Add(mdlMain.Num2NepNum(Conversions.ToString((int)num)));
				this.cboADYear.Items.Add(checked(num - 57));
				num = checked((short)(num + 1));
			}
			while (num <= 2110);
			this.cboBSMonth.Items.Clear();
			this.cboADMonth.Items.Clear();
			num = 0;
			do
			{
				this.cboBSMonth.Items.Add(string.Concat(mdlMain.Num2NepNum(Conversions.ToString(checked(num + 1))), ". ", NepDate.arBSMonthName[num]));
				this.cboADMonth.Items.Add(string.Concat(Conversions.ToString(checked(num + 1)), ". ", NepDate.arADMonthNameFull[num]));
				num = checked((short)(num + 1));
			}
			while (num <= 11);
			this.cboBSDay.Items.Clear();
			this.cboADDay.Items.Clear();
			num = 1;
			do
			{
				this.cboBSDay.Items.Add(mdlMain.Num2NepNum(Conversions.ToString((int)num)));
				this.cboADDay.Items.Add(num);
				num = checked((short)(num + 1));
			}
			while (num <= 31);
			this.cboBSDay.Items.Add("३२");
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.cboBSMonth = new ComboBox();
			this.cboBSYear = new ComboBox();
			this.cboBSDay = new ComboBox();
			this.Label1 = new Label();
			this.txtADDate = new TextBox();
			this.txtBSDate = new TextBox();
			this.Label2 = new Label();
			this.cboADDay = new ComboBox();
			this.cboADMonth = new ComboBox();
			this.cboADYear = new ComboBox();
			this.btnBS2AD = new Button();
			this.btnAD2BS = new Button();
			this.SuspendLayout();
			this.cboBSMonth.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSMonth.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSMonth.FlatStyle = FlatStyle.Popup;
			this.cboBSMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSMonth.FormattingEnabled = true;
			this.cboBSMonth.ItemHeight = 29;
			ComboBox comboBox = this.cboBSMonth;
			Point point = new Point(149, 58);
			comboBox.Location = point;
			ComboBox comboBox1 = this.cboBSMonth;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(4);
			comboBox1.Margin = padding;
			this.cboBSMonth.Name = "cboBSMonth";
			ComboBox comboBox2 = this.cboBSMonth;
			System.Drawing.Size size = new System.Drawing.Size(203, 37);
			comboBox2.Size = size;
			this.cboBSMonth.TabIndex = 1;
			this.cboBSYear.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSYear.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSYear.DropDownHeight = 300;
			this.cboBSYear.FlatStyle = FlatStyle.Popup;
			this.cboBSYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSYear.FormattingEnabled = true;
			this.cboBSYear.IntegralHeight = false;
			this.cboBSYear.ItemHeight = 29;
			ComboBox comboBox3 = this.cboBSYear;
			point = new Point(28, 58);
			comboBox3.Location = point;
			ComboBox comboBox4 = this.cboBSYear;
			padding = new System.Windows.Forms.Padding(4);
			comboBox4.Margin = padding;
			this.cboBSYear.Name = "cboBSYear";
			ComboBox comboBox5 = this.cboBSYear;
			size = new System.Drawing.Size(113, 37);
			comboBox5.Size = size;
			this.cboBSYear.TabIndex = 0;
			this.cboBSDay.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboBSDay.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboBSDay.DropDownHeight = 300;
			this.cboBSDay.FlatStyle = FlatStyle.Popup;
			this.cboBSDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboBSDay.FormattingEnabled = true;
			this.cboBSDay.IntegralHeight = false;
			this.cboBSDay.ItemHeight = 29;
			ComboBox comboBox6 = this.cboBSDay;
			point = new Point(360, 58);
			comboBox6.Location = point;
			ComboBox comboBox7 = this.cboBSDay;
			padding = new System.Windows.Forms.Padding(4);
			comboBox7.Margin = padding;
			this.cboBSDay.Name = "cboBSDay";
			ComboBox comboBox8 = this.cboBSDay;
			size = new System.Drawing.Size(90, 37);
			comboBox8.Size = size;
			this.cboBSDay.TabIndex = 2;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(24, 29);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new System.Drawing.Size(130, 20);
			label.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Select BS Date:";
			this.txtADDate.BackColor = SystemColors.Control;
			this.txtADDate.BorderStyle = BorderStyle.None;
			this.txtADDate.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtADDate.ForeColor = Color.Red;
			TextBox textBox = this.txtADDate;
			point = new Point(28, 107);
			textBox.Location = point;
			this.txtADDate.Name = "txtADDate";
			this.txtADDate.ReadOnly = true;
			TextBox textBox1 = this.txtADDate;
			size = new System.Drawing.Size(422, 23);
			textBox1.Size = size;
			this.txtADDate.TabIndex = 6;
			this.txtADDate.TabStop = false;
			this.txtADDate.Text = "Select BS year, month and day to convert";
			this.txtBSDate.BackColor = SystemColors.Control;
			this.txtBSDate.BorderStyle = BorderStyle.None;
			this.txtBSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtBSDate.ForeColor = Color.Red;
			TextBox textBox2 = this.txtBSDate;
			point = new Point(28, 248);
			textBox2.Location = point;
			this.txtBSDate.Name = "txtBSDate";
			this.txtBSDate.ReadOnly = true;
			TextBox textBox3 = this.txtBSDate;
			size = new System.Drawing.Size(422, 27);
			textBox3.Size = size;
			this.txtBSDate.TabIndex = 11;
			this.txtBSDate.TabStop = false;
			this.txtBSDate.Text = "साल, महिना र गते छान्नुहोस् ।";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(24, 175);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(131, 20);
			label21.Size = size;
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Select AD Date:";
			this.cboADDay.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboADDay.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboADDay.DropDownHeight = 300;
			this.cboADDay.FlatStyle = FlatStyle.Popup;
			this.cboADDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboADDay.FormattingEnabled = true;
			this.cboADDay.IntegralHeight = false;
			this.cboADDay.ItemHeight = 25;
			ComboBox comboBox9 = this.cboADDay;
			point = new Point(360, 204);
			comboBox9.Location = point;
			ComboBox comboBox10 = this.cboADDay;
			padding = new System.Windows.Forms.Padding(4);
			comboBox10.Margin = padding;
			this.cboADDay.Name = "cboADDay";
			ComboBox comboBox11 = this.cboADDay;
			size = new System.Drawing.Size(90, 33);
			comboBox11.Size = size;
			this.cboADDay.TabIndex = 6;
			this.cboADMonth.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboADMonth.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboADMonth.FlatStyle = FlatStyle.Popup;
			this.cboADMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboADMonth.FormattingEnabled = true;
			this.cboADMonth.ItemHeight = 25;
			ComboBox comboBox12 = this.cboADMonth;
			point = new Point(149, 204);
			comboBox12.Location = point;
			ComboBox comboBox13 = this.cboADMonth;
			padding = new System.Windows.Forms.Padding(4);
			comboBox13.Margin = padding;
			this.cboADMonth.Name = "cboADMonth";
			ComboBox comboBox14 = this.cboADMonth;
			size = new System.Drawing.Size(203, 33);
			comboBox14.Size = size;
			this.cboADMonth.TabIndex = 5;
			this.cboADYear.AutoCompleteMode = AutoCompleteMode.Append;
			this.cboADYear.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboADYear.DropDownHeight = 300;
			this.cboADYear.FlatStyle = FlatStyle.Popup;
			this.cboADYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboADYear.FormattingEnabled = true;
			this.cboADYear.IntegralHeight = false;
			this.cboADYear.ItemHeight = 25;
			ComboBox comboBox15 = this.cboADYear;
			point = new Point(28, 204);
			comboBox15.Location = point;
			ComboBox comboBox16 = this.cboADYear;
			padding = new System.Windows.Forms.Padding(4);
			comboBox16.Margin = padding;
			this.cboADYear.Name = "cboADYear";
			ComboBox comboBox17 = this.cboADYear;
			size = new System.Drawing.Size(113, 33);
			comboBox17.Size = size;
			this.cboADYear.TabIndex = 4;
			this.btnBS2AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button = this.btnBS2AD;
			point = new Point(475, 58);
			button.Location = point;
			this.btnBS2AD.Name = "btnBS2AD";
			Button button1 = this.btnBS2AD;
			size = new System.Drawing.Size(122, 37);
			button1.Size = size;
			this.btnBS2AD.TabIndex = 3;
			this.btnBS2AD.Text = "BS to AD";
			this.btnBS2AD.UseVisualStyleBackColor = true;
			this.btnAD2BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button2 = this.btnAD2BS;
			point = new Point(475, 204);
			button2.Location = point;
			this.btnAD2BS.Name = "btnAD2BS";
			Button button3 = this.btnAD2BS;
			size = new System.Drawing.Size(122, 33);
			button3.Size = size;
			this.btnAD2BS.TabIndex = 7;
			this.btnAD2BS.Text = "AD to BS";
			this.btnAD2BS.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(622, 300);
			this.ClientSize = size;
			this.Controls.Add(this.btnAD2BS);
			this.Controls.Add(this.btnBS2AD);
			this.Controls.Add(this.txtBSDate);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cboADDay);
			this.Controls.Add(this.cboADMonth);
			this.Controls.Add(this.cboADYear);
			this.Controls.Add(this.txtADDate);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cboBSDay);
			this.Controls.Add(this.cboBSMonth);
			this.Controls.Add(this.cboBSYear);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DateConverter";
			this.ShowIcon = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Date Converter";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}