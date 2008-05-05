using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class AddPerson : Action {
  public AddPerson(params object[] Params) : base("AddPerson", null, Params) { }
  override public object Execute() {
    Request Count = new Request(RequestType.SELECT);
    Count.AddCommandParameter("COUNT(*)");
    Count.AddFromParameter("persons");
    int c = int.Parse(DataBaseManager.Instance().ExecuteQueryScalar(Count).ToString());
    Request AddPerson = new Request(RequestType.INSERT);
    AddPerson.AddCommandParameter("persons");
    AddPerson.AddValueParameter(new ValueParemeter("id_persons", c+1));
    AddPerson.AddValueParameter(new ValueParemeter("name",String.Format("'{0}'", Params[0])));
    AddPerson.AddValueParameter(new ValueParemeter("surname",String.Format("'{0}'", Params[1])));
    AddPerson.AddValueParameter(new ValueParemeter("middle_name", String.Format("'{0}'",Params[2])));
    DataBaseManager.Instance().ExecuteQuery(AddPerson);
    return c + 1;
  }
}
