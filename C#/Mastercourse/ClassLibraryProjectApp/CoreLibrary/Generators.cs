﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary;

public class Generators
{

    public string WelcomeMessage(string prefix, string lastName)
    {
        return $"Welcome to our demo app {prefix} {lastName}";
    }


    public string FarewellMessage(string prefix, string lastName)
    {
        return $"I Hope you enjoyed your time with us {prefix} {lastName}. Please come back again.";
    }

}
