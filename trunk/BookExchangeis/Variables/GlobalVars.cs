using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


class GlobalVars {
  public static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=books.mdb";
  public static User user;
}

class Roles {
  DataTable data;
  static Roles instance;
  private Roles() {
    Request GetRoles = new Request(RequestType.SELECT);
    GetRoles.AddCommandParameter("id_roles");
    GetRoles.AddCommandParameter("name");
    GetRoles.AddFromParameter("roles");
    data = (DataBaseManager.Instance().ExecuteQuery(GetRoles) as DataSet).Tables[0];
  }
  public static Roles Instance() {
    if (instance == null)
      instance = new Roles();
    return instance;
  }
  public DataTable Data{
    get { return data; }
  }
}
class Statuses {
  DataTable data;
  static Statuses instance;
  private Statuses() {
    Request GetStatuses = new Request(RequestType.SELECT);
    GetStatuses.AddCommandParameter("user_status_id");
    GetStatuses.AddCommandParameter("name");
    GetStatuses.AddFromParameter("user_status");
    data = (DataBaseManager.Instance().ExecuteQuery(GetStatuses) as DataSet).Tables[0];
  }
  public static Statuses Instance() {
    if (instance == null)
      instance = new Statuses();
    return instance;
  }
  public DataTable Data {
    get { return data; }
  }
}

