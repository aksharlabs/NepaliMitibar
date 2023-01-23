using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NepaliMitibar.My
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance;

		private static bool addedHandler;

		private static object addedHandlerLockObject;

		[DebuggerNonUserCode]
		[DefaultSettingValue("RoyalBlue")]
		[UserScopedSetting]
		public Color BackColor
		{
			get
			{
				Color color = new Color();
				object item = this["BackColor"];
				if (item == null)
				{
					return color;
				}
				return (Color)item;
			}
			set
			{
				this["BackColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int DataDay
		{
			get
			{
				return Conversions.ToInteger(this["DataDay"]);
			}
			set
			{
				this["DataDay"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("1985-12-31")]
		[UserScopedSetting]
		public DateTime DBLastUpdated
		{
			get
			{
				return Conversions.ToDate(this["DBLastUpdated"]);
			}
			set
			{
				this["DBLastUpdated"] = value;
			}
		}

		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool flag = false;
					try
					{
						Monitor.Enter(obj, ref flag);
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("3")]
		[UserScopedSetting]
		public int FontSize
		{
			get
			{
				return Conversions.ToInteger(this["FontSize"]);
			}
			set
			{
				this["FontSize"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int NoticeVer
		{
			get
			{
				return Conversions.ToInteger(this["NoticeVer"]);
			}
			set
			{
				this["NoticeVer"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowTithi
		{
			get
			{
				return Conversions.ToBoolean(this["ShowTithi"]);
			}
			set
			{
				this["ShowTithi"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("4")]
		[UserScopedSetting]
		public int StartupPos
		{
			get
			{
				return Conversions.ToInteger(this["StartupPos"]);
			}
			set
			{
				this["StartupPos"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("White")]
		[UserScopedSetting]
		public Color TextColor
		{
			get
			{
				Color color = new Color();
				object item = this["TextColor"];
				if (item == null)
				{
					return color;
				}
				return (Color)item;
			}
			set
			{
				this["TextColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool TopMost
		{
			get
			{
				return Conversions.ToBoolean(this["TopMost"]);
			}
			set
			{
				this["TopMost"] = value;
			}
		}

		static MySettings()
		{
			MySettings.defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
		}

		public MySettings()
		{
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}