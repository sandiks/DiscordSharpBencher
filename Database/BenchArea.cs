using System;
using System.ComponentModel.DataAnnotations;

namespace DiscordSharpBencher.Database
{
    public class BenchArea
    {
        [Key]
        public long Id { get; set; }
        public string AreaName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}