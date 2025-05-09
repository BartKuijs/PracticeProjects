using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLibrary;

public class SqlCrud
{
    private readonly string _connectionString;
    private SqlDataAccess db = new SqlDataAccess();

    public SqlCrud(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddPerson(string firstName, string lastName)
    {
        var sql = "insert into People (FirstName, LastName) values (@FirstName, @LastName);";

        db.SaveData(sql, new { FirstName = firstName, LastName = lastName }, _connectionString);

    }

    public List<PeopleModel> LookUpPeople()
    {
        var sql = "select Id, FirstName, LastName from People;";

        return db.LoadData<PeopleModel, dynamic>(sql, new { }, _connectionString);

        
    }
}
