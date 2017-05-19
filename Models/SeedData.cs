using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcRecords.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRecordsContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcRecordsContext>>()))
            {
                // Look for any records.
                if (context.Record.Any())
                {
                    return;   // DB has been seeded
                }

                context.Record.AddRange(
                    new Record
                    {
                        Name = "Alex Lin",
                        Email = "alexlinica@gmail.com",
                        Phone = "(732)640-8661",
                        DateofBirth = DateTime.Parse("1993-2-24"),
                        Address = "206 Hampshire Court Piscataway, NJ 08854"
                    },
                    new Record
                    {
                        Name = "Jane Mah",
                        Email = "janem@gmail.com",
                        Phone = "(909)456-1001",
                        DateofBirth = DateTime.Parse("1993-2-24"),
                        Address = "123 Cherry Lane"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
