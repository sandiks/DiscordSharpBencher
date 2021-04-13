using System;
using System.ComponentModel.DataAnnotations;

namespace DiscordSharpBencher.Database
{
    public partial class BenchQuestion
    {
        [Key]
        public long Id { get; set; }
        public long BenchAreaId { get; set; }
        public string QuestText { get; set; }
        public bool MultiOptional { get; set; }
        public string QuestAnswers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
