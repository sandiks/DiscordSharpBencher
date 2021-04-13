using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DiscordSharpBencher.Database
{
    public partial class CsharpiEntities : DbContext
    {
        public virtual DbSet<BenchArea> BenchAreas { get; set; }
        public virtual DbSet<BenchQuestion> BenchQuestions { get; set; }
        public virtual DbSet<BenchResult> BenchResults { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "csharpi.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            optionsBuilder.UseSqlite(connection);
        }        
    }
}