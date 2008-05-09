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
  public int ExecuteAction(User Usr, Action Act, out object Result) {
    int code;
    if (Usr.HasRight(Act.Name)) {
      code = Act.Execute(out Result);
      return code;
    } else
      throw new Exception("This role hasn't this right!");
  }
  public int ExecuteAction(User Usr, Action Act) {
    int code;
    if (Usr.HasRight(Act.Name)) {
      code = Act.Execute();
      return code;
    } else
      throw new Exception("This role hasn't this right!");
  }
}
