using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MvcRecords.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new MvcRecordsContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcRecordsContext>>());
            context.Database.EnsureCreated();
        }
    }
}
