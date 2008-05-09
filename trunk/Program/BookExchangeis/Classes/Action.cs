using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

public abstract class Action {
  protected string name;
  protected Type return_type;
  public abstract int Execute(out object Result);
  public abstract int Execute();
  public Action(string name, Type return_type) {
    this.name = name;
    this.return_type = return_type;
  }
  public string Name {
    get { return name; }
  }
  public Type ReturnType {
    get { return return_type; }
  }
}
