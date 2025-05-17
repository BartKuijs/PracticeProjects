using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes;

public class HomeworkProperties
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    
    public string FullAddress
    {
        get
        {
            return $"{StreetAddress} \n" +
                $"{PostalCode} in {City} \n" +
                $"{Country}";
        }
    }
}
