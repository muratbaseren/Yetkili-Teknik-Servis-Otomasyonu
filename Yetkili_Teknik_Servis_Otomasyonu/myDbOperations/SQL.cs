using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace myDbOperations
{
	public class SQL : ImySqlOperations
	{
		private string MyDbTable_;

		private SqlConnection MyConn_;

		private SqlCommand MyCmd_;

		private string DbName_;

		private string DbUserID_;

		private string DbPassword_;

		private string DbServer_;

		private myDbOperations.SQL mySqlClass;

		public string DbName
		{
			get
			{
				return this.DbName_;
			}
			set
			{
				this.DbName_ = value;
			}
		}

		public string DbPassword
		{
			get
			{
				return this.DbPassword_;
			}
			set
			{
				this.DbPassword_ = value;
			}
		}

		public string DbServer
		{
			get
			{
				return this.DbServer_;
			}
			set
			{
				this.DbServer_ = value;
			}
		}

		public string DbUserID
		{
			get
			{
				return this.DbUserID_;
			}
			set
			{
				this.DbUserID_ = value;
			}
		}

		public SqlCommand MyCmd
		{
			get
			{
				return this.MyCmd_;
			}
			set
			{
				this.MyCmd_ = value;
			}
		}

		public SqlConnection MyConn
		{
			get
			{
				return this.MyConn_;
			}
			set
			{
				this.MyConn_ = value;
			}
		}

		public string MyDbTable
		{
			get
			{
				return this.MyDbTable_;
			}
			set
			{
				this.MyDbTable_ = value;
			}
		}

		public SQL(string MyDbTable)
		{
			this.MyDbTable_ = MyDbTable;
		}

		public SQL(string DbServer, string DbName, string MyDbTable)
		{
			this.DbName_ = DbName;
			this.DbServer_ = DbServer;
			this.MyDbTable_ = MyDbTable;
			string[] dbServer = new string[] { "Server=", DbServer, ";Database=", DbName, ";Integrated Security=SSPI;" };
			this.MyConn_ = new SqlConnection(string.Concat(dbServer));
			this.MyCmd_ = new SqlCommand();
			this.MyCmd_.Connection = this.MyConn;
			this.MyCmd_.CommandType = CommandType.Text;
		}

		public SQL(string DbServer, string DbName, string MyDbTable, string DbUserID, string DbPassword)
		{
			this.DbUserID_ = DbUserID;
			this.DbPassword_ = DbPassword;
			this.DbName_ = DbName;
			this.DbServer_ = DbServer;
			this.MyDbTable_ = MyDbTable;
			string[] dbServer = new string[] { "Server=", DbServer, ";Database=", DbName, ";UserID=", DbUserID, ";Password=", DbPassword, ";" };
			this.MyConn_ = new SqlConnection(string.Concat(dbServer));
			this.MyCmd_ = new SqlCommand();
			this.MyCmd_.Connection = this.MyConn;
			this.MyCmd_.CommandType = CommandType.Text;
		}

		public void ConnClose()
		{
			if (this.MyConn.State != ConnectionState.Closed)
			{
				this.MyConn.Close();
			}
		}

		public void ConnOpen()
		{
			if (this.MyConn.State != ConnectionState.Open)
			{
				this.MyConn.Open();
			}
		}

		public string CreateValues(ArrayList Values)
		{
			IEnumerator enumerator = null;
			bool flag;
			string str = "";
			try
			{
				enumerator = Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Parameters current = (Parameters)enumerator.Current;
					if (current.OleValType != OLEVariableTypes.Currency && current.OleValType != OLEVariableTypes.YesNo)
					{
						if (current.OleValType == OLEVariableTypes.Number)
						{
							goto Label5;
						}
						if ((int)current.OleValType == 9)
						{
							goto Label0;
						}
						if (current.OleValType == (OLEVariableTypes.DateTime | OLEVariableTypes.Text | OLEVariableTypes.Number | OLEVariableTypes.Currency | OLEVariableTypes.YesNo))
						{
							goto Label1;
						}
						if ((int)current.OleValType == 8)
						{
							goto Label2;
						}
						if (current.OleValType == (OLEVariableTypes.Text | OLEVariableTypes.Currency))
						{
							goto Label3;
						}
						flag = false;
						goto Label4;
					}
				Label5:
				Label0:
				Label1:
				Label2:
				Label3:
					flag = true;
				Label4:
					str = (!flag ? string.Concat(str, "'", current.Val, "', ") : string.Concat(str, current.Val, ", "));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			str = str.Remove(checked(str.Length - 2), 2);
			str = str;
			return str;
		}

		public int Delete()
		{
			string str = string.Concat("DELETE FROM ", this.MyDbTable);
			int ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
			ınteger = ınteger;
			return ınteger;
		}

		public int Delete(Parameters DelColVal)
		{
			int ınteger;
			bool flag;
			string[] myDbTable = new string[] { "DELETE FROM ", this.MyDbTable, " WHERE ", DelColVal.Col, "=" };
			string str = string.Concat(myDbTable);
			if (DelColVal.OleValType != OLEVariableTypes.Currency && DelColVal.OleValType != OLEVariableTypes.YesNo)
			{
				if (DelColVal.OleValType == OLEVariableTypes.Number)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					ınteger = ınteger;
					return ınteger;
				}
				if ((int)DelColVal.OleValType == 9)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					ınteger = ınteger;
					return ınteger;
				}
				if (DelColVal.OleValType == (OLEVariableTypes.DateTime | OLEVariableTypes.Text | OLEVariableTypes.Number | OLEVariableTypes.Currency | OLEVariableTypes.YesNo))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					ınteger = ınteger;
					return ınteger;
				}
				if ((int)DelColVal.OleValType == 8)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					ınteger = ınteger;
					return ınteger;
				}
				if (DelColVal.OleValType == (OLEVariableTypes.Text | OLEVariableTypes.Currency))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					ınteger = ınteger;
					return ınteger;
				}
				flag = false;
				str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
				ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
				ınteger = ınteger;
				return ınteger;
			}
			flag = true;
			str = (!flag ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
			ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
			ınteger = ınteger;
			return ınteger;
		}

		public int Insert(ArrayList InsValues)
		{
			string[] myDbTable = new string[] { "INSERT INTO ", this.MyDbTable, "(", this.ReadInsColumns(), ") VALUES (", this.CreateValues(InsValues), ")" };
			string str = string.Concat(myDbTable);
			return Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
		}

		public string ReadInsColumns()
		{
			IEnumerator enumerator = null;
			string str = "";
			DataTable dataTable = new DataTable();
			this.mySqlClass = new myDbOperations.SQL(this.DbServer, this.DbName, this.MyDbTable);
			dataTable = (DataTable)this.mySqlClass.RunQuery(QueryType.Select, string.Concat("SELECT [name] FROM syscolumns WHERE id=object_id('", this.MyDbTable, "') AND colstat<>'1' ORDER BY colorder"));
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow current = (DataRow)enumerator.Current;
					str = string.Concat(str, "[", current[0].ToString(), "], ");
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			str = str.Remove(checked(str.Length - 2), 2);
			str = str;
			return str;
		}

		public object RunQuery(QueryType Type, string Query)
		{
			object obj = null;
			try
			{
				try
				{
					this.MyCmd_.CommandText = Query;
					this.ConnOpen();
					if ((Type == QueryType.Select || Type == QueryType.InsCols ? false : true))
					{
						obj = this.MyCmd.ExecuteNonQuery();
					}
					else
					{
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.MyCmd);
						DataTable dataTable = new DataTable();
						sqlDataAdapter.Fill(dataTable);
						obj = dataTable;
					}
					this.ConnClose();
				}
				catch (SqlException sqlException1)
				{
					SqlException sqlException = sqlException1;
                    System.Windows.Forms.MessageBox.Show("SQL HATA",sqlException.Message.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
                    System.Windows.Forms.MessageBox.Show("GENEL HATA",exception.Message.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
				}
			}
			finally
			{
				this.ConnClose();
			}
			obj = obj;
			return obj;
		}

		public DataTable Select()
		{
			string str = string.Concat("SELECT * FROM ", this.MyDbTable);
			return (DataTable)this.RunQuery(QueryType.Select, str);
		}

		public DataTable Select(Parameters SelColVal)
		{
			DataTable dataTable;
			bool flag;
			string[] myDbTable = new string[] { "SELECT * FROM ", this.MyDbTable, " WHERE [", SelColVal.Col, "] =" };
			string str = string.Concat(myDbTable);
			if (SelColVal.OleValType != OLEVariableTypes.Currency && SelColVal.OleValType != OLEVariableTypes.YesNo)
			{
				if (SelColVal.OleValType == OLEVariableTypes.Number)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
					return dataTable;
				}
				if ((int)SelColVal.OleValType == 9)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
					return dataTable;
				}
				if (SelColVal.OleValType == (OLEVariableTypes.DateTime | OLEVariableTypes.Text | OLEVariableTypes.Number | OLEVariableTypes.Currency | OLEVariableTypes.YesNo))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
					return dataTable;
				}
				if ((int)SelColVal.OleValType == 8)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
					return dataTable;
				}
				if (SelColVal.OleValType == (OLEVariableTypes.Text | OLEVariableTypes.Currency))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
					return dataTable;
				}
				flag = false;
				str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
				str = str.Remove(checked(str.Length - 2), 2);
				dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
				return dataTable;
			}
			flag = true;
			str = (!flag ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
			str = str.Remove(checked(str.Length - 2), 2);
			dataTable = (DataTable)this.RunQuery(QueryType.Select, str);
			return dataTable;
		}

		public DataTable Select(ArrayList SelCols)
		{
			IEnumerator enumerator = null;
			string str = "SELECT ";
			try
			{
				enumerator = SelCols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string str1 = Convert.ToString(enumerator.Current);
					str = string.Concat(str, "[", str1, "],");
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			str = str.Remove(checked(str.Length - 1), 1);
			str = string.Concat(str, " FROM ", this.MyDbTable);
			return (DataTable)this.RunQuery(QueryType.Select, str);
		}

		public DataTable Select(ArrayList SelCols, ArrayList SelColsVals, bool IsWithAnd)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			string[] col;
			string str = "SELECT ";
			try
			{
				enumerator = SelCols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string str1 = Convert.ToString(enumerator.Current);
					str = string.Concat(str, str1, ",");
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			str = str.Remove(checked(str.Length - 1), 1);
			str = string.Concat(str, " FROM ", this.MyDbTable, " WHERE ");
			string str2 = "";
			try
			{
				enumerator1 = SelColsVals.GetEnumerator();
				while (enumerator1.MoveNext())
				{
					Parameters current = (Parameters)enumerator1.Current;
					if (!IsWithAnd)
					{
						col = new string[] { str2, "[", current.Col, "] ='", current.Val, "' OR " };
						str2 = string.Concat(col);
					}
					else
					{
						col = new string[] { str2, "[", current.Col, "] ='", current.Val, "' AND " };
						str2 = string.Concat(col);
					}
				}
			}
			finally
			{
				if (enumerator1 is IDisposable)
				{
					(enumerator1 as IDisposable).Dispose();
				}
			}
			str2 = str2.Remove(checked(str2.Length - 4), 4);
			str = string.Concat(str, str2);
			return (DataTable)this.RunQuery(QueryType.Select, str);
		}

		public int Update(Parameters UpdColVal, ArrayList UpdColsVals)
		{
			int ınteger;
			bool flag;
			string str = string.Concat("UPDATE ", this.MyDbTable, " SET ");
			int ınt32 = 0;
			string str1 = "";
			string str2 = "";
			string str3 = string.Concat(",", new string(this.CreateValues(UpdColsVals).ToCharArray()));
			int ınt321 = 0;
			int length = str3.Length;
			while (ınt321 < length)
			{
				str1 = char.ToString(str3[ınt321]);
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, ",", false) == 0)
				{
					Parameters ıtem = (Parameters)UpdColsVals[ınt32];
					str1 = string.Concat(",[", ıtem.Col, "] =");
					ınt32++;
				}
				str2 = string.Concat(str2, str1);
				ınt321++;
			}
			str2 = str2.Remove(0, 1);
			string[] col = new string[] { str, str2, " WHERE ", UpdColVal.Col, " = " };
			str = string.Concat(col);
			if (UpdColVal.OleValType != OLEVariableTypes.Currency && UpdColVal.OleValType != OLEVariableTypes.YesNo)
			{
				if (UpdColVal.OleValType == OLEVariableTypes.Number)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					return ınteger;
				}
				if ((int)UpdColVal.OleValType == 9)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					return ınteger;
				}
				if (UpdColVal.OleValType == (OLEVariableTypes.DateTime | OLEVariableTypes.Text | OLEVariableTypes.Number | OLEVariableTypes.Currency | OLEVariableTypes.YesNo))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					return ınteger;
				}
				if ((int)UpdColVal.OleValType == 8)
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					return ınteger;
				}
				if (UpdColVal.OleValType == (OLEVariableTypes.Text | OLEVariableTypes.Currency))
				{
					flag = true;
					str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
					str = str.Remove(checked(str.Length - 2), 2);
					ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
					return ınteger;
				}
				flag = false;
				str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
				str = str.Remove(checked(str.Length - 2), 2);
				ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
				return ınteger;
			}
			flag = true;
			str = (!flag ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
			str = str.Remove(checked(str.Length - 2), 2);
			ınteger = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
			return ınteger;
		}
	}
}