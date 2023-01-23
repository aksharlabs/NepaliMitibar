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
    public class About : Form
    {
        private IContainer components;

        [AccessedThroughProperty("lblTitle")]
        private Label _lblTitle;

        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;

        [AccessedThroughProperty("lblVer")]
        private Label _lblVer;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        [AccessedThroughProperty("lblEmail1")]
        private LinkLabel _lblEmail1;

        [AccessedThroughProperty("lblEmail2")]
        private LinkLabel _lblEmail2;

        [AccessedThroughProperty("lblWebsite")]
        private LinkLabel _lblWebsite;

        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        [AccessedThroughProperty("lblAndroid")]
        private LinkLabel _lblAndroid;

        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        [AccessedThroughProperty("pbNCIcon")]
        private PictureBox _pbNCIcon;

        [AccessedThroughProperty("lblFacebook")]
        private LinkLabel _lblFacebook;

        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        [AccessedThroughProperty("lblWebsiteCSW")]
        private LinkLabel _lblWebsiteCSW;

        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        [AccessedThroughProperty("pbIcon")]
        private PictureBox _pbIcon;

        internal virtual Button btnOK
        {
            get
            {
                return this._btnOK;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                EventHandler eventHandler = new EventHandler(about.btnOK_Click);
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

        internal virtual Label Label5
        {
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Label Label6
        {
            get
            {
                return this._Label6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Label Label7
        {
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual LinkLabel lblAndroid
        {
            get
            {
                return this._lblAndroid;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblAndroid_LinkClicked);
                if (this._lblAndroid != null)
                {
                    this._lblAndroid.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblAndroid = value;
                if (this._lblAndroid != null)
                {
                    this._lblAndroid.LinkClicked += linkLabelLinkClickedEventHandler;
                }
            }
        }

        internal virtual LinkLabel lblEmail1
        {
            get
            {
                return this._lblEmail1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblEmail1_LinkClicked);
                if (this._lblEmail1 != null)
                {
                    this._lblEmail1.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblEmail1 = value;
                if (this._lblEmail1 != null)
                {
                    this._lblEmail1.LinkClicked += linkLabelLinkClickedEventHandler;
                }
            }
        }

        internal virtual LinkLabel lblEmail2
        {
            get
            {
                return this._lblEmail2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblEmail2_LinkClicked);
                if (this._lblEmail2 != null)
                {
                    this._lblEmail2.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblEmail2 = value;
                if (this._lblEmail2 != null)
                {
                    this._lblEmail2.LinkClicked += linkLabelLinkClickedEventHandler;
                }
            }
        }

        internal virtual LinkLabel lblFacebook
        {
            get
            {
                return this._lblFacebook;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblFacebook_LinkClicked);
                if (this._lblFacebook != null)
                {
                    this._lblFacebook.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblFacebook = value;
                if (this._lblFacebook != null)
                {
                    this._lblFacebook.LinkClicked += linkLabelLinkClickedEventHandler;
                }
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

        internal virtual Label lblVer
        {
            get
            {
                return this._lblVer;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblVer = value;
            }
        }

        internal virtual LinkLabel lblWebsite
        {
            get
            {
                return this._lblWebsite;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblWebsite_LinkClicked);
                if (this._lblWebsite != null)
                {
                    this._lblWebsite.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblWebsite = value;
                if (this._lblWebsite != null)
                {
                    this._lblWebsite.LinkClicked += linkLabelLinkClickedEventHandler;
                }
            }
        }

        internal virtual LinkLabel lblWebsiteCSW
        {
            get
            {
                return this._lblWebsiteCSW;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                About about = this;
                LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(about.lblWebsiteCSW_LinkClicked);
                if (this._lblWebsiteCSW != null)
                {
                    this._lblWebsiteCSW.LinkClicked -= linkLabelLinkClickedEventHandler;
                }
                this._lblWebsiteCSW = value;
                if (this._lblWebsiteCSW != null)
                {
                    this._lblWebsiteCSW.LinkClicked += linkLabelLinkClickedEventHandler;
                }
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

        internal virtual PictureBox pbNCIcon
        {
            get
            {
                return this._pbNCIcon;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbNCIcon = value;
            }
        }

        public About()
        {
            About about = this;
            base.Load += new EventHandler(about.About_Load);
            this.InitializeComponent();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void About_Load(object sender, EventArgs e)
        {
            this.pbIcon.Width = 58;
            this.pbIcon.Height = 58;
            this.pbNCIcon.Width = 38;
            this.pbNCIcon.Height = 38;
            this.Width = checked(checked(this.btnOK.Left + this.btnOK.Width) + 50);
            this.Height = checked(checked(this.btnOK.Top + this.btnOK.Height) + 80);
            this.lblVer.Text = string.Concat("Version ", Conversions.ToString(MyProject.Application.Info.Version.Major), ".", Conversions.ToString(MyProject.Application.Info.Version.Minor));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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
            this.lblTitle = new Label();
            this.btnOK = new Button();
            this.lblVer = new Label();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.lblEmail1 = new LinkLabel();
            this.lblEmail2 = new LinkLabel();
            this.lblWebsite = new LinkLabel();
            this.Label4 = new Label();
            this.lblAndroid = new LinkLabel();
            this.Label5 = new Label();
            this.lblFacebook = new LinkLabel();
            this.Label6 = new Label();
            this.lblWebsiteCSW = new LinkLabel();
            this.Label7 = new Label();
            this.pbIcon = new PictureBox();
            this.pbNCIcon = new PictureBox();
            ((ISupportInitialize)this.pbIcon).BeginInit();
            ((ISupportInitialize)this.pbNCIcon).BeginInit();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label = this.lblTitle;
            Point point = new Point(143, 31);
            label.Location = point;
            Label label1 = this.lblTitle;
            System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Margin = padding;
            this.lblTitle.Name = "lblTitle";
            Label label2 = this.lblTitle;
            System.Drawing.Size size = new System.Drawing.Size(179, 31);
            label2.Size = size;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nepali Mitibar";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Button button = this.btnOK;
            point = new Point(318, 422);
            button.Location = point;
            Button button1 = this.btnOK;
            padding = new System.Windows.Forms.Padding(4);
            button1.Margin = padding;
            this.btnOK.Name = "btnOK";
            Button button2 = this.btnOK;
            size = new System.Drawing.Size(106, 37);
            button2.Size = size;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label3 = this.lblVer;
            point = new Point(146, 75);
            label3.Location = point;
            Label label4 = this.lblVer;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Margin = padding;
            this.lblVer.Name = "lblVer";
            Label label5 = this.lblVer;
            size = new System.Drawing.Size(93, 20);
            label5.Size = size;
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "Version 3.0";
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
            Label label11 = this.Label1;
            point = new Point(62, 115);
            label11.Location = point;
            Label label12 = this.Label1;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Margin = padding;
            this.Label1.Name = "Label1";
            Label label13 = this.Label1;
            size = new System.Drawing.Size(110, 20);
            label13.Size = size;
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Developed by";
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label label21 = this.Label2;
            point = new Point(62, 142);
            label21.Location = point;
            Label label22 = this.Label2;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Margin = padding;
            this.Label2.Name = "Label2";
            Label label23 = this.Label2;
            size = new System.Drawing.Size(167, 20);
            label23.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Naresh Manandhar";
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label31 = this.Label3;
            point = new Point(62, 212);
            label31.Location = point;
            Label label32 = this.Label3;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label32.Margin = padding;
            this.Label3.Name = "Label3";
            Label label33 = this.Label3;
            size = new System.Drawing.Size(62, 20);
            label33.Size = size;
            this.Label3.TabIndex = 5;
            this.Label3.Text = "E-mail:";
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel = this.lblEmail1;
            point = new Point(161, 212);
            linkLabel.Location = point;
            LinkLabel linkLabel1 = this.lblEmail1;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Margin = padding;
            this.lblEmail1.Name = "lblEmail1";
            LinkLabel linkLabel2 = this.lblEmail1;
            size = new System.Drawing.Size(182, 20);
            linkLabel2.Size = size;
            this.lblEmail1.TabIndex = 6;
            this.lblEmail1.TabStop = true;
            this.lblEmail1.Text = "mdrnaresh@gmail.com";
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel3 = this.lblEmail2;
            point = new Point(161, 240);
            linkLabel3.Location = point;
            LinkLabel linkLabel4 = this.lblEmail2;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel4.Margin = padding;
            this.lblEmail2.Name = "lblEmail2";
            LinkLabel linkLabel5 = this.lblEmail2;
            size = new System.Drawing.Size(186, 20);
            linkLabel5.Size = size;
            this.lblEmail2.TabIndex = 7;
            this.lblEmail2.TabStop = true;
            this.lblEmail2.Text = "nareshmdr@yahoo.com";
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel6 = this.lblWebsite;
            point = new Point(161, 271);
            linkLabel6.Location = point;
            LinkLabel linkLabel7 = this.lblWebsite;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel7.Margin = padding;
            this.lblWebsite.Name = "lblWebsite";
            LinkLabel linkLabel8 = this.lblWebsite;
            size = new System.Drawing.Size(190, 20);
            linkLabel8.Size = size;
            this.lblWebsite.TabIndex = 9;
            this.lblWebsite.TabStop = true;
            this.lblWebsite.Text = "http://nareshmdr.com.np";
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label41 = this.Label4;
            point = new Point(62, 271);
            label41.Location = point;
            Label label42 = this.Label4;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label42.Margin = padding;
            this.Label4.Name = "Label4";
            Label label43 = this.Label4;
            size = new System.Drawing.Size(75, 20);
            label43.Size = size;
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Website:";
            this.lblAndroid.AutoSize = true;
            this.lblAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel9 = this.lblAndroid;
            point = new Point(120, 424);
            linkLabel9.Location = point;
            LinkLabel linkLabel10 = this.lblAndroid;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel10.Margin = padding;
            this.lblAndroid.Name = "lblAndroid";
            LinkLabel linkLabel11 = this.lblAndroid;
            size = new System.Drawing.Size(128, 20);
            linkLabel11.Size = size;
            this.lblAndroid.TabIndex = 10;
            this.lblAndroid.TabStop = true;
            this.lblAndroid.Text = "Nepali Calendar";
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Underline, GraphicsUnit.Point, 0);
            Label label51 = this.Label5;
            point = new Point(62, 385);
            label51.Location = point;
            Label label52 = this.Label5;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label52.Margin = padding;
            this.Label5.Name = "Label5";
            Label label53 = this.Label5;
            size = new System.Drawing.Size(133, 20);
            label53.Size = size;
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Android Version:";
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel12 = this.lblFacebook;
            point = new Point(161, 331);
            linkLabel12.Location = point;
            LinkLabel linkLabel13 = this.lblFacebook;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel13.Margin = padding;
            this.lblFacebook.Name = "lblFacebook";
            LinkLabel linkLabel14 = this.lblFacebook;
            size = new System.Drawing.Size(240, 20);
            linkLabel14.Size = size;
            this.lblFacebook.TabIndex = 14;
            this.lblFacebook.TabStop = true;
            this.lblFacebook.Text = "http://facebook.com/nareshmdr";
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label6 = this.Label6;
            point = new Point(62, 331);
            label6.Location = point;
            Label label61 = this.Label6;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label61.Margin = padding;
            this.Label6.Name = "Label6";
            Label label62 = this.Label6;
            size = new System.Drawing.Size(86, 20);
            label62.Size = size;
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Facebook:";
            this.lblWebsiteCSW.AutoSize = true;
            this.lblWebsiteCSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabel linkLabel15 = this.lblWebsiteCSW;
            point = new Point(161, 298);
            linkLabel15.Location = point;
            LinkLabel linkLabel16 = this.lblWebsiteCSW;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel16.Margin = padding;
            this.lblWebsiteCSW.Name = "lblWebsiteCSW";
            LinkLabel linkLabel17 = this.lblWebsiteCSW;
            size = new System.Drawing.Size(140, 20);
            linkLabel17.Size = size;
            this.lblWebsiteCSW.TabIndex = 15;
            this.lblWebsiteCSW.TabStop = true;
            this.lblWebsiteCSW.Text = "http://csw.com.np";
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label label7 = this.Label7;
            point = new Point(62, 168);
            label7.Location = point;
            Label label71 = this.Label7;
            padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label71.Margin = padding;
            this.Label7.Name = "Label7";
            Label label72 = this.Label7;
            size = new System.Drawing.Size(141, 20);
            label72.Size = size;
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Crystal Softworks";
            this.pbIcon.Image = Resources.icon;
            PictureBox pictureBox = this.pbIcon;
            point = new Point(66, 31);
            pictureBox.Location = point;
            this.pbIcon.Name = "pbIcon";
            PictureBox pictureBox1 = this.pbIcon;
            size = new System.Drawing.Size(64, 64);
            pictureBox1.Size = size;
            this.pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 17;
            this.pbIcon.TabStop = false;
            this.pbNCIcon.Image = Resources.icon_64;
            PictureBox pictureBox2 = this.pbNCIcon;
            point = new Point(65, 411);
            pictureBox2.Location = point;
            this.pbNCIcon.Name = "pbNCIcon";
            PictureBox pictureBox3 = this.pbNCIcon;
            size = new System.Drawing.Size(48, 48);
            pictureBox3.Size = size;
            this.pbNCIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbNCIcon.TabIndex = 12;
            this.pbNCIcon.TabStop = false;
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            size = new System.Drawing.Size(453, 493);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblWebsiteCSW);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.pbNCIcon);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblAndroid);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            padding = new System.Windows.Forms.Padding(4);
            this.Margin = padding;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "About Nepali Mitibar";
            ((ISupportInitialize)this.pbIcon).EndInit();
            ((ISupportInitialize)this.pbNCIcon).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void lblAndroid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://play.google.com/store/apps/details?id=np.com.nareshmdr.nepalicalendar");
        }

        private void lblEmail1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:mdrnaresh@gmail.com");
        }

        private void lblEmail2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:nareshmdr@yahoo.com");
        }

        private void lblFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://facebook.com/nareshmdr");
        }

        private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://nareshmdr.com.np");
        }

        private void lblWebsiteCSW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://csw.com.np");
        }
    }
}