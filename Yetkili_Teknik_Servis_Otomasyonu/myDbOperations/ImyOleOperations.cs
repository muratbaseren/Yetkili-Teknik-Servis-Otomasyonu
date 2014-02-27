using System;
using System.Collections;
using System.Data;

namespace myDbOperations
{
	public interface ImyOleOperations
	{
		void ConnClose();

		void ConnOpen();

		string CreateValues(ArrayList Values);

		int Delete();

		int Delete(Parameters DelColVal);

		int Insert(ArrayList InsValues, bool FirstIdentity);

		int Insert(ArrayList InsColsVals);

		string ReadInsColumns();

		object RunQuery(QueryType Type, string Query);

		DataTable Select();

		DataTable Select(Parameters SelColVal);

		DataTable Select(ArrayList SelCols);

		DataTable Select(ArrayList SelCols, ArrayList SelColsVals, bool IsWithAnd);

		int Update(Parameters UpdColVal, ArrayList UpdColsVals);
	}
}