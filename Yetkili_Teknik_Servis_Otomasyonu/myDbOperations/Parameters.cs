using System;

namespace myDbOperations
{
	public class Parameters
	{
		private string Col_;

		private string Val_;

		private SQLVariableTypes SqlValType_;

		private OLEVariableTypes OleValType_;

		public string Col
		{
			get
			{
				return this.Col_;
			}
			set
			{
				this.Col_ = value;
			}
		}

		public OLEVariableTypes OleValType
		{
			get
			{
				return this.OleValType_;
			}
			set
			{
				this.OleValType_ = value;
			}
		}

		public SQLVariableTypes SqlValType
		{
			get
			{
				return this.SqlValType_;
			}
			set
			{
				this.SqlValType_ = value;
			}
		}

		public string Val
		{
			get
			{
				return this.Val_;
			}
			set
			{
				this.Val_ = value;
			}
		}

		public Parameters()
		{
		}

		public Parameters(string Col)
		{
			this.Col_ = Col;
		}

		public Parameters(string Col, string Val, SQLVariableTypes SqlValType)
		{
			this.Col_ = Col;
			this.Val_ = Val;
			this.SqlValType_ = SqlValType;
		}

		public Parameters(string Col, string Val, OLEVariableTypes OleValType)
		{
			this.Col_ = Col;
			this.Val_ = Val;
			this.OleValType_ = OleValType;
		}

		public Parameters(string Val, SQLVariableTypes SqlValType)
		{
			this.Val_ = Val;
			this.SqlValType_ = SqlValType;
		}

		public Parameters(string Val, OLEVariableTypes OleValType)
		{
			this.Val_ = Val;
			this.OleValType_ = OleValType;
		}

		public Parameters(string Col, string Val)
		{
			this.Col_ = Col;
			this.Val_ = Val;
		}
	}
}