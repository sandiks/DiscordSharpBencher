using System;
using System.ComponentModel.DataAnnotations;

namespace DiscordSharpBencher.Database
{
    public class BenchUserSession
    {
        [Key]
        public long Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool Finished { get; set; }
        public string ResultText { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}