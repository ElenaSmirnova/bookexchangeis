using System;
using System.Collections.Generic;
using System.Text;

class UpdateUser : Action {
  string _Name, _Surname, _MiddleName, _id_roles, _log, _pass, _user_status_id, _id_user;
  public UpdateUser(string id_user, string Name, string Surname, string MiddleName,
                 string id_roles, string log, string pass, string user_status_id) : base("UpdateUser", null) {
    _id_user = id_user;
    _Name = Name;
    _Surname = Surname;
    _MiddleName = MiddleName;
    _id_roles = id_roles;
    _log = log;
    _pass = pass;
    _user_status_id = user_status_id;
  }
  public override int Execute(out object Result) {
    throw new Exception("The method or operation is not implemented.");
  }
  public override int Execute() {
    new UpdatePerson(_id_user, _Name, _Surname, _MiddleName).Execute();
    Request UpdateUser = new Request(RequestType.UPDATE);
    UpdateUser.AddCommandParameter("users");
    UpdateUser.AddValueParameter(new ValueParemeter("id_roles", _id_roles));
    UpdateUser.AddValueParameter(new ValueParemeter("log", String.Format("'{0}'", _log)));
    UpdateUser.AddValueParameter(new ValueParemeter("pass", String.Format("'{0}'", _pass)));
    UpdateUser.AddValueParameter(new ValueParemeter("user_status_id", _user_status_id));
    UpdateUser.AddWhereParameter(String.Format("id_user={0}", _id_user));
    try {
      DataBaseManager.Instance().ExecuteQuery(UpdateUser);
      return 0;
    } catch (Exception ex) {
      return 1;
    }
  }
  
}
