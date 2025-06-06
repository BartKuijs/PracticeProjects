﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary;
public class Person
{
    // protected allows access within class it is declared and child classes
    private protected string formerLastName = "";
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    // private can only be accessed within the class it is declared
    private string _ssn;

    public string SSN
    {
        get 
        { 
            return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
        }
        set 
        { 
            _ssn = value; 
        }
    }

    public void ChangeLastName(string newLastName)
    {
        formerLastName = LastName;
        LastName = newLastName;
    }

    public void SayHello()
    {
        
        Console.WriteLine($"Hello {FirstName}");
    }
    public void SavePerson()
    {
        DataAccess data = new DataAccess();
        string conn = data.GetConnectionString();
        // saves person
    }

    
}
