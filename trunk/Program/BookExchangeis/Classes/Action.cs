using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

public abstract class Action {
  protected string name;
  protected Type return_type;
  protected ArrayList Params;
  public abstract object Execute();
  public Action(string name, Type return_type, params object[] Params) {
    this.name = name;
    this.return_type = return_type;
    this.Params = new ArrayList(Params);
  }
  public string Name {
    get { return name; }
  }
  public Type ReturnType {
    get { return return_type; }
  }
}
