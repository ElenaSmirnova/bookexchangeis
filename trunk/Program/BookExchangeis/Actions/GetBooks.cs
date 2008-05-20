using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class GetBooks : Action {
  public GetBooks():base("GetBooks", typeof(DataTable)) {}
  override public int Execute(out object Result) {
    Request GetBooks = new Request(RequestType.SELECT);
    GetBooks.AddCommandParameter("books.name");
    GetBooks.AddCommandParameter("persons.name");
    GetBooks.AddCommandParameter("persons.surname");
    GetBooks.AddCommandParameter("persons.middle_name");
    GetBooks.AddFromParameter("books");
    GetBooks.AddFromParameter("persons");
    GetBooks.AddFromParameter("r_books_authors");
    GetBooks.AddWhereParameter("books.id_books=r_books_authors.id_books");
    GetBooks.AddWhereParameter("id_persons=id_author");
    try {
      Result = (DataBaseManager.Instance().ExecuteQuery(GetBooks) as DataSet).Tables[0];
      return 0;
    } catch (Exception ex) {
      Result = null;
      return 1;
    }
  }
  public override int Execute() {
    throw new Exception("The method or operation is not implemented.");
  }
}