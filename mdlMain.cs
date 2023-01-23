using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NepaliMitibar.My;
using System;
using System.Windows.Forms;

namespace NepaliMitibar
{
	internal static class mdlMain
	{
		public static short GiCurBSYear;

		public static short GiCurBSMonth;

		public static short GiCurBSDay;

		public static short GiSelBSYear;

		public static short GiSelBSMonth;

		public static short GiSelBSDay;

		public static bool IsCanceled;

		public static string GsDataDir;

		public static string GsNoticePath;

		public static string GsNotice;

		public static string GsNoticeLink;

		public static string GsNoticeLinkTitle;

		public static bool IsShowNoticeLink;

		public static int[] arFontSize;

		static mdlMain()
		{
			int[] numArray = new int[] { 8, 10, 12, 14, 16, 18 };
			mdlMain.arFontSize = numArray;
		}

		public static bool IsInternetConnected()
		{
			bool flag;
			try
			{
				MyProject.Computer.Network.Ping("google.com");
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public static void LoadCurBSDate()
		{
			string str = NepDate.AD2BS(DateAndTime.Today);
			string[] strArrays = Strings.Split(str, NepDate.sDateSep, -1, CompareMethod.Binary);
			mdlMain.GiCurBSYear = Conversions.ToShort(strArrays[0]);
			mdlMain.GiCurBSMonth = Conversions.ToShort(strArrays[1]);
			mdlMain.GiCurBSDay = Conversions.ToShort(strArrays[2]);
		}

		public static void LogErr(string sModule, string sProcedure, string sErr, int lngErrNum)
		{
			MessageBox.Show("Unexpected error occurred.\r\nPlease, contact developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public static short NepNum2Num(string sNepNum)
		{
			sNepNum = sNepNum.Replace("०", "0");
			sNepNum = sNepNum.Replace("१", "1");
			sNepNum = sNepNum.Replace("२", "2");
			sNepNum = sNepNum.Replace("३", "3");
			sNepNum = sNepNum.Replace("४", "4");
			sNepNum = sNepNum.Replace("५", "5");
			sNepNum = sNepNum.Replace("६", "6");
			sNepNum = sNepNum.Replace("७", "7");
			sNepNum = sNepNum.Replace("८", "8");
			sNepNum = sNepNum.Replace("९", "9");
			return Conversions.ToShort(sNepNum);
		}

		public static string Num2NepNum(string sNum)
		{
			sNum = sNum.Replace("0", "०");
			sNum = sNum.Replace("1", "१");
			sNum = sNum.Replace("2", "२");
			sNum = sNum.Replace("3", "३");
			sNum = sNum.Replace("4", "४");
			sNum = sNum.Replace("5", "५");
			sNum = sNum.Replace("6", "६");
			sNum = sNum.Replace("7", "७");
			sNum = sNum.Replace("8", "८");
			sNum = sNum.Replace("9", "९");
			return sNum;
		}
	}
}