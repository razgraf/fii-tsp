using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFStudiiDeCaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductDeploy();
            //PhotographDeploy();

        }

        private void PhotographDeploy()
        {
            byte[] thumbBits = new byte[100]; 
            byte[] fullBits = new byte[2000];
            using (var context = new PhotographContext()){
                var photo = new Model.Photograph { Title = "Bird", ThumbnailBits = thumbBits }; 
                var fullImage = new Model.PhotographFullImage { HighResolutionBits = fullBits }; 
                photo.PhotographFullImage = fullImage; 
                context.Photographs.Add(photo); 
                context.SaveChanges(); 
            }
            using (var context = new PhotographContext()){
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes", photo.Title, photo.ThumbnailBits.Length);// explicitly load the "expensive" entity,
                    context
                        .Entry(photo)
                        .Reference(p => p.PhotographFullImage)
                        .Load();
                    Console.WriteLine("Full Image Size: {0} bytes",photo.PhotographFullImage.HighResolutionBits.Length);
                }}
                }

        private void ProductDeploy()
        {
            using (var context = new ProductContext())
            {
                var product = new Model.Product { SKU = 147, Description = "Expandable Hydration Pack", Price = 19.97M, ImageURL = "/pack147.jpg" }; context.Products.Add(product); product = new Model.Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                }; context.Products.Add(product); product = new Model.Product { SKU = 186, Description = "Range Field Pack", Price = 98.97M, ImageURL = "/noimage.jp" }; context.Products.Add(product); product = new Model.Product { SKU = 202, Description = "Small Deployment Back Pack", Price = 29.97M, ImageURL = "/pack202.jpg" }; context.Products.Add(product); context.SaveChanges();
            }
            using (var context = new ProductContext()) { foreach (var p in context.Products) { Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description, p.Price.ToString("C"), p.ImageURL); } }

        }
    }
}
