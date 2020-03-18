﻿using System;
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
            //BusinessDeploy();
            //EmployeeDeploy();

        }

        private void EmployeeDeploy()
        {
            using (var context = new EmployeeContext())
            {
                var fte = new Model.FullTimeEmployee { FirstName = "Jane", LastName = "Doe", Salary = 71500M };
                context.Employees.Add(fte);
                fte = new Model.FullTimeEmployee { FirstName = "John", LastName = "Smith", Salary = 62500M };
                context.Employees.Add(fte);
                var hourly = new Model.HourlyEmployee { FirstName = "Tom", LastName = "Jones", Wage = 8.75M }; context.Employees.Add(hourly); context.SaveChanges();
            }
            using (var context = new EmployeeContext())
            {
                Console.WriteLine("---All Employees ---");
                foreach (var emp in context.Employees) { bool fullTime = emp is Model.HourlyEmployee ? false : true; Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName, fullTime ? "Full Time" : "Hourly"); }
                Console.WriteLine("---Full Time ---");
                foreach (var fte in context.Employees.OfType<Model.FullTimeEmployee>()) { Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName); }
                Console.WriteLine("---Hourly ---");
                foreach (var hourly in context.Employees.OfType<Model.HourlyEmployee>()) { Console.WriteLine("{0} {1}", hourly.FirstName, hourly.LastName); }
            }
        }

        private void BusinessDeploy()
        {
            using (var context = new BusinessContext()){
                var business = new Model.Business{ Name = "Corner Dry Cleaning", LicenseNumber = "100x1" };
                context.Businesses.Add(business);
                var retail = new Model.Retail { Name = "Shop and Save", LicenseNumber = "200C", Address = "101 Main", City = "Anytown", State = "TX", ZIPCode = "76106" };
                context.Businesses.Add(retail); 
                var web = new Model.ECommerce { Name = "BuyNow.com", LicenseNumber = "300AB", URL = "www.buynow.com" };
                context.Businesses.Add(web); 
                context.SaveChanges();
            }
            using (var context = new BusinessContext()){ Console.WriteLine("\n---All Businesses ---");
                foreach (var b in context.Businesses) 
                {

                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n---Retail Businesses ---"); 
                foreach (var r in context.Businesses.OfType<Model.Retail>()) 
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address); 
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                } Console.WriteLine("\n---eCommerce Businesses ---"); 
                foreach (var e in context.Businesses.OfType<Model.ECommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL); }
            }
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
