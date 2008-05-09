using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;

class DataBaseManager {
  OleDbConnection Connection;
  static DataBaseManager manager;
  public static DataBaseManager Instance() {
    if (manager == null)
      manager = new DataBaseManager(GlobalVars.ConnectionString);
    return manager;
  }
  private DataBaseManager(OleDbConnection Connection) {
    this.Connection = Connection;
    this.Connection.Open();
  }
  private DataBaseManager(string ConnectionString) {
    Connection = new OleDbConnection(ConnectionString);
    Connection.Open();
  }
  public string MakeQueryFromRequest(Request Req) {
    string res = "";
    string delim = "";
    IDictionaryEnumerator Enumer;
    switch (Req.Type) {
      #region SELECT COMMAND
        case RequestType.SELECT:
          delim = "SELECT ";
          Enumer = Req.GetCommandParams();
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value;
            delim = ", ";
          }
          delim = " FROM ";
          Enumer = Req.GetFromParams();
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value;
            delim = ", ";
          }
          Enumer = Req.GetWhereParams();
          delim = " WHERE ";
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value;
            delim = " AND ";
          }
          break;
        #endregion
      #region DELETE COMMAND
        case RequestType.DELETE:
          delim = "DELETE FROM ";
          Enumer = Req.GetCommandParams();
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value ;
            delim = ", ";
          }
          Enumer = Req.GetWhereParams();
          delim = " WHERE ";
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value;
            delim = " AND ";
          }
          break;
        #endregion
      #region INSERT COMMAND
        case RequestType.INSERT:
          delim = "INSERT INTO ";
          Enumer = Req.GetCommandParams();
          while (Enumer.MoveNext()) {
            res += delim;
            res +=Enumer.Value;
            delim = ", ";
          }
          string part1 = "(", part2 = " VALUES (";
          Enumer = Req.GetValueParams();
          delim = "";
          while (Enumer.MoveNext()) {
            ValueParemeter P = (Enumer.Value as ValueParemeter);
            part1 += delim;
            part1 += P.Name;
            part2 += delim;
            part2 += P.Value;
            delim = ", ";
          }
          part1 += ")";
          part2 += ")";
          res += part1 + " " + part2;
          break;
        #endregion
      #region UPDATE COMMAND
        case RequestType.UPDATE:
          delim = "UPDATE ";
          Enumer = Req.GetCommandParams();
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value ;
            delim = ", ";
          }
          Enumer = Req.GetValueParams();
          delim = " SET ";
          while (Enumer.MoveNext()) {
            ValueParemeter P = (Enumer.Value as ValueParemeter);
            res += delim;
            res += P.Name + " = " + P.Value;
            delim = ", ";
          }
          Enumer = Req.GetWhereParams();
          delim = " WHERE ";
          while (Enumer.MoveNext()) {
            res += delim;
            res += Enumer.Value;
            delim = " AND ";
          }
          break;
        #endregion
    }
    return res;
  }
  public object ExecuteQuery(Request Req) {
    OleDbCommand Command = Connection.CreateCommand();
    Command.CommandText = MakeQueryFromRequest(Req);
    switch (Req.Type) {
      case RequestType.SELECT:
        OleDbDataAdapter Adapter = new OleDbDataAdapter(Command);
        DataSet Result = new DataSet();
        Adapter.Fill(Result);
        return Result;
      case RequestType.DELETE:
      case RequestType.INSERT:
      case RequestType.UPDATE:
      return Command.ExecuteNonQuery();
    }
    return null;
  }
  public object ExecuteQueryScalar(Request Req) {
    OleDbCommand Command = Connection.CreateCommand();
    Command.CommandText = MakeQueryFromRequest(Req);
    switch (Req.Type) {
      case RequestType.SELECT:
        return Command.ExecuteScalar();
      case RequestType.DELETE:
      case RequestType.INSERT:
      case RequestType.UPDATE:
        return Command.ExecuteNonQuery();
    }
    return null;
  }
}
