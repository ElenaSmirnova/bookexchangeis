using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class AddUser : Action {
  string _Name, _Surname, _MiddleName, _id_roles, _log, _pass, _user_status_id;
  public AddUser(string Name, string Surname, string MiddleName,
                 string id_roles, string log, string pass, string user_status_id) : base("AddUser", null) {
    _Name = Name;
    _Surname = Surname;
    _MiddleName = MiddleName;
    _id_roles = id_roles;
    _log = log;
    _pass = pass;
    _user_status_id = user_status_id;
  }
  override public int Execute() {
    object res;
    new AddPerson(_Name, _Surname, _MiddleName).Execute(out res);
    string _id_user = res.ToString();
    Request AddUser = new Request(RequestType.INSERT);
    AddUser.AddCommandParameter("users");
    AddUser.AddValueParameter(new ValueParemeter("id_roles", _id_roles));
    AddUser.AddValueParameter(new ValueParemeter("id_user", _id_user));
    AddUser.AddValueParameter(new ValueParemeter("log", String.Format("'{0}'", _log)));
    AddUser.AddValueParameter(new ValueParemeter("pass", String.Format("'{0}'", _pass)));
    AddUser.AddValueParameter(new ValueParemeter("user_status_id", _user_status_id));
    try {
      DataBaseManager.Instance().ExecuteQuery(AddUser);
      return 0;
    } catch (Exception ex) {
      return 1;
    }
  }
  public override int Execute(out object Result) {
    throw new Exception("The method or operation is not implemented.");
  }
}
