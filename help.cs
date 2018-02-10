using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talBot.Modules
{
    public class help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task testAsync()
        {
            await ReplyAsync("***Commands:***\n***help***\n***manual***\n***dice***\n***test***");
        }
    }
}
