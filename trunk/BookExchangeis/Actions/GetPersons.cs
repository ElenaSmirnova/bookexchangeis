/* copyright Константинов Александр (konst06), Шульгин Даниил (dan.shulgin) */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class GetPersons : Action
{
    public GetPersons() : base("GetPersons", typeof(DataTable)) { }
    override public int Execute(out object Result)
    {
        Request GetPersons = new Request(RequestType.SELECT);
        GetPersons.AddCommandParameter("persons.id_persons");
        GetPersons.AddCommandParameter("persons.name");
        GetPersons.AddCommandParameter("persons.surname");
        GetPersons.AddCommandParameter("persons.middle_name");
        GetPersons.AddFromParameter("persons");     
        try
        {
            Result = (DataBaseManager.Instance().ExecuteQuery(GetPersons) as DataSet).Tables[0];
            return 0;
        }
        catch (Exception ex)
        {
            Result = null;
            return 1;
        }
    }
    public override int Execute()
    {
        throw new Exception("The method or operation is not implemented.");
    }
}