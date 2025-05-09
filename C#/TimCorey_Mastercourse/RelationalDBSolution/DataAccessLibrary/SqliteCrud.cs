using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class SqliteCrud
{
    private readonly string _connectionString;
    private SqliteDataAccess db = new SqliteDataAccess();

    public SqliteCrud(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<BasicContactModel> GetAllContacts()
    {
        var sql = "select Id, FirstName, LastName from Contacts";

        return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
    }

    public FullContactModel GetFullContactById(int id)
    {
        string sql = "select Id, FirstName, LastName from Contacts where Id = @Id";
        FullContactModel output = new FullContactModel();

        output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();

        if (output.BasicInfo == null)
        {
            // do something to tell the user that the revord was not found
            // exit code: throw new Exception("User not found");
            return null;
        }

        sql = @"select e.*
                from EmailAddresses e
                inner join ContactEmail ce on ce.EmailAddressID = e.Id
                where ce.ContactID = @Id";

        output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

        sql = @"select p.*
                from PhoneNumbers p
                inner join ContactPhoneNumber cp on cp.PhoneNumberId = p.Id
                where cp.ContactID = @Id";

        output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

        return output;
    }


    public void CreateContact(FullContactModel contact)
    {
        var sql = "insert into Contacts (FirstName, LastName) values (@FirstName, @LastName);";

        db.SaveData(sql,
            new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
            _connectionString);

        sql = "select Id from Contacts where FirstName = @FirstName and LastName = @LastName;";
        int contactId = db.LoadData<IdLookUpModel, dynamic>(sql,
            new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
            _connectionString).First().Id;



        foreach (var phonenumber in contact.PhoneNumbers)
        {
            if (phonenumber.Id == 0)
            {
                sql = "insert into PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                db.SaveData(sql, new { phonenumber.PhoneNumber }, _connectionString);

                sql = "select Id from PhoneNumbers where PhoneNumber = @PhoneNumber;";
                phonenumber.Id = db.LoadData<IdLookUpModel, dynamic>(
                    sql,
                    new { phonenumber.PhoneNumber },
                    _connectionString).First().Id;
            }

            sql = "insert into ContactPhoneNumber (ContactId, PhoneNumberId) values (@ContactId, @PhoneNumberId);";
            db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phonenumber.Id }, _connectionString);
        }


        foreach (var email in contact.EmailAddresses)
        {
            if (email.Id == 0)
            {
                sql = "insert into EmailAddresses (EmailAddress) values (@EmailAddress);";
                db.SaveData(sql, new { email.EmailAddress }, _connectionString);

                sql = "select Id from EmailAddresses where EmailAddress = @EmailAddress;";
                email.Id = db.LoadData<IdLookUpModel, dynamic>(
                    sql,
                    new { email.EmailAddress },
                    _connectionString).First().Id;
            }

            sql = "insert into ContactEmail (ContactId, EmailAddressId) values (@ContactId, @EmailAddressId);";
            db.SaveData(sql, new { ContactId = contactId, EmailAddressId = email.Id }, _connectionString);
        }

    }

    public void UpdateContactName(BasicContactModel contact)
    {
        var sql = "update Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id;";
        db.SaveData(sql, contact, _connectionString);
    }

    public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
    {
        var sql = "select Id, ContactId, PhoneNumberId from ContactPhoneNumber where PhoneNumberId = @PhoneNumberId;";
        var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);

        sql = "delete from ContactPhoneNumber where PhoneNumberId = @PhoneNumberId and ContactId = @ContactId;";
        db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

        if (links.Count == 1)
        {
            sql = "delete from PhoneNumbers where Id = @PhoneNumberId;";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
        }

    }
}
