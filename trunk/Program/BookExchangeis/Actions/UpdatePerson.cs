using System;
using System.Collections.Generic;
using System.Text;

class UpdatePerson : Action{
  string _Name, _Surname, _MiddleName, _id_persons;
  public UpdatePerson(string id_persons, string Name, string Surname, string MiddleName) : base("UpdatePerson", null) {
    _Name = Name;
    _Surname = Surname;
    _MiddleName = MiddleName;
    _id_persons = id_persons;
  }
  public override int Execute(out object Result) {
    throw new Exception("The method or operation is not implemented.");
  }
  public override int Execute() {
    Request UpdatePerson = new Request(RequestType.UPDATE);
    UpdatePerson.AddCommandParameter("persons");
    UpdatePerson.AddValueParameter(new ValueParemeter("name", "'" + _Name + "'"));
    UpdatePerson.AddValueParameter(new ValueParemeter("surname", "'" + _Surname + "'"));
    UpdatePerson.AddValueParameter(new ValueParemeter("middle_name", "'" + _MiddleName + "'"));
    UpdatePerson.AddWhereParameter(String.Format("id_persons={0}", _id_persons));
    try {
      DataBaseManager.Instance().ExecuteQuery(UpdatePerson);
      return 0;
    } catch (Exception ex) {
      return 1;
    }
  }
}
