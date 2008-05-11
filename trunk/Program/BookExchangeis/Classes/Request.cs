using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.Data;

enum RequestType { SELECT, INSERT, UPDATE, DELETE };

class ValueParemeter {
  string name;
  object value;
  public ValueParemeter(string Name, object Value) {
    name = Name;
    value = Value;
  }
  public object Value {
    get { return value; }
    set { this.value = value; }
  }
  public string Name {
    set { name = value; }
    get { return name; }
  }
}

class Request {
  RequestType type;
  Hashtable CommandParams;
  Hashtable FromParams;
  Hashtable WhereParams;
  Hashtable ValueParams;
  public RequestType Type { get { return this.type; } }
  public Request(RequestType Type) {
    this.type = Type;
    CommandParams = new Hashtable(16);
    FromParams = new Hashtable(16);
    WhereParams = new Hashtable(16);
    ValueParams = new Hashtable(16);
  }
  public void AddCommandParameter(string Name, object Value) {
    CommandParams.Add(Name, Value);
  }
  public void AddCommandParameter(object Value) {
    CommandParams.Add(CommandParams.Count, Value);
  }
  public void AddFromParameter(string Name, object Value) {
    FromParams.Add(Name, Value);
  }
  public void AddFromParameter(object Value) {
    FromParams.Add(FromParams.Count, Value);
  }
  public void AddWhereParameter(string Name, object Value) {
    WhereParams.Add(Name, Value);
  }
  public void AddWhereParameter(object Value) {
    WhereParams.Add(WhereParams.Count, Value);
  }
  public void AddValueParameter(object Name, ValueParemeter Param) {
    ValueParams.Add(Name, Param);
  }
  public void AddValueParameter(ValueParemeter Param) {
    ValueParams.Add(ValueParams.Count, Param);
  }
  public void SetCommandParameter(string Name, object Value) {
    CommandParams[Name] = Value;
  }
  public void SetFromParameter(string Name, object Value) {
    FromParams[Name] = Value;
  }
  public void SetWhereParameter(string Name, object Value) {
    WhereParams[Name] = Value;
  }
  public void SetValueParameter(string Name, ValueParemeter Param) {
    ValueParams[Name] = Param;
  }
  public void ClearCommand() { CommandParams.Clear(); }
  public void ClearFrom() { FromParams.Clear(); }
  public void ClearWhere() { WhereParams.Clear(); }
  public void ClearValues() { ValueParams.Clear(); }
  public IDictionaryEnumerator GetCommandParams() {
    return CommandParams.GetEnumerator();
  }
  public IDictionaryEnumerator GetFromParams() {
    return FromParams.GetEnumerator();
  }
  public IDictionaryEnumerator GetWhereParams() {
    return WhereParams.GetEnumerator();
  }
  public IDictionaryEnumerator GetValueParams() {
    return ValueParams.GetEnumerator();
  }
}
