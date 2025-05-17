using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary;

public class AddressModel
{
    public string Street { get; set; }
    public string City { get; set; }
    public string HouseNumber { get; set; }
    public string PostalCode { get; set; }

    public string AddressDisplayValue => $"{Street} {HouseNumber}, {PostalCode} {City} ";


}
