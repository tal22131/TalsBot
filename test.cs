using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talBot.Modules
{
    public class test : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task testAsync()
        {
            await ReplyAsync("***STFU NERD!***");
        }
    }
}
