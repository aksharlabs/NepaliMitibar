using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NepaliMitibar
{
	internal static class mdl_DB
	{
		public static bool IsPEDBLoaded;

		public static string GsDBPath;

		public static OleDbConnection GDBCon;

		public static int GlngID;

		public static void DBConnect()
		{
			if (!File.Exists(mdl_DB.GsDBPath))
			{
				mdl_DB.IsPEDBLoaded = false;
				return;
			}
			mdl_DB.GDBCon = new OleDbConnection(string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", mdl_DB.GsDBPath, ";Persist Security Info=False;"));
			mdl_DB.GDBCon.Open();
			mdl_DB.IsPEDBLoaded = true;
		}

		public static void DBDisconnect()
		{
			if (mdl_DB.IsPEDBLoaded)
			{
				mdl_DB.GDBCon.Close();
				mdl_DB.GDBCon.Dispose();
			}
			mdl_DB.IsPEDBLoaded = false;
		}

		public static OleDbDataReader DBQuery(string sCommand)
		{
			OleDbCommand oleDbCommand = new OleDbCommand()
			{
				Connection = mdl_DB.GDBCon,
				CommandText = sCommand
			};
			return oleDbCommand.ExecuteReader();
		}

		public static int dbRecCount(string sTable, string sField, string sWhere)
		{
			OleDbCommand oleDbCommand = new OleDbCommand()
			{
				Connection = mdl_DB.GDBCon,
				CommandText = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT COUNT(", sField), ") AS CountID FROM "), sTable), Interaction.IIf(Operators.CompareString(sWhere, "", false) == 0, "", string.Concat(" WHERE(", sWhere, ")"))))
			};
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (!oleDbDataReader.Read())
			{
				return 0;
			}
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader["CountID"])))
			{
				return 0;
			}
			return Conversions.ToInteger(oleDbDataReader["CountID"]);
		}

		public static void DBUpdate(string sCommand)
		{
			OleDbCommand oleDbCommand = new OleDbCommand()
			{
				Connection = mdl_DB.GDBCon,
				CommandText = sCommand
			};
			oleDbCommand.ExecuteNonQuery();
		}

		public static int GetNewID(string sTable)
		{
			OleDbCommand oleDbCommand = new OleDbCommand()
			{
				Connection = mdl_DB.GDBCon,
				CommandText = string.Concat("SELECT MAX(id) AS MaxID FROM ", sTable)
			};
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (!oleDbDataReader.Read())
			{
				return 0;
			}
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader["MaxID"])))
			{
				return 0;
			}
			return checked(Conversions.ToInteger(oleDbDataReader["MaxID"]) + 1);
		}

		public static void SelectCboItemByID(ref ComboBox cbo, int intID)
		{
			int count = checked(cbo.Items.Count - 1);
			for (int i = 0; i <= count; i = checked(i + 1))
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo.Items[i], null, "MyItemID", new object[0], null, null, null), intID, false))
				{
					cbo.SelectedIndex = i;
					return;
				}
			}
		}
	}
}