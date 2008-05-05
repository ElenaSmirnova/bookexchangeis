using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class AddUser : Action {
  public AddUser(params object[] Params) : base("AddPerson", null, Params) { }
  override public object Execute() {
    string id_user = new AddPerson(Params[0], Params[1], Params[2]).Execute().ToString();
    Request AddUser = new Request(RequestType.INSERT);
    AddUser.AddCommandParameter("users");
    AddUser.AddValueParameter(new ValueParemeter("id_roles", Params[3]));
    AddUser.AddValueParameter(new ValueParemeter("id_user", id_user));
    AddUser.AddValueParameter(new ValueParemeter("log", String.Format("'{0}'",Params[4])));
    AddUser.AddValueParameter(new ValueParemeter("pass", String.Format("'{0}'", Params[5])));
    AddUser.AddValueParameter(new ValueParemeter("user_status_id", Params[6]));
    DataBaseManager.Instance().ExecuteQuery(AddUser);
    return null;
  }
}
