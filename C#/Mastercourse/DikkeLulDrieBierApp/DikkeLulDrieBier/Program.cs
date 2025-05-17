

using Bibocrafts.Data.Context;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using static System.Net.WebRequestMethods;

var contextOptionsBuilder = new DbContextOptionsBuilder<BibocraftsContext>();

var connectionString = "Server=bibocrafts-db.micloud.pw;User ID=bibocrafts;Password=lknmasdfJKJAi2l39002;Database=bibocraftsdb";

contextOptionsBuilder.UseLazyLoadingProxies(true).UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

var entityFrameWorkContext = new BibocraftsContext(contextOptionsBuilder.Options);

//var textielProducts = entityFrameWorkContext.Products.Include(x => x.Images).Where(x => x.Name.StartsWith("textiel") && !x.Images.Any(y => y.Type == Bibocrafts.Core.Models.ImageType.Static)).ToList();



//foreach (var product in textielProducts)
//{
//    product.Images.Add(new Bibocrafts.Core.Models.ProductImage
//    {
//        Id = Guid.NewGuid(),
//        Uri = "https://bwkprod.blob.core.windows.net/static-image/textiele_placemat_1.jpg",
//        Type = Bibocrafts.Core.Models.ImageType.Static,
//        Order = 3

//    });

//    product.Images.Add(new Bibocrafts.Core.Models.ProductImage
//    {
//        Id = Guid.NewGuid(),
//        Uri = "https://bwkprod.blob.core.windows.net/static-image/textiele_placemat_2.jpg",
//        Type = Bibocrafts.Core.Models.ImageType.Static,
//        Order = 3

//    });
    
//}
//entityFrameWorkContext.SaveChanges();

var stevigeProducts = entityFrameWorkContext.Products.Include(x => x.Images).Where(x => x.Name.StartsWith("stevig") && !x.Images.Any(y => y.Type == Bibocrafts.Core.Models.ImageType.Static)).ToList();

foreach (var product in stevigeProducts)
{
    product.Images.Add(new Bibocrafts.Core.Models.ProductImage
    {
        Id = Guid.NewGuid(),
        Uri = "https://bwkprod.blob.core.windows.net/static-image/stevige_placemat.jpg",
        Type = Bibocrafts.Core.Models.ImageType.Static,
        Order = 3

    });
}
entityFrameWorkContext.SaveChanges();

var luxeProducts = entityFrameWorkContext.Products.Include(x => x.Images).Where(x => x.Name.StartsWith("luxe") && !x.Images.Any(y => y.Type == Bibocrafts.Core.Models.ImageType.Static)).ToList();

foreach (var product in luxeProducts)
{
    product.Images.Add(new Bibocrafts.Core.Models.ProductImage
    {
        Id = Guid.NewGuid(),
        Uri = "https://bwkprod.blob.core.windows.net/static-image/luxe_placemats.jpg",
        Type = Bibocrafts.Core.Models.ImageType.Static,
        Order = 3

    });
}
entityFrameWorkContext.SaveChanges();

var flexibeleProducts = entityFrameWorkContext.Products.Include(x => x.Images).Where(x => x.Name.StartsWith("flex") && !x.Images.Any(y => y.Type == Bibocrafts.Core.Models.ImageType.Static)).ToList();

foreach (var product in flexibeleProducts)
{
    product.Images.Add(new Bibocrafts.Core.Models.ProductImage
    {
        Id = Guid.NewGuid(),
        Uri = "https://bwkprod.blob.core.windows.net/static-image/flexibele_placemat.jpg",
        Type = Bibocrafts.Core.Models.ImageType.Static,
        Order = 3

    });
}

entityFrameWorkContext.SaveChanges();


var poep = 0;


// https://bwkprod.blob.core.windows.net/static-image/flexibele_placemat.jpg
// https://bwkprod.blob.core.windows.net/static-image/luxe_placemats.jpg
// https://bwkprod.blob.core.windows.net/static-image/stevige_placemat.jpg
// https://bwkprod.blob.core.windows.net/static-image/textiele_placemat_1.jpg
// https://bwkprod.blob.core.windows.net/static-image/textiele_placemat_2.jpg
