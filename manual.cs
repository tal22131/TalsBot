using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talBot.Modules
{
    public class manual : ModuleBase<SocketCommandContext>
    {
        [Command("manual")]
        public async Task testAsync()
        {
            await ReplyAsync("***dont explode:***\n***https://goo.gl/U3ULns***");
        }
    }
}
