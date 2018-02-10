using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace talBot.Modules
{
    public class dice : ModuleBase<SocketCommandContext>
    {
        [Command("dice")]
        public async Task testAsync()
        {
            Random rnd = new Random();
            int result = rnd.Next(1,7);
            await ReplyAsync("***Rolling:...***");
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            await ReplyAsync("***"+result+"***");

        }
    }
}
