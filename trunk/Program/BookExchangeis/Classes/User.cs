using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

enum UserType {SimpleUser, Admin};

class User {
  private UserType type;
  private string Name, Surname;
  private ArrayList Rights;
  public User(UserType Type, ICollection Rights) {
      this.type = Type;
      this.Rights = new ArrayList(Rights);
    }
  public User(UserType Type, string Name, string Surname, ICollection Rights) {
      this.type = Type;
      this.Surname = Surname;
      this.Name = Name;
      this.Rights = new ArrayList(Rights);
    }
  public UserType Type {
      get { return type; }
    }
  public bool HasRight(string RightName) {
      return (Rights.IndexOf(RightName) != -1);
    }
}

