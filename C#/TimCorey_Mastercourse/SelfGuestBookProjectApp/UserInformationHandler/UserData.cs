using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace UserInformationHandler;

public class UserData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MessageToHost { get; set; }
    public string UserAgeText { get; set; }

    public int UserAge { get; set; }
}
