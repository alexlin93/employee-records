using Microsoft.EntityFrameworkCore;

namespace MvcRecords.Models
{
    public class MvcRecordsContext : DbContext
    {
        public MvcRecordsContext (DbContextOptions<MvcRecordsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcRecords.Models.Record> Record { get; set; }
    }
}
