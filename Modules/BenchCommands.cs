using Discord;
using Discord.Commands;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using DiscordSharpBencher.Database;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordSharpBencher.Modules
{
    // for commands to be available, and have the Context passed to them, we must inherit ModuleBase
    public class BenchCommands : ModuleBase
    {
        private readonly CsharpiEntities _db;
        private readonly IConfiguration _config;

        public BenchCommands(IServiceProvider services)
        {
            // we can pass in the db context via depedency injection
            _db = services.GetRequiredService<CsharpiEntities>();
            _config = services.GetRequiredService<IConfiguration>();
            
        }

        [Command("Start")]
        public async Task AddResponse(int benchAreaId)
        {            
            var sb = new StringBuilder();
            var embed = new EmbedBuilder();

            // get user info from the Context
            var user = Context.User;
            
            embed.Color = new Color(0, 255, 0);
            // set embed
            embed.Title = $"Wellcome {user.Username}";
            embed.Description = $"Start new bench session benchId {benchAreaId}";
            
            // send embed reply
            await ReplyAsync(null, false, embed.Build());
        }

        [Command("Help")]
        public async Task ListCommands()
        {            
            var sb = new StringBuilder();
            var embed = new EmbedBuilder();

            // get user info from the Context
            var user = Context.User;
            
                      // set embed
            embed.Title = "Commnds list";
            embed.Description = "Start, Select, Next, Pause, Result";
            
            // send embed reply
            await ReplyAsync(null, false, embed.Build());
        }   

      
       
    }
}