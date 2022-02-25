using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;   // Framewok Entity
using Microsoft.Extensions.DependencyInjection;   //Entension SQL Injection framework
using MvcVase.Data;  // Add MvcVase data

namespace MvcVase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcVaseContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcVaseContext>>()))
            {
                if(context.Vase.Any())
                {
                    return;       // DB has been seeded
                }

                context.Vase.AddRange(
                    new Vase
                    {  
                        Name = "Portland vase",
                        Type = "Rustic",
                        Material = "Crystal",
                        Shape = "Trumpet",
                        Rating = "3",
                        Antique = true
                    },

                    new Vase
                    {
                        Name = "Amphora Crystal vase",
                        Type = "Pail",
                        Material = "Rock",
                        Shape = "Bowl",
                        Rating = "5",
                        Antique = true
                    },

                    new Vase
                    {
                        Name = "Mariana vase",
                        Type = "Jug/Pitcher",
                        Material = "Clay",
                        Shape = "Rotund",
                        Rating = "2",
                        Antique = false
                    },

                    new Vase
                    {
                        Name = "Casata vase",
                        Type = "Amphora",
                        Material = "Plastic",
                        Shape = "Gourd",
                        Rating = "1",
                        Antique = true
                    },

                    new Vase
                    {
                        Name = "Pioneer vase",
                        Type = "Floor",
                        Material = "Glass",
                        Shape = "Square",
                        Rating = "5",
                        Antique = false
                    },

                    new Vase
                    {
                        Name = "Chinese Old vase",
                        Type = "Wall",
                        Material = "Clay",
                        Shape = "Honeycomb",
                        Rating = "2",
                        Antique = false
                    },

                    new Vase
                    {
                        Name = "Aurveda vase",
                        Type = "Resin",
                        Material = "Plastic",
                        Shape = "Drop Slim",
                        Rating = "1",
                        Antique = false
                    },

                    new Vase
                    {
                        Name = "Japanes vase",
                        Type = "Stone",
                        Material = "Wood",
                        Shape = "Sphere",
                        Rating = "5",
                        Antique = true
                    },

                    new Vase
                    {
                        Name = "Maharaja vase",
                        Type = "Eco-Friendy",
                        Material = "Metal",
                        Shape = "Bud",
                        Rating = "3",
                        Antique = false
                    },

                    new Vase
                    {
                        Name = "kevinMitnick vase",
                        Type = "Handblown",
                        Material = "Glass",
                        Shape = "Low Pan",
                        Rating = "2",
                        Antique = true
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
