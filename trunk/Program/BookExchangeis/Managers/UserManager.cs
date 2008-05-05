using System;
using System.Collections.Generic;
using System.Text;


class UserManager {
  DataBaseManager DBManager;
  static UserManager UManager;
  public static  UserManager Instance() {
      if (UManager == null)
        UManager = new UserManager();
      return UManager;
    }
  private UserManager() {
      DBManager = DataBaseManager.Instance();
    }
  public object ExecuteAction(User Usr, Action Act) {
    if (Usr.HasRight(Act.Name))
      return Act.Execute();
    else
      throw new Exception("This role hasn't this right!");
  }
}
