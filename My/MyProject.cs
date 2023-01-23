using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using NepaliMitibar;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NepaliMitibar.My
{
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	[HideModuleName]
	internal static class MyProject
	{
		private readonly static MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider;

		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider;

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static Microsoft.VisualBasic.ApplicationServices.User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		static MyProject()
		{
			MyProject.m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
			MyProject.m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
			MyProject.m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
			MyProject.m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
			MyProject.m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			public About m_About;

			public Calendar m_Calendar;

			public DateCalculator m_DateCalculator;

			public DateConverter m_DateConverter;

			public Mitibar m_Mitibar;

			public NoticeBoard m_NoticeBoard;

			public Settings m_Settings;

			public Splash m_Splash;

			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			public About About
			{
				get
				{
					this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
					return this.m_About;
				}
				set
				{
					if (value == this.m_About)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<About>(ref this.m_About);
				}
			}

			public Calendar Calendar
			{
				get
				{
					this.m_Calendar = MyProject.MyForms.Create__Instance__<Calendar>(this.m_Calendar);
					return this.m_Calendar;
				}
				set
				{
					if (value == this.m_Calendar)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Calendar>(ref this.m_Calendar);
				}
			}

			public DateCalculator DateCalculator
			{
				get
				{
					this.m_DateCalculator = MyProject.MyForms.Create__Instance__<DateCalculator>(this.m_DateCalculator);
					return this.m_DateCalculator;
				}
				set
				{
					if (value == this.m_DateCalculator)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<DateCalculator>(ref this.m_DateCalculator);
				}
			}

			public DateConverter DateConverter
			{
				get
				{
					this.m_DateConverter = MyProject.MyForms.Create__Instance__<DateConverter>(this.m_DateConverter);
					return this.m_DateConverter;
				}
				set
				{
					if (value == this.m_DateConverter)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<DateConverter>(ref this.m_DateConverter);
				}
			}

			public Mitibar Mitibar
			{
				get
				{
					this.m_Mitibar = MyProject.MyForms.Create__Instance__<Mitibar>(this.m_Mitibar);
					return this.m_Mitibar;
				}
				set
				{
					if (value == this.m_Mitibar)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Mitibar>(ref this.m_Mitibar);
				}
			}

			public NoticeBoard NoticeBoard
			{
				get
				{
					this.m_NoticeBoard = MyProject.MyForms.Create__Instance__<NoticeBoard>(this.m_NoticeBoard);
					return this.m_NoticeBoard;
				}
				set
				{
					if (value == this.m_NoticeBoard)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<NoticeBoard>(ref this.m_NoticeBoard);
				}
			}

			public Settings Settings
			{
				get
				{
					this.m_Settings = MyProject.MyForms.Create__Instance__<Settings>(this.m_Settings);
					return this.m_Settings;
				}
				set
				{
					if (value == this.m_Settings)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Settings>(ref this.m_Settings);
				}
			}

			public Splash Splash
			{
				get
				{
					this.m_Splash = MyProject.MyForms.Create__Instance__<Splash>(this.m_Splash);
					return this.m_Splash;
				}
				set
				{
					if (value == this.m_Splash)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Splash>(ref this.m_Splash);
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance)
			where T : Form, new()
			{
				T t;
				if (Instance != null && !Instance.IsDisposed)
				{
					return Instance;
				}
				if (MyProject.MyForms.m_FormBeingCreated == null)
				{
					MyProject.MyForms.m_FormBeingCreated = new Hashtable();
				}
				else if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
				MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					try
					{
						t = Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException targetInvocationException) when (targetInvocationException.InnerException != null)
					{
						string[] message = new string[] { targetInvocationException.InnerException.Message };
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", message);
						throw new InvalidOperationException(resourceString, targetInvocationException.InnerException);
					}
				}
				finally
				{
					MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
				}
				return t;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance)
			where T : new()
			{
				if (instance == null)
				{
					return Activator.CreateInstance<T>();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T>
		where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}
	}
}