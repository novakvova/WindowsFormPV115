using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Helpers;
using Bogus;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace _14_CreateDialogWinForms.Services
{
    public static class SeedData
    {
        public static void Init()
        {
            AppFormData formData = new AppFormData();
            if(!formData.Users.Any())
            {
                var testOrders = new Faker<UserEntity>("uk")
                //Ensure all properties have rules. By default, StrictMode is false
                //Set a global policy by using Faker.DefaultStrictMode
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName((Bogus.DataSets.Name.Gender)(int)u.Gender))
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName((Bogus.DataSets.Name.Gender)(int)u.Gender))
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber())
                .RuleFor(u => u.Password, (f, u) => f.Internet.Password())
                .RuleFor(u => u.Image, (f, u) => f.Image.LoremFlickrUrl());

                for (int i = 0; i < 20; i++)
                {
                    var user = testOrders.Generate();
                    using (WebClient client = new WebClient())
                    {
                        //byte[] data = client.DownloadData(user.Image);
                        using (Stream stream = client.OpenRead(user.Image))
                        {
                            Bitmap bitmap;
                            bitmap = new Bitmap(stream);
                            string fileName = Path.GetRandomFileName() + ".jpg";
                            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                            foreach (string size in sizes)
                            {
                                int width = int.Parse(size);
                                var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                                saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                            }
                            user.Image = fileName;
                        }
                    }
                    formData.Users.Add(user);
                    formData.SaveChanges();
                }
            }

            if (!formData.Categories.Any())
            {
                var list = new List<CategoryEntity>()
                {
                    new CategoryEntity { Image="laptop", Name="Ноутбуки", Proirity=1 },
                    new CategoryEntity { Image="officesupplies", Name="Канцелярія", Proirity=2 },
                    new CategoryEntity { Image="householdgoods", Name="Побутові товари", Proirity=3 },
                    new CategoryEntity { Image="auto", Name="Авто запчастини", Proirity=4 },
                    new CategoryEntity { Image="bureau", Name="Дівчачі дрібнички", Proirity=5 }
                };

                foreach (var category in list)
                {
                    string url = $"https://loremflickr.com/1280/960/{category.Image}";
                    using (WebClient client = new WebClient())
                    {
                        using (Stream stream = client.OpenRead(url))
                        {
                            Bitmap bitmap;
                            bitmap = new Bitmap(stream);
                            string fileName = Path.GetRandomFileName() + ".jpg";
                            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                            foreach (string size in sizes)
                            {
                                int width = int.Parse(size);
                                var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                                saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                            }
                            category.Image = fileName;
                        }
                    }
                    formData.Add(category);
                    formData.SaveChanges();
                }
                
            }


            if (!formData.Products.Any())
            {
                var product = new ProductEntity
                {
                    Name = "Dell Lattitude 9151",
                    Description = "Дешево і сердито",
                    Price = 35251.45M
                };
              

                string images = "";
                for (int i = 0; i < 4; i++)
                {
                    string url = $"https://loremflickr.com/1280/960/laptop";
                    using (WebClient client = new WebClient())
                    {
                        using (Stream stream = client.OpenRead(url))
                        {
                            Bitmap bitmap;
                            bitmap = new Bitmap(stream);
                            string fileName = Path.GetRandomFileName() + ".jpg";
                            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                            foreach (string size in sizes)
                            {
                                int width = int.Parse(size);
                                var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                                saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                            }

                            images += fileName + (i == 3 ? "" : " ");
                        }
                    }
                
                }
                product.Images = images;
                formData.Products.Add(product);
                formData.SaveChanges();

            }
        }
    }
}
