using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

public class AddPerson : Action {
  string _Name, _Surname, _MiddleName;
  public AddPerson(string Name, string Surname, string MiddleName) : base("AddPerson", null) {
    _Name = Name;
    _Surname = Surname;
    _MiddleName = MiddleName;
  }
  override public int Execute(out object Result) {
    Request Count = new Request(RequestType.SELECT);
    Count.AddCommandParameter("COUNT(*)");
    Count.AddFromParameter("persons");
    int c = int.Parse(DataBaseManager.Instance().ExecuteQueryScalar(Count).ToString());
    Request AddPerson = new Request(RequestType.INSERT);
    AddPerson.AddCommandParameter("persons");
    AddPerson.AddValueParameter(new ValueParemeter("id_persons", c+1));
    AddPerson.AddValueParameter(new ValueParemeter("name",String.Format("'{0}'", _Name)));
    AddPerson.AddValueParameter(new ValueParemeter("surname",String.Format("'{0}'", _Surname)));
    AddPerson.AddValueParameter(new ValueParemeter("middle_name", String.Format("'{0}'",_MiddleName)));
    try {
      DataBaseManager.Instance().ExecuteQuery(AddPerson);
      Result = (c + 1).ToString();
      return 0;
    } catch (Exception ex) {
      MessageBox.Show(ex.ToString());
      Result = null;
      return 1;
    }
  }
  public override int Execute() {
    throw new Exception("The method or operation is not implemented.");
  }
}
