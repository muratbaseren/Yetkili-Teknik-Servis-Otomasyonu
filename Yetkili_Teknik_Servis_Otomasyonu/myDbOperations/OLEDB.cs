using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace myDbOperations
{
    public class OLEDB : ImyOleOperations
    {
        private string MyDbTable_;

        private OleDbConnection MyConn_;

        private OleDbCommand MyCmd_;

        private string DbPath_;

        private string DbUserID_;

        private string DbPassword_;

        private OLEDB myOleClass;

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

        public string DbPath
        {
            get
            {
                return this.DbPath_;
            }
            set
            {
                this.DbPath_ = value;
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

        public OleDbCommand MyCmd
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

        public OleDbConnection MyConn
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

        public OLEDB(string MyDbTable)
        {
            this.MyDbTable_ = MyDbTable;
        }

        public OLEDB(string DbPath, string MyDbTable)
        {
            this.DbPath_ = DbPath;
            this.MyDbTable_ = MyDbTable;
            this.MyConn_ = new OleDbConnection(string.Concat("Provider=Microsoft.Ace.OleDb.12.0;Data Source=", DbPath, ";"));
            this.MyCmd_ = new OleDbCommand();
            this.MyCmd_.Connection = this.MyConn;
            this.MyCmd_.CommandType = CommandType.Text;
        }

        public OLEDB(string DbPath, string MyDbTable, string DbUserID, string DbPassword)
        {
            this.DbUserID_ = DbUserID;
            this.DbPassword_ = DbPassword;
            this.DbPath_ = DbPath;
            this.MyDbTable_ = MyDbTable;
            string[] dbPath = new string[] { "Provider=Microsoft.Ace.OleDb.12.0;Data Source=", DbPath, ";UserID=", DbUserID, ";Password=", DbPassword, ";" };
            this.MyConn_ = new OleDbConnection(string.Concat(dbPath));
            this.MyCmd_ = new OleDbCommand();
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
            string str = "";
            try
            {
                enumerator = Values.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Parameters current = (Parameters)enumerator.Current;
                    str = ((current.OleValType == OLEVariableTypes.Number || current.OleValType == OLEVariableTypes.YesNo ? false : true) ? string.Concat(str, "'", current.Val, "', ") : string.Concat(str, current.Val, ", "));
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
            int result = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
            result = result;
            return result;
        }

        public int Delete(Parameters DelColVal)
        {
            string[] myDbTable = new string[] { "DELETE FROM ", this.MyDbTable, " WHERE ", DelColVal.Col, "=" };
            string str = string.Concat(myDbTable);
            str = ((DelColVal.OleValType == OLEVariableTypes.Number || DelColVal.OleValType == OLEVariableTypes.YesNo ? false : true) ? string.Concat(str, "'", DelColVal.Val, "'") : string.Concat(str, DelColVal.Val));
            int result = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
            result = result;
            return result;
        }

        public int Insert(ArrayList InsColsVals)
        {
            IEnumerator enumerator = null;
            string str = "";
            try
            {
                enumerator = InsColsVals.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Parameters current = (Parameters)enumerator.Current;
                    str = string.Concat(str, "[", current.Col.ToString(), "], ");
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
            string[] myDbTable = new string[] { "INSERT INTO ", this.MyDbTable, "(", str, ") VALUES (", this.CreateValues(InsColsVals), ")" };
            string str1 = string.Concat(myDbTable);
            return Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str1));
        }

        public int Insert(ArrayList InsValues, bool FirstIdentity)
        {
            int result = 0;
            if (FirstIdentity)
            {
                string[] myDbTable = new string[] { "INSERT INTO ", this.MyDbTable, "(", this.ReadInsColumns(), ") VALUES (", this.CreateValues(InsValues), ")" };
                string str = string.Concat(myDbTable);
                result = Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
            }
            return result;
        }

        public string ReadInsColumns()
        {
            IEnumerator enumerator = null;
            string str = "";
            DataTable dataTable = new DataTable();
            this.myOleClass = new OLEDB(this.DbPath, this.MyDbTable);
            dataTable = (DataTable)this.myOleClass.RunQuery(QueryType.Select, string.Concat("SELECT * FROM ", this.MyDbTable));
            bool flag = false;
            try
            {
                enumerator = dataTable.Columns.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataColumn current = (DataColumn)enumerator.Current;
                    if (!flag)
                    {
                        flag = true;
                    }
                    else
                    {
                        str = string.Concat(str, "[", current.Caption.ToString(), "], ");
                    }
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
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(this.MyCmd);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        obj = dataTable;
                    }
                    this.ConnClose();
                }
                catch (OleDbException oleDbException1)
                {
                    OleDbException oleDbException = oleDbException1;
                    System.Windows.Forms.MessageBox.Show("OLEDB HATA",oleDbException.Message.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    System.Windows.Forms.MessageBox.Show( "GENEL HATA",exception.Message.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
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
            string[] myDbTable = new string[] { "SELECT * FROM ", this.MyDbTable, " WHERE [", SelColVal.Col, "] =" };
            string str = string.Concat(myDbTable);
            str = ((SelColVal.OleValType == OLEVariableTypes.Number || SelColVal.OleValType == OLEVariableTypes.YesNo ? false : true) ? string.Concat(str, "'", SelColVal.Val, "', ") : string.Concat(str, SelColVal.Val, ", "));
            str = str.Remove(checked(str.Length - 2), 2);
            return (DataTable)this.RunQuery(QueryType.Select, str);
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
            str = ((UpdColVal.OleValType == OLEVariableTypes.Number || UpdColVal.OleValType == OLEVariableTypes.YesNo ? false : true) ? string.Concat(str, "'", UpdColVal.Val, "', ") : string.Concat(str, UpdColVal.Val, ", "));
            str = str.Remove(checked(str.Length - 2), 2);
            return Convert.ToInt32(this.RunQuery(QueryType.InsUpdDel, str));
        }
    }
}