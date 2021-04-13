using System;
using System.ComponentModel.DataAnnotations;

namespace DiscordSharpBencher.Database
{
    public class BenchResult
    {
        [Key]
        public long Id { get; set; }
        public long BenchQuestionId { get; set; }
        public int BenchUserSessionId { get; set; }
        public string UserName { get; set; }
        public string Result { get; set; }
        public DateTimeOffset ProceededAt { get; set; }
    }
}