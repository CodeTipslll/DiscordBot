using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Discord;
using Discord.WebSocket;

namespace discordbot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        
        [Command("Hi")]
        public async Task Hi()
        {
            await ReplyAsync("Hi This is my discord bot");
        }
    }
}
