using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class GetBooks : Action {
  public GetBooks():base("GetBooks", typeof(DataTable)) {}
  override public object Execute() {
    Request GetBooks = new Request(RequestType.SELECT);
    GetBooks.AddCommandParameter("books.name");
    GetBooks.AddCommandParameter("persons.name");
    GetBooks.AddCommandParameter("persons.surname");
    GetBooks.AddFromParameter("books");
    GetBooks.AddFromParameter("persons");
    GetBooks.AddFromParameter("r_books_authors");
    GetBooks.AddWhereParameter("books.id_books=r_books_authors.id_books");
    GetBooks.AddWhereParameter("id_persons=id_author");
    return (DataBaseManager.Instance().ExecuteQuery(GetBooks) as DataSet).Tables[0];
  }
}