using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class GetUsers : Action {
  public GetUsers() : base("GetUsers", typeof(DataTable)) { }
  override public int Execute(out object Result) {
    Request GetUsers = new Request(RequestType.SELECT);
    GetUsers.AddCommandParameter("users.id_user");
    GetUsers.AddCommandParameter("persons.name");
    GetUsers.AddCommandParameter("persons.surname");
    GetUsers.AddCommandParameter("persons.middle_name");
    GetUsers.AddCommandParameter("roles.id_roles");
    GetUsers.AddCommandParameter("users.log");
    GetUsers.AddCommandParameter("users.pass");
    GetUsers.AddCommandParameter("user_status.user_status_id");
    GetUsers.AddFromParameter("persons");
    GetUsers.AddFromParameter("roles");
    GetUsers.AddFromParameter("users");
    GetUsers.AddFromParameter("user_status");
    GetUsers.AddWhereParameter("persons.id_persons=users.id_user");
    GetUsers.AddWhereParameter("users.id_roles=roles.id_roles");
    try {
      Result=(DataBaseManager.Instance().ExecuteQuery(GetUsers) as DataSet).Tables[0];
      return 0;
    } catch (Exception ex) {
      Result = null;
      return 1;
    }
  }
  public override int Execute() {
    throw new Exception("The method or operation is not implemented.");
  }
}