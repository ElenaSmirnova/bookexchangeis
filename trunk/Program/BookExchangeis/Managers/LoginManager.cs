using System;
using System.Collections.Generic;
using System.Text;


using System.Data;
using System.Collections;

class LoginManager {
  static LoginManager manager;
  DataBaseManager DBManager;
  private LoginManager() {
    DBManager = DataBaseManager.Instance();
  }
  public static LoginManager Instance() {
    if (manager == null)
      manager = new LoginManager();
    return manager;
  }
  public User MakeUser(string log, string pass) {
    Request Req = new Request(RequestType.SELECT);
    User user = null;
    string id_user, id_roles, user_status_id, role;
    ArrayList Rights;
    #region Поиск пользователя по логину и паролю
    Req.AddCommandParameter("id_user");
    Req.AddCommandParameter("id_roles");
    Req.AddCommandParameter("user_status_id");
    Req.AddFromParameter("users");
    Req.AddWhereParameter(String.Format("log='{0}'", log));
    Req.AddWhereParameter(String.Format("pass='{0}'", pass));
    DataSet UserDataSet = DBManager.ExecuteQuery(Req) as DataSet;
    #endregion
    if (UserDataSet.Tables[0].Rows.Count == 1) {
      #region Получение информации о пользователе
      DataRow r = UserDataSet.Tables[0].Rows[0];
      id_user = r["id_user"].ToString();
      id_roles = r["id_roles"].ToString();
      user_status_id = r["user_status_id"].ToString();
      #endregion
      #region Получение роли
      Req = new Request(RequestType.SELECT);
      Req.AddCommandParameter("name");
      Req.AddFromParameter("roles");
      Req.AddWhereParameter(String.Format("id_roles={0}", id_roles));
      role = DBManager.ExecuteQueryScalar(Req).ToString();
      #endregion
      #region Получение прав для данной роли (по id_roles)
      Req = new Request(RequestType.SELECT);
      Req.AddCommandParameter("name");
      Req.AddFromParameter("rights");
      Req.AddFromParameter("r_roles_rights");
      Req.AddWhereParameter("r_roles_rights.id_rights=rights.id_rights");
      Req.AddWhereParameter(String.Format("r_roles_rights.id_roles={0}", id_roles));
      DataSet temp = DBManager.ExecuteQuery(Req) as DataSet;
      Rights = new ArrayList(temp.Tables[0].Rows.Count);
      foreach (DataRow row in temp.Tables[0].Rows)
        Rights.Add(row[0].ToString());
      #endregion
      #region Получение имени, фамилии
      Req = new Request(RequestType.SELECT);
      Req.AddCommandParameter("name");
      Req.AddCommandParameter("surname");
      Req.AddFromParameter("persons");
      Req.AddWhereParameter(String.Format("id_persons={0}", id_user));
      UserDataSet.Clear();
      UserDataSet = DBManager.ExecuteQuery(Req) as DataSet;
      r = UserDataSet.Tables[0].Rows[0];
      #endregion
      if (role == "Admin")
        user = new User(UserType.Admin, r["name"].ToString(), r["surname"].ToString(), Rights);
      else
        if (role == "SimpleUser")
          user = new User(UserType.SimpleUser, r["name"].ToString(), r["surname"].ToString(), Rights);
    }
    return user;
  }
}
  

