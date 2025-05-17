using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintImageDownloader;

public class DataModel
{
    public string LinkPartOne { get; set; } = "https://bibocraftseu.blob.core.windows.net/print-image/";
    public string LinkPartTwo { get; set; } = "/";

    public string PrintImageId { get; set; }
    public string PrintImageMapId { get; set; }
}
