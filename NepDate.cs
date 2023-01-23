using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace NepaliMitibar
{
	internal static class NepDate
	{
		private static string[] sData;

		public static bool IsDateOutOfRange;

		public static short[,] arBSDate;

		public static DateTime[] arADDate;

		public static short iMaxVIndex;

		public static string sDateSep;

		public static string[] arBSDayName;

		public static string[] arTithiName;

		public static string[] arBSMonthName;

		public static string[] arBSDayNo;

		public static string[] arADDayName;

		public static string[] arADDayNameFull;

		public static string[] arADMonthName;

		public static string[] arADMonthNameFull;

		static NepDate()
		{
			NepDate.sData = new string[123];
			NepDate.arBSDate = new short[123, 13];
			NepDate.arADDate = new DateTime[123];
			NepDate.iMaxVIndex = 121;
			NepDate.sDateSep = "/";
			string[] strArrays = new string[] { "आइत", "सोम", "मंगल", "बुध", "बिहि", "शुक्र", "शनि" };
			NepDate.arBSDayName = strArrays;
			strArrays = new string[] { "प्रतिपदा", "द्वितीया", "तृतीया", "चतुर्थी", "पञ्चमी", "षष्ठी", "सप्तमी", "अष्टमी", "नवमी", "दशमी", "एकादशी", "द्वादशी", "त्रयोदशी", "चतुर्दशी", "पूर्णिमा", "औंसी" };
			NepDate.arTithiName = strArrays;
			strArrays = new string[] { "बैशाख", "जेठ", "असार", "श्रावण", "भाद्र", "आश्विन", "कार्तिक", "मंसिर", "पौष", "माघ", "फाल्गुण", "चैत्र" };
			NepDate.arBSMonthName = strArrays;
			strArrays = new string[] { "0", "१", "२", "३", "४", "५", "६", "७", "८", "९", "१०", "११", "१२", "१३", "१४", "१५", "१६", "१७", "१८", "१९", "२०", "२१", "२२", "२३", "२४", "२५", "२६", "२७", "२८", "२९", "३०", "३१", "३२" };
			NepDate.arBSDayNo = strArrays;
			strArrays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
			NepDate.arADDayName = strArrays;
			strArrays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			NepDate.arADDayNameFull = strArrays;
			strArrays = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
			NepDate.arADMonthName = strArrays;
			strArrays = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
			NepDate.arADMonthNameFull = strArrays;
		}

		public static string AD2BS(DateTime dtADDate)
		{
			DateTime dateTime = new DateTime();
			short i;
			short num = 0;
			short num1;
			short num2 = 0;
			bool flag = false;
			short year = checked((short)dtADDate.Year);
			NepDate.IsDateOutOfRange = false;
			if (year >= 2033)
			{
				num2 = 101;
			}
			else if (year >= 2013)
			{
				num2 = 81;
			}
			else if (year >= 1993)
			{
				num2 = 61;
			}
			else if (year >= 1973)
			{
				num2 = 41;
			}
			else if (year >= 1953)
			{
				num2 = 21;
			}
			else if (year >= 1933)
			{
				num2 = 1;
			}
			short num3 = NepDate.iMaxVIndex;
			short num4 = num2;
			while (num4 <= num3)
			{
				if (NepDate.arADDate[num4].Year != year)
				{
					num4 = checked((short)(num4 + 1));
				}
				else
				{
					dateTime = NepDate.arADDate[num4];
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				NepDate.IsDateOutOfRange = true;
				return "(Out of Range)";
			}
			short num5 = checked((short)DateAndTime.DateDiff(DateInterval.Day, dateTime, dtADDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
			if (num5 < 0)
			{
				num4 = checked((short)(checked(num4 - 1)));
				dateTime = NepDate.arADDate[num4];
				num5 = checked((short)DateAndTime.DateDiff(DateInterval.Day, dateTime, dtADDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
			}
			short num6 = 1;
			do
			{
				num1 = NepDate.arBSDate[num4, num6];
				num = checked((short)(num + num1));
				if (num <= num5)
				{
					num6 = checked((short)(num6 + 1));
				}
				else
				{
					num = checked((short)(num - num1));
					break;
				}
			}
			while (num6 <= 12);
			short num7 = num1;
			for (i = 1; i <= num7 && num != num5; i = checked((short)(i + 1)))
			{
				num = checked((short)(checked(num + 1)));
			}
			string[] str = new string[] { Conversions.ToString((int)NepDate.arBSDate[num4, 0]), "/", Conversions.ToString((int)num6), "/", Conversions.ToString((int)i) };
			return string.Concat(str);
		}

		public static DateTime BS2AD(short iYear, short iMonth, short iDay)
		{
			short num = 0;
			short num1 = 0;
			bool flag = false;
			NepDate.IsDateOutOfRange = false;
			if (iYear >= 2090)
			{
				num1 = 101;
			}
			else if (iYear >= 2070)
			{
				num1 = 81;
			}
			else if (iYear >= 2050)
			{
				num1 = 61;
			}
			else if (iYear >= 2030)
			{
				num1 = 41;
			}
			else if (iYear >= 2010)
			{
				num1 = 21;
			}
			else if (iYear >= 1990)
			{
				num1 = 1;
			}
			short num2 = NepDate.iMaxVIndex;
			short num3 = num1;
			while (num3 <= num2)
			{
				if (NepDate.arBSDate[num3, 0] != iYear)
				{
					num3 = checked((short)(num3 + 1));
				}
				else
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				NepDate.IsDateOutOfRange = true;
				return DateAndTime.Today;
			}
			DateTime dateTime = NepDate.arADDate[num3];
			short num4 = checked((short)(checked(iMonth - 1)));
			for (short i = 1; i <= num4; i = checked((short)(i + 1)))
			{
				num = checked((short)(num + NepDate.arBSDate[num3, i]));
			}
			num = checked((short)(checked(checked((short)(num + iDay)) - 1)));
			return dateTime.AddDays((double)num);
		}

		public static short BSMonthLen(short iYear, short iMonth)
		{
			short num;
			short num1 = 0;
			if (iYear >= 2090)
			{
				num = 101;
			}
			else if (iYear >= 2070)
			{
				num = 81;
			}
			else if (iYear >= 2050)
			{
				num = 61;
			}
			else if (iYear >= 2030)
			{
				num = 41;
			}
			else if (iYear >= 2010)
			{
				num = 21;
			}
			else if (iYear >= 1990)
			{
				num = 1;
			}
			short num2 = NepDate.iMaxVIndex;
			short num3 = 1;
			while (num3 <= num2)
			{
				if (NepDate.arBSDate[num3, 0] != iYear)
				{
					num3 = checked((short)(num3 + 1));
				}
				else
				{
					num1 = NepDate.arBSDate[num3, iMonth];
					break;
				}
			}
			return num1;
		}

		public static void LoadDateData()
		{
			NepDate.sData[0] = "1989|31|31|31|32|31|31|29|30|30|29|30|30|4/13/1932";
			NepDate.sData[1] = "1990|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1933";
			NepDate.sData[2] = "1991|31|32|31|32|31|30|30|29|30|29|30|30|4/13/1934";
			NepDate.sData[3] = "1992|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1935";
			NepDate.sData[4] = "1993|31|31|31|32|31|31|30|29|30|29|30|30|4/13/1936";
			NepDate.sData[5] = "1994|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1937";
			NepDate.sData[6] = "1995|31|32|31|32|31|30|30|30|29|29|30|30|4/13/1938";
			NepDate.sData[7] = "1996|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1939";
			NepDate.sData[8] = "1997|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1940";
			NepDate.sData[9] = "1998|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1941";
			NepDate.sData[10] = "1999|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1942";
			NepDate.sData[11] = "2000|30|32|31|32|31|30|30|30|29|30|29|31|4/14/1943";
			NepDate.sData[12] = "2001|31|31|31|31|31|31|30|29|30|29|30|30|4/13/1944";
			NepDate.sData[13] = "2002|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1945";
			NepDate.sData[14] = "2003|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1946";
			NepDate.sData[15] = "2004|30|32|31|32|31|30|30|30|29|30|29|31|4/14/1947";
			NepDate.sData[16] = "2005|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1948";
			NepDate.sData[17] = "2006|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1949";
			NepDate.sData[18] = "2007|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1950";
			NepDate.sData[19] = "2008|31|31|31|32|31|31|29|30|30|29|29|31|4/14/1951";
			NepDate.sData[20] = "2009|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1952";
			NepDate.sData[21] = "2010|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1953";
			NepDate.sData[22] = "2011|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1954";
			NepDate.sData[23] = "2012|31|31|31|32|31|31|29|30|30|29|30|30|4/14/1955";
			NepDate.sData[24] = "2013|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1956";
			NepDate.sData[25] = "2014|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1957";
			NepDate.sData[26] = "2015|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1958";
			NepDate.sData[27] = "2016|31|31|31|32|31|31|29|30|30|29|30|30|4/14/1958";
			NepDate.sData[28] = "2017|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1960";
			NepDate.sData[29] = "2018|31|32|31|32|31|30|30|29|30|29|30|30|4/13/1961";
			NepDate.sData[30] = "2019|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1962";
			NepDate.sData[31] = "2020|31|31|31|32|31|31|30|29|30|29|30|30|4/14/1963";
			NepDate.sData[32] = "2021|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1964";
			NepDate.sData[33] = "2022|31|32|31|32|31|30|30|30|29|29|30|30|4/13/1965";
			NepDate.sData[34] = "2023|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1966";
			NepDate.sData[35] = "2024|31|31|31|32|31|31|30|29|30|29|30|30|4/14/1967";
			NepDate.sData[36] = "2025|31|31|32|31|31|31|30|29|30|29|30|30|4/13/1968";
			NepDate.sData[37] = "2026|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1969";
			NepDate.sData[38] = "2027|30|32|31|32|31|30|30|30|29|30|29|31|4/14/1970";
			NepDate.sData[39] = "2028|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1971";
			NepDate.sData[40] = "2029|31|31|32|31|32|30|30|29|30|29|30|30|4/13/1972";
			NepDate.sData[41] = "2030|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1973";
			NepDate.sData[42] = "2031|30|32|31|32|31|30|30|30|29|30|29|31|4/14/1974";
			NepDate.sData[43] = "2032|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1975";
			NepDate.sData[44] = "2033|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1976";
			NepDate.sData[45] = "2034|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1977";
			NepDate.sData[46] = "2035|30|32|31|32|31|31|29|30|30|29|29|31|4/14/1978";
			NepDate.sData[47] = "2036|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1979";
			NepDate.sData[48] = "2037|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1980";
			NepDate.sData[49] = "2038|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1981";
			NepDate.sData[50] = "2039|31|31|31|32|31|31|29|30|30|29|30|30|4/14/1982";
			NepDate.sData[51] = "2040|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1983";
			NepDate.sData[52] = "2041|31|31|32|32|31|30|30|29|30|29|30|30|4/13/1984";
			NepDate.sData[53] = "2042|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1985";
			NepDate.sData[54] = "2043|31|31|31|32|31|31|29|30|30|29|30|30|4/14/1986";
			NepDate.sData[55] = "2044|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1987";
			NepDate.sData[56] = "2045|31|32|31|32|31|30|30|29|30|29|30|30|4/13/1988";
			NepDate.sData[57] = "2046|31|32|31|32|31|30|30|30|29|29|30|31|4/13/1989";
			NepDate.sData[58] = "2047|31|31|31|32|31|31|30|29|30|29|30|30|4/14/1990";
			NepDate.sData[59] = "2048|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1991";
			NepDate.sData[60] = "2049|31|32|31|32|31|30|30|30|29|29|30|30|4/13/1992";
			NepDate.sData[61] = "2050|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1993";
			NepDate.sData[62] = "2051|31|31|31|32|31|31|30|29|30|29|30|30|4/14/1994";
			NepDate.sData[63] = "2052|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1995";
			NepDate.sData[64] = "2053|31|32|31|32|31|30|30|30|29|29|30|30|4/13/1996";
			NepDate.sData[65] = "2054|31|32|31|32|31|30|30|30|29|30|29|31|4/13/1997";
			NepDate.sData[66] = "2055|31|31|32|31|31|31|30|29|30|29|30|30|4/14/1998";
			NepDate.sData[67] = "2056|31|31|32|31|32|30|30|29|30|29|30|30|4/14/1999";
			NepDate.sData[68] = "2057|31|32|31|32|31|30|30|30|29|29|30|31|4/13/2000";
			NepDate.sData[69] = "2058|30|32|31|32|31|30|30|30|29|30|29|31|4/14/2001";
			NepDate.sData[70] = "2059|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2002";
			NepDate.sData[71] = "2060|31|31|32|32|31|30|30|29|30|29|30|30|4/14/2003";
			NepDate.sData[72] = "2061|31|32|31|32|31|30|30|30|29|29|30|31|4/13/2004";
			NepDate.sData[73] = "2062|30|32|31|32|31|31|29|30|29|30|29|31|4/14/2005";
			NepDate.sData[74] = "2063|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2006";
			NepDate.sData[75] = "2064|31|31|32|32|31|30|30|29|30|29|30|30|4/14/2007";
			NepDate.sData[76] = "2065|31|32|31|32|31|30|30|30|29|29|30|31|4/13/2008";
			NepDate.sData[77] = "2066|31|31|31|32|31|31|29|30|30|29|29|31|4/14/2009";
			NepDate.sData[78] = "2067|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2010";
			NepDate.sData[79] = "2068|31|31|32|32|31|30|30|29|30|29|30|30|4/14/2011";
			NepDate.sData[80] = "2069|31|32|31|32|31|30|30|30|29|29|30|31|4/13/2012";
			NepDate.sData[81] = "2070|31|31|31|32|31|31|29|30|30|29|30|30|4/14/2013";
			NepDate.sData[82] = "2071|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2014";
			NepDate.sData[83] = "2072|31|32|31|32|31|30|30|29|30|29|30|30|4/14/2015";
			NepDate.sData[84] = "2073|31|32|31|32|31|30|30|30|29|29|30|31|4/13/2016";
			NepDate.sData[85] = "2074|31|31|31|32|31|31|30|29|30|29|30|30|4/14/2017";
			NepDate.sData[86] = "2075|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2018";
			NepDate.sData[87] = "2076|31|32|31|32|31|30|30|30|29|29|30|30|4/14/2019";
			NepDate.sData[88] = "2077|31|32|31|32|31|30|30|30|29|30|29|31|4/13/2020";
			NepDate.sData[89] = "2078|31|31|31|32|31|31|30|29|30|29|30|30|4/14/2021";
			NepDate.sData[90] = "2079|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2022";
			NepDate.sData[91] = "2080|31|32|31|32|31|30|30|30|29|29|30|30|4/14/2023";
			NepDate.sData[92] = "2081|31|31|32|32|31|30|30|30|29|30|30|30|4/13/2024";
			NepDate.sData[93] = "2082|30|32|31|32|31|30|30|30|29|30|30|30|4/14/2025";
			NepDate.sData[94] = "2083|31|31|32|31|31|30|30|30|29|30|30|30|4/14/2026";
			NepDate.sData[95] = "2084|31|31|32|31|31|30|30|30|29|30|30|30|4/14/2027";
			NepDate.sData[96] = "2085|31|32|31|32|30|31|30|30|29|30|30|30|4/13/2028";
			NepDate.sData[97] = "2086|30|32|31|32|31|30|30|30|29|30|30|30|4/14/2029";
			NepDate.sData[98] = "2087|31|31|32|31|31|31|30|30|29|30|30|30|4/14/2030";
			NepDate.sData[99] = "2088|30|31|32|32|30|31|30|30|29|30|30|30|4/15/2031";
			NepDate.sData[100] = "2089|30|32|31|32|31|30|30|30|29|30|30|30|4/14/2032";
			NepDate.sData[101] = "2090|30|32|31|32|31|30|30|30|29|30|30|30|4/14/2033";
			NepDate.sData[102] = "2091|31|31|32|31|31|30|30|30|29|30|30|30|4/14/2034";
			NepDate.sData[103] = "2092|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2035";
			NepDate.sData[104] = "2093|31|32|31|31|31|31|30|29|30|29|30|31|4/13/2036";
			NepDate.sData[105] = "2094|31|31|31|32|31|30|30|30|29|30|30|30|4/14/2037";
			NepDate.sData[106] = "2095|31|31|32|31|31|30|30|30|29|30|30|30|4/14/2038";
			NepDate.sData[107] = "2096|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2039";
			NepDate.sData[108] = "2097|31|32|30|31|31|31|30|30|29|30|29|31|4/13/2040";
			NepDate.sData[109] = "2098|31|31|31|32|31|30|30|30|29|30|30|30|4/14/2041";
			NepDate.sData[110] = "2099|31|31|32|31|31|30|30|30|29|30|30|30|4/14/2042";
			NepDate.sData[111] = "2100|31|31|32|31|31|31|30|29|30|29|30|30|4/14/2043";
			NepDate.sData[112] = "2101|31|32|31|31|31|31|30|30|29|30|29|31|4/13/2044";
			NepDate.sData[113] = "2102|31|31|31|32|31|30|30|30|29|30|30|30|4/14/2045";
			NepDate.sData[114] = "2103|31|31|32|31|31|30|30|30|30|29|30|30|4/14/2046";
			NepDate.sData[115] = "2104|31|31|32|31|31|31|30|29|30|29|30|31|4/14/2047";
			NepDate.sData[116] = "2105|30|32|31|31|31|31|30|30|29|30|29|31|4/14/2048";
			NepDate.sData[117] = "2106|31|31|31|32|31|30|30|30|29|30|30|30|4/14/2049";
			NepDate.sData[118] = "2107|31|31|32|31|31|30|30|30|30|29|30|30|4/14/2050";
			NepDate.sData[119] = "2108|31|31|32|31|31|31|30|29|30|29|30|31|4/14/2051";
			NepDate.sData[120] = "2109|30|32|31|31|31|31|30|30|29|30|29|31|4/14/2052";
			NepDate.sData[121] = "2110|31|31|31|32|31|30|30|30|29|30|30|30|4/14/2053";
			NepDate.sData[122] = "2111|31|31|32|31|31|30|30|30|30|29|30|30|4/14/2054";
			short num = checked((short)(checked(NepDate.iMaxVIndex + 1)));
			for (short i = 0; i <= num; i = checked((short)(i + 1)))
			{
				string[] strArrays = Strings.Split(NepDate.sData[i], "|", -1, CompareMethod.Binary);
				short num1 = 0;
				do
				{
					NepDate.arBSDate[i, num1] = Conversions.ToShort(strArrays[num1]);
					num1 = checked((short)(num1 + 1));
				}
				while (num1 <= 12);
				string[] strArrays1 = strArrays[13].Split(new char[] { '/' });
				NepDate.arADDate[i] = DateAndTime.DateSerial(Conversions.ToInteger(strArrays1[2]), Conversions.ToInteger(strArrays1[0]), Conversions.ToInteger(strArrays1[1]));
			}
		}

		public static short NepDatePart(string sBSDate, string sPart)
		{
			string[] strArrays = Strings.Split(sBSDate, NepDate.sDateSep, -1, CompareMethod.Binary);
			if (Operators.CompareString(sPart, "y", false) == 0)
			{
				return Conversions.ToShort(strArrays[0]);
			}
			if (Operators.CompareString(sPart, "m", false) == 0)
			{
				return Conversions.ToShort(strArrays[1]);
			}
			if (Operators.CompareString(sPart, "d", false) != 0)
			{
				return -1;
			}
			return Conversions.ToShort(strArrays[2]);
		}
	}
}