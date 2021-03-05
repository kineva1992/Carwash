using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carwash.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var contex = new ProductDbContext(serviceProvider.
                GetRequiredService<DbContextOptions<ProductDbContext>>())) {
                if (contex.Products.Any()) {
                    return;                
                }

                //contex.Products.AddRange(
                //new Product {
                //ProductName = "МОЙКА ЭКСПРЕСС",
                //Discriptio ="Мойка кузова, арок колес, колесных дисков, порогов с " +
                //"активной пеной; обработка кузова жидким воском; без сушки; без протирки",
                //Price = 330,
                //ReleaseDate = DateTime.Now,
                
                //},
                // new Product
                // {
                //     ProductName = "МОЙКА СТАНДАРТ",
                //     Discriptio = "мойка кузова, арок колес, колесных дисков, порогов с активной" +
                //     "пеной; обработка кузова жидким воском; сушка кузова",
                //     Price = 540,
                //     ReleaseDate = DateTime.Now,
                    
                // },
                //  new Product
                //  {
                //      ProductName = "КОМПЛЕКСНАЯ МОЙКА СТАНДАРТ",
                //      Discriptio = "мойка кузова, арок колес, колесных дисков, порогов и ковриков ( 4шт) с активной пеной; обработка кузова жидким воском; сушка кузова; уборка салона: " +
                //      "пылесос, протирка стекол со спец.средством, полировка пластика со спец.средством",
                //      Price = 1080,
                //      ReleaseDate = DateTime.Now,
                      
                //  },
                //   new Product
                //   {
                //       ProductName = "НАНОМОЙКА",
                //       Discriptio = "мойка кузова, врок колес, колёсных дисков, порогов и ковриков ( 4шт) с активной пеной; мойка кузова наношампунью; " +
                //       "обработка кузова жидким воском; сушка кузова",
                //       Price = 900,
                //       ReleaseDate = DateTime.Now,
                       
                //   },
                //   new Product
                //   {
                //       ProductName = "КОМПЛЕКСНАЯ НАНОМОЙКА",
                //       Discriptio = "мойка кузова, арок колес, колёсных дисков, порогов и ковриков ( 4шт) с активной пеной; мойка кузова наношампунью; обработка кузова жидким воском; сушка кузова; уборка салона: " +
                //       "пылесос, протирка стеком спец, средством, полировка пластика со спец. средстаом",
                //       Price = 1520,
                //       ReleaseDate = DateTime.Now,
                       
                //   }

                   
                //);

                contex.NewsModels.AddRange(
                    new NewsModel { 
                    Title = "Мы создали новый сайт",
                    SomeText = "Оцените наши новые возможности и примите участие в розыгрыше приза",
                    Text = "Оцените наши новые возможности и примите участие в розыгрыше приза, описание участия в розыгрыше.",
                    Author = "Admin",
                    CreateNews = DateTime.Now,
                    },
                    new NewsModel
                    {
                        Title = "Мы создали новый сайт",
                        SomeText = "Оцените наши новые возможности и примите участие в розыгрыше приза",
                        Text = "Оцените наши новые возможности и примите участие в розыгрыше приза, описание участия в розыгрыше.",
                        Author = "Admin",
                    CreateNews = DateTime.Now,
                    }
                    );
                contex.SaveChanges();
            }
        }

    }
}
