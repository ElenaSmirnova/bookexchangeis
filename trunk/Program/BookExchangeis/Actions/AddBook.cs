/* copyright Константинов Александр (konst06), Шульгин Даниил (dan.shulgin) */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class AddBook : Action
{
    string _Name;
    int _id_persons;
    bool t;
    public AddBook(int id_persons, string Name)
        : base("AddBook", null)
    {
        _Name = Name;
        _id_persons = id_persons;
    }
    override public int Execute(out object Result)
    {
        throw new Exception("The method or operation is not implemented.");
    }
    public override int Execute()
    {
        Request Count = new Request(RequestType.SELECT);
        Count.AddCommandParameter("COUNT(*)");
        Count.AddFromParameter("books");
        int c = int.Parse(DataBaseManager.Instance().ExecuteQueryScalar(Count).ToString());
        Request AddBook = new Request(RequestType.INSERT);
        AddBook.AddCommandParameter("books");
        AddBook.AddValueParameter(new ValueParemeter("id_books", c));
        AddBook.AddValueParameter(new ValueParemeter("name", String.Format("'{0}'", _Name)));
        AddBook.AddValueParameter(new ValueParemeter("id_book_status", 1));
        try
        {
            DataBaseManager.Instance().ExecuteQuery(AddBook);
        }

        catch (Exception ex)
        {
            return 1;
        }


       
        Request check = new Request(RequestType.SELECT);
        check.AddFromParameter("authors");
        check.AddCommandParameter("id_author");
        check.AddWhereParameter(String.Format("id_author={0}", _id_persons));
        DataSet res = null;
        try
        {
            res = DataBaseManager.Instance().ExecuteQuery(check) as DataSet;
       
        }                
        catch (Exception ex)
        {
            return 0;
        }
        if (res.Tables[0].Rows.Count <= 0)
        {
            //добавление нового автора
            Request AddNewAuthor = new Request(RequestType.INSERT);
            AddNewAuthor.AddCommandParameter("authors");
            AddNewAuthor.AddValueParameter(new ValueParemeter("id_author", _id_persons));
            try
            {
                DataBaseManager.Instance().ExecuteQuery(AddNewAuthor);               
            }
            catch (Exception ex)
            {
                return 1;
            }

        }
        
        Request AddAuthor = new Request(RequestType.INSERT);
        AddAuthor.AddCommandParameter("r_books_authors");
        AddAuthor.AddValueParameter(new ValueParemeter("id_books", c));
        AddAuthor.AddValueParameter(new ValueParemeter("id_author", _id_persons));
        try
        {
            DataBaseManager.Instance().ExecuteQuery(AddAuthor);
            return 0;
        }
        catch (Exception ex)
        {
            return 1;
        }
        
        
    }
}
      


